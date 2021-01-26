
namespace Componentes
{
    partial class F_transportes
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
            this.clb_transportes = new System.Windows.Forms.CheckedListBox();
            this.btn_mostrarSelecionados = new System.Windows.Forms.Button();
            this.btn_limparLista = new System.Windows.Forms.Button();
            this.btn_rezetarLista = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_novoTransporte = new System.Windows.Forms.TextBox();
            this.btm_addNovoTransporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clb_transportes
            // 
            this.clb_transportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_transportes.FormattingEnabled = true;
            this.clb_transportes.Items.AddRange(new object[] {
            "Carrro",
            "Avião ",
            "Navio",
            "Ônibus",
            "Trem",
            "a"});
            this.clb_transportes.Location = new System.Drawing.Point(28, 12);
            this.clb_transportes.Name = "clb_transportes";
            this.clb_transportes.Size = new System.Drawing.Size(227, 388);
            this.clb_transportes.TabIndex = 0;
            this.clb_transportes.SelectedIndexChanged += new System.EventHandler(this.clb_trasportes_SelectedIndexChanged);
            // 
            // btn_mostrarSelecionados
            // 
            this.btn_mostrarSelecionados.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_mostrarSelecionados.Location = new System.Drawing.Point(294, 21);
            this.btn_mostrarSelecionados.Name = "btn_mostrarSelecionados";
            this.btn_mostrarSelecionados.Size = new System.Drawing.Size(254, 37);
            this.btn_mostrarSelecionados.TabIndex = 1;
            this.btn_mostrarSelecionados.Text = "Mostrar Selecionado";
            this.btn_mostrarSelecionados.UseVisualStyleBackColor = true;
            this.btn_mostrarSelecionados.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_limparLista
            // 
            this.btn_limparLista.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_limparLista.Location = new System.Drawing.Point(294, 77);
            this.btn_limparLista.Name = "btn_limparLista";
            this.btn_limparLista.Size = new System.Drawing.Size(254, 37);
            this.btn_limparLista.TabIndex = 2;
            this.btn_limparLista.Text = "Limpar Lista";
            this.btn_limparLista.UseVisualStyleBackColor = true;
            this.btn_limparLista.Click += new System.EventHandler(this.btn_limparLista_Click);
            // 
            // btn_rezetarLista
            // 
            this.btn_rezetarLista.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_rezetarLista.Location = new System.Drawing.Point(294, 136);
            this.btn_rezetarLista.Name = "btn_rezetarLista";
            this.btn_rezetarLista.Size = new System.Drawing.Size(254, 37);
            this.btn_rezetarLista.TabIndex = 3;
            this.btn_rezetarLista.Text = "Rezetar a lista";
            this.btn_rezetarLista.UseVisualStyleBackColor = true;
            this.btn_rezetarLista.Click += new System.EventHandler(this.btn_rezetarLista_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite um novo transporte";
            // 
            // tb_novoTransporte
            // 
            this.tb_novoTransporte.Location = new System.Drawing.Point(294, 224);
            this.tb_novoTransporte.Name = "tb_novoTransporte";
            this.tb_novoTransporte.Size = new System.Drawing.Size(254, 20);
            this.tb_novoTransporte.TabIndex = 5;
            // 
            // btm_addNovoTransporte
            // 
            this.btm_addNovoTransporte.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.btm_addNovoTransporte.Location = new System.Drawing.Point(294, 250);
            this.btm_addNovoTransporte.Name = "btm_addNovoTransporte";
            this.btm_addNovoTransporte.Size = new System.Drawing.Size(254, 37);
            this.btm_addNovoTransporte.TabIndex = 6;
            this.btm_addNovoTransporte.Text = "Adicionar um Novo Trasnporte";
            this.btm_addNovoTransporte.UseVisualStyleBackColor = true;
            this.btm_addNovoTransporte.Click += new System.EventHandler(this.btm_addNovoTransporte_Click);
            // 
            // F_transportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 432);
            this.Controls.Add(this.btm_addNovoTransporte);
            this.Controls.Add(this.tb_novoTransporte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_rezetarLista);
            this.Controls.Add(this.btn_limparLista);
            this.Controls.Add(this.btn_mostrarSelecionados);
            this.Controls.Add(this.clb_transportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_transportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.F_transportes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_transportes;
        private System.Windows.Forms.Button btn_mostrarSelecionados;
        private System.Windows.Forms.Button btn_limparLista;
        private System.Windows.Forms.Button btn_rezetarLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_novoTransporte;
        private System.Windows.Forms.Button btm_addNovoTransporte;
    }
}