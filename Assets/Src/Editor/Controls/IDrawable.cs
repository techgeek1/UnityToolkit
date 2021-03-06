using UnityEngine;

namespace UnityToolkit.Editor.Controls  {
  interface IDrawable {
    void Draw();
    void DrawAbsolute(Rect position);
  }
}