
namespace Componentes
{
    partial class F_TabControl
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
            this.tb_novaTab = new System.Windows.Forms.TextBox();
            this.btn_tap = new System.Windows.Forms.Button();
            this.btn_removerTab = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_posicioarTab = new System.Windows.Forms.Button();
            this.cb_preto = new System.Windows.Forms.CheckBox();
            this.cb_azul = new System.Windows.Forms.CheckBox();
            this.cb_branco = new System.Windows.Forms.CheckBox();
            this.cb_cinza = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tab_componentes = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tab_componentes.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_novaTab
            // 
            this.tb_novaTab.Location = new System.Drawing.Point(43, 30);
            this.tb_novaTab.Name = "tb_novaTab";
            this.tb_novaTab.Size = new System.Drawing.Size(168, 20);
            this.tb_novaTab.TabIndex = 1;
            this.tb_novaTab.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_novaTab_KeyDown);
            // 
            // btn_tap
            // 
            this.btn_tap.Location = new System.Drawing.Point(217, 27);
            this.btn_tap.Name = "btn_tap";
            this.btn_tap.Size = new System.Drawing.Size(129, 23);
            this.btn_tap.TabIndex = 2;
            this.btn_tap.Text = "Nova Tab";
            this.btn_tap.UseVisualStyleBackColor = true;
            this.btn_tap.Click += new System.EventHandler(this.btn_tap_Click);
            this.btn_tap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_tap_KeyDown);
            // 
            // btn_removerTab
            // 
            this.btn_removerTab.Location = new System.Drawing.Point(352, 27);
            this.btn_removerTab.Name = "btn_removerTab";
            this.btn_removerTab.Size = new System.Drawing.Size(129, 23);
            this.btn_removerTab.TabIndex = 3;
            this.btn_removerTab.Text = "Remover Tab Atual";
            this.btn_removerTab.UseVisualStyleBackColor = true;
            this.btn_removerTab.Click += new System.EventHandler(this.btn_removerTab_Click_1);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(43, 59);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(168, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_posicioarTab
            // 
            this.btn_posicioarTab.Location = new System.Drawing.Point(217, 56);
            this.btn_posicioarTab.Name = "btn_posicioarTab";
            this.btn_posicioarTab.Size = new System.Drawing.Size(129, 23);
            this.btn_posicioarTab.TabIndex = 5;
            this.btn_posicioarTab.Text = "Posicionar na Tab";
            this.btn_posicioarTab.UseVisualStyleBackColor = true;
            this.btn_posicioarTab.Click += new System.EventHandler(this.btn_posicioarTab_Click_1);
            // 
            // cb_preto
            // 
            this.cb_preto.AutoSize = true;
            this.cb_preto.Location = new System.Drawing.Point(581, 31);
            this.cb_preto.Name = "cb_preto";
            this.cb_preto.Size = new System.Drawing.Size(51, 17);
            this.cb_preto.TabIndex = 6;
            this.cb_preto.Text = "Preto";
            this.cb_preto.UseVisualStyleBackColor = true;
            // 
            // cb_azul
            // 
            this.cb_azul.AutoSize = true;
            this.cb_azul.Location = new System.Drawing.Point(581, 55);
            this.cb_azul.Name = "cb_azul";
            this.cb_azul.Size = new System.Drawing.Size(46, 17);
            this.cb_azul.TabIndex = 7;
            this.cb_azul.Text = "Azul";
            this.cb_azul.UseVisualStyleBackColor = true;
            // 
            // cb_branco
            // 
            this.cb_branco.AutoSize = true;
            this.cb_branco.Location = new System.Drawing.Point(714, 31);
            this.cb_branco.Name = "cb_branco";
            this.cb_branco.Size = new System.Drawing.Size(60, 17);
            this.cb_branco.TabIndex = 8;
            this.cb_branco.Text = "Branco";
            this.cb_branco.UseVisualStyleBackColor = true;
            // 
            // cb_cinza
            // 
            this.cb_cinza.AutoSize = true;
            this.cb_cinza.Location = new System.Drawing.Point(714, 55);
            this.cb_cinza.Name = "cb_cinza";
            this.cb_cinza.Size = new System.Drawing.Size(52, 17);
            this.cb_cinza.TabIndex = 9;
            this.cb_cinza.Text = "Cinza";
            this.cb_cinza.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tab_componentes
            // 
            this.tab_componentes.BackColor = System.Drawing.Color.DimGray;
            this.tab_componentes.Controls.Add(this.button1);
            this.tab_componentes.Controls.Add(this.textBox1);
            this.tab_componentes.Controls.Add(this.label1);
            this.tab_componentes.Location = new System.Drawing.Point(4, 22);
            this.tab_componentes.Name = "tab_componentes";
            this.tab_componentes.Padding = new System.Windows.Forms.Padding(3);
            this.tab_componentes.Size = new System.Drawing.Size(768, 342);
            this.tab_componentes.TabIndex = 0;
            this.tab_componentes.Text = "Componentes";
            this.tab_componentes.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_componentes);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(43, 85);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 368);
            this.tabControl1.TabIndex = 0;
            // 
            // F_TabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 487);
            this.Controls.Add(this.cb_cinza);
            this.Controls.Add(this.cb_branco);
            this.Controls.Add(this.cb_azul);
            this.Controls.Add(this.cb_preto);
            this.Controls.Add(this.btn_posicioarTab);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_removerTab);
            this.Controls.Add(this.btn_tap);
            this.Controls.Add(this.tb_novaTab);
            this.Controls.Add(this.tabControl1);
            this.Name = "F_TabControl";
            this.Text = "F_TabControl";
            this.Load += new System.EventHandler(this.F_TabControl_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F_TabControl_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.F_TabControl_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tab_componentes.ResumeLayout(false);
            this.tab_componentes.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_novaTab;
        private System.Windows.Forms.Button btn_tap;
        private System.Windows.Forms.Button btn_removerTab;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_posicioarTab;
        private System.Windows.Forms.CheckBox cb_preto;
        private System.Windows.Forms.CheckBox cb_azul;
        private System.Windows.Forms.CheckBox cb_branco;
        private System.Windows.Forms.CheckBox cb_cinza;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tab_componentes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}