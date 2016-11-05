namespace Latihan_4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.main = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fontsizelist = new System.Windows.Forms.ToolStripComboBox();
            this.BOLD = new System.Windows.Forms.ToolStripButton();
            this.Italic = new System.Windows.Forms.ToolStripButton();
            this.Underline = new System.Windows.Forms.ToolStripButton();
            this.fontfamilylist = new System.Windows.Forms.ToolStripComboBox();
            this.A = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // main
            // 
            this.main.Location = new System.Drawing.Point(12, 33);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(485, 388);
            this.main.TabIndex = 5;
            this.main.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontsizelist,
            this.BOLD,
            this.Italic,
            this.Underline,
            this.fontfamilylist,
            this.A});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(501, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // fontsizelist
            // 
            this.fontsizelist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontsizelist.Name = "fontsizelist";
            this.fontsizelist.Size = new System.Drawing.Size(121, 25);
            this.fontsizelist.Click += new System.EventHandler(this.fontsizelist_Click);
            // 
            // BOLD
            // 
            this.BOLD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BOLD.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOLD.Image = ((System.Drawing.Image)(resources.GetObject("BOLD.Image")));
            this.BOLD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BOLD.Name = "BOLD";
            this.BOLD.Size = new System.Drawing.Size(23, 22);
            this.BOLD.Text = "B";
            this.BOLD.Click += new System.EventHandler(this.BOLD_Click);
            // 
            // Italic
            // 
            this.Italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Italic.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Italic.Image = ((System.Drawing.Image)(resources.GetObject("Italic.Image")));
            this.Italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Italic.Name = "Italic";
            this.Italic.Size = new System.Drawing.Size(23, 22);
            this.Italic.Text = "I";
            this.Italic.Click += new System.EventHandler(this.Italic_Click);
            // 
            // Underline
            // 
            this.Underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Underline.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Underline.Image = ((System.Drawing.Image)(resources.GetObject("Underline.Image")));
            this.Underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Underline.Name = "Underline";
            this.Underline.Size = new System.Drawing.Size(23, 22);
            this.Underline.Text = "U";
            this.Underline.Click += new System.EventHandler(this.Underline_Click);
            // 
            // fontfamilylist
            // 
            this.fontfamilylist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontfamilylist.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontfamilylist.Name = "fontfamilylist";
            this.fontfamilylist.Size = new System.Drawing.Size(121, 25);
            this.fontfamilylist.Click += new System.EventHandler(this.fontfamilylist_Click);
            // 
            // A
            // 
            this.A.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.A.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A.Image = ((System.Drawing.Image)(resources.GetObject("A.Image")));
            this.A.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(23, 22);
            this.A.Text = "A";
            this.A.Click += new System.EventHandler(this.A_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 422);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.main);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox main;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox fontsizelist;
        private System.Windows.Forms.ToolStripButton BOLD;
        private System.Windows.Forms.ToolStripButton Italic;
        private System.Windows.Forms.ToolStripButton Underline;
        private System.Windows.Forms.ToolStripComboBox fontfamilylist;
        private System.Windows.Forms.ToolStripButton A;

    }
}

