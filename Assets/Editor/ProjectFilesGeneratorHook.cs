using System.Text;
using UnityEngine;
using UnityEditor;
using UnityToolkit;
using SyntaxTree.VisualStudio.Unity.Bridge;

namespace UnityToolkitEditor {
    [InitializeOnLoad]
    public static class ProjectFilesGeneratorHook {
        private static UserPreferences _preferences = null;

        static ProjectFilesGeneratorHook() {
            ProjectFilesGenerator.ProjectFileGeneration += ModifyProjectFile;
        }

        private static string ModifyProjectFile(string name, string content) {
            if (_preferences == null) {
                _preferences = ProjectSettings.GetProjectSettings<UserPreferences>();
            }

            StringBuilder builder = new StringBuilder(content);

            if (_preferences.UseNamespace) {
                builder.Replace("<RootNamespace></RootNamespace>", string.Format("<RootNamespace>{0}</RootNamespace>", _preferences.RootNamespace));
            }

            return builder.ToString();
        }
    }
}
