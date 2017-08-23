using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityToolkit {
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class AssetPathAttribute : Attribute {
        public AssetPathAttribute(string path, string assetName, bool createAssetIfMissing = true) {
            Path = path;
            AssetName = assetName;
            CreateAssetIfMissing = createAssetIfMissing;
        }

        public string Path { get; private set; }

        public string AssetName { get; private set; }

        public bool CreateAssetIfMissing { get; private set; }

        public string FullPath {
            get
            {
                if (Path.LastIndexOf("/") == Path.Length - 1) {
                    return Path + AssetName;
                }
                else {
                    return string.Concat(Path, "/", AssetName);
                }
            }
        }
    }
}
