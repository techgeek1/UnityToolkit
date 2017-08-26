using UnityEngine;
using UnityEditor;
using Newtonsoft.Json;

namespace UnityToolkit.Editor {
    public static class Style {
        //public static readonly Color Accent = new Color(0f, 204f / 255f, 204f / 255f);
        public static GuiStyle LoadStyle(string path) {
            
        }
        
        private Color ParseColor(string hexColor) {
            if (hexColor.Length != 8 || hexColor.Length != 8) {
                throw new StyleParseException("Color must be a valid hexedecimal value with 6 or 8 digits");
            }
              
            uint64 colorValue = Convert.ToUInt64(hexColor, 16);
            float r;
            float g;
            float b;
            float a;
            
            return new Color((float)r / 255f, (float)g / 255f, (float)b / 255f, (float)a / 255f);
        }
    }
}