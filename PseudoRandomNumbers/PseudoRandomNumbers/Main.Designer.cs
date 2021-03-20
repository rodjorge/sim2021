
namespace PseudoRandomNumbers
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
            this.txta_output = new System.Windows.Forms.RichTextBox();
            this.lbl_output = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.msk_seed = new System.Windows.Forms.MaskedTextBox();
            this.msk_k = new System.Windows.Forms.MaskedTextBox();
            this.msk_g = new System.Windows.Forms.MaskedTextBox();
            this.msk_c = new System.Windows.Forms.MaskedTextBox();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.msk_n = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_generador = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txta_output
            // 
            this.txta_output.Location = new System.Drawing.Point(12, 286);
            this.txta_output.Name = "txta_output";
            this.txta_output.Size = new System.Drawing.Size(356, 152);
            this.txta_output.TabIndex = 6;
            this.txta_output.Text = "";
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_output.Location = new System.Drawing.Point(12, 258);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(71, 25);
            this.lbl_output.TabIndex = 7;
            this.lbl_output.Text = "Output";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Seed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "k";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(223, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "g";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(329, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "c";
            // 
            // msk_seed
            // 
            this.msk_seed.Location = new System.Drawing.Point(12, 149);
            this.msk_seed.Mask = "00000";
            this.msk_seed.Name = "msk_seed";
            this.msk_seed.Size = new System.Drawing.Size(54, 20);
            this.msk_seed.TabIndex = 0;
            this.msk_seed.ValidatingType = typeof(int);
            // 
            // msk_k
            // 
            this.msk_k.Location = new System.Drawing.Point(122, 149);
            this.msk_k.Mask = "00000";
            this.msk_k.Name = "msk_k";
            this.msk_k.Size = new System.Drawing.Size(43, 20);
            this.msk_k.TabIndex = 1;
            this.msk_k.ValidatingType = typeof(int);
            // 
            // msk_g
            // 
            this.msk_g.Location = new System.Drawing.Point(228, 149);
            this.msk_g.Mask = "00000";
            this.msk_g.Name = "msk_g";
            this.msk_g.Size = new System.Drawing.Size(39, 20);
            this.msk_g.TabIndex = 2;
            this.msk_g.ValidatingType = typeof(int);
            // 
            // msk_c
            // 
            this.msk_c.Location = new System.Drawing.Point(334, 149);
            this.msk_c.Mask = "00000";
            this.msk_c.Name = "msk_c";
            this.msk_c.Size = new System.Drawing.Size(38, 20);
            this.msk_c.TabIndex = 3;
            this.msk_c.ValidatingType = typeof(int);
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Location = new System.Drawing.Point(108, 230);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(75, 23);
            this.btn_iniciar.TabIndex = 5;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // msk_n
            // 
            this.msk_n.Location = new System.Drawing.Point(12, 230);
            this.msk_n.Mask = "00000";
            this.msk_n.Name = "msk_n";
            this.msk_n.Size = new System.Drawing.Size(38, 20);
            this.msk_n.TabIndex = 4;
            this.msk_n.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "n";
            // 
            // cmb_generador
            // 
            this.cmb_generador.FormattingEnabled = true;
            this.cmb_generador.Items.AddRange(new object[] {
            "Método Congruencial Lineal",
            "Método Congruencial Multiplicativo",
            "Generador Propio del Lenguaje"});
            this.cmb_generador.Location = new System.Drawing.Point(12, 59);
            this.cmb_generador.Name = "cmb_generador";
            this.cmb_generador.Size = new System.Drawing.Size(171, 21);
            this.cmb_generador.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Generador";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_generador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.msk_n);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.msk_c);
            this.Controls.Add(this.msk_g);
            this.Controls.Add(this.msk_k);
            this.Controls.Add(this.msk_seed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.txta_output);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txta_output;
        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox msk_seed;
        private System.Windows.Forms.MaskedTextBox msk_k;
        private System.Windows.Forms.MaskedTextBox msk_g;
        private System.Windows.Forms.MaskedTextBox msk_c;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.MaskedTextBox msk_n;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_generador;
        private System.Windows.Forms.Label label6;
    }
}

