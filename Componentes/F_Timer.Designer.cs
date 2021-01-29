
namespace Componentes
{
    partial class F_Timer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Timer));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_iniciar_t1 = new System.Windows.Forms.Button();
            this.brn_para_t1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reiniciar = new System.Windows.Forms.Button();
            this.btn_zerar = new System.Windows.Forms.Button();
            this.img_carro = new System.Windows.Forms.PictureBox();
            this.but_iniciarCarro = new System.Windows.Forms.Button();
            this.timer_carro = new System.Windows.Forms.Timer(this.components);
            this.btn_pararCarro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_carro)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_iniciar_t1
            // 
            this.btn_iniciar_t1.Location = new System.Drawing.Point(12, 12);
            this.btn_iniciar_t1.Name = "btn_iniciar_t1";
            this.btn_iniciar_t1.Size = new System.Drawing.Size(131, 45);
            this.btn_iniciar_t1.TabIndex = 0;
            this.btn_iniciar_t1.Text = "Iniciar";
            this.btn_iniciar_t1.UseVisualStyleBackColor = true;
            this.btn_iniciar_t1.Click += new System.EventHandler(this.btn_iniciar_t1_Click);
            // 
            // brn_para_t1
            // 
            this.brn_para_t1.Location = new System.Drawing.Point(149, 12);
            this.brn_para_t1.Name = "brn_para_t1";
            this.brn_para_t1.Size = new System.Drawing.Size(131, 45);
            this.brn_para_t1.TabIndex = 1;
            this.brn_para_t1.Text = "Parar";
            this.brn_para_t1.UseVisualStyleBackColor = true;
            this.brn_para_t1.Click += new System.EventHandler(this.brn_para_t1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // btn_reiniciar
            // 
            this.btn_reiniciar.Location = new System.Drawing.Point(286, 12);
            this.btn_reiniciar.Name = "btn_reiniciar";
            this.btn_reiniciar.Size = new System.Drawing.Size(131, 45);
            this.btn_reiniciar.TabIndex = 3;
            this.btn_reiniciar.Text = "Reiniciar";
            this.btn_reiniciar.UseVisualStyleBackColor = true;
            this.btn_reiniciar.Click += new System.EventHandler(this.btn_reiniciar_Click);
            // 
            // btn_zerar
            // 
            this.btn_zerar.Location = new System.Drawing.Point(423, 12);
            this.btn_zerar.Name = "btn_zerar";
            this.btn_zerar.Size = new System.Drawing.Size(131, 45);
            this.btn_zerar.TabIndex = 4;
            this.btn_zerar.Text = "Zerar";
            this.btn_zerar.UseVisualStyleBackColor = true;
            this.btn_zerar.Click += new System.EventHandler(this.btn_zerar_Click);
            // 
            // img_carro
            // 
            this.img_carro.Image = ((System.Drawing.Image)(resources.GetObject("img_carro.Image")));
            this.img_carro.Location = new System.Drawing.Point(12, 119);
            this.img_carro.Name = "img_carro";
            this.img_carro.Size = new System.Drawing.Size(215, 122);
            this.img_carro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_carro.TabIndex = 5;
            this.img_carro.TabStop = false;
            // 
            // but_iniciarCarro
            // 
            this.but_iniciarCarro.Location = new System.Drawing.Point(12, 90);
            this.but_iniciarCarro.Name = "but_iniciarCarro";
            this.but_iniciarCarro.Size = new System.Drawing.Size(75, 23);
            this.but_iniciarCarro.TabIndex = 6;
            this.but_iniciarCarro.Text = "Iniciar Carro";
            this.but_iniciarCarro.UseVisualStyleBackColor = true;
            this.but_iniciarCarro.Click += new System.EventHandler(this.but_iniciarCarro_Click);
            // 
            // timer_carro
            // 
            this.timer_carro.Interval = 1;
            this.timer_carro.Tick += new System.EventHandler(this.timer_carro_Tick);
            // 
            // btn_pararCarro
            // 
            this.btn_pararCarro.Location = new System.Drawing.Point(125, 90);
            this.btn_pararCarro.Name = "btn_pararCarro";
            this.btn_pararCarro.Size = new System.Drawing.Size(75, 23);
            this.btn_pararCarro.TabIndex = 7;
            this.btn_pararCarro.Text = "Parar Carro";
            this.btn_pararCarro.UseVisualStyleBackColor = true;
            this.btn_pararCarro.Click += new System.EventHandler(this.btn_pararCarro_Click);
            // 
            // F_Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_pararCarro);
            this.Controls.Add(this.but_iniciarCarro);
            this.Controls.Add(this.img_carro);
            this.Controls.Add(this.btn_zerar);
            this.Controls.Add(this.btn_reiniciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brn_para_t1);
            this.Controls.Add(this.btn_iniciar_t1);
            this.Name = "F_Timer";
            this.Text = "F_Timer";
            this.Load += new System.EventHandler(this.F_Timer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_carro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_iniciar_t1;
        private System.Windows.Forms.Button brn_para_t1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_reiniciar;
        private System.Windows.Forms.Button btn_zerar;
        private System.Windows.Forms.PictureBox img_carro;
        private System.Windows.Forms.Button but_iniciarCarro;
        private System.Windows.Forms.Timer timer_carro;
        private System.Windows.Forms.Button btn_pararCarro;
    }
}