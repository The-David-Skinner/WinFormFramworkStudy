using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointlessCalc
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            txtTotal.Text = (numValue1.Value + numValue2.Value).ToString();
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            txtTotal.Text = (numValue1.Value / numValue2.Value).ToString();
        }
    }
}
