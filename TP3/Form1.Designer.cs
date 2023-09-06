
namespace Simulacion_tp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dtgVariables = new System.Windows.Forms.DataGridView();
            this.orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.variable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpTipoDistribucion = new System.Windows.Forms.GroupBox();
            this.radPoisson = new System.Windows.Forms.RadioButton();
            this.radNormal = new System.Windows.Forms.RadioButton();
            this.radExponencial = new System.Windows.Forms.RadioButton();
            this.radUniforme = new System.Windows.Forms.RadioButton();
            this.grpParametros = new System.Windows.Forms.GroupBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtTamanio = new System.Windows.Forms.TextBox();
            this.lblTamanio = new System.Windows.Forms.Label();
            this.txtLambda = new System.Windows.Forms.TextBox();
            this.lblLambda = new System.Windows.Forms.Label();
            this.txtDesviacion = new System.Windows.Forms.TextBox();
            this.lblDesviacion = new System.Windows.Forms.Label();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.lblMedia = new System.Windows.Forms.Label();
            this.txtLimSup = new System.Windows.Forms.TextBox();
            this.lblLimSup = new System.Windows.Forms.Label();
            this.txtLimInf = new System.Windows.Forms.TextBox();
            this.lblLimInf = new System.Windows.Forms.Label();
            this.txtSemilla = new System.Windows.Forms.TextBox();
            this.lblSemilla = new System.Windows.Forms.Label();
            this.grpHistograma = new System.Windows.Forms.GroupBox();
            this.btnFe = new System.Windows.Forms.Button();
            this.graficoHistograma = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblGradosLibertad = new System.Windows.Forms.Label();
            this.cmbIntervalos = new System.Windows.Forms.ComboBox();
            this.lblIntervalos = new System.Windows.Forms.Label();
            this.btnHistograma = new System.Windows.Forms.Button();
            this.dtgHistograma = new System.Windows.Forms.DataGridView();
            this.limInf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limSup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVariables)).BeginInit();
            this.grpTipoDistribucion.SuspendLayout();
            this.grpParametros.SuspendLayout();
            this.grpHistograma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficoHistograma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistograma)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgVariables
            // 
            this.dtgVariables.AllowUserToAddRows = false;
            this.dtgVariables.AllowUserToDeleteRows = false;
            this.dtgVariables.AllowUserToOrderColumns = true;
            this.dtgVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVariables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orden,
            this.variable});
            this.dtgVariables.Location = new System.Drawing.Point(202, 12);
            this.dtgVariables.Name = "dtgVariables";
            this.dtgVariables.RowHeadersVisible = false;
            this.dtgVariables.RowTemplate.Height = 25;
            this.dtgVariables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgVariables.Size = new System.Drawing.Size(151, 354);
            this.dtgVariables.TabIndex = 0;
            // 
            // orden
            // 
            this.orden.HeaderText = "#";
            this.orden.Name = "orden";
            this.orden.Width = 50;
            // 
            // variable
            // 
            this.variable.HeaderText = "Variable";
            this.variable.Name = "variable";
            // 
            // grpTipoDistribucion
            // 
            this.grpTipoDistribucion.Controls.Add(this.radPoisson);
            this.grpTipoDistribucion.Controls.Add(this.radNormal);
            this.grpTipoDistribucion.Controls.Add(this.radExponencial);
            this.grpTipoDistribucion.Controls.Add(this.radUniforme);
            this.grpTipoDistribucion.Location = new System.Drawing.Point(10, 10);
            this.grpTipoDistribucion.Name = "grpTipoDistribucion";
            this.grpTipoDistribucion.Size = new System.Drawing.Size(180, 98);
            this.grpTipoDistribucion.TabIndex = 1;
            this.grpTipoDistribucion.TabStop = false;
            this.grpTipoDistribucion.Text = "Tipo de distribución a generar";
            // 
            // radPoisson
            // 
            this.radPoisson.AutoSize = true;
            this.radPoisson.Location = new System.Drawing.Point(5, 73);
            this.radPoisson.Name = "radPoisson";
            this.radPoisson.Size = new System.Drawing.Size(62, 17);
            this.radPoisson.TabIndex = 5;
            this.radPoisson.TabStop = true;
            this.radPoisson.Text = "Poisson";
            this.radPoisson.UseVisualStyleBackColor = true;
            this.radPoisson.Click += new System.EventHandler(this.cambioDistribucion);
            // 
            // radNormal
            // 
            this.radNormal.AutoSize = true;
            this.radNormal.Location = new System.Drawing.Point(5, 55);
            this.radNormal.Name = "radNormal";
            this.radNormal.Size = new System.Drawing.Size(58, 17);
            this.radNormal.TabIndex = 4;
            this.radNormal.TabStop = true;
            this.radNormal.Text = "Normal";
            this.radNormal.UseVisualStyleBackColor = true;
            this.radNormal.Click += new System.EventHandler(this.cambioDistribucion);
            // 
            // radExponencial
            // 
            this.radExponencial.AutoSize = true;
            this.radExponencial.Location = new System.Drawing.Point(5, 37);
            this.radExponencial.Name = "radExponencial";
            this.radExponencial.Size = new System.Drawing.Size(127, 17);
            this.radExponencial.TabIndex = 3;
            this.radExponencial.TabStop = true;
            this.radExponencial.Text = "Exponencial negativa";
            this.radExponencial.UseVisualStyleBackColor = true;
            this.radExponencial.Click += new System.EventHandler(this.cambioDistribucion);
            // 
            // radUniforme
            // 
            this.radUniforme.AutoSize = true;
            this.radUniforme.Checked = true;
            this.radUniforme.Location = new System.Drawing.Point(5, 19);
            this.radUniforme.Name = "radUniforme";
            this.radUniforme.Size = new System.Drawing.Size(111, 17);
            this.radUniforme.TabIndex = 2;
            this.radUniforme.TabStop = true;
            this.radUniforme.Text = "Uniforme continua";
            this.radUniforme.UseVisualStyleBackColor = true;
            this.radUniforme.Click += new System.EventHandler(this.cambioDistribucion);
            // 
            // grpParametros
            // 
            this.grpParametros.Controls.Add(this.btnGenerar);
            this.grpParametros.Controls.Add(this.txtTamanio);
            this.grpParametros.Controls.Add(this.lblTamanio);
            this.grpParametros.Controls.Add(this.txtLambda);
            this.grpParametros.Controls.Add(this.lblLambda);
            this.grpParametros.Controls.Add(this.txtDesviacion);
            this.grpParametros.Controls.Add(this.lblDesviacion);
            this.grpParametros.Controls.Add(this.txtMedia);
            this.grpParametros.Controls.Add(this.lblMedia);
            this.grpParametros.Controls.Add(this.txtLimSup);
            this.grpParametros.Controls.Add(this.lblLimSup);
            this.grpParametros.Controls.Add(this.txtLimInf);
            this.grpParametros.Controls.Add(this.lblLimInf);
            this.grpParametros.Controls.Add(this.txtSemilla);
            this.grpParametros.Controls.Add(this.lblSemilla);
            this.grpParametros.Location = new System.Drawing.Point(10, 114);
            this.grpParametros.Name = "grpParametros";
            this.grpParametros.Size = new System.Drawing.Size(180, 250);
            this.grpParametros.TabIndex = 2;
            this.grpParametros.TabStop = false;
            this.grpParametros.Text = "Parámetros";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(102, 225);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(64, 20);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtTamanio
            // 
            this.txtTamanio.Location = new System.Drawing.Point(52, 194);
            this.txtTamanio.Name = "txtTamanio";
            this.txtTamanio.Size = new System.Drawing.Size(115, 20);
            this.txtTamanio.TabIndex = 14;
            // 
            // lblTamanio
            // 
            this.lblTamanio.AutoSize = true;
            this.lblTamanio.Location = new System.Drawing.Point(5, 197);
            this.lblTamanio.Name = "lblTamanio";
            this.lblTamanio.Size = new System.Drawing.Size(49, 13);
            this.lblTamanio.TabIndex = 15;
            this.lblTamanio.Text = "Tamaño:";
            // 
            // txtLambda
            // 
            this.txtLambda.Location = new System.Drawing.Point(81, 159);
            this.txtLambda.Name = "txtLambda";
            this.txtLambda.Size = new System.Drawing.Size(86, 20);
            this.txtLambda.TabIndex = 12;
            // 
            // lblLambda
            // 
            this.lblLambda.AutoSize = true;
            this.lblLambda.Location = new System.Drawing.Point(5, 161);
            this.lblLambda.Name = "lblLambda";
            this.lblLambda.Size = new System.Drawing.Size(48, 13);
            this.lblLambda.TabIndex = 13;
            this.lblLambda.Text = "Lambda:";
            // 
            // txtDesviacion
            // 
            this.txtDesviacion.Location = new System.Drawing.Point(81, 132);
            this.txtDesviacion.Name = "txtDesviacion";
            this.txtDesviacion.Size = new System.Drawing.Size(86, 20);
            this.txtDesviacion.TabIndex = 10;
            // 
            // lblDesviacion
            // 
            this.lblDesviacion.AutoSize = true;
            this.lblDesviacion.Location = new System.Drawing.Point(5, 134);
            this.lblDesviacion.Name = "lblDesviacion";
            this.lblDesviacion.Size = new System.Drawing.Size(63, 13);
            this.lblDesviacion.TabIndex = 11;
            this.lblDesviacion.Text = "Desviación:";
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(81, 105);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(86, 20);
            this.txtMedia.TabIndex = 8;
            this.txtMedia.TextChanged += new System.EventHandler(this.txtMedia_TextChanged);
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(5, 107);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(39, 13);
            this.lblMedia.TabIndex = 9;
            this.lblMedia.Text = "Media:";
            // 
            // txtLimSup
            // 
            this.txtLimSup.Location = new System.Drawing.Point(81, 78);
            this.txtLimSup.Name = "txtLimSup";
            this.txtLimSup.Size = new System.Drawing.Size(86, 20);
            this.txtLimSup.TabIndex = 6;
            // 
            // lblLimSup
            // 
            this.lblLimSup.AutoSize = true;
            this.lblLimSup.Location = new System.Drawing.Point(5, 81);
            this.lblLimSup.Name = "lblLimSup";
            this.lblLimSup.Size = new System.Drawing.Size(79, 13);
            this.lblLimSup.TabIndex = 7;
            this.lblLimSup.Text = "Límite superior:";
            // 
            // txtLimInf
            // 
            this.txtLimInf.Location = new System.Drawing.Point(81, 53);
            this.txtLimInf.Name = "txtLimInf";
            this.txtLimInf.Size = new System.Drawing.Size(86, 20);
            this.txtLimInf.TabIndex = 4;
            // 
            // lblLimInf
            // 
            this.lblLimInf.AutoSize = true;
            this.lblLimInf.Location = new System.Drawing.Point(5, 54);
            this.lblLimInf.Name = "lblLimInf";
            this.lblLimInf.Size = new System.Drawing.Size(73, 13);
            this.lblLimInf.TabIndex = 5;
            this.lblLimInf.Text = "Límite inferior:";
            // 
            // txtSemilla
            // 
            this.txtSemilla.Location = new System.Drawing.Point(81, 27);
            this.txtSemilla.Name = "txtSemilla";
            this.txtSemilla.Size = new System.Drawing.Size(86, 20);
            this.txtSemilla.TabIndex = 3;
            // 
            // lblSemilla
            // 
            this.lblSemilla.AutoSize = true;
            this.lblSemilla.Location = new System.Drawing.Point(5, 29);
            this.lblSemilla.Name = "lblSemilla";
            this.lblSemilla.Size = new System.Drawing.Size(43, 13);
            this.lblSemilla.TabIndex = 3;
            this.lblSemilla.Text = "Semilla:";
            // 
            // grpHistograma
            // 
            this.grpHistograma.Controls.Add(this.btnFe);
            this.grpHistograma.Controls.Add(this.graficoHistograma);
            this.grpHistograma.Controls.Add(this.lblGradosLibertad);
            this.grpHistograma.Controls.Add(this.cmbIntervalos);
            this.grpHistograma.Controls.Add(this.lblIntervalos);
            this.grpHistograma.Controls.Add(this.btnHistograma);
            this.grpHistograma.Controls.Add(this.dtgHistograma);
            this.grpHistograma.Location = new System.Drawing.Point(353, 12);
            this.grpHistograma.Name = "grpHistograma";
            this.grpHistograma.Size = new System.Drawing.Size(729, 558);
            this.grpHistograma.TabIndex = 3;
            this.grpHistograma.TabStop = false;
            this.grpHistograma.Text = "Histograma";
            // 
            // btnFe
            // 
            this.btnFe.Location = new System.Drawing.Point(628, 479);
            this.btnFe.Name = "btnFe";
            this.btnFe.Size = new System.Drawing.Size(75, 23);
            this.btnFe.TabIndex = 6;
            this.btnFe.Text = "Mostrar Fe";
            this.btnFe.UseVisualStyleBackColor = true;
            this.btnFe.Visible = false;
            this.btnFe.Click += new System.EventHandler(this.btnFe_Click);
            // 
            // graficoHistograma
            // 
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.IsStaggered = true;
            chartArea1.Name = "ChartArea1";
            this.graficoHistograma.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graficoHistograma.Legends.Add(legend1);
            this.graficoHistograma.Location = new System.Drawing.Point(9, 241);
            this.graficoHistograma.Name = "graficoHistograma";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.graficoHistograma.Series.Add(series1);
            this.graficoHistograma.Series.Add(series2);
            this.graficoHistograma.Size = new System.Drawing.Size(714, 311);
            this.graficoHistograma.TabIndex = 5;
            this.graficoHistograma.Text = "chart1";
            this.graficoHistograma.Visible = false;
            // 
            // lblGradosLibertad
            // 
            this.lblGradosLibertad.AutoSize = true;
            this.lblGradosLibertad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradosLibertad.Location = new System.Drawing.Point(6, 217);
            this.lblGradosLibertad.Name = "lblGradosLibertad";
            this.lblGradosLibertad.Size = new System.Drawing.Size(128, 13);
            this.lblGradosLibertad.TabIndex = 4;
            this.lblGradosLibertad.Text = "GRADOS LIBERTAD:";
            // 
            // cmbIntervalos
            // 
            this.cmbIntervalos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIntervalos.FormattingEnabled = true;
            this.cmbIntervalos.Items.AddRange(new object[] {
            "10",
            "15",
            "20"});
            this.cmbIntervalos.Location = new System.Drawing.Point(68, 21);
            this.cmbIntervalos.Name = "cmbIntervalos";
            this.cmbIntervalos.Size = new System.Drawing.Size(74, 21);
            this.cmbIntervalos.TabIndex = 3;
            // 
            // lblIntervalos
            // 
            this.lblIntervalos.AutoSize = true;
            this.lblIntervalos.Location = new System.Drawing.Point(6, 24);
            this.lblIntervalos.Name = "lblIntervalos";
            this.lblIntervalos.Size = new System.Drawing.Size(56, 13);
            this.lblIntervalos.TabIndex = 2;
            this.lblIntervalos.Text = "Intervalos:";
            // 
            // btnHistograma
            // 
            this.btnHistograma.Location = new System.Drawing.Point(572, 17);
            this.btnHistograma.Name = "btnHistograma";
            this.btnHistograma.Size = new System.Drawing.Size(151, 23);
            this.btnHistograma.TabIndex = 1;
            this.btnHistograma.Text = "Generar histograma";
            this.btnHistograma.UseVisualStyleBackColor = true;
            this.btnHistograma.Click += new System.EventHandler(this.btnHistograma_Click);
            // 
            // dtgHistograma
            // 
            this.dtgHistograma.AllowUserToAddRows = false;
            this.dtgHistograma.AllowUserToDeleteRows = false;
            this.dtgHistograma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHistograma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.limInf,
            this.limSup,
            this.fo,
            this.fe,
            this.c,
            this.ca});
            this.dtgHistograma.Location = new System.Drawing.Point(6, 46);
            this.dtgHistograma.Name = "dtgHistograma";
            this.dtgHistograma.ReadOnly = true;
            this.dtgHistograma.RowHeadersVisible = false;
            this.dtgHistograma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgHistograma.Size = new System.Drawing.Size(717, 161);
            this.dtgHistograma.TabIndex = 0;
            // 
            // limInf
            // 
            this.limInf.HeaderText = "Limite Inferior";
            this.limInf.Name = "limInf";
            this.limInf.ReadOnly = true;
            // 
            // limSup
            // 
            this.limSup.HeaderText = "Limite Superior";
            this.limSup.Name = "limSup";
            this.limSup.ReadOnly = true;
            // 
            // fo
            // 
            this.fo.HeaderText = "Fo";
            this.fo.Name = "fo";
            this.fo.ReadOnly = true;
            // 
            // fe
            // 
            this.fe.HeaderText = "Fe";
            this.fe.Name = "fe";
            this.fe.ReadOnly = true;
            // 
            // c
            // 
            this.c.HeaderText = "C";
            this.c.Name = "c";
            this.c.ReadOnly = true;
            // 
            // ca
            // 
            this.ca.HeaderText = "Ca";
            this.ca.Name = "ca";
            this.ca.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 370);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 194);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grupo 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Chavez, Juan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rodriguez, Jorge";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gaiga, Marcela";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Panero, Agustin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gómez Toledo, Benjamin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ardilles, Hernan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 582);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpHistograma);
            this.Controls.Add(this.grpParametros);
            this.Controls.Add(this.grpTipoDistribucion);
            this.Controls.Add(this.dtgVariables);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SIM TP2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVariables)).EndInit();
            this.grpTipoDistribucion.ResumeLayout(false);
            this.grpTipoDistribucion.PerformLayout();
            this.grpParametros.ResumeLayout(false);
            this.grpParametros.PerformLayout();
            this.grpHistograma.ResumeLayout(false);
            this.grpHistograma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficoHistograma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistograma)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgVariables;
        private System.Windows.Forms.GroupBox grpTipoDistribucion;
        private System.Windows.Forms.RadioButton radNormal;
        private System.Windows.Forms.RadioButton radExponencial;
        private System.Windows.Forms.RadioButton radUniforme;
        private System.Windows.Forms.GroupBox grpParametros;
        private System.Windows.Forms.TextBox txtTamanio;
        private System.Windows.Forms.Label lblTamanio;
        private System.Windows.Forms.TextBox txtLambda;
        private System.Windows.Forms.Label lblLambda;
        private System.Windows.Forms.TextBox txtDesviacion;
        private System.Windows.Forms.Label lblDesviacion;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.TextBox txtLimSup;
        private System.Windows.Forms.Label lblLimSup;
        private System.Windows.Forms.TextBox txtLimInf;
        private System.Windows.Forms.Label lblLimInf;
        private System.Windows.Forms.TextBox txtSemilla;
        private System.Windows.Forms.Label lblSemilla;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.GroupBox grpHistograma;
        private System.Windows.Forms.DataGridViewTextBoxColumn orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn variable;
        private System.Windows.Forms.DataGridView dtgHistograma;
        private System.Windows.Forms.Button btnHistograma;
        private System.Windows.Forms.ComboBox cmbIntervalos;
        private System.Windows.Forms.Label lblIntervalos;
        private System.Windows.Forms.Label lblGradosLibertad;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoHistograma;
        private System.Windows.Forms.Button btnFe;
        private System.Windows.Forms.DataGridViewTextBoxColumn limInf;
        private System.Windows.Forms.DataGridViewTextBoxColumn limSup;
        private System.Windows.Forms.DataGridViewTextBoxColumn fo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fe;
        private System.Windows.Forms.DataGridViewTextBoxColumn c;
        private System.Windows.Forms.DataGridViewTextBoxColumn ca;
        private System.Windows.Forms.RadioButton radPoisson;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

