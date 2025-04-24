using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador.Model.Estetica
{
    class ArredondarPainel
    {
        public static void Arredondar(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90); // Canto superior esquerdo
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90); // Canto superior direito
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90); // Canto inferior direito
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90); // Canto inferior esquerdo
            path.CloseFigure();

            panel.Region = new Region(path);
        }
    }
}
