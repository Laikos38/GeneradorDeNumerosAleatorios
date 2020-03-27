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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tabControl1 = new System.Windows.Forms.TabControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbCalculator.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbGenerator.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(611, 444);
            this.tabControl1.TabIndex = 0;
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(804, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TP1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 461);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TP1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbCalculator.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.gbGenerator.ResumeLayout(false);
            this.gbGenerator.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TabControl tabControl1;
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
    }
}

