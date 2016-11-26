using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolleyBall
{
    public partial class Form1 : Form
    {
        static long far = 10000000007;
        public Form1()
        {
            InitializeComponent();
        }
        static private long kombinasi(long a, long b)
        {
            long result = 1;
            for (int i = 0; i < b; i++)
            {
                result = result * (a - i) / (i + 1);
            }
            return result % far;
        }
        static long pow(long m, long n)
        {
            if (n == 0)
                return 1;
            if (n == 1)
                return m;
            if (m == 0)
                return 0;
            long setengah = pow(m, n / 2);
            if (n % 2 == 0)
                return (setengah * setengah) % far;
            else
                return ((setengah * setengah) % far) * m;
        }
        static long compare(int x, int y)
        {
            int temp = 0;
            if (x < y)
            {
                temp = x;
                x = y;
                y = temp;
            }
            if (x >= (y + 2) && x == 25)
            {
                return kombinasi((x + y) - 1, y);
            }
            else if (x == (y + 2) && x >= 26)
            {
                return kombinasi(48, 24) * pow(2, (y - 24)) % far;
            }
            else
                return 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox3.Text = compare(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)).ToString();
        }

    }
}
