using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_3
{
    public partial class Form1 : Form
    {
        public int state;
        public string alamatFile = "";

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
            foreach (KnownColor warna in Enum.GetValues(typeof(KnownColor)))
            {
                fontcolorlist.Items.Add(warna);
            }   
            state = 0;
            fontfamilylist.SelectedIndex = 0;
            fontsizelist.SelectedIndex = 13;
            saveFileDialog1.DefaultExt = "*.rtf";
            saveFileDialog1.Filter = "RTF Files|*.rtf";
            openFileDialog1.DefaultExt = "*.rtf";
            openFileDialog1.Filter = "RTF Files|*.rtf";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Font bold;
            if (main.SelectionFont == null)
            {
                return;
            }
            if (main.SelectionFont.Style.ToString().Contains("Bold"))
            {
                bold = new Font(main.SelectionFont.FontFamily, main.SelectionFont.Size, main.SelectionFont.Style & ~FontStyle.Bold);
                toolStripButton1.Checked=false;
            }
            else
            {
                bold = new Font(main.SelectionFont.FontFamily, main.SelectionFont.Size, main.SelectionFont.Style | FontStyle.Bold);
                toolStripButton1.Checked = true;
            }
            main.SelectionFont = bold;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Font italic;
            if (main.SelectionFont == null)
            {
                return;
            }
            if (main.SelectionFont.Style.ToString().Contains("Italic"))
            {
                italic = new Font(main.SelectionFont.FontFamily, main.SelectionFont.Size, main.SelectionFont.Style & ~FontStyle.Italic);
                toolStripButton2.Checked = false;
            }
            else
            {
                italic = new Font(main.SelectionFont.FontFamily, main.SelectionFont.Size, main.SelectionFont.Style | FontStyle.Italic);
                toolStripButton2.Checked = true;
            }
            main.SelectionFont = italic;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Font underline;
            if (main.SelectionFont == null)
            {
                return;
            }
            if (main.SelectionFont.Style.ToString().Contains("Underline"))
            {
                underline = new Font(main.SelectionFont.FontFamily, main.SelectionFont.Size, main.SelectionFont.Style & ~FontStyle.Underline);
                toolStripButton3.Checked = false;
            }
            else
            {
                underline = new Font(main.SelectionFont.FontFamily, main.SelectionFont.Size, main.SelectionFont.Style | FontStyle.Underline);
                toolStripButton3.Checked = true;
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

        private void fontsizelist_Click(object sender, EventArgs e)
        {
            if (main.SelectionFont == null)
            {
                return;
            }
            main.SelectionFont = new System.Drawing.Font(main.SelectionFont.FontFamily, Convert.ToInt32(fontsizelist.Text), main.SelectionFont.Style);
        }

        private void fontcolorlist_Click(object sender, EventArgs e)
        {
            if (main.SelectionFont == null)
            {
                return;
            }
            main.SelectionColor = Color.FromName(fontcolorlist.Text);
        }
        private void fungsiSave()
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                main.SaveFile(saveFileDialog1.FileName);
            }
        }
        private void fungsiLoad()
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFileDialog1.FileName.Length > 0)
            {
                main.LoadFile(openFileDialog1.FileName);
                alamatFile = openFileDialog1.FileName;
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (alamatFile.Length == 0)
            {
                fungsiSave();
                alamatFile = saveFileDialog1.FileName;
            }
            else
            {
                main.SaveFile(alamatFile);
            }
            state = 0;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (state == 1)
            {
                DialogResult pilihan = MessageBox.Show("Apakah anda ingin melakukan save?", "Text Editor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (pilihan == (DialogResult.Yes))
                {
                    if (alamatFile.Length == 0)
                    {
                        fungsiSave();
                    }
                    else
                    {
                        main.SaveFile(alamatFile);
                    }
                    fungsiLoad();
                    state = 0;
                }
                else if (pilihan == (DialogResult.No))
                {
                    fungsiLoad();
                    state = 0;
                }
                else
                {
                    return;
                }
            }
            else
            {
                fungsiLoad();
                state = 0;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (state == 1)
            {
                DialogResult pilihan = MessageBox.Show("Apakah anda ingin melakukan save?", "Text Editor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (pilihan == (DialogResult.Yes))
                {
                    if (alamatFile.Length == 0)
                    {
                        fungsiSave();
                        alamatFile = saveFileDialog1.FileName;
                    }
                    else
                    {
                        main.SaveFile(alamatFile);
                    }
                    state = 0;
                    main.ResetText();
                    alamatFile = "";
                }
                else if (pilihan == (DialogResult.No))
                {
                    main.ResetText();
                    state = 0;
                    alamatFile = "";
                }
                else
                {
                    return;
                }
            }
            else
            {
                main.ResetText();
                state = 0;
                alamatFile = "";
            }
        }

        private void isi_TextChanged(object sender, EventArgs e)
        {
            state = 1;
        }
    }
}

