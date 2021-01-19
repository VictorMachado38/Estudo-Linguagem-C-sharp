using System;
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
    public partial class F_LinkLabel : Form
    {
        public F_LinkLabel()
        {
            InitializeComponent();
            ll_multiplosLinks.Links.Add(0,6,"www.google.com.br");
            ll_multiplosLinks.Links.Add(10, 6, "www.youtube.com.br");
            ll_multiplosLinks.Links.Add(20, 6, "www.facebook.com.br");

            ll_multiplosLinks.LinkColor = Color.Green;
            ll_multiplosLinks.DisabledLinkColor = Color.Red;
            ll_multiplosLinks.Links[1].Enabled =  false;
        }

        private void ll_google_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/results?search_query=" + tb_nome.Text);

            LinkLabel ll = (LinkLabel)sender;
            ll.LinkVisited = false;
         
        }

        private void ll_calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
            LinkLabel ll = (LinkLabel)sender;
            ll.LinkVisited = false;
        }

        private void ll_multiplosLinks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}
