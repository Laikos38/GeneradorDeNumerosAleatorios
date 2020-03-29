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
            btnValorNuevo.Enabled = false;
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
                this.btnValorNuevo.Enabled = false;
                this.lstGeneratedNums.Items.Clear();
            }
            else
            {
                this.txtSeed.Text = "31767";
                this.txtA.Text = "71561";
                this.txtC.Text = "56822";
                this.txtM.Text = "341157";
                this.txtQuantity.Text = "";
                this.cmbGenerator.SelectedIndex = 0;
                this.btnValorNuevo.Enabled = false;
                this.lstGeneratedNums.Items.Clear();
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
                    btnValorNuevo.Enabled = true;
                    generator.seed = Convert.ToDecimal(this.txtSeed.Text);
                    generator.a = Convert.ToDecimal(this.txtA.Text);
                    generator.c = Convert.ToDecimal(this.txtC.Text);
                    generator.M = Convert.ToDecimal(this.txtM.Text);
                    int q = Convert.ToInt32(this.txtQuantity.Text);

                    this.lstGeneratedNums.Items.Clear();
                    var randomList = generator.Generate(q);
                    for (int i = 0; i < randomList.Count; i++)
                    {
                        this.lstGeneratedNums.Items.Add(i + 1 + ")\t" + randomList[i]);
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

        private void btnGenerateRandom_Click(object sender, EventArgs e)
        {
            

            if(String.IsNullOrEmpty(this.txtQuantityRandom.Text) || String.IsNullOrEmpty(this.txtIntervalQuantityRandom.Text))
            {
                MessageBox.Show("Debe llenar los parámetros obligatorios antes de generar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                if (this.txtIntervalQuantityRandom.Text.Equals("0"))
                {
                    MessageBox.Show("La cantidad de subintervalos debe ser mayor a cero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    List<double> randomList = new List<double>();
                    int q = Convert.ToInt32(this.txtQuantityRandom.Text);
                    int subInt = Convert.ToInt32(this.txtIntervalQuantityRandom.Text);

                    randomList = GenerateRandom(q);
                    this.lstGeneratedNumsRandom.Items.Clear();
                    for(int i=0; i<randomList.Count; i++)
                    {
                        this.lstGeneratedNumsRandom.Items.Add(i+1 + ")\t" + randomList[i]);
                    }

                    ChiCuadrado chi2 = new ChiCuadrado();
                    Intervalo[] intervalos = new Intervalo[subInt];
                    intervalos = chi2.getFrequencies(randomList, subInt, this.chkDistributionRandom.Checked);

                    this.chartFreqRandom.Series["Freq observada"].Points.Clear();
                    this.chartFreqRandom.Series["Freq esperada"].Points.Clear();
                    this.dgvChiRandom.Rows.Clear();
                    decimal sum = 0;
                    foreach (Intervalo intervalo in intervalos)
                    {
                        string intervalStr = intervalo.ToString();
                        int waitedFreq = (int)(randomList.Count / intervalos.Length);
                        decimal col4 = (decimal) Math.Round(Math.Pow(intervalo.contador - waitedFreq, 2), 4);
                        decimal col5 = Math.Round(col4 / waitedFreq, 4);
                        sum += col5;
                        // Agrego points de grafico de frecuencia observada
                        this.chartFreqRandom.Series["Freq observada"].Points.AddXY(
                            intervalStr,
                            intervalo.contador
                            );
                        // Agrego points de grafico de frecuencia esperada
                        this.chartFreqRandom.Series["Freq esperada"].Points.Add(waitedFreq);
                        // Agrego fila a la tabla
                        this.dgvChiRandom.Rows.Add(
                            intervalStr,
                            intervalo.contador,
                            waitedFreq,
                            col4,
                            col5,
                            sum
                            );
                    }
                }           
            }     
        }

        private List<double> GenerateRandom(int q)
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
            if (!String.IsNullOrEmpty(this.txtQuantityRandom.Text))
            {
                long q = Convert.ToInt64(this.txtQuantityRandom.Text);
                this.txtIntervalQuantityRandom.Text = Math.Round(Math.Sqrt(q)).ToString();
            }
        }
    }
}
