
namespace TP5
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fin_acond = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_llg_basket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo_llg_basket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prox_llg_basket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_llg_futbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo_llg_futbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prox_llg_futbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_llg_handball = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo_llg_handball = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prox_llg_handball = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_ocu_basket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo_ocu_basket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fin_ocu_basket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_ocu_f = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo_ocu_f = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fin_ocu_f = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_ocu_h = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo_ocu_h = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fin_ocu_h = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_cancha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cont_b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cont_f = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cont_h = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espera_b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espera_f = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espera_h = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acum_ocu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.evento,
            this.reloj,
            this.fin_acond,
            this.rnd_llg_basket,
            this.tiempo_llg_basket,
            this.prox_llg_basket,
            this.rnd_llg_futbol,
            this.tiempo_llg_futbol,
            this.prox_llg_futbol,
            this.rnd_llg_handball,
            this.tiempo_llg_handball,
            this.prox_llg_handball,
            this.rnd_ocu_basket,
            this.tiempo_ocu_basket,
            this.fin_ocu_basket,
            this.rnd_ocu_f,
            this.tiempo_ocu_f,
            this.fin_ocu_f,
            this.rnd_ocu_h,
            this.tiempo_ocu_h,
            this.fin_ocu_h,
            this.estado_cancha,
            this.cola,
            this.cont_b,
            this.cont_f,
            this.cont_h,
            this.espera_b,
            this.espera_f,
            this.espera_h,
            this.acum_ocu});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1264, 380);
            this.dataGridView1.TabIndex = 2;
            // 
            // evento
            // 
            this.evento.HeaderText = "Evento";
            this.evento.Name = "evento";
            // 
            // reloj
            // 
            this.reloj.HeaderText = "Reloj";
            this.reloj.Name = "reloj";
            // 
            // fin_acond
            // 
            this.fin_acond.HeaderText = "Fin acond";
            this.fin_acond.Name = "fin_acond";
            // 
            // rnd_llg_basket
            // 
            this.rnd_llg_basket.HeaderText = "RND LL Basket";
            this.rnd_llg_basket.Name = "rnd_llg_basket";
            this.rnd_llg_basket.Width = 50;
            // 
            // tiempo_llg_basket
            // 
            this.tiempo_llg_basket.HeaderText = "Tiempo LLG Basket";
            this.tiempo_llg_basket.Name = "tiempo_llg_basket";
            // 
            // prox_llg_basket
            // 
            this.prox_llg_basket.HeaderText = "Prox LLG Basket";
            this.prox_llg_basket.Name = "prox_llg_basket";
            // 
            // rnd_llg_futbol
            // 
            this.rnd_llg_futbol.HeaderText = "RND LLG Futbol";
            this.rnd_llg_futbol.Name = "rnd_llg_futbol";
            this.rnd_llg_futbol.Width = 50;
            // 
            // tiempo_llg_futbol
            // 
            this.tiempo_llg_futbol.HeaderText = "Tiempo LLG Futbol";
            this.tiempo_llg_futbol.Name = "tiempo_llg_futbol";
            // 
            // prox_llg_futbol
            // 
            this.prox_llg_futbol.HeaderText = "Prox LLG Futbol";
            this.prox_llg_futbol.Name = "prox_llg_futbol";
            // 
            // rnd_llg_handball
            // 
            this.rnd_llg_handball.HeaderText = "RND LLG Hand";
            this.rnd_llg_handball.Name = "rnd_llg_handball";
            this.rnd_llg_handball.Width = 50;
            // 
            // tiempo_llg_handball
            // 
            this.tiempo_llg_handball.HeaderText = "Tiempo LLG Hand";
            this.tiempo_llg_handball.Name = "tiempo_llg_handball";
            // 
            // prox_llg_handball
            // 
            this.prox_llg_handball.HeaderText = "Prox LLG Hand";
            this.prox_llg_handball.Name = "prox_llg_handball";
            // 
            // rnd_ocu_basket
            // 
            this.rnd_ocu_basket.HeaderText = "RND ocu Basket";
            this.rnd_ocu_basket.Name = "rnd_ocu_basket";
            this.rnd_ocu_basket.Width = 50;
            // 
            // tiempo_ocu_basket
            // 
            this.tiempo_ocu_basket.HeaderText = "Tiempo ocu Basket";
            this.tiempo_ocu_basket.Name = "tiempo_ocu_basket";
            // 
            // fin_ocu_basket
            // 
            this.fin_ocu_basket.HeaderText = "Fin Ocu Basket";
            this.fin_ocu_basket.Name = "fin_ocu_basket";
            // 
            // rnd_ocu_f
            // 
            this.rnd_ocu_f.HeaderText = "RND Ocu F";
            this.rnd_ocu_f.Name = "rnd_ocu_f";
            this.rnd_ocu_f.Width = 50;
            // 
            // tiempo_ocu_f
            // 
            this.tiempo_ocu_f.HeaderText = "Tiempo ocu F";
            this.tiempo_ocu_f.Name = "tiempo_ocu_f";
            // 
            // fin_ocu_f
            // 
            this.fin_ocu_f.HeaderText = "Fin Ocu F";
            this.fin_ocu_f.Name = "fin_ocu_f";
            // 
            // rnd_ocu_h
            // 
            this.rnd_ocu_h.HeaderText = "RND ocu H";
            this.rnd_ocu_h.Name = "rnd_ocu_h";
            this.rnd_ocu_h.Width = 50;
            // 
            // tiempo_ocu_h
            // 
            this.tiempo_ocu_h.HeaderText = "Tiempo ocu H";
            this.tiempo_ocu_h.Name = "tiempo_ocu_h";
            // 
            // fin_ocu_h
            // 
            this.fin_ocu_h.HeaderText = "Fin Ocu H";
            this.fin_ocu_h.Name = "fin_ocu_h";
            // 
            // estado_cancha
            // 
            this.estado_cancha.HeaderText = "Estado C";
            this.estado_cancha.Name = "estado_cancha";
            // 
            // cola
            // 
            this.cola.HeaderText = "Cola";
            this.cola.Name = "cola";
            this.cola.Width = 30;
            // 
            // cont_b
            // 
            this.cont_b.HeaderText = "Cont B";
            this.cont_b.Name = "cont_b";
            this.cont_b.Width = 30;
            // 
            // cont_f
            // 
            this.cont_f.HeaderText = "Cont F";
            this.cont_f.Name = "cont_f";
            this.cont_f.Width = 30;
            // 
            // cont_h
            // 
            this.cont_h.HeaderText = "Cont H";
            this.cont_h.Name = "cont_h";
            this.cont_h.Width = 30;
            // 
            // espera_b
            // 
            this.espera_b.HeaderText = "Espera B";
            this.espera_b.Name = "espera_b";
            // 
            // espera_f
            // 
            this.espera_f.HeaderText = "Espera F";
            this.espera_f.Name = "espera_f";
            // 
            // espera_h
            // 
            this.espera_h.HeaderText = "Espera H";
            this.espera_h.Name = "espera_h";
            // 
            // acum_ocu
            // 
            this.acum_ocu.HeaderText = "Acum Ocu";
            this.acum_ocu.Name = "acum_ocu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 473);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn reloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn fin_acond;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd_llg_basket;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_llg_basket;
        private System.Windows.Forms.DataGridViewTextBoxColumn prox_llg_basket;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd_llg_futbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_llg_futbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn prox_llg_futbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd_llg_handball;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_llg_handball;
        private System.Windows.Forms.DataGridViewTextBoxColumn prox_llg_handball;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd_ocu_basket;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_ocu_basket;
        private System.Windows.Forms.DataGridViewTextBoxColumn fin_ocu_basket;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd_ocu_f;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_ocu_f;
        private System.Windows.Forms.DataGridViewTextBoxColumn fin_ocu_f;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd_ocu_h;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_ocu_h;
        private System.Windows.Forms.DataGridViewTextBoxColumn fin_ocu_h;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_cancha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cola;
        private System.Windows.Forms.DataGridViewTextBoxColumn cont_b;
        private System.Windows.Forms.DataGridViewTextBoxColumn cont_f;
        private System.Windows.Forms.DataGridViewTextBoxColumn cont_h;
        private System.Windows.Forms.DataGridViewTextBoxColumn espera_b;
        private System.Windows.Forms.DataGridViewTextBoxColumn espera_f;
        private System.Windows.Forms.DataGridViewTextBoxColumn espera_h;
        private System.Windows.Forms.DataGridViewTextBoxColumn acum_ocu;
    }
}

