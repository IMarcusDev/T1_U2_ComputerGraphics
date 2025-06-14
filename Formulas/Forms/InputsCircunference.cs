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
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            int radio = int.Parse(txtRadio.Text);
            OnDrawClicked?.Invoke(radio);
        }
    }
}
