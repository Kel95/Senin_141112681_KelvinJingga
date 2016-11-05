using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 
    
        public int Range;
        DateTime min, max, now;
        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            now = DateTime.Now;
            label2.Text = hScrollBar2.Value.ToString();
            Range = hScrollBar1.Value + hScrollBar2.Value;
            label3.Text = "Range : "+Range;
            min = new DateTime(now.Year - Range,now.Month,now.Day);
            max = new DateTime(now.Year + Range, now.Month, now.Day); 
            dateTimePicker1.MinDate = min;
            dateTimePicker1.MaxDate = max;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
            
        {
            now = DateTime.Now;
            label1.Text = hScrollBar1.Value.ToString();
            Range = hScrollBar1.Value + hScrollBar2.Value;
            label3.Text = "Range : "+ Range;
            min = new DateTime(now.Year - Range, now.Month, now.Day);
            max = new DateTime(now.Year + Range, now.Month, now.Day);
            dateTimePicker1.MinDate = min;
            dateTimePicker1.MaxDate = max;
            
        }       
    }
}
