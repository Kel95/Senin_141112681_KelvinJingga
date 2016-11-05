using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_4
{
    public partial class Form1 : Form
    {
        public int state;
        public Form1()
        {
            InitializeComponent();
            foreach (FontFamily font in FontFamily.Families.ToArray())
            {
                fontfamilylist.Items.Add(font.Name);
            }
            for (int i = 1; i <= 100; i++)
            {
                fontsizelist.Items.Add(i);
            }
            state = 0;
            fontfamilylist.SelectedIndex = 0;
            fontsizelist.SelectedIndex = 13;   
        }

        private void fontsizelist_Click(object sender, EventArgs e)
        {
            if (main.SelectionFont == null)
            {
                return;
            }
            main.SelectionFont = new System.Drawing.Font(fontfamilylist.Text, main.SelectionFont.Size, main.SelectionFont.Style);
        }

        private void BOLD_Click(object sender, EventArgs e)
        {
            Font bold;
            if (main.SelectionFont == null)
            {
                return;
            }
            if (main.SelectionFont.Style.ToString().Contains("Bold"))
            {
                bold = new Font(main.SelectionFont.FontFamily, main.SelectionFont.Size, main.SelectionFont.Style & ~FontStyle.Bold);
                BOLD.Checked = false;
            }
            else
            {
                bold = new Font(main.SelectionFont.FontFamily, main.SelectionFont.Size, main.SelectionFont.Style | FontStyle.Bold);
                BOLD.Checked = true;
            }
            main.SelectionFont = bold;
        }

        private void Italic_Click(object sender, EventArgs e)
        {
            Font italic;
            if (main.SelectionFont == null)
            {
                return;
            }
            if (main.SelectionFont.Style.ToString().Contains("Italic"))
            {
                italic = new Font(main.SelectionFont.FontFamily, main.SelectionFont.Size, main.SelectionFont.Style & ~FontStyle.Italic);
                Italic.Checked = false;
            }
            else
            {
                italic = new Font(main.SelectionFont.FontFamily, main.SelectionFont.Size, main.SelectionFont.Style | FontStyle.Italic);
                Italic.Checked = true;
            }
            main.SelectionFont = italic;
        }
        private void Underline_Click(object sender, EventArgs e)
        {
            Font underline;
            if (main.SelectionFont == null)
            {
                return;
            }
            if (main.SelectionFont.Style.ToString().Contains("Underline"))
            {
                underline = new Font(main.SelectionFont.FontFamily, main.SelectionFont.Size, main.SelectionFont.Style & ~FontStyle.Underline);
                Underline.Checked = false;
            }
            else
            {
                underline = new Font(main.SelectionFont.FontFamily, main.SelectionFont.Size, main.SelectionFont.Style | FontStyle.Underline);
                Underline.Checked = true;
            }
            main.SelectionFont = underline;
        }

        private void fontfamilylist_Click(object sender, EventArgs e)
        {
            if (main.SelectionFont == null)
            {
                return;
            }
            main.SelectionFont = new System.Drawing.Font(fontfamilylist.Text, main.SelectionFont.Size, main.SelectionFont.Style);
        }

        private void A_Click(object sender, EventArgs e)
        {
            if (main.SelectionFont == null)
            {
                return;
            }
            main.SelectionColor = Color.FromName(A.Text);
        }
        private void isi_TextChanged(object sender, EventArgs e)
        {
            state = 1;
        }
        
    }
        
}
