using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DateTime awal = new DateTime(2016, 1, 1);
            DateTime akhir = new DateTime(2016, 1, 31);
            while (awal <= akhir)
            {
                if (awal.DayOfWeek == DayOfWeek.Saturday || awal.DayOfWeek == DayOfWeek.Sunday)
                {
                    monthCalendar1.AddBoldedDate(awal);
                }
                awal = awal.AddDays(1);
            }
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = 1;
        }
        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            if (domainUpDown1.SelectedIndex == 0 || domainUpDown1.SelectedIndex == 2 || domainUpDown1.SelectedIndex == 4 || domainUpDown1.SelectedIndex == 6 || domainUpDown1.SelectedIndex == 7 || domainUpDown1.SelectedIndex == 9 || domainUpDown1.SelectedIndex == 11)
            {
                numericUpDown1.Maximum = 31;
            }
            else if (domainUpDown1.SelectedIndex == 3 || domainUpDown1.SelectedIndex == 5 || domainUpDown1.SelectedIndex == 8 || domainUpDown1.SelectedIndex == 10)
            {
                numericUpDown1.Maximum = 30;
            }
            else
                numericUpDown1.Maximum = 29;
        }
        private void monthCalender1_DateChanged(object sender, DataRowChangeEventArgs e)
        {
            DateTime ultah = new DateTime(2016, 9, 2);
            monthCalendar1.AddAnnuallyBoldedDate(ultah);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            monthCalendar1.AddAnnuallyBoldedDate(new DateTime(2016, domainUpDown1.SelectedIndex + 1, (int)numericUpDown1.Value));
            monthCalendar1.UpdateBoldedDates();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            monthCalendar1.RemoveAnnuallyBoldedDate(new DateTime(2016, domainUpDown1.SelectedIndex + 1, (int)numericUpDown1.Value));
            monthCalendar1.UpdateBoldedDates();
        }
    }
}