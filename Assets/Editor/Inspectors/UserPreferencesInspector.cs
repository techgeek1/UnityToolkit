using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityToolkit;

namespace UnityToolkitEditor.Inspectors {
    [CustomEditor(typeof(UserPreferences))]
    public class UserPreferencesInspector : Editor {

        private void OnDisable() {
            AssetDatabase.SaveAssets();
        }

        public override void OnInspectorGUI() {
            EditorGUI.BeginChangeCheck();

            DrawDefaultInspector();

            if (EditorGUI.EndChangeCheck()) {
                EditorUtility.SetDirty(target);
            }
        }
    }
}