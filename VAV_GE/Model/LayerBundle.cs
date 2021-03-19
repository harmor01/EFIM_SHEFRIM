using System;
using System.Drawing;

namespace VAV_GE.Model
{
    [Serializable]
    public class LayerBundle
    {
        public Bitmap Bitmap { get; set; }
        public bool IsVisible { get; set; }
        public Point Position { get; set; }
        public Size Size { get; set; }
    }
}
