using System;
using UnityEngine;
using UnityEditor;
using UnityToolkit;

namespace UnityToolkitEditor {
    [AssetPath("Assets/ProjectSettings/UnityToolkit", "UserPreferences.asset", true)]
    internal class UserPreferences : ProjectSettings {
        private const string USE_TOOLKIT_SKIN = "useToolkitSkin";

        [Header("Look and Feel")]

        [SerializeField]
        private bool _useToolkitSkin = false;

        [Header("Namespaces")]

        [SerializeField]
        private ScriptSettings _project = new ScriptSettings(
            rootNamespace: "ProjectName",

            namespaceExcludeFolders: new string[] { "Scripts" }, 
            
            includes: new string[] {
                "System",
                "System.Collections",
                "System.Collections.Generic",
                "UnityEngine",
                "UnityToolkit"
        });

        [SerializeField]
        private ScriptSettings _editor = new ScriptSettings(
            rootNamespace: "ProjectNameEditor",

            namespaceExcludeFolders: new string[] { "Editor" },

            includes: new string[] {
                "UnityEngine",
                "UnityEditor",
                "UnityToolkitEditor"
        });
        

        public bool UseToolkitSkin {
            get
            {
                return _useToolkitSkin;
            }
            set
            {
                _useToolkitSkin = value;
            }
        }

        public ScriptSettings ProjectScriptSettings {
            get
            {
                return _project;
            }
            set
            {
                _project = value;
            }
        }

        public ScriptSettings EditorScriptSettings {
            get
            {
                return _editor;
            }
            set
            {
                _editor = value;
            }
        }
    }

    [System.Serializable]
    internal class ScriptSettings {
        [Header("Namespace")]

        [SerializeField]
        private bool _useNamespace = true;

        [SerializeField]
        private string _rootNamespace = "ProjectName";

        [SerializeField]
        private bool _generateNamespaceFromPath = false;

        [SerializeField]
        private string[] _namespaceExcludeFolders = null;

        [Header("Includes")]

        [SerializeField]
        private bool _useIncludeTemplate = false;

        [SerializeField]
        private string[] _includes = null;

        [Header("License")]

        [SerializeField]
        private bool _includeLicense = true;

        [SerializeField]
        private bool _useCustomLicense = false;

        [SerializeField]
        private string _licenseTemplate = "";

        public ScriptSettings(string rootNamespace, string[] namespaceExcludeFolders, string[] includes) {
            _rootNamespace = rootNamespace;
            _namespaceExcludeFolders = namespaceExcludeFolders;
            _includes = includes;
        }

        public bool UseNamespace {
            get
            {
                return _useNamespace;
            }
            set
            {
                _useNamespace = value;
            }
        }

        public string RootNamespace {
            get
            {
                return _rootNamespace;
            }
            set
            {
                _rootNamespace = value;
            }
        }

        public bool GenerateNamespaceFromPath {
            get
            {
                return _generateNamespaceFromPath;
            }
            set
            {
                _generateNamespaceFromPath = value;
            }
        }

        public string[] NamespaceExcludeFolders {
            get
            {
                return _namespaceExcludeFolders;
            }
            set
            {
                _namespaceExcludeFolders = value;
            }
        }

        public bool UseIncludeTemplate {
            get
            {
                return _useIncludeTemplate;
            }
            set
            {
                _useIncludeTemplate = value;
            }
        }

        public string[] Includes {
            get
            {
                return _includes;
            }
            set
            {
                _includes = value;
            }
        }

        public bool IncludeLicense {
            get
            {
                return _includeLicense;
            }
            set
            {
                _includeLicense = value;
            }
        }

        public string License {
            get
            {
                if (_useCustomLicense) {
                    return _licenseTemplate;
                }
                else {
                    return string.Format("Copyright (C) {0} {1} - All Rights Reserved", DateTime.Now.Year, PlayerSettings.companyName);
                }
            }
            set
            {
                _useCustomLicense = true;
                _licenseTemplate = value;
            }
        }
    }
}
