using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneradorDeNumerosAleatorios
{
    public partial class TP1 : Form
    {
        public TP1()
        {
            InitializeComponent();
            this.cmbGenerator.SelectedIndex = 0;
        }

        private void chkModifyValues_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkModifyValues.Checked)
            {
                this.txtSeed.Enabled = true;
                this.txtA.Enabled = true;
                this.txtC.Enabled = true;
                this.txtM.Enabled = true;
                this.cmbGenerator.Enabled = true;
            }
            else
            {
                this.txtSeed.Enabled = false;
                this.txtA.Enabled = false;
                this.txtC.Enabled = false;
                this.txtM.Enabled = false;
                this.cmbGenerator.Enabled = false;
                this.txtSeed.Text = "31767";
                this.txtA.Text = "71561";
                this.txtC.Text = "56822";
                this.txtM.Text = "341157";
                this.cmbGenerator.SelectedIndex = 0;
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            if (this.chkModifyValues.Checked)
            {
                this.txtSeed.Text = "";
                this.txtA.Text = "";
                this.txtC.Text = "";
                this.txtM.Text = "";
                this.cmbGenerator.SelectedIndex = 0;
            }
            else
            {
                this.txtSeed.Text = "31767";
                this.txtA.Text = "71561";
                this.txtC.Text = "56822";
                this.txtM.Text = "341157";
                this.txtQuantity.Text = "";
                this.cmbGenerator.SelectedIndex = 0;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Generator generator = new Generator(); ;

            if(string.IsNullOrEmpty(this.txtSeed.Text) || string.IsNullOrEmpty(this.txtA.Text) ||
                string.IsNullOrEmpty(this.txtC.Text) || string.IsNullOrEmpty(this.txtM.Text) || string.IsNullOrEmpty(this.txtQuantity.Text))
            {
                MessageBox.Show("Ingrese todos los campos necesarios.","Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                generator.seed = Convert.ToDecimal(this.txtSeed.Text);
                generator.a = Convert.ToDecimal(this.txtA.Text);
                generator.c = Convert.ToDecimal(this.txtC.Text);
                generator.M = Convert.ToDecimal(this.txtM.Text);
                int q = Convert.ToInt32(this.txtQuantity.Text);

                this.lstGeneratedNums.Items.Clear();
                foreach (decimal rnd in generator.Generate(q))
                {
                    this.lstGeneratedNums.Items.Add(rnd);
                }
            }

        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
