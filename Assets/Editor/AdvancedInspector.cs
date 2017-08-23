using UnityEngine;
using UnityEditor;

namespace UnityToolkit.Editor {
    public class AdvancedInspector : EditorWindow {
    
        void OnGUI() {
            
        }
        
        [CustomMenuItem("Windows/Unity Toolkit/Advanced Inspector")]
        public static void ShowAdvancedInspector() {
            EditorWindow window = EditorWindow.GetWindow(typeof(AdvancedInspector));
            window.Show();
        }
    }
}