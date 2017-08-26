using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using UnityEngine;
using UnityEditor;

namespace UnityToolkitEditor {
    internal class ScriptAssetPostProcessor : UnityEditor.AssetModificationProcessor {
        private UserPreferences _preferences = null;

        private void OnWillCreateAsset(string path) {
            path = path.Replace(".meta", "");
            int index = path.LastIndexOf(".");
            if (index < 0)
                return;

            string file = path.Substring(index);
            if (file != ".cs")
                return;

            index = Application.dataPath.LastIndexOf("Assets");
            path = Application.dataPath.Substring(0, index) + path;
            if (!File.Exists(path))
                return;

            
            AssetDatabase.Refresh();
        }

        private void LoadUserPreferences() {
            if (_preferences == null) {
                _preferences = ProjectSettings.GetProjectSettings<UserPreferences>();
            }
        }

        private string ProcessScript(string path) {
            // Load file and data
            string content = File.ReadAllText(path);
            bool isEditorScript = path.Contains("/Editor");
            ScriptSettings scriptSettings = (!isEditorScript) ? _preferences.ProjectScriptSettings : _preferences.EditorScriptSettings;
            StringBuilder script = new StringBuilder(content);

            // Add license
            if (scriptSettings.IncludeLicense) {
                script.Insert(0, scriptSettings.License);
            }

            // Add includes
            if (scriptSettings.UseIncludeTemplate) {
                StringBuilder includes = new StringBuilder();
                foreach(string ns in scriptSettings.Includes) {
                    includes.AppendFormat("using {0};", ns);
                }

                MatchCollection matches = Regex.Matches(script.ToString(), "(using .+\n)", RegexOptions.None);
                StringBuilder usings = new StringBuilder();
                foreach(Match match in matches) {
                    usings.Append(match.Value);
                }

                script.Replace(usings.ToString(), includes.ToString());
            }

            // Add namespace
            if (scriptSettings.UseNamespace) {
                
            }

            File.WriteAllText(path, script.ToString());
        }

        private string GenerateNamespace(ScriptSettings settings) {
            
        }
    }
}
