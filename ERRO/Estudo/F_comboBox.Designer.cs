
namespace Componentes
{
    partial class F_comboBox
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
            this.btn_mostrarSelecionado = new System.Windows.Forms.Button();
            this.btn_limparElementos = new System.Windows.Forms.Button();
            this.cb_transportes = new System.Windows.Forms.ComboBox();
            this.btn_rezetarElementos = new System.Windows.Forms.Button();
            this.btn_addNovoTransporte = new System.Windows.Forms.Button();
            this.tb_novoTransporte = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_mostrarSelecionado
            // 
            this.btn_mostrarSelecionado.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_mostrarSelecionado.Location = new System.Drawing.Point(273, 29);
            this.btn_mostrarSelecionado.Name = "btn_mostrarSelecionado";
            this.btn_mostrarSelecionado.Size = new System.Drawing.Size(254, 37);
            this.btn_mostrarSelecionado.TabIndex = 0;
            this.btn_mostrarSelecionado.Text = "Mostrar Selecionado";
            this.btn_mostrarSelecionado.UseVisualStyleBackColor = true;
            this.btn_mostrarSelecionado.Click += new System.EventHandler(this.btn_mostrarSelecionado_Click);
            // 
            // btn_limparElementos
            // 
            this.btn_limparElementos.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_limparElementos.Location = new System.Drawing.Point(273, 84);
            this.btn_limparElementos.Name = "btn_limparElementos";
            this.btn_limparElementos.Size = new System.Drawing.Size(254, 37);
            this.btn_limparElementos.TabIndex = 0;
            this.btn_limparElementos.Text = "Limpar Elementos";
            this.btn_limparElementos.UseVisualStyleBackColor = true;
            this.btn_limparElementos.Click += new System.EventHandler(this.btn_limparElementos_Click);
            // 
            // cb_transportes
            // 
            this.cb_transportes.FormattingEnabled = true;
            this.cb_transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ônibus",
            "Trem"});
            this.cb_transportes.Location = new System.Drawing.Point(22, 36);
            this.cb_transportes.Name = "cb_transportes";
            this.cb_transportes.Size = new System.Drawing.Size(225, 21);
            this.cb_transportes.TabIndex = 1;
            this.cb_transportes.SelectedIndexChanged += new System.EventHandler(this.cb_transportes_SelectedIndexChanged);
            // 
            // btn_rezetarElementos
            // 
            this.btn_rezetarElementos.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_rezetarElementos.Location = new System.Drawing.Point(273, 153);
            this.btn_rezetarElementos.Name = "btn_rezetarElementos";
            this.btn_rezetarElementos.Size = new System.Drawing.Size(254, 37);
            this.btn_rezetarElementos.TabIndex = 2;
            this.btn_rezetarElementos.Text = "Rezetar Elementos";
            this.btn_rezetarElementos.UseVisualStyleBackColor = true;
            this.btn_rezetarElementos.Click += new System.EventHandler(this.btn_rezetarElementos_Click);
            // 
            // btn_addNovoTransporte
            // 
            this.btn_addNovoTransporte.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_addNovoTransporte.Location = new System.Drawing.Point(273, 253);
            this.btn_addNovoTransporte.Name = "btn_addNovoTransporte";
            this.btn_addNovoTransporte.Size = new System.Drawing.Size(254, 37);
            this.btn_addNovoTransporte.TabIndex = 3;
            this.btn_addNovoTransporte.Text = "Adicionar Novo Transporte";
            this.btn_addNovoTransporte.UseVisualStyleBackColor = true;
            this.btn_addNovoTransporte.Click += new System.EventHandler(this.button4_Click);
            // 
            // tb_novoTransporte
            // 
            this.tb_novoTransporte.Location = new System.Drawing.Point(273, 214);
            this.tb_novoTransporte.Name = "tb_novoTransporte";
            this.tb_novoTransporte.Size = new System.Drawing.Size(254, 20);
            this.tb_novoTransporte.TabIndex = 4;
            // 
            // F_comboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 313);
            this.Controls.Add(this.tb_novoTransporte);
            this.Controls.Add(this.btn_addNovoTransporte);
            this.Controls.Add(this.btn_rezetarElementos);
            this.Controls.Add(this.cb_transportes);
            this.Controls.Add(this.btn_limparElementos);
            this.Controls.Add(this.btn_mostrarSelecionado);
            this.Name = "F_comboBox";
            this.Text = "F_comboBox";
            this.Load += new System.EventHandler(this.F_comboBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mostrarSelecionado;
        private System.Windows.Forms.Button btn_limparElementos;
        private System.Windows.Forms.ComboBox cb_transportes;
        private System.Windows.Forms.Button btn_rezetarElementos;
        private System.Windows.Forms.Button btn_addNovoTransporte;
        private System.Windows.Forms.TextBox tb_novoTransporte;
    }
}