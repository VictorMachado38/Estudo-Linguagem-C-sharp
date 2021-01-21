
namespace Componentes
{
    partial class F_filhoCheckBox
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
            this.cb_onibus = new System.Windows.Forms.CheckBox();
            this.cb_navio = new System.Windows.Forms.CheckBox();
            this.cb_avião = new System.Windows.Forms.CheckBox();
            this.cb_carro = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cb_onibus
            // 
            this.cb_onibus.AutoSize = true;
            this.cb_onibus.Location = new System.Drawing.Point(22, 100);
            this.cb_onibus.Name = "cb_onibus";
            this.cb_onibus.Size = new System.Drawing.Size(59, 17);
            this.cb_onibus.TabIndex = 7;
            this.cb_onibus.Text = "Ônibus";
            this.cb_onibus.UseVisualStyleBackColor = true;
            this.cb_onibus.CheckedChanged += new System.EventHandler(this.cb_onibus_CheckedChanged);
            // 
            // cb_navio
            // 
            this.cb_navio.AutoSize = true;
            this.cb_navio.Location = new System.Drawing.Point(22, 77);
            this.cb_navio.Name = "cb_navio";
            this.cb_navio.Size = new System.Drawing.Size(54, 17);
            this.cb_navio.TabIndex = 6;
            this.cb_navio.Text = "Navio";
            this.cb_navio.UseVisualStyleBackColor = true;
            this.cb_navio.CheckedChanged += new System.EventHandler(this.cb_navio_CheckedChanged);
            // 
            // cb_avião
            // 
            this.cb_avião.AutoSize = true;
            this.cb_avião.Location = new System.Drawing.Point(23, 54);
            this.cb_avião.Name = "cb_avião";
            this.cb_avião.Size = new System.Drawing.Size(53, 17);
            this.cb_avião.TabIndex = 5;
            this.cb_avião.Text = "Avião";
            this.cb_avião.UseVisualStyleBackColor = true;
            this.cb_avião.CheckedChanged += new System.EventHandler(this.cb_avião_CheckedChanged);
            // 
            // cb_carro
            // 
            this.cb_carro.AutoSize = true;
            this.cb_carro.Location = new System.Drawing.Point(23, 31);
            this.cb_carro.Name = "cb_carro";
            this.cb_carro.Size = new System.Drawing.Size(51, 17);
            this.cb_carro.TabIndex = 4;
            this.cb_carro.Text = "Carro";
            this.cb_carro.UseVisualStyleBackColor = true;
            this.cb_carro.CheckedChanged += new System.EventHandler(this.cb_carro_CheckedChanged);
            // 
            // F_filhoCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 291);
            this.Controls.Add(this.cb_onibus);
            this.Controls.Add(this.cb_navio);
            this.Controls.Add(this.cb_avião);
            this.Controls.Add(this.cb_carro);
            this.Name = "F_filhoCheckBox";
            this.Text = "Filho Check Box";
            this.Load += new System.EventHandler(this.F_filhoCheckBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_onibus;
        private System.Windows.Forms.CheckBox cb_navio;
        private System.Windows.Forms.CheckBox cb_avião;
        private System.Windows.Forms.CheckBox cb_carro;
    }
}