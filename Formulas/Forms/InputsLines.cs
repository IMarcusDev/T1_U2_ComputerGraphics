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

            txtX1.KeyPress += OnlyNumbers_KeyPress;
            txtY1.KeyPress += OnlyNumbers_KeyPress;
            txtX2.KeyPress += OnlyNumbers_KeyPress;
            txtY2.KeyPress += OnlyNumbers_KeyPress;
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtX1.Text) || string.IsNullOrWhiteSpace(txtY1.Text) ||
                string.IsNullOrWhiteSpace(txtX2.Text) || string.IsNullOrWhiteSpace(txtY2.Text))
            {
                MessageBox.Show("Todos los campos deben estar completos y ser numéricos.", "Error de entrada");
                return;
            }

            int x1, y1, x2, y2;
            if (!int.TryParse(txtX1.Text, out x1) || !int.TryParse(txtY1.Text, out y1) ||
                !int.TryParse(txtX2.Text, out x2) || !int.TryParse(txtY2.Text, out y2))
            {
                MessageBox.Show("Todos los valores deben ser números enteros.", "Error de entrada");
                return;
            }

            if (!IsValidCoordinate(x1, y1) || !IsValidCoordinate(x2, y2))
            {
                MessageBox.Show("Las coordenadas deben estar dentro del área del canvas (0-799, 0-599).", "Error de entrada");
                return;
            }

            OnDrawClicked?.Invoke(new Point(x1, y1), new Point(x2, y2));
        }

        private bool IsValidCoordinate(int x, int y)
        {
            int maxW = 658, maxH = 552;
            return x >= 0 && x < maxW && y >= 0 && y < maxH;
        }

        private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }
    }
}
