﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_ToolStripContainer : Form
    {
        public F_ToolStripContainer()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void F_ToolStripContainer_Load(object sender, EventArgs e)
        {
            List<ToolStrip> bf = new List<ToolStrip>();
            int num = toolStripContainer1.TopToolStripPanel.Controls.Count;
            //string a = ;
            MessageBox.Show(num.ToString());
          //////  Console.WriteLine(num.ToString());
            for(int i = 0; i < num; i++)
            {
                checkedListBox1.Items.Add(toolStripContainer1.TopToolStripPanel.Controls[i].Name);
                // toolStripContainer1.TopToolStripPanel.Controls[i].Visible = false;
                checkedListBox1.SetItemChecked(i, false);
                if (checkedListBox1.GetItemChecked(i) == true)
                {
                    toolStripContainer1.TopToolStripPanel.Controls[i].Visible = false;
                }
            }
           

        }
    }
}
