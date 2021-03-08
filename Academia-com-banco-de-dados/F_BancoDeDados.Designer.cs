
namespace Academia_com_banco_de_dados
{
    partial class F_BancoDeDados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_BancoDeDados));
            this.dgv_bandoDeDados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bandoDeDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_bandoDeDados
            // 
            this.dgv_bandoDeDados.AllowUserToAddRows = false;
            this.dgv_bandoDeDados.AllowUserToDeleteRows = false;
            this.dgv_bandoDeDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bandoDeDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_bandoDeDados.Location = new System.Drawing.Point(0, 0);
            this.dgv_bandoDeDados.MultiSelect = false;
            this.dgv_bandoDeDados.Name = "dgv_bandoDeDados";
            this.dgv_bandoDeDados.ReadOnly = true;
            this.dgv_bandoDeDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_bandoDeDados.Size = new System.Drawing.Size(502, 446);
            this.dgv_bandoDeDados.TabIndex = 0;
            // 
            // F_BancoDeDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 446);
            this.Controls.Add(this.dgv_bandoDeDados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_BancoDeDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco De Dados";
            this.Load += new System.EventHandler(this.F_BancoDeDados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bandoDeDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_bandoDeDados;
    }
}