
namespace TP5
{
    partial class FormTablaIntegracion
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.t = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPrima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.t,
            this.D,
            this.DPrima,
            this.t_1,
            this.D_1});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(424, 586);
            this.dataGridView1.TabIndex = 0;
            // 
            // t
            // 
            this.t.HeaderText = "t(i)";
            this.t.Name = "t";
            this.t.Width = 75;
            // 
            // D
            // 
            this.D.HeaderText = "D(i)";
            this.D.Name = "D";
            this.D.Width = 75;
            // 
            // DPrima
            // 
            this.DPrima.HeaderText = "D\'(i)";
            this.DPrima.Name = "DPrima";
            this.DPrima.Width = 75;
            // 
            // t_1
            // 
            this.t_1.HeaderText = "t(i+1)";
            this.t_1.Name = "t_1";
            this.t_1.Width = 75;
            // 
            // D_1
            // 
            this.D_1.HeaderText = "D(i+1)";
            this.D_1.Name = "D_1";
            this.D_1.Width = 75;
            // 
            // FormTablaIntegracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 610);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormTablaIntegracion";
            this.ShowIcon = false;
            this.Text = "Tabla de integración numérica";
            this.Load += new System.EventHandler(this.FormTablaIntegracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn t;
        private System.Windows.Forms.DataGridViewTextBoxColumn D;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPrima;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_1;
    }
}