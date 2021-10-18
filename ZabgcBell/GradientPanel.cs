using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZabgcBell
{
    public class GradientPanel : Panel
    {
        public Color ColorTop { get; set; }
        public Color ColorBottom { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(ClientRectangle, ColorTop, ColorBottom,90F);
            Graphics g = e.Graphics;
            g.FillRectangle(linearGradientBrush, ClientRectangle);
            base.OnPaint(e);
        }
    }
}
