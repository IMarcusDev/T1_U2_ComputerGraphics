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
    public partial class InputsCircunference : UserControl
    {
        public event Action<int> OnDrawClicked;

        public InputsCircunference()
        {
            InitializeComponent();
            txtRadio.KeyPress += OnlyNumbers_KeyPress;
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRadio.Text))
            {
                MessageBox.Show("Ingrese un radio válido.", "Error de entrada");
                return;
            }

            int radio;
            if (!int.TryParse(txtRadio.Text, out radio) || radio <= 0)
            {
                MessageBox.Show("Ingrese un radio válido (número mayor que cero).", "Error de entrada");
                return;
            }

            int maxW = 658, maxH = 552;
            int xc = maxW / 2, yc = maxH / 2;
            if (xc - radio < 0 || xc + radio >= maxW || yc - radio < 0 || yc + radio >= maxH)
            {
                MessageBox.Show("El radio es demasiado grande para el canvas.", "Error de entrada");
                return;
            }

            OnDrawClicked?.Invoke(radio);
        }

        private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
