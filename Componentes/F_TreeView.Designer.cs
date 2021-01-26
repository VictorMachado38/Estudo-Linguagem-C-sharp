
namespace Componentes
{
    partial class F_TreeView
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
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("HRV");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("FIT");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Honda", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("GOLF");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Polo");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Volksvagem", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("ONIX");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("GM", new System.Windows.Forms.TreeNode[] {
            treeNode15});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btn_add = new System.Windows.Forms.Button();
            this.tb_treeview = new System.Windows.Forms.TextBox();
            this.tb_tag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_removerSelecionado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(23, 12);
            this.treeView1.Name = "treeView1";
            treeNode9.Name = "hrv";
            treeNode9.Tag = "Um carro mt bom!";
            treeNode9.Text = "HRV";
            treeNode10.Name = "fit";
            treeNode10.Text = "FIT";
            treeNode11.Name = "honda";
            treeNode11.Text = "Honda";
            treeNode12.Name = "golf";
            treeNode12.Text = "GOLF";
            treeNode13.Name = "polo";
            treeNode13.Text = "Polo";
            treeNode14.Name = "volksvagem";
            treeNode14.Text = "Volksvagem";
            treeNode15.Name = "onix";
            treeNode15.Text = "ONIX";
            treeNode16.Name = "gm";
            treeNode16.Text = "GM";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode14,
            treeNode16});
            this.treeView1.Size = new System.Drawing.Size(219, 347);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(248, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(150, 30);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tb_treeview
            // 
            this.tb_treeview.Location = new System.Drawing.Point(248, 105);
            this.tb_treeview.Name = "tb_treeview";
            this.tb_treeview.Size = new System.Drawing.Size(150, 20);
            this.tb_treeview.TabIndex = 3;
            // 
            // tb_tag
            // 
            this.tb_tag.Location = new System.Drawing.Point(248, 158);
            this.tb_tag.Name = "tb_tag";
            this.tb_tag.Size = new System.Drawing.Size(150, 20);
            this.tb_tag.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tag";
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(248, 48);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(150, 30);
            this.btn_remover.TabIndex = 2;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_removerSelecionado
            // 
            this.btn_removerSelecionado.Location = new System.Drawing.Point(426, 12);
            this.btn_removerSelecionado.Name = "btn_removerSelecionado";
            this.btn_removerSelecionado.Size = new System.Drawing.Size(150, 30);
            this.btn_removerSelecionado.TabIndex = 7;
            this.btn_removerSelecionado.Text = "Remover Selecionado";
            this.btn_removerSelecionado.UseVisualStyleBackColor = true;
            this.btn_removerSelecionado.Click += new System.EventHandler(this.btn_removerSelecionado_Click);
            // 
            // F_TreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_removerSelecionado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_tag);
            this.Controls.Add(this.tb_treeview);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.treeView1);
            this.Name = "F_TreeView";
            this.Text = "F_TreeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_treeview;
        private System.Windows.Forms.TextBox tb_tag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_removerSelecionado;
    }
}