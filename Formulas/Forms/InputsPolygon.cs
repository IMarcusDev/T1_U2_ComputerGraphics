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

            txtNumLados.KeyPress += OnlyNumbers_KeyPress;
            txtMagnitud.KeyPress += OnlyNumbers_KeyPress;
            this.center = center;
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumLados.Text) || string.IsNullOrWhiteSpace(txtMagnitud.Text))
            {
                MessageBox.Show("Todos los campos deben estar completos y ser numéricos.", "Error de entrada");
                return;
            }

            int lados;
            float magnitud;
            if (!int.TryParse(txtNumLados.Text, out lados) ||
                !float.TryParse(txtMagnitud.Text, out magnitud))
            {
                MessageBox.Show("Todos los valores deben ser numéricos.", "Error de entrada");
                return;
            }

            if (lados < 3)
            {
                MessageBox.Show("El polígono debe tener al menos 3 lados.", "Error de entrada");
                return;
            }
            if (magnitud <= 0)
            {
                MessageBox.Show("La magnitud debe ser mayor que cero.", "Error de entrada");
                return;
            }
            
            OnDrawClicked?.Invoke(lados, magnitud, this.center);
        }

        private bool IsValidCoordinate(float x, float y)
        {
            int maxW = 658, maxH = 552;
            return x >= 0 && x < maxW && y >= 0 && y < maxH;
        }

        private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
