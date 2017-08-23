using UnityEditor;

namespace UnityToolkit.Editor.Controls {
    public class TextBox : Control {
        private string _text = "";
        
        public override void Draw() {
            
        }
        
        public override void DrawAbsolute(Rect position) {
            EditorGui.TextBox(position, )
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
    }
}