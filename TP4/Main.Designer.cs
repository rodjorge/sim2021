
namespace TP4
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPrimeraTirada = new System.Windows.Forms.DataGridView();
            this.nroPinos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Probabilidad1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtMaximo = new System.Windows.Forms.TextBox();
            this.txtMinimo = new System.Windows.Forms.TextBox();
            this.dgvSegundaTirada = new System.Windows.Forms.DataGridView();
            this.pinosPrimeraBola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pinosSegundaBola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probabilidad2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSegundaTirada = new System.Windows.Forms.Label();
            this.btnGenerarSegunda = new System.Windows.Forms.Button();
            this.btnSimular = new System.Windows.Forms.Button();
            this.txtStrike = new System.Windows.Forms.TextBox();
            this.txtSpare = new System.Windows.Forms.TextBox();
            this.txtThreshold = new System.Windows.Forms.TextBox();
            this.lblStrike = new System.Windows.Forms.Label();
            this.lblSpare = new System.Windows.Forms.Label();
            this.lblThreshold = new System.Windows.Forms.Label();
            this.txtSimulaciones = new System.Windows.Forms.TextBox();
            this.txtExitos = new System.Windows.Forms.TextBox();
            this.lblSimulaciones = new System.Windows.Forms.Label();
            this.lblExitos = new System.Windows.Forms.Label();
            this.lblProbabilidadExito = new System.Windows.Forms.Label();
            this.nroExito = new System.Windows.Forms.Label();
            this.txtVueltas = new System.Windows.Forms.TextBox();
            this.chkDefault = new System.Windows.Forms.CheckBox();
            this.lblVueltas = new System.Windows.Forms.Label();
            this.lblRounds = new System.Windows.Forms.Label();
            this.txtRounds = new System.Windows.Forms.TextBox();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultado1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultado2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.chkVerMedio = new System.Windows.Forms.CheckBox();
            this.gbxGeneradores = new System.Windows.Forms.GroupBox();
            this.rbtMCG = new System.Windows.Forms.RadioButton();
            this.rbtLCG = new System.Windows.Forms.RadioButton();
            this.rbtStandard = new System.Windows.Forms.RadioButton();
            this.rbtCrypto = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimeraTirada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSegundaTirada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.gbxGeneradores.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPrimeraTirada
            // 
            this.dgvPrimeraTirada.AllowUserToAddRows = false;
            this.dgvPrimeraTirada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrimeraTirada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroPinos,
            this.Probabilidad1});
            this.dgvPrimeraTirada.Location = new System.Drawing.Point(13, 126);
            this.dgvPrimeraTirada.Name = "dgvPrimeraTirada";
            this.dgvPrimeraTirada.RowHeadersVisible = false;
            this.dgvPrimeraTirada.Size = new System.Drawing.Size(204, 150);
            this.dgvPrimeraTirada.TabIndex = 0;
            this.dgvPrimeraTirada.Visible = false;
            this.dgvPrimeraTirada.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrimeraTirada_CellValueChanged);
            // 
            // nroPinos
            // 
            this.nroPinos.HeaderText = "Numero de Pinos";
            this.nroPinos.Name = "nroPinos";
            this.nroPinos.ReadOnly = true;
            this.nroPinos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Probabilidad1
            // 
            this.Probabilidad1.HeaderText = "Probabilidad (0, 1)";
            this.Probabilidad1.Name = "Probabilidad1";
            this.Probabilidad1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(13, 88);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtMaximo
            // 
            this.txtMaximo.Location = new System.Drawing.Point(12, 62);
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.Size = new System.Drawing.Size(100, 20);
            this.txtMaximo.TabIndex = 2;
            // 
            // txtMinimo
            // 
            this.txtMinimo.Location = new System.Drawing.Point(118, 62);
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.Size = new System.Drawing.Size(99, 20);
            this.txtMinimo.TabIndex = 3;
            // 
            // dgvSegundaTirada
            // 
            this.dgvSegundaTirada.AllowUserToAddRows = false;
            this.dgvSegundaTirada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSegundaTirada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pinosPrimeraBola,
            this.pinosSegundaBola,
            this.probabilidad2});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSegundaTirada.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSegundaTirada.Location = new System.Drawing.Point(223, 67);
            this.dgvSegundaTirada.Name = "dgvSegundaTirada";
            this.dgvSegundaTirada.RowHeadersVisible = false;
            this.dgvSegundaTirada.Size = new System.Drawing.Size(304, 209);
            this.dgvSegundaTirada.TabIndex = 4;
            this.dgvSegundaTirada.Visible = false;
            this.dgvSegundaTirada.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSegundaTirada_CellValueChanged);
            // 
            // pinosPrimeraBola
            // 
            this.pinosPrimeraBola.HeaderText = "Pinos de la Primera Bola";
            this.pinosPrimeraBola.Name = "pinosPrimeraBola";
            this.pinosPrimeraBola.ReadOnly = true;
            this.pinosPrimeraBola.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pinosSegundaBola
            // 
            this.pinosSegundaBola.HeaderText = "Pinos de la Segunda Bola";
            this.pinosSegundaBola.Name = "pinosSegundaBola";
            this.pinosSegundaBola.ReadOnly = true;
            this.pinosSegundaBola.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // probabilidad2
            // 
            this.probabilidad2.HeaderText = "Probabilidad (0, 1)";
            this.probabilidad2.Name = "probabilidad2";
            this.probabilidad2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Maximo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Minimo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Primera Tirada";
            // 
            // lblSegundaTirada
            // 
            this.lblSegundaTirada.AutoSize = true;
            this.lblSegundaTirada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundaTirada.Location = new System.Drawing.Point(219, 9);
            this.lblSegundaTirada.Name = "lblSegundaTirada";
            this.lblSegundaTirada.Size = new System.Drawing.Size(145, 24);
            this.lblSegundaTirada.TabIndex = 8;
            this.lblSegundaTirada.Text = "Segunda Tirada";
            this.lblSegundaTirada.Visible = false;
            // 
            // btnGenerarSegunda
            // 
            this.btnGenerarSegunda.Location = new System.Drawing.Point(223, 38);
            this.btnGenerarSegunda.Name = "btnGenerarSegunda";
            this.btnGenerarSegunda.Size = new System.Drawing.Size(101, 23);
            this.btnGenerarSegunda.TabIndex = 9;
            this.btnGenerarSegunda.Text = "generar segunda";
            this.btnGenerarSegunda.UseVisualStyleBackColor = true;
            this.btnGenerarSegunda.Visible = false;
            this.btnGenerarSegunda.Click += new System.EventHandler(this.btnGenerarSegunda_Click);
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(603, 414);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(75, 23);
            this.btnSimular.TabIndex = 10;
            this.btnSimular.Text = "simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Visible = false;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // txtStrike
            // 
            this.txtStrike.Location = new System.Drawing.Point(20, 324);
            this.txtStrike.Name = "txtStrike";
            this.txtStrike.Size = new System.Drawing.Size(100, 20);
            this.txtStrike.TabIndex = 12;
            this.txtStrike.Visible = false;
            // 
            // txtSpare
            // 
            this.txtSpare.Location = new System.Drawing.Point(139, 324);
            this.txtSpare.Name = "txtSpare";
            this.txtSpare.Size = new System.Drawing.Size(100, 20);
            this.txtSpare.TabIndex = 13;
            this.txtSpare.Visible = false;
            // 
            // txtThreshold
            // 
            this.txtThreshold.Location = new System.Drawing.Point(254, 324);
            this.txtThreshold.Name = "txtThreshold";
            this.txtThreshold.Size = new System.Drawing.Size(100, 20);
            this.txtThreshold.TabIndex = 14;
            this.txtThreshold.Visible = false;
            // 
            // lblStrike
            // 
            this.lblStrike.AutoSize = true;
            this.lblStrike.Location = new System.Drawing.Point(17, 308);
            this.lblStrike.Name = "lblStrike";
            this.lblStrike.Size = new System.Drawing.Size(34, 13);
            this.lblStrike.TabIndex = 15;
            this.lblStrike.Text = "Strike";
            this.lblStrike.Visible = false;
            // 
            // lblSpare
            // 
            this.lblSpare.AutoSize = true;
            this.lblSpare.Location = new System.Drawing.Point(136, 308);
            this.lblSpare.Name = "lblSpare";
            this.lblSpare.Size = new System.Drawing.Size(35, 13);
            this.lblSpare.TabIndex = 16;
            this.lblSpare.Text = "Spare";
            this.lblSpare.Visible = false;
            // 
            // lblThreshold
            // 
            this.lblThreshold.AutoSize = true;
            this.lblThreshold.Location = new System.Drawing.Point(251, 308);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(54, 13);
            this.lblThreshold.TabIndex = 17;
            this.lblThreshold.Text = "Threshold";
            this.lblThreshold.Visible = false;
            // 
            // txtSimulaciones
            // 
            this.txtSimulaciones.Enabled = false;
            this.txtSimulaciones.Location = new System.Drawing.Point(20, 382);
            this.txtSimulaciones.Name = "txtSimulaciones";
            this.txtSimulaciones.Size = new System.Drawing.Size(100, 20);
            this.txtSimulaciones.TabIndex = 18;
            this.txtSimulaciones.Visible = false;
            // 
            // txtExitos
            // 
            this.txtExitos.Enabled = false;
            this.txtExitos.Location = new System.Drawing.Point(139, 382);
            this.txtExitos.Name = "txtExitos";
            this.txtExitos.Size = new System.Drawing.Size(100, 20);
            this.txtExitos.TabIndex = 19;
            this.txtExitos.Visible = false;
            // 
            // lblSimulaciones
            // 
            this.lblSimulaciones.AutoSize = true;
            this.lblSimulaciones.Location = new System.Drawing.Point(17, 366);
            this.lblSimulaciones.Name = "lblSimulaciones";
            this.lblSimulaciones.Size = new System.Drawing.Size(69, 13);
            this.lblSimulaciones.TabIndex = 20;
            this.lblSimulaciones.Text = "Simulaciones";
            this.lblSimulaciones.Visible = false;
            // 
            // lblExitos
            // 
            this.lblExitos.AutoSize = true;
            this.lblExitos.Location = new System.Drawing.Point(136, 366);
            this.lblExitos.Name = "lblExitos";
            this.lblExitos.Size = new System.Drawing.Size(35, 13);
            this.lblExitos.TabIndex = 21;
            this.lblExitos.Text = "Exitos";
            this.lblExitos.Visible = false;
            // 
            // lblProbabilidadExito
            // 
            this.lblProbabilidadExito.AutoSize = true;
            this.lblProbabilidadExito.Location = new System.Drawing.Point(17, 414);
            this.lblProbabilidadExito.Name = "lblProbabilidadExito";
            this.lblProbabilidadExito.Size = new System.Drawing.Size(112, 13);
            this.lblProbabilidadExito.TabIndex = 22;
            this.lblProbabilidadExito.Text = "Probabilidad de Exito: ";
            this.lblProbabilidadExito.Visible = false;
            // 
            // nroExito
            // 
            this.nroExito.AutoSize = true;
            this.nroExito.Location = new System.Drawing.Point(132, 414);
            this.nroExito.Name = "nroExito";
            this.nroExito.Size = new System.Drawing.Size(13, 13);
            this.nroExito.TabIndex = 23;
            this.nroExito.Text = "0";
            this.nroExito.Visible = false;
            // 
            // txtVueltas
            // 
            this.txtVueltas.Location = new System.Drawing.Point(603, 385);
            this.txtVueltas.Name = "txtVueltas";
            this.txtVueltas.Size = new System.Drawing.Size(100, 20);
            this.txtVueltas.TabIndex = 24;
            this.txtVueltas.Visible = false;
            // 
            // chkDefault
            // 
            this.chkDefault.AutoSize = true;
            this.chkDefault.Location = new System.Drawing.Point(118, 94);
            this.chkDefault.Name = "chkDefault";
            this.chkDefault.Size = new System.Drawing.Size(81, 17);
            this.chkDefault.TabIndex = 26;
            this.chkDefault.Text = "Por defecto";
            this.chkDefault.UseVisualStyleBackColor = true;
            this.chkDefault.CheckedChanged += new System.EventHandler(this.chkDefault_CheckedChanged);
            // 
            // lblVueltas
            // 
            this.lblVueltas.AutoSize = true;
            this.lblVueltas.Location = new System.Drawing.Point(600, 369);
            this.lblVueltas.Name = "lblVueltas";
            this.lblVueltas.Size = new System.Drawing.Size(129, 13);
            this.lblVueltas.TabIndex = 27;
            this.lblVueltas.Text = "Cantidad de Simulaciones";
            this.lblVueltas.Visible = false;
            // 
            // lblRounds
            // 
            this.lblRounds.AutoSize = true;
            this.lblRounds.Location = new System.Drawing.Point(599, 311);
            this.lblRounds.Name = "lblRounds";
            this.lblRounds.Size = new System.Drawing.Size(104, 13);
            this.lblRounds.TabIndex = 29;
            this.lblRounds.Text = "Cantidad de Rounds";
            this.lblRounds.Visible = false;
            // 
            // txtRounds
            // 
            this.txtRounds.Location = new System.Drawing.Point(602, 327);
            this.txtRounds.Name = "txtRounds";
            this.txtRounds.Size = new System.Drawing.Size(100, 20);
            this.txtRounds.TabIndex = 28;
            this.txtRounds.Visible = false;
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iteracion,
            this.rnd1,
            this.resultado1,
            this.rnd2,
            this.resultado2,
            this.puntos,
            this.accum});
            this.dgvResultados.Location = new System.Drawing.Point(12, 443);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersVisible = false;
            this.dgvResultados.Size = new System.Drawing.Size(703, 150);
            this.dgvResultados.TabIndex = 30;
            this.dgvResultados.Visible = false;
            // 
            // iteracion
            // 
            this.iteracion.HeaderText = "Iteracion";
            this.iteracion.Name = "iteracion";
            this.iteracion.ReadOnly = true;
            // 
            // rnd1
            // 
            this.rnd1.HeaderText = "Variable Aleatoria";
            this.rnd1.Name = "rnd1";
            this.rnd1.ReadOnly = true;
            // 
            // resultado1
            // 
            this.resultado1.HeaderText = "Pinos 1er tirada";
            this.resultado1.Name = "resultado1";
            this.resultado1.ReadOnly = true;
            // 
            // rnd2
            // 
            this.rnd2.HeaderText = "Variable Aleatoria";
            this.rnd2.Name = "rnd2";
            this.rnd2.ReadOnly = true;
            // 
            // resultado2
            // 
            this.resultado2.HeaderText = "Pinos segunda tirada";
            this.resultado2.Name = "resultado2";
            this.resultado2.ReadOnly = true;
            // 
            // puntos
            // 
            this.puntos.HeaderText = "Puntos";
            this.puntos.Name = "puntos";
            this.puntos.ReadOnly = true;
            // 
            // accum
            // 
            this.accum.HeaderText = "Puntos Acumulados";
            this.accum.Name = "accum";
            this.accum.ReadOnly = true;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(481, 366);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(35, 13);
            this.lblHasta.TabIndex = 34;
            this.lblHasta.Text = "Hasta";
            this.lblHasta.Visible = false;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(374, 366);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(38, 13);
            this.lblDesde.TabIndex = 33;
            this.lblDesde.Text = "Desde";
            this.lblDesde.Visible = false;
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(484, 385);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(99, 20);
            this.txtHasta.TabIndex = 32;
            this.txtHasta.Visible = false;
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(378, 385);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(100, 20);
            this.txtDesde.TabIndex = 31;
            this.txtDesde.Visible = false;
            // 
            // chkVerMedio
            // 
            this.chkVerMedio.AutoSize = true;
            this.chkVerMedio.Location = new System.Drawing.Point(380, 327);
            this.chkVerMedio.Name = "chkVerMedio";
            this.chkVerMedio.Size = new System.Drawing.Size(148, 17);
            this.chkVerMedio.TabIndex = 35;
            this.chkVerMedio.Text = "ver resultados intermedios";
            this.chkVerMedio.UseVisualStyleBackColor = true;
            this.chkVerMedio.Visible = false;
            this.chkVerMedio.CheckedChanged += new System.EventHandler(this.chkVerMedio_CheckedChanged);
            // 
            // gbxGeneradores
            // 
            this.gbxGeneradores.Controls.Add(this.rbtMCG);
            this.gbxGeneradores.Controls.Add(this.rbtLCG);
            this.gbxGeneradores.Controls.Add(this.rbtStandard);
            this.gbxGeneradores.Controls.Add(this.rbtCrypto);
            this.gbxGeneradores.Location = new System.Drawing.Point(545, 67);
            this.gbxGeneradores.Name = "gbxGeneradores";
            this.gbxGeneradores.Size = new System.Drawing.Size(200, 209);
            this.gbxGeneradores.TabIndex = 36;
            this.gbxGeneradores.TabStop = false;
            this.gbxGeneradores.Text = "generadores";
            this.gbxGeneradores.Visible = false;
            // 
            // rbtMCG
            // 
            this.rbtMCG.AutoSize = true;
            this.rbtMCG.Location = new System.Drawing.Point(7, 95);
            this.rbtMCG.Name = "rbtMCG";
            this.rbtMCG.Size = new System.Drawing.Size(49, 17);
            this.rbtMCG.TabIndex = 3;
            this.rbtMCG.TabStop = true;
            this.rbtMCG.Text = "MCG";
            this.rbtMCG.UseVisualStyleBackColor = true;
            // 
            // rbtLCG
            // 
            this.rbtLCG.AutoSize = true;
            this.rbtLCG.Location = new System.Drawing.Point(7, 72);
            this.rbtLCG.Name = "rbtLCG";
            this.rbtLCG.Size = new System.Drawing.Size(46, 17);
            this.rbtLCG.TabIndex = 2;
            this.rbtLCG.TabStop = true;
            this.rbtLCG.Text = "LCG";
            this.rbtLCG.UseVisualStyleBackColor = true;
            // 
            // rbtStandard
            // 
            this.rbtStandard.AutoSize = true;
            this.rbtStandard.Location = new System.Drawing.Point(7, 49);
            this.rbtStandard.Name = "rbtStandard";
            this.rbtStandard.Size = new System.Drawing.Size(68, 17);
            this.rbtStandard.TabIndex = 1;
            this.rbtStandard.TabStop = true;
            this.rbtStandard.Text = "Standard";
            this.rbtStandard.UseVisualStyleBackColor = true;
            // 
            // rbtCrypto
            // 
            this.rbtCrypto.AutoSize = true;
            this.rbtCrypto.Location = new System.Drawing.Point(7, 26);
            this.rbtCrypto.Name = "rbtCrypto";
            this.rbtCrypto.Size = new System.Drawing.Size(55, 17);
            this.rbtCrypto.TabIndex = 0;
            this.rbtCrypto.TabStop = true;
            this.rbtCrypto.Text = "Crypto";
            this.rbtCrypto.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 631);
            this.Controls.Add(this.gbxGeneradores);
            this.Controls.Add(this.chkVerMedio);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.lblRounds);
            this.Controls.Add(this.txtRounds);
            this.Controls.Add(this.lblVueltas);
            this.Controls.Add(this.chkDefault);
            this.Controls.Add(this.txtVueltas);
            this.Controls.Add(this.nroExito);
            this.Controls.Add(this.lblProbabilidadExito);
            this.Controls.Add(this.lblExitos);
            this.Controls.Add(this.lblSimulaciones);
            this.Controls.Add(this.txtExitos);
            this.Controls.Add(this.txtSimulaciones);
            this.Controls.Add(this.lblThreshold);
            this.Controls.Add(this.lblSpare);
            this.Controls.Add(this.lblStrike);
            this.Controls.Add(this.txtThreshold);
            this.Controls.Add(this.txtSpare);
            this.Controls.Add(this.txtStrike);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.btnGenerarSegunda);
            this.Controls.Add(this.lblSegundaTirada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSegundaTirada);
            this.Controls.Add(this.txtMinimo);
            this.Controls.Add(this.txtMaximo);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dgvPrimeraTirada);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimeraTirada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSegundaTirada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.gbxGeneradores.ResumeLayout(false);
            this.gbxGeneradores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrimeraTirada;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtMaximo;
        private System.Windows.Forms.TextBox txtMinimo;
        private System.Windows.Forms.DataGridView dgvSegundaTirada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSegundaTirada;
        private System.Windows.Forms.Button btnGenerarSegunda;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.TextBox txtStrike;
        private System.Windows.Forms.TextBox txtSpare;
        private System.Windows.Forms.TextBox txtThreshold;
        private System.Windows.Forms.Label lblStrike;
        private System.Windows.Forms.Label lblSpare;
        private System.Windows.Forms.Label lblThreshold;
        private System.Windows.Forms.TextBox txtSimulaciones;
        private System.Windows.Forms.TextBox txtExitos;
        private System.Windows.Forms.Label lblSimulaciones;
        private System.Windows.Forms.Label lblExitos;
        private System.Windows.Forms.Label lblProbabilidadExito;
        private System.Windows.Forms.Label nroExito;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroPinos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Probabilidad1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pinosPrimeraBola;
        private System.Windows.Forms.DataGridViewTextBoxColumn pinosSegundaBola;
        private System.Windows.Forms.DataGridViewTextBoxColumn probabilidad2;
        private System.Windows.Forms.TextBox txtVueltas;
        private System.Windows.Forms.CheckBox chkDefault;
        private System.Windows.Forms.Label lblVueltas;
        private System.Windows.Forms.Label lblRounds;
        private System.Windows.Forms.TextBox txtRounds;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd1;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultado1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd2;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultado2;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn accum;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.CheckBox chkVerMedio;
        private System.Windows.Forms.RadioButton rbtLCG;
        private System.Windows.Forms.RadioButton rbtStandard;
        private System.Windows.Forms.RadioButton rbtCrypto;
        private System.Windows.Forms.GroupBox gbxGeneradores;
        private System.Windows.Forms.RadioButton rbtMCG;
    }
}