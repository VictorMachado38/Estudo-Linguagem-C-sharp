
namespace Academia_com_banco_de_dados
{
    partial class F_Horarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Horarios));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_idHorario = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_exluirHorario = new System.Windows.Forms.Button();
            this.btn_salvarHorario = new System.Windows.Forms.Button();
            this.btn_novoHorario = new System.Windows.Forms.Button();
            this.dgv_horarios = new System.Windows.Forms.DataGridView();
            this.mtb_dscHoario = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horário";
            // 
            // tb_idHorario
            // 
            this.tb_idHorario.BackColor = System.Drawing.SystemColors.Control;
            this.tb_idHorario.Location = new System.Drawing.Point(15, 31);
            this.tb_idHorario.Name = "tb_idHorario";
            this.tb_idHorario.ReadOnly = true;
            this.tb_idHorario.Size = new System.Drawing.Size(78, 20);
            this.tb_idHorario.TabIndex = 2;
            this.tb_idHorario.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_exluirHorario);
            this.panel1.Controls.Add(this.btn_salvarHorario);
            this.panel1.Controls.Add(this.btn_novoHorario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 569);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 41);
            this.panel1.TabIndex = 4;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.Location = new System.Drawing.Point(453, 6);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(141, 30);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            // 
            // btn_exluirHorario
            // 
            this.btn_exluirHorario.Location = new System.Drawing.Point(306, 6);
            this.btn_exluirHorario.Name = "btn_exluirHorario";
            this.btn_exluirHorario.Size = new System.Drawing.Size(141, 30);
            this.btn_exluirHorario.TabIndex = 2;
            this.btn_exluirHorario.Text = "Excluir Horário";
            this.btn_exluirHorario.UseVisualStyleBackColor = true;
            // 
            // btn_salvarHorario
            // 
            this.btn_salvarHorario.Location = new System.Drawing.Point(159, 6);
            this.btn_salvarHorario.Name = "btn_salvarHorario";
            this.btn_salvarHorario.Size = new System.Drawing.Size(141, 30);
            this.btn_salvarHorario.TabIndex = 1;
            this.btn_salvarHorario.Text = "Salvar Horário";
            this.btn_salvarHorario.UseVisualStyleBackColor = true;
            // 
            // btn_novoHorario
            // 
            this.btn_novoHorario.Location = new System.Drawing.Point(12, 6);
            this.btn_novoHorario.Name = "btn_novoHorario";
            this.btn_novoHorario.Size = new System.Drawing.Size(141, 30);
            this.btn_novoHorario.TabIndex = 0;
            this.btn_novoHorario.Text = "Novo Horário";
            this.btn_novoHorario.UseVisualStyleBackColor = true;
            // 
            // dgv_horarios
            // 
            this.dgv_horarios.AllowUserToAddRows = false;
            this.dgv_horarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_horarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_horarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_horarios.EnableHeadersVisualStyles = false;
            this.dgv_horarios.Location = new System.Drawing.Point(15, 57);
            this.dgv_horarios.Name = "dgv_horarios";
            this.dgv_horarios.ReadOnly = true;
            this.dgv_horarios.RowHeadersVisible = false;
            this.dgv_horarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_horarios.Size = new System.Drawing.Size(575, 504);
            this.dgv_horarios.TabIndex = 5;
            // 
            // mtb_dscHoario
            // 
            this.mtb_dscHoario.Location = new System.Drawing.Point(113, 31);
            this.mtb_dscHoario.Mask = "99:99\\até 99:99";
            this.mtb_dscHoario.Name = "mtb_dscHoario";
            this.mtb_dscHoario.Size = new System.Drawing.Size(100, 20);
            this.mtb_dscHoario.TabIndex = 6;
            // 
            // F_Horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 610);
            this.Controls.Add(this.mtb_dscHoario);
            this.Controls.Add(this.dgv_horarios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_idHorario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Horarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horários";
            this.Load += new System.EventHandler(this.F_Horarios_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_idHorario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_exluirHorario;
        private System.Windows.Forms.Button btn_salvarHorario;
        private System.Windows.Forms.Button btn_novoHorario;
        private System.Windows.Forms.DataGridView dgv_horarios;
        private System.Windows.Forms.MaskedTextBox mtb_dscHoario;
    }
}