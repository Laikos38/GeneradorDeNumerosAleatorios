using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading.Tasks;
using System.Windows.Forms;


//Revisar bien las validaciones de los txts, hay alguno que no pueden recibir 0 o se rompe todo.

namespace GeneradorDeNumerosAleatorios
{
    public partial class TP1 : Form
    {
        private Generator generator = new Generator();
        public TP1()
        {
            InitializeComponent();
            this.cmbGenerator.SelectedIndex = 0;
            btnValorNuevo.Visible = false;
        }

        private void chkModifyValues_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkModifyValues.Checked)
            {
                if (cmbGenerator.SelectedIndex == 1) //Opcion: Congruente multiplicativo
                {
                    this.txtC.Text = "0";
                    this.txtC.Enabled = false;
                }
                else //Opcion: Congruente mixto
                {
                    this.txtC.Enabled = true;
                }
                this.txtSeed.Enabled = true;
                this.txtA.Enabled = true;
                this.txtM.Enabled = true;
                this.cmbGenerator.Enabled = true;
            }
            else
            {
                if (cmbGenerator.SelectedIndex == 0) //Opcion: Congruente mixto
                {
                    this.txtC.Text = "56822";
                }
                this.txtSeed.Enabled = false;
                this.txtA.Enabled = false;
                this.txtC.Enabled = false;
                this.txtM.Enabled = false;
                this.cmbGenerator.Enabled = false;
                this.txtSeed.Text = "31767";
                this.txtA.Text = "71561";
                this.txtM.Text = "341157";
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
                this.txtQuantity.Text = "";
                this.cmbGenerator.SelectedIndex = 0;
                this.txtC.Enabled = true;
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

            if(string.IsNullOrEmpty(this.txtSeed.Text) || string.IsNullOrEmpty(this.txtA.Text) ||
                string.IsNullOrEmpty(this.txtC.Text) || string.IsNullOrEmpty(this.txtM.Text) || string.IsNullOrEmpty(this.txtQuantity.Text)
                || (Convert.ToInt32(this.txtQuantity.Text) <= 0))
            {
                MessageBox.Show("Ingrese todos los campos necesarios.","Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (this.txtSeed.Text == "0" || this.txtM.Text == "0")
                {
                    MessageBox.Show("Los parámetros 'Semilla' o 'M' no pueden tener valor 0. Intente nuevamente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else 
                {
                    btnValorNuevo.Visible = true;
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

        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Unicamente un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void BtnValorNuevo_Click(object sender, EventArgs e)
        {
            decimal rnd = generator.SingleGenerate();
            this.lstGeneratedNums.Items.Add(rnd);
        }

        private void CmbGenerator_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbGenerator.SelectedIndex == 1) //Opción congruente multiplicativo en el combo.
            {
                txtC.Enabled = false;
                txtC.Text = "0";
            }
            else
            {
                if (!this.chkModifyValues.Checked)
                {
                    txtC.Text = "56822";
                }
                txtC.Enabled = true;
                txtC.Text = "";
            }
        }

        private void btnGenerarChi_Click(object sender, EventArgs e)
        {
            

            if(String.IsNullOrEmpty(this.txtNumChi.Text) || String.IsNullOrEmpty(this.txtSubintervChi.Text))
            {
                MessageBox.Show("Debe llenar los parámetros obligatorios antes de generar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                if (this.txtSubintervChi.Text.Equals("0"))
                {
                    MessageBox.Show("La cantidad de subintervalos debe ser mayor a cero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    List<double> randomList = new List<double>();
                    int q = Convert.ToInt32(this.txtNumChi.Text);
                    int subInt = Convert.ToInt32(this.txtSubintervChi.Text);

                    randomList = GenerateRandomChi(q);

                    ChiCuadrado chi2 = new ChiCuadrado();
                    Intervalo[] intervalos = new Intervalo[subInt];
                    intervalos = chi2.getFrequencies(randomList, subInt, this.chkDistribution.Checked);

                    this.chartFreq.Series["Freq observada"].Points.Clear();
                    this.chartFreq.Series["Freq esperada"].Points.Clear();
                    foreach (Intervalo intervalo in intervalos)
                    {
                        this.chartFreq.Series["Freq observada"].Points.AddXY(
                            "[" + Math.Round(intervalo.LimInf, 2).ToString() + " - " + Math.Round(intervalo.LimSup, 2).ToString() + ")",
                            intervalo.contador
                            );
                        this.chartFreq.Series["Freq esperada"].Points.Add((int)(randomList.Count/intervalos.Length));
                    }
                }           
            }     
        }

        private List<double> GenerateRandomChi(int q)
        {
            Random rnd = new Random();
            List<double> rndList = new List<double>();

            for (int i = 0; i < q; i++)
            {
                double num = rnd.NextDouble();
                rndList.Add(Math.Truncate(num * 10000) / 10000);
            }

            return rndList;
        }

        private void txtSubintervChi_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txtNumChi.Text))
            {
                long q = Convert.ToInt64(this.txtNumChi.Text);
                this.txtSubintervChi.Text = Math.Round(Math.Sqrt(q)).ToString();
            }
        }
    }
}
