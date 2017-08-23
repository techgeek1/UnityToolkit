using System;
using System.IO;
using UnityEngine;
using UnityEditor;

namespace UnityToolkitEditor {
    public abstract class ProjectSettings : ScriptableObject {
        public static T GetProjectSettings<T>() where T : ProjectSettings {
            Type type = typeof(T);
            if (!Attribute.IsDefined(type, typeof(AssetPathAttribute))) {
                throw new ArgumentException("Type does not have a AssetPathAttribute!");
            }

            AssetPathAttribute assetPathMeta = Attribute.GetCustomAttribute(type, typeof(AssetPathAttribute), false) as AssetPathAttribute;

            T settings = AssetDatabase.LoadAssetAtPath<T>(assetPathMeta.FullPath);
            if (settings == null && assetPathMeta.CreateAssetIfMissing) {
                settings = ScriptableObject.CreateInstance(type) as T;

                if (!Directory.Exists(assetPathMeta.Path)) {
                    Directory.CreateDirectory(assetPathMeta.Path);
                }

                AssetDatabase.CreateAsset(settings, assetPathMeta.FullPath);
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh(ImportAssetOptions.Default);
            }

            if (settings == null) {
                throw new NotImplementedException();
            }

            return settings;
        }
    }
}
