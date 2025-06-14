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
    public partial class InputsLines : UserControl
    {
        public event Action<Point, Point> OnDrawClicked;

        public InputsLines()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            var p1 = new Point(int.Parse(txtX1.Text),int.Parse(txtY1.Text));
            var p2 = new Point(int.Parse(txtX2.Text), int.Parse(txtY2.Text));
            OnDrawClicked?.Invoke(p1, p2);
        }
    }
}
