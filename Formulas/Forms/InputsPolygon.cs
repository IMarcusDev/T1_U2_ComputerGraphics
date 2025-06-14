using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulas.Forms
{
    public partial class InputsPolygon : UserControl
    {
        public event Action<int, float, PointF> OnDrawClicked;
        private PointF center;

        public InputsPolygon(PointF center)
        {
            InitializeComponent();
            this.center = center;
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            int lados = int.Parse(txtNumLados.Text);
            float magnitud = float.Parse(txtMagnitud.Text);
            PointF center = this.center;
            OnDrawClicked?.Invoke(lados, magnitud, center);
        }
    }
}
