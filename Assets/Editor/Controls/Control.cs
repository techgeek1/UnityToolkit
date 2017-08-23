using UnityEngine;
using UnityEditor;

namespace UnityToolkit.Editor.Controls {
  public class Control : IDrawable {    
    public virtual void Draw() {
      
    }
    
    public virtual void DrawAbsolute(Rect position) {
      
    }
  }
}