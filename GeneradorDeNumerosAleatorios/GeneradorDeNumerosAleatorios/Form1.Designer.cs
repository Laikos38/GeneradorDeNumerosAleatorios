namespace GeneradorDeNumerosAleatorios
{
    partial class TP1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tabChiCuadrado = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbCalculator = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblVariance = new System.Windows.Forms.Label();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.txtVarience = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lstGeneratedNums = new System.Windows.Forms.ListBox();
            this.gbGenerator = new System.Windows.Forms.GroupBox();
            this.btnValorNuevo = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblM = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.lblSeed = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.cmbGenerator = new System.Windows.Forms.ComboBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.lblGenerator = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.chkModifyValues = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chartFreq = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkDistribution = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubintervChi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumChi = new System.Windows.Forms.TextBox();
            this.btnGenerarChi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.tabChiCuadrado.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbCalculator.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbGenerator.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFreq)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // tabChiCuadrado
            // 
            this.tabChiCuadrado.Controls.Add(this.tabPage1);
            this.tabChiCuadrado.Controls.Add(this.tabPage2);
            this.tabChiCuadrado.Location = new System.Drawing.Point(12, 12);
            this.tabChiCuadrado.Name = "tabChiCuadrado";
            this.tabChiCuadrado.SelectedIndex = 0;
            this.tabChiCuadrado.Size = new System.Drawing.Size(611, 444);
            this.tabChiCuadrado.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbCalculator);
            this.tabPage1.Controls.Add(this.lstGeneratedNums);
            this.tabPage1.Controls.Add(this.gbGenerator);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(603, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Generador";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbCalculator
            // 
            this.gbCalculator.Controls.Add(this.tableLayoutPanel2);
            this.gbCalculator.Controls.Add(this.btnCalculate);
            this.gbCalculator.Location = new System.Drawing.Point(223, 278);
            this.gbCalculator.Name = "gbCalculator";
            this.gbCalculator.Size = new System.Drawing.Size(371, 135);
            this.gbCalculator.TabIndex = 1;
            this.gbCalculator.TabStop = false;
            this.gbCalculator.Text = "Calculos";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblAverage, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblVariance, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtAverage, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtVarience, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(7, 30);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(344, 63);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(7, 34);
            this.lblAverage.Margin = new System.Windows.Forms.Padding(7);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(39, 13);
            this.lblAverage.TabIndex = 0;
            this.lblAverage.Text = "Media:";
            // 
            // lblVariance
            // 
            this.lblVariance.AutoSize = true;
            this.lblVariance.Location = new System.Drawing.Point(7, 7);
            this.lblVariance.Margin = new System.Windows.Forms.Padding(7);
            this.lblVariance.Name = "lblVariance";
            this.lblVariance.Size = new System.Drawing.Size(51, 13);
            this.lblVariance.TabIndex = 0;
            this.lblVariance.Text = "Varianza:";
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(175, 30);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(150, 20);
            this.txtAverage.TabIndex = 1;
            // 
            // txtVarience
            // 
            this.txtVarience.Location = new System.Drawing.Point(175, 3);
            this.txtVarience.Name = "txtVarience";
            this.txtVarience.Size = new System.Drawing.Size(150, 20);
            this.txtVarience.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(276, 99);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // lstGeneratedNums
            // 
            this.lstGeneratedNums.FormattingEnabled = true;
            this.lstGeneratedNums.Location = new System.Drawing.Point(6, 6);
            this.lstGeneratedNums.Name = "lstGeneratedNums";
            this.lstGeneratedNums.Size = new System.Drawing.Size(211, 407);
            this.lstGeneratedNums.TabIndex = 2;
            // 
            // gbGenerator
            // 
            this.gbGenerator.Controls.Add(this.btnValorNuevo);
            this.gbGenerator.Controls.Add(this.tableLayoutPanel1);
            this.gbGenerator.Controls.Add(this.btnGenerate);
            this.gbGenerator.Controls.Add(this.btnClean);
            this.gbGenerator.Controls.Add(this.chkModifyValues);
            this.gbGenerator.Location = new System.Drawing.Point(223, 6);
            this.gbGenerator.Name = "gbGenerator";
            this.gbGenerator.Size = new System.Drawing.Size(371, 266);
            this.gbGenerator.TabIndex = 0;
            this.gbGenerator.TabStop = false;
            this.gbGenerator.Text = "Generador";
            // 
            // btnValorNuevo
            // 
            this.btnValorNuevo.Location = new System.Drawing.Point(120, 221);
            this.btnValorNuevo.Name = "btnValorNuevo";
            this.btnValorNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnValorNuevo.TabIndex = 3;
            this.btnValorNuevo.Text = "Uno mas";
            this.btnValorNuevo.UseVisualStyleBackColor = true;
            this.btnValorNuevo.Click += new System.EventHandler(this.BtnValorNuevo_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblM, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblC, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblA, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSeed, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSeed, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtC, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbGenerator, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtA, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtM, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblGenerator, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtQuantity, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblQuantity, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(344, 163);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(7, 88);
            this.lblM.Margin = new System.Windows.Forms.Padding(7);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(19, 13);
            this.lblM.TabIndex = 0;
            this.lblM.Text = "M:";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(7, 61);
            this.lblC.Margin = new System.Windows.Forms.Padding(7);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(16, 13);
            this.lblC.TabIndex = 0;
            this.lblC.Text = "c:";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(7, 34);
            this.lblA.Margin = new System.Windows.Forms.Padding(7);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(16, 13);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "a:";
            // 
            // txtSeed
            // 
            this.txtSeed.Enabled = false;
            this.txtSeed.Location = new System.Drawing.Point(175, 3);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(150, 20);
            this.txtSeed.TabIndex = 0;
            this.txtSeed.Text = "31767";
            this.txtSeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // lblSeed
            // 
            this.lblSeed.AutoSize = true;
            this.lblSeed.Location = new System.Drawing.Point(7, 7);
            this.lblSeed.Margin = new System.Windows.Forms.Padding(7);
            this.lblSeed.Name = "lblSeed";
            this.lblSeed.Size = new System.Drawing.Size(43, 13);
            this.lblSeed.TabIndex = 0;
            this.lblSeed.Text = "Semilla:";
            // 
            // txtC
            // 
            this.txtC.Enabled = false;
            this.txtC.Location = new System.Drawing.Point(175, 57);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(150, 20);
            this.txtC.TabIndex = 2;
            this.txtC.Text = "56822";
            this.txtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // cmbGenerator
            // 
            this.cmbGenerator.DisplayMember = "1";
            this.cmbGenerator.Enabled = false;
            this.cmbGenerator.FormattingEnabled = true;
            this.cmbGenerator.Items.AddRange(new object[] {
            "Congruente mixto",
            "Congruente multiplicativo"});
            this.cmbGenerator.Location = new System.Drawing.Point(175, 111);
            this.cmbGenerator.Name = "cmbGenerator";
            this.cmbGenerator.Size = new System.Drawing.Size(150, 21);
            this.cmbGenerator.TabIndex = 4;
            this.cmbGenerator.ValueMember = "1";
            this.cmbGenerator.SelectionChangeCommitted += new System.EventHandler(this.CmbGenerator_SelectionChangeCommitted);
            // 
            // txtA
            // 
            this.txtA.Enabled = false;
            this.txtA.Location = new System.Drawing.Point(175, 30);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(150, 20);
            this.txtA.TabIndex = 1;
            this.txtA.Text = "71561";
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // txtM
            // 
            this.txtM.Enabled = false;
            this.txtM.Location = new System.Drawing.Point(175, 84);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(150, 20);
            this.txtM.TabIndex = 3;
            this.txtM.Text = "341157";
            this.txtM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // lblGenerator
            // 
            this.lblGenerator.AutoSize = true;
            this.lblGenerator.Location = new System.Drawing.Point(7, 115);
            this.lblGenerator.Margin = new System.Windows.Forms.Padding(7);
            this.lblGenerator.Name = "lblGenerator";
            this.lblGenerator.Size = new System.Drawing.Size(57, 13);
            this.lblGenerator.TabIndex = 0;
            this.lblGenerator.Text = "Generador";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(175, 138);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(150, 20);
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(7, 142);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(7);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(158, 13);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Cantidad de números a generar:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(201, 221);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generar";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(282, 221);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 2;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // chkModifyValues
            // 
            this.chkModifyValues.AutoSize = true;
            this.chkModifyValues.Location = new System.Drawing.Point(251, 16);
            this.chkModifyValues.Name = "chkModifyValues";
            this.chkModifyValues.Size = new System.Drawing.Size(106, 17);
            this.chkModifyValues.TabIndex = 0;
            this.chkModifyValues.Text = "Modificar valores";
            this.chkModifyValues.UseVisualStyleBackColor = true;
            this.chkModifyValues.CheckedChanged += new System.EventHandler(this.chkModifyValues_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chartFreq);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(603, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Test Chi Cuadrado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartFreq
            // 
            this.chartFreq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Title = "Intervalos";
            chartArea1.AxisY.Title = "Valores";
            chartArea1.Name = "ChartArea1";
            this.chartFreq.ChartAreas.Add(chartArea1);
            this.chartFreq.DataSource = this.chartFreq.Series;
            legend1.Name = "Legend1";
            this.chartFreq.Legends.Add(legend1);
            this.chartFreq.Location = new System.Drawing.Point(6, 142);
            this.chartFreq.Name = "chartFreq";
            this.chartFreq.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Freq observada";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Freq esperada";
            this.chartFreq.Series.Add(series1);
            this.chartFreq.Series.Add(series2);
            this.chartFreq.Size = new System.Drawing.Size(569, 270);
            this.chartFreq.TabIndex = 3;
            this.chartFreq.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkDistribution);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSubintervChi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNumChi);
            this.groupBox1.Controls.Add(this.btnGenerarChi);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 130);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros";
            // 
            // chkDistribution
            // 
            this.chkDistribution.AutoSize = true;
            this.chkDistribution.Checked = true;
            this.chkDistribution.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDistribution.Location = new System.Drawing.Point(294, 25);
            this.chkDistribution.Name = "chkDistribution";
            this.chkDistribution.Size = new System.Drawing.Size(138, 17);
            this.chkDistribution.TabIndex = 8;
            this.chkDistribution.Text = "Distribuir uniformemente";
            this.chkDistribution.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "(considere que el método es más adecuado\r\n para muestras de 30 o más elementos)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numeros a generar";
            // 
            // txtSubintervChi
            // 
            this.txtSubintervChi.Location = new System.Drawing.Point(179, 56);
            this.txtSubintervChi.Name = "txtSubintervChi";
            this.txtSubintervChi.Size = new System.Drawing.Size(87, 20);
            this.txtSubintervChi.TabIndex = 1;
            this.txtSubintervChi.Enter += new System.EventHandler(this.txtSubintervChi_Enter);
            this.txtSubintervChi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad de subintervalos";
            // 
            // txtNumChi
            // 
            this.txtNumChi.Location = new System.Drawing.Point(179, 26);
            this.txtNumChi.Name = "txtNumChi";
            this.txtNumChi.Size = new System.Drawing.Size(87, 20);
            this.txtNumChi.TabIndex = 0;
            this.txtNumChi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // btnGenerarChi
            // 
            this.btnGenerarChi.Location = new System.Drawing.Point(371, 85);
            this.btnGenerarChi.Name = "btnGenerarChi";
            this.btnGenerarChi.Size = new System.Drawing.Size(61, 25);
            this.btnGenerarChi.TabIndex = 2;
            this.btnGenerarChi.Text = "Generar";
            this.btnGenerarChi.UseVisualStyleBackColor = true;
            this.btnGenerarChi.Click += new System.EventHandler(this.btnGenerarChi_Click);
            // 
            // TP1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 464);
            this.Controls.Add(this.tabChiCuadrado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TP1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.tabChiCuadrado.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbCalculator.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.gbGenerator.ResumeLayout(false);
            this.gbGenerator.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFreq)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TabControl tabChiCuadrado;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gbCalculator;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblVariance;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.TextBox txtVarience;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListBox lstGeneratedNums;
        private System.Windows.Forms.GroupBox gbGenerator;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.CheckBox chkModifyValues;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtSeed;
        private System.Windows.Forms.Label lblSeed;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.ComboBox cmbGenerator;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label lblGenerator;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnValorNuevo;
        private System.Windows.Forms.TextBox txtNumChi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubintervChi;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.DataVisualization.Charting.Chart chartFreq;
        private System.Windows.Forms.CheckBox chkDistribution;
    }
}

