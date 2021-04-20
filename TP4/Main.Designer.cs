
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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtMaximo = new System.Windows.Forms.TextBox();
            this.txtMinimo = new System.Windows.Forms.TextBox();
            this.dgvSegundaTirada = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nroPinos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Probabilidad1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenerarSegunda = new System.Windows.Forms.Button();
            this.btnSimular = new System.Windows.Forms.Button();
            this.cajaTextual = new System.Windows.Forms.TextBox();
            this.pinosPrimeraBola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pinosSegundaBola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probabilidad2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStrike = new System.Windows.Forms.TextBox();
            this.txtSpare = new System.Windows.Forms.TextBox();
            this.txtThreshold = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSimulaciones = new System.Windows.Forms.TextBox();
            this.txtExitos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            this.dgvPrimeraTirada.Location = new System.Drawing.Point(13, 126);
            this.dgvPrimeraTirada.Name = "dgvPrimeraTirada";
            this.dgvPrimeraTirada.RowHeadersVisible = false;
            this.dgvPrimeraTirada.Size = new System.Drawing.Size(205, 150);
            this.dgvPrimeraTirada.TabIndex = 0;
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
            this.txtMinimo.Size = new System.Drawing.Size(100, 20);
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
            this.dgvSegundaTirada.Location = new System.Drawing.Point(399, 126);
            this.dgvSegundaTirada.Name = "dgvSegundaTirada";
            this.dgvSegundaTirada.RowHeadersVisible = false;
            this.dgvSegundaTirada.Size = new System.Drawing.Size(304, 150);
            this.dgvSegundaTirada.TabIndex = 4;
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
            // nroPinos
            // 
            this.nroPinos.HeaderText = "Numero de Pinos";
            this.nroPinos.Name = "nroPinos";
            this.nroPinos.ReadOnly = true;
            // 
            // Probabilidad1
            // 
            this.Probabilidad1.HeaderText = "Probabilidad (0, 1)";
            this.Probabilidad1.Name = "Probabilidad1";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(395, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Segunda Tirada";
            // 
            // btnGenerarSegunda
            // 
            this.btnGenerarSegunda.Location = new System.Drawing.Point(399, 88);
            this.btnGenerarSegunda.Name = "btnGenerarSegunda";
            this.btnGenerarSegunda.Size = new System.Drawing.Size(101, 23);
            this.btnGenerarSegunda.TabIndex = 9;
            this.btnGenerarSegunda.Text = "generar segunda";
            this.btnGenerarSegunda.UseVisualStyleBackColor = true;
            this.btnGenerarSegunda.Click += new System.EventHandler(this.btnGenerarSegunda_Click);
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
            // pinosPrimeraBola
            // 
            this.pinosPrimeraBola.HeaderText = "Pinos de la Primera Bola";
            this.pinosPrimeraBola.Name = "pinosPrimeraBola";
            this.pinosPrimeraBola.ReadOnly = true;
            // 
            // pinosSegundaBola
            // 
            this.pinosSegundaBola.HeaderText = "Pinos de la Segunda Bola";
            this.pinosSegundaBola.Name = "pinosSegundaBola";
            this.pinosSegundaBola.ReadOnly = true;
            // 
            // probabilidad2
            // 
            this.probabilidad2.HeaderText = "Probabilidad (0, 1)";
            this.probabilidad2.Name = "probabilidad2";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Strike";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(524, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Spare";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(639, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Threshold";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(405, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Simulaciones";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(524, 382);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Exitos";
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
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtExitos);
            this.Controls.Add(this.txtSimulaciones);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtThreshold);
            this.Controls.Add(this.txtSpare);
            this.Controls.Add(this.txtStrike);
            this.Controls.Add(this.cajaTextual);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.btnGenerarSegunda);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn nroPinos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Probabilidad1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGenerarSegunda;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.TextBox cajaTextual;
        private System.Windows.Forms.DataGridViewTextBoxColumn pinosPrimeraBola;
        private System.Windows.Forms.DataGridViewTextBoxColumn pinosSegundaBola;
        private System.Windows.Forms.DataGridViewTextBoxColumn probabilidad2;
        private System.Windows.Forms.TextBox txtStrike;
        private System.Windows.Forms.TextBox txtSpare;
        private System.Windows.Forms.TextBox txtThreshold;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSimulaciones;
        private System.Windows.Forms.TextBox txtExitos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblProbabilidadExito;
        private System.Windows.Forms.Label nroExito;
    }
}