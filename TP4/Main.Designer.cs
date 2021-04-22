
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
            this.dgvSegundaTirada = new System.Windows.Forms.DataGridView();
            this.pinosPrimeraBola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pinosSegundaBola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probabilidad2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSegundaTirada = new System.Windows.Forms.Label();
            this.btnSimular = new System.Windows.Forms.Button();
            this.cajaTextual = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimeraTirada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSegundaTirada)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrimeraTirada
            // 
            this.dgvPrimeraTirada.AllowUserToAddRows = false;
            this.dgvPrimeraTirada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrimeraTirada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroPinos,
            this.Probabilidad1});
            this.dgvPrimeraTirada.Location = new System.Drawing.Point(12, 45);
            this.dgvPrimeraTirada.Name = "dgvPrimeraTirada";
            this.dgvPrimeraTirada.RowHeadersVisible = false;
            this.dgvPrimeraTirada.Size = new System.Drawing.Size(204, 150);
            this.dgvPrimeraTirada.TabIndex = 0;
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
            this.dgvSegundaTirada.Location = new System.Drawing.Point(290, 45);
            this.dgvSegundaTirada.Name = "dgvSegundaTirada";
            this.dgvSegundaTirada.RowHeadersVisible = false;
            this.dgvSegundaTirada.Size = new System.Drawing.Size(304, 150);
            this.dgvSegundaTirada.TabIndex = 4;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Primera Tirada";
            // 
            // lblSegundaTirada
            // 
            this.lblSegundaTirada.AutoSize = true;
            this.lblSegundaTirada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundaTirada.Location = new System.Drawing.Point(286, 9);
            this.lblSegundaTirada.Name = "lblSegundaTirada";
            this.lblSegundaTirada.Size = new System.Drawing.Size(145, 24);
            this.lblSegundaTirada.TabIndex = 8;
            this.lblSegundaTirada.Text = "Segunda Tirada";
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(300, 338);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(75, 23);
            this.btnSimular.TabIndex = 10;
            this.btnSimular.Text = "simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // cajaTextual
            // 
            this.cajaTextual.Location = new System.Drawing.Point(16, 340);
            this.cajaTextual.Multiline = true;
            this.cajaTextual.Name = "cajaTextual";
            this.cajaTextual.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.cajaTextual.Size = new System.Drawing.Size(278, 170);
            this.cajaTextual.TabIndex = 11;
            // 
            // txtStrike
            // 
            this.txtStrike.Location = new System.Drawing.Point(408, 340);
            this.txtStrike.Name = "txtStrike";
            this.txtStrike.Size = new System.Drawing.Size(100, 20);
            this.txtStrike.TabIndex = 12;
            // 
            // txtSpare
            // 
            this.txtSpare.Location = new System.Drawing.Point(527, 340);
            this.txtSpare.Name = "txtSpare";
            this.txtSpare.Size = new System.Drawing.Size(100, 20);
            this.txtSpare.TabIndex = 13;
            // 
            // txtThreshold
            // 
            this.txtThreshold.Location = new System.Drawing.Point(642, 340);
            this.txtThreshold.Name = "txtThreshold";
            this.txtThreshold.Size = new System.Drawing.Size(100, 20);
            this.txtThreshold.TabIndex = 14;
            // 
            // lblStrike
            // 
            this.lblStrike.AutoSize = true;
            this.lblStrike.Location = new System.Drawing.Point(405, 324);
            this.lblStrike.Name = "lblStrike";
            this.lblStrike.Size = new System.Drawing.Size(34, 13);
            this.lblStrike.TabIndex = 15;
            this.lblStrike.Text = "Strike";
            // 
            // lblSpare
            // 
            this.lblSpare.AutoSize = true;
            this.lblSpare.Location = new System.Drawing.Point(524, 324);
            this.lblSpare.Name = "lblSpare";
            this.lblSpare.Size = new System.Drawing.Size(35, 13);
            this.lblSpare.TabIndex = 16;
            this.lblSpare.Text = "Spare";
            // 
            // lblThreshold
            // 
            this.lblThreshold.AutoSize = true;
            this.lblThreshold.Location = new System.Drawing.Point(639, 324);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(54, 13);
            this.lblThreshold.TabIndex = 17;
            this.lblThreshold.Text = "Threshold";
            // 
            // txtSimulaciones
            // 
            this.txtSimulaciones.Enabled = false;
            this.txtSimulaciones.Location = new System.Drawing.Point(408, 398);
            this.txtSimulaciones.Name = "txtSimulaciones";
            this.txtSimulaciones.Size = new System.Drawing.Size(100, 20);
            this.txtSimulaciones.TabIndex = 18;
            // 
            // txtExitos
            // 
            this.txtExitos.Enabled = false;
            this.txtExitos.Location = new System.Drawing.Point(527, 398);
            this.txtExitos.Name = "txtExitos";
            this.txtExitos.Size = new System.Drawing.Size(100, 20);
            this.txtExitos.TabIndex = 19;
            // 
            // lblSimulaciones
            // 
            this.lblSimulaciones.AutoSize = true;
            this.lblSimulaciones.Location = new System.Drawing.Point(405, 382);
            this.lblSimulaciones.Name = "lblSimulaciones";
            this.lblSimulaciones.Size = new System.Drawing.Size(69, 13);
            this.lblSimulaciones.TabIndex = 20;
            this.lblSimulaciones.Text = "Simulaciones";
            // 
            // lblExitos
            // 
            this.lblExitos.AutoSize = true;
            this.lblExitos.Location = new System.Drawing.Point(524, 382);
            this.lblExitos.Name = "lblExitos";
            this.lblExitos.Size = new System.Drawing.Size(35, 13);
            this.lblExitos.TabIndex = 21;
            this.lblExitos.Text = "Exitos";
            // 
            // lblProbabilidadExito
            // 
            this.lblProbabilidadExito.AutoSize = true;
            this.lblProbabilidadExito.Location = new System.Drawing.Point(405, 455);
            this.lblProbabilidadExito.Name = "lblProbabilidadExito";
            this.lblProbabilidadExito.Size = new System.Drawing.Size(112, 13);
            this.lblProbabilidadExito.TabIndex = 22;
            this.lblProbabilidadExito.Text = "Probabilidad de Exito: ";
            // 
            // nroExito
            // 
            this.nroExito.AutoSize = true;
            this.nroExito.Location = new System.Drawing.Point(515, 455);
            this.nroExito.Name = "nroExito";
            this.nroExito.Size = new System.Drawing.Size(13, 13);
            this.nroExito.TabIndex = 23;
            this.nroExito.Text = "0";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
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
            this.Controls.Add(this.cajaTextual);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.lblSegundaTirada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvSegundaTirada);
            this.Controls.Add(this.dgvPrimeraTirada);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimeraTirada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSegundaTirada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrimeraTirada;
        private System.Windows.Forms.DataGridView dgvSegundaTirada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSegundaTirada;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.TextBox cajaTextual;
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
    }
}