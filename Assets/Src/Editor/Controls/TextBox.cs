using UnityEngine;
using UnityEditor;

namespace UnityToolkit.Editor.Controls {
    public class TextBox : Control {
        private string _text = "";
        private string _lastText = "";
        
        public override void Draw() {
            
        }
        
        public override void DrawAbsolute(Rect position) {
            // Prompt
            if (string.IsNullOrEmpty(_text)) {
                //_text = editoru
            }
            else {
                _text = EditorGUI.TextField(position, _text);
            }
        }
        
        protected virtual void OnTextChanged(string text, string newText, char newCharacter) {}
    
        public string Text {
            get {
                return _text;
            }
            set {
                _text = value;
            }
        }

        public string DefaultText { get; set; }
    }
}