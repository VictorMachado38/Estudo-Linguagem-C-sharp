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
    public partial class F_MonthCalendar : Form
    {
        public F_MonthCalendar()
        {
            InitializeComponent();
        }

        private void F_MonthCalendar_Load(object sender, EventArgs e)
        {

        }

        private void btn_pegarData_Click(object sender, EventArgs e)
        {
            tb_date.Text = monthCalendar1.SelectionStart.ToShortDateString();

            if(monthCalendar1.SelectionStart.ToShortDateString() != monthCalendar1.SelectionEnd.ToShortDateString())
            {
                tb_dateLast.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            }
            else
                tb_dateLast.Clear();

            tb_dateNow.Text = monthCalendar1.TodayDate.ToShortDateString();


        }

        private void btn_limparData_Click(object sender, EventArgs e)
        {
            tb_date.Clear();
            tb_dateLast.Clear();
            tb_dateNow.Clear();
            monthCalendar1.Focus();

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            tb_date.Text = monthCalendar1.SelectionStart.ToShortDateString();

            if (monthCalendar1.SelectionStart.ToShortDateString() != monthCalendar1.SelectionEnd.ToShortDateString())
            {
                tb_dateLast.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            }
            else
                tb_dateLast.Clear();

            tb_dateNow.Text = monthCalendar1.TodayDate.ToShortDateString();
        }
    }
}
