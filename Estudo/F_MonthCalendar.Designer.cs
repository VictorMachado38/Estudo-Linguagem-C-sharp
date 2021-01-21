
namespace Componentes
{
    partial class F_MonthCalendar
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btn_pegarData = new System.Windows.Forms.Button();
            this.tb_date = new System.Windows.Forms.TextBox();
            this.tb_dateLast = new System.Windows.Forms.TextBox();
            this.btn_limparData = new System.Windows.Forms.Button();
            this.tb_dateNow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar1.MaxSelectionCount = 30;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowWeekNumbers = true;
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // btn_pegarData
            // 
            this.btn_pegarData.Location = new System.Drawing.Point(279, 18);
            this.btn_pegarData.Name = "btn_pegarData";
            this.btn_pegarData.Size = new System.Drawing.Size(208, 31);
            this.btn_pegarData.TabIndex = 1;
            this.btn_pegarData.Text = "Pegar data";
            this.btn_pegarData.UseVisualStyleBackColor = true;
            this.btn_pegarData.Click += new System.EventHandler(this.btn_pegarData_Click);
            // 
            // tb_date
            // 
            this.tb_date.Location = new System.Drawing.Point(279, 55);
            this.tb_date.Name = "tb_date";
            this.tb_date.Size = new System.Drawing.Size(208, 20);
            this.tb_date.TabIndex = 2;
            // 
            // tb_dateLast
            // 
            this.tb_dateLast.Location = new System.Drawing.Point(279, 81);
            this.tb_dateLast.Name = "tb_dateLast";
            this.tb_dateLast.Size = new System.Drawing.Size(208, 20);
            this.tb_dateLast.TabIndex = 3;
            // 
            // btn_limparData
            // 
            this.btn_limparData.Location = new System.Drawing.Point(41, 192);
            this.btn_limparData.Name = "btn_limparData";
            this.btn_limparData.Size = new System.Drawing.Size(208, 31);
            this.btn_limparData.TabIndex = 4;
            this.btn_limparData.Text = "Limpar datas";
            this.btn_limparData.UseVisualStyleBackColor = true;
            this.btn_limparData.Click += new System.EventHandler(this.btn_limparData_Click);
            // 
            // tb_dateNow
            // 
            this.tb_dateNow.Location = new System.Drawing.Point(279, 151);
            this.tb_dateNow.Name = "tb_dateNow";
            this.tb_dateNow.Size = new System.Drawing.Size(208, 20);
            this.tb_dateNow.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data de hoje";
            // 
            // F_MonthCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_dateNow);
            this.Controls.Add(this.btn_limparData);
            this.Controls.Add(this.tb_dateLast);
            this.Controls.Add(this.tb_date);
            this.Controls.Add(this.btn_pegarData);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "F_MonthCalendar";
            this.Text = "F_MonthCalendar";
            this.Load += new System.EventHandler(this.F_MonthCalendar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btn_pegarData;
        private System.Windows.Forms.TextBox tb_date;
        private System.Windows.Forms.TextBox tb_dateLast;
        private System.Windows.Forms.Button btn_limparData;
        private System.Windows.Forms.TextBox tb_dateNow;
        private System.Windows.Forms.Label label1;
    }
}