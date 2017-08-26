using UnityEngine;
using UnityEditor;
using UnityToolkit;

namespace UnityToolkitEditor {
    public class ToolkitToolbarMenu {
        [MenuItem("Unity Toolkit/Settings/User Preferences")]
        public static void ShowToolkitUserPreferences() {
            UserPreferences preferences = ProjectSettings.GetProjectSettings<UserPreferences>();
            Selection.SetActiveObjectWithContext(preferences, null);
        }
    }
}
