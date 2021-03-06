using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Gum.Widgets
{
    public class Button : Widget
    {
        public override void Construct()
        {
            TextVerticalAlign = VerticalAlign.Center;

            if (string.IsNullOrEmpty(Border))
            {
                Border = "border-button";
            }

            var color = TextColor;
            OnMouseEnter += (widget, action) =>
            {
                widget.TextColor = new Vector4(0.5f, 0, 0, 1.0f);
                widget.Invalidate();
            };

            OnMouseLeave += (widget, action) =>
            {
                widget.TextColor = color;
                widget.Invalidate();
            };
        }
    }
}
