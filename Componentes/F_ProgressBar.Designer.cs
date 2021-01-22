
namespace Componentes
{
    partial class F_ProgressBar
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_definirValor = new System.Windows.Forms.Button();
            this.tb_progresso = new System.Windows.Forms.TextBox();
            this.btn_preencher = new System.Windows.Forms.Button();
            this.tb_velocidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(151, 196);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(482, 70);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 100;
            // 
            // btn_definirValor
            // 
            this.btn_definirValor.Location = new System.Drawing.Point(151, 77);
            this.btn_definirValor.Name = "btn_definirValor";
            this.btn_definirValor.Size = new System.Drawing.Size(121, 67);
            this.btn_definirValor.TabIndex = 1;
            this.btn_definirValor.Text = "Definir Valor";
            this.btn_definirValor.UseVisualStyleBackColor = true;
            this.btn_definirValor.Click += new System.EventHandler(this.btn_definirValor_Click);
            // 
            // tb_progresso
            // 
            this.tb_progresso.Location = new System.Drawing.Point(151, 36);
            this.tb_progresso.Name = "tb_progresso";
            this.tb_progresso.Size = new System.Drawing.Size(220, 20);
            this.tb_progresso.TabIndex = 3;
            this.tb_progresso.Text = "0";
            // 
            // btn_preencher
            // 
            this.btn_preencher.Location = new System.Drawing.Point(289, 77);
            this.btn_preencher.Name = "btn_preencher";
            this.btn_preencher.Size = new System.Drawing.Size(121, 67);
            this.btn_preencher.TabIndex = 4;
            this.btn_preencher.Text = "Peencher";
            this.btn_preencher.UseVisualStyleBackColor = true;
            this.btn_preencher.Click += new System.EventHandler(this.btn_preencher_Click);
            // 
            // tb_velocidade
            // 
            this.tb_velocidade.Location = new System.Drawing.Point(488, 36);
            this.tb_velocidade.Name = "tb_velocidade";
            this.tb_velocidade.Size = new System.Drawing.Size(100, 20);
            this.tb_velocidade.TabIndex = 5;
            this.tb_velocidade.Text = "10000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(485, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // F_ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_velocidade);
            this.Controls.Add(this.btn_preencher);
            this.Controls.Add(this.tb_progresso);
            this.Controls.Add(this.btn_definirValor);
            this.Controls.Add(this.progressBar1);
            this.Name = "F_ProgressBar";
            this.Text = "F_ProgressBar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_definirValor;
        private System.Windows.Forms.TextBox tb_progresso;
        private System.Windows.Forms.Button btn_preencher;
        private System.Windows.Forms.TextBox tb_velocidade;
        private System.Windows.Forms.Label label1;
    }
}