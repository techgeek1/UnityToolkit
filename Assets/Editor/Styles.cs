using UnityEngine;
using UnityEditor;

namespace UnityToolkit.Editor {
    public static class Styles {
        public static readonly Color Primary = new Color();
        public static readonly Color Accent = new Color(0f, 204f / 255f, 204f / 255f);
        public static readonly Color Text = new Color(1f, 1f, 1f, 1f);

        public static readonly GUISkin ToolkitSkin = null;// TODO: Define a new dark theme for the editor later
    }
}