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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.txtGeneratedListRandom = new System.Windows.Forms.RichTextBox();
            this.gbChiRandom = new System.Windows.Forms.GroupBox();
            this.lblTabuledChi = new System.Windows.Forms.Label();
            this.lblObtainedChiSum = new System.Windows.Forms.Label();
            this.txtObtainedSChiSum = new System.Windows.Forms.TextBox();
            this.txtTabuledChi = new System.Windows.Forms.TextBox();
            this.lblRta = new System.Windows.Forms.Label();
            this.txtRtaRandom = new System.Windows.Forms.TextBox();
            this.dgvChiRandom = new System.Windows.Forms.DataGridView();
            this.colIntervals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObservableFreq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWaitedFreq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperation1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperation2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFreqRandom = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbGeneratorRandom = new System.Windows.Forms.GroupBox();
            this.btnGenerateRandom = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblQuantityRandom = new System.Windows.Forms.Label();
            this.txtIntervalQuantityRandom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantityRandom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.tabChiCuadrado.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbCalculator.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbGenerator.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbChiRandom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiRandom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFreqRandom)).BeginInit();
            this.gbGeneratorRandom.SuspendLayout();
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
            this.tabChiCuadrado.Size = new System.Drawing.Size(960, 537);
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
            this.tabPage1.Size = new System.Drawing.Size(952, 511);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Generador";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbCalculator
            // 
            this.gbCalculator.Controls.Add(this.tableLayoutPanel2);
            this.gbCalculator.Controls.Add(this.btnCalculate);
            this.gbCalculator.Location = new System.Drawing.Point(223, 294);
            this.gbCalculator.Name = "gbCalculator";
            this.gbCalculator.Size = new System.Drawing.Size(708, 210);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(159, 57);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(383, 63);
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
            this.txtAverage.Location = new System.Drawing.Point(194, 30);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(150, 20);
            this.txtAverage.TabIndex = 1;
            // 
            // txtVarience
            // 
            this.txtVarience.Location = new System.Drawing.Point(194, 3);
            this.txtVarience.Name = "txtVarience";
            this.txtVarience.Size = new System.Drawing.Size(150, 20);
            this.txtVarience.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(599, 170);
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
            this.lstGeneratedNums.Size = new System.Drawing.Size(211, 498);
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
            this.gbGenerator.Size = new System.Drawing.Size(708, 282);
            this.gbGenerator.TabIndex = 0;
            this.gbGenerator.TabStop = false;
            this.gbGenerator.Text = "Generador";
            // 
            // btnValorNuevo
            // 
            this.btnValorNuevo.Location = new System.Drawing.Point(518, 238);
            this.btnValorNuevo.Name = "btnValorNuevo";
            this.btnValorNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnValorNuevo.TabIndex = 3;
            this.btnValorNuevo.Text = "Siguiente";
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(117, 59);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(465, 163);
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
            this.txtSeed.Location = new System.Drawing.Point(235, 3);
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
            this.txtC.Location = new System.Drawing.Point(235, 57);
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
            this.cmbGenerator.Location = new System.Drawing.Point(235, 111);
            this.cmbGenerator.Name = "cmbGenerator";
            this.cmbGenerator.Size = new System.Drawing.Size(150, 21);
            this.cmbGenerator.TabIndex = 4;
            this.cmbGenerator.ValueMember = "1";
            this.cmbGenerator.SelectionChangeCommitted += new System.EventHandler(this.CmbGenerator_SelectionChangeCommitted);
            // 
            // txtA
            // 
            this.txtA.Enabled = false;
            this.txtA.Location = new System.Drawing.Point(235, 30);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(150, 20);
            this.txtA.TabIndex = 1;
            this.txtA.Text = "71561";
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // txtM
            // 
            this.txtM.Enabled = false;
            this.txtM.Location = new System.Drawing.Point(235, 84);
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
            this.txtQuantity.Location = new System.Drawing.Point(235, 138);
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
            this.btnGenerate.Location = new System.Drawing.Point(437, 238);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generar";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(599, 238);
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
            this.chkModifyValues.Location = new System.Drawing.Point(353, 36);
            this.chkModifyValues.Name = "chkModifyValues";
            this.chkModifyValues.Size = new System.Drawing.Size(106, 17);
            this.chkModifyValues.TabIndex = 0;
            this.chkModifyValues.Text = "Modificar valores";
            this.chkModifyValues.UseVisualStyleBackColor = true;
            this.chkModifyValues.CheckedChanged += new System.EventHandler(this.chkModifyValues_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtGeneratedListRandom);
            this.tabPage2.Controls.Add(this.gbChiRandom);
            this.tabPage2.Controls.Add(this.gbGeneratorRandom);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(952, 511);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Generador de C#";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtGeneratedListRandom
            // 
            this.txtGeneratedListRandom.Location = new System.Drawing.Point(4, 22);
            this.txtGeneratedListRandom.Name = "txtGeneratedListRandom";
            this.txtGeneratedListRandom.Size = new System.Drawing.Size(155, 476);
            this.txtGeneratedListRandom.TabIndex = 6;
            this.txtGeneratedListRandom.Text = "";
            // 
            // gbChiRandom
            // 
            this.gbChiRandom.Controls.Add(this.lblTabuledChi);
            this.gbChiRandom.Controls.Add(this.lblObtainedChiSum);
            this.gbChiRandom.Controls.Add(this.txtObtainedSChiSum);
            this.gbChiRandom.Controls.Add(this.txtTabuledChi);
            this.gbChiRandom.Controls.Add(this.lblRta);
            this.gbChiRandom.Controls.Add(this.txtRtaRandom);
            this.gbChiRandom.Controls.Add(this.dgvChiRandom);
            this.gbChiRandom.Controls.Add(this.chartFreqRandom);
            this.gbChiRandom.Location = new System.Drawing.Point(165, 109);
            this.gbChiRandom.Name = "gbChiRandom";
            this.gbChiRandom.Size = new System.Drawing.Size(781, 395);
            this.gbChiRandom.TabIndex = 5;
            this.gbChiRandom.TabStop = false;
            this.gbChiRandom.Text = "Chi Cuadrado";
            // 
            // lblTabuledChi
            // 
            this.lblTabuledChi.AutoSize = true;
            this.lblTabuledChi.Location = new System.Drawing.Point(599, 242);
            this.lblTabuledChi.Name = "lblTabuledChi";
            this.lblTabuledChi.Size = new System.Drawing.Size(73, 13);
            this.lblTabuledChi.TabIndex = 10;
            this.lblTabuledChi.Text = "Chi Tabulado:";
            // 
            // lblObtainedChiSum
            // 
            this.lblObtainedChiSum.AutoSize = true;
            this.lblObtainedChiSum.Location = new System.Drawing.Point(599, 191);
            this.lblObtainedChiSum.Name = "lblObtainedChiSum";
            this.lblObtainedChiSum.Size = new System.Drawing.Size(139, 13);
            this.lblObtainedChiSum.TabIndex = 9;
            this.lblObtainedChiSum.Text = "Sumatoria de Chi Cuadrado:";
            // 
            // txtObtainedSChiSum
            // 
            this.txtObtainedSChiSum.Location = new System.Drawing.Point(599, 210);
            this.txtObtainedSChiSum.Name = "txtObtainedSChiSum";
            this.txtObtainedSChiSum.Size = new System.Drawing.Size(108, 20);
            this.txtObtainedSChiSum.TabIndex = 8;
            // 
            // txtTabuledChi
            // 
            this.txtTabuledChi.Location = new System.Drawing.Point(599, 258);
            this.txtTabuledChi.Name = "txtTabuledChi";
            this.txtTabuledChi.Size = new System.Drawing.Size(108, 20);
            this.txtTabuledChi.TabIndex = 7;
            // 
            // lblRta
            // 
            this.lblRta.AutoSize = true;
            this.lblRta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRta.Location = new System.Drawing.Point(599, 306);
            this.lblRta.Name = "lblRta";
            this.lblRta.Size = new System.Drawing.Size(82, 13);
            this.lblRta.TabIndex = 6;
            this.lblRta.Text = "RESULTADO";
            // 
            // txtRtaRandom
            // 
            this.txtRtaRandom.Location = new System.Drawing.Point(599, 322);
            this.txtRtaRandom.Name = "txtRtaRandom";
            this.txtRtaRandom.Size = new System.Drawing.Size(108, 20);
            this.txtRtaRandom.TabIndex = 5;
            // 
            // dgvChiRandom
            // 
            this.dgvChiRandom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiRandom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIntervals,
            this.colObservableFreq,
            this.colWaitedFreq,
            this.colOperation1,
            this.colOperation2,
            this.colSum});
            this.dgvChiRandom.Location = new System.Drawing.Point(12, 19);
            this.dgvChiRandom.Name = "dgvChiRandom";
            this.dgvChiRandom.ReadOnly = true;
            this.dgvChiRandom.Size = new System.Drawing.Size(763, 150);
            this.dgvChiRandom.TabIndex = 4;
            // 
            // colIntervals
            // 
            this.colIntervals.HeaderText = "Intervalos";
            this.colIntervals.Name = "colIntervals";
            this.colIntervals.ReadOnly = true;
            // 
            // colObservableFreq
            // 
            this.colObservableFreq.HeaderText = "Frec. Observable";
            this.colObservableFreq.Name = "colObservableFreq";
            this.colObservableFreq.ReadOnly = true;
            // 
            // colWaitedFreq
            // 
            this.colWaitedFreq.HeaderText = "Frec. Esperada";
            this.colWaitedFreq.Name = "colWaitedFreq";
            this.colWaitedFreq.ReadOnly = true;
            // 
            // colOperation1
            // 
            this.colOperation1.HeaderText = "(fo-fe)^2";
            this.colOperation1.Name = "colOperation1";
            this.colOperation1.ReadOnly = true;
            // 
            // colOperation2
            // 
            this.colOperation2.HeaderText = "(col4)/fe";
            this.colOperation2.Name = "colOperation2";
            this.colOperation2.ReadOnly = true;
            // 
            // colSum
            // 
            this.colSum.HeaderText = "Sumatoria";
            this.colSum.Name = "colSum";
            this.colSum.ReadOnly = true;
            // 
            // chartFreqRandom
            // 
            this.chartFreqRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisX.Title = "Intervalos";
            chartArea2.AxisY.Title = "Valores";
            chartArea2.Name = "ChartArea1";
            this.chartFreqRandom.ChartAreas.Add(chartArea2);
            this.chartFreqRandom.DataSource = this.chartFreqRandom.Series;
            legend2.Name = "Legend1";
            this.chartFreqRandom.Legends.Add(legend2);
            this.chartFreqRandom.Location = new System.Drawing.Point(6, 171);
            this.chartFreqRandom.Name = "chartFreqRandom";
            this.chartFreqRandom.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Freq observada";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Freq esperada";
            this.chartFreqRandom.Series.Add(series3);
            this.chartFreqRandom.Series.Add(series4);
            this.chartFreqRandom.Size = new System.Drawing.Size(587, 218);
            this.chartFreqRandom.TabIndex = 3;
            this.chartFreqRandom.Text = "chart1";
            // 
            // gbGeneratorRandom
            // 
            this.gbGeneratorRandom.Controls.Add(this.btnGenerateRandom);
            this.gbGeneratorRandom.Controls.Add(this.label3);
            this.gbGeneratorRandom.Controls.Add(this.lblQuantityRandom);
            this.gbGeneratorRandom.Controls.Add(this.txtIntervalQuantityRandom);
            this.gbGeneratorRandom.Controls.Add(this.label1);
            this.gbGeneratorRandom.Controls.Add(this.txtQuantityRandom);
            this.gbGeneratorRandom.Location = new System.Drawing.Point(165, 6);
            this.gbGeneratorRandom.Name = "gbGeneratorRandom";
            this.gbGeneratorRandom.Size = new System.Drawing.Size(781, 97);
            this.gbGeneratorRandom.TabIndex = 2;
            this.gbGeneratorRandom.TabStop = false;
            this.gbGeneratorRandom.Text = "Parámetros";
            // 
            // btnGenerateRandom
            // 
            this.btnGenerateRandom.Location = new System.Drawing.Point(675, 53);
            this.btnGenerateRandom.Name = "btnGenerateRandom";
            this.btnGenerateRandom.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateRandom.TabIndex = 9;
            this.btnGenerateRandom.Text = "Generar";
            this.btnGenerateRandom.UseVisualStyleBackColor = true;
            this.btnGenerateRandom.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnGenerateRandom_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "(considere que el método es más adecuado\r\n para muestras de 30 o más elementos)";
            // 
            // lblQuantityRandom
            // 
            this.lblQuantityRandom.AutoSize = true;
            this.lblQuantityRandom.Location = new System.Drawing.Point(9, 19);
            this.lblQuantityRandom.Name = "lblQuantityRandom";
            this.lblQuantityRandom.Size = new System.Drawing.Size(158, 13);
            this.lblQuantityRandom.TabIndex = 6;
            this.lblQuantityRandom.Text = "Cantidad de números a generar:";
            // 
            // txtIntervalQuantityRandom
            // 
            this.txtIntervalQuantityRandom.Location = new System.Drawing.Point(470, 17);
            this.txtIntervalQuantityRandom.Name = "txtIntervalQuantityRandom";
            this.txtIntervalQuantityRandom.Size = new System.Drawing.Size(138, 20);
            this.txtIntervalQuantityRandom.TabIndex = 1;
            this.txtIntervalQuantityRandom.Enter += new System.EventHandler(this.txtSubintervChi_Enter);
            this.txtIntervalQuantityRandom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad de subintervalos:";
            // 
            // txtQuantityRandom
            // 
            this.txtQuantityRandom.Location = new System.Drawing.Point(173, 16);
            this.txtQuantityRandom.Name = "txtQuantityRandom";
            this.txtQuantityRandom.Size = new System.Drawing.Size(138, 20);
            this.txtQuantityRandom.TabIndex = 0;
            this.txtQuantityRandom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // TP1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
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
            this.gbChiRandom.ResumeLayout(false);
            this.gbChiRandom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiRandom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFreqRandom)).EndInit();
            this.gbGeneratorRandom.ResumeLayout(false);
            this.gbGeneratorRandom.PerformLayout();
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
        private System.Windows.Forms.TextBox txtQuantityRandom;
        private System.Windows.Forms.GroupBox gbGeneratorRandom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuantityRandom;
        private System.Windows.Forms.TextBox txtIntervalQuantityRandom;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.DataVisualization.Charting.Chart chartFreqRandom;
        private System.Windows.Forms.GroupBox gbChiRandom;
        private System.Windows.Forms.Label lblRta;
        private System.Windows.Forms.TextBox txtRtaRandom;
        private System.Windows.Forms.DataGridView dgvChiRandom;
        private System.Windows.Forms.Button btnGenerateRandom;
        private System.Windows.Forms.Label lblTabuledChi;
        private System.Windows.Forms.Label lblObtainedChiSum;
        private System.Windows.Forms.TextBox txtObtainedSChiSum;
        private System.Windows.Forms.TextBox txtTabuledChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIntervals;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObservableFreq;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWaitedFreq;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperation1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperation2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSum;
        private System.Windows.Forms.RichTextBox txtGeneratedListRandom;
    }
}

