namespace CiscoCLIGuide.View
{
    partial class hlavniOkno
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.komunikaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.menuButtonNastaveniRS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuButtonNastaveniLog = new System.Windows.Forms.ToolStripMenuItem();
            this.menuButtonNastaveniPlaintext = new System.Windows.Forms.ToolStripMenuItem();
            this.menuButtonNastaveniHesel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.souborToolStripMenuItem,
            this.komunikaceToolStripMenuItem,
            this.menuButtonNastaveniHesel});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(572, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // souborToolStripMenuItem
            // 
            this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            this.souborToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.souborToolStripMenuItem.Text = "Soubor";
            // 
            // komunikaceToolStripMenuItem
            // 
            this.komunikaceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.menuButtonNastaveniRS,
            this.menuButtonNastaveniLog,
            this.menuButtonNastaveniPlaintext});
            this.komunikaceToolStripMenuItem.Name = "komunikaceToolStripMenuItem";
            this.komunikaceToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.komunikaceToolStripMenuItem.Text = "Komunikace";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Konzole (RS-232)",
            "Telnet",
            "Plaintext",
            "Soubor"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.Text = "Plaintext";
            // 
            // menuButtonNastaveniRS
            // 
            this.menuButtonNastaveniRS.Name = "menuButtonNastaveniRS";
            this.menuButtonNastaveniRS.Size = new System.Drawing.Size(196, 22);
            this.menuButtonNastaveniRS.Text = "Nastavení RS-232";
            this.menuButtonNastaveniRS.Click += new System.EventHandler(this.menuButtonNastaveniRS_Click);
            // 
            // menuButtonNastaveniLog
            // 
            this.menuButtonNastaveniLog.Name = "menuButtonNastaveniLog";
            this.menuButtonNastaveniLog.Size = new System.Drawing.Size(196, 22);
            this.menuButtonNastaveniLog.Text = "Nastavení log. souboru";
            this.menuButtonNastaveniLog.Click += new System.EventHandler(this.menuButtonNastaveniLog_Click);
            // 
            // menuButtonNastaveniPlaintext
            // 
            this.menuButtonNastaveniPlaintext.Name = "menuButtonNastaveniPlaintext";
            this.menuButtonNastaveniPlaintext.Size = new System.Drawing.Size(196, 22);
            this.menuButtonNastaveniPlaintext.Text = "Nastavení plaintextu";
            this.menuButtonNastaveniPlaintext.Click += new System.EventHandler(this.menuButtonNastaveniPlaintext_Click);
            // 
            // menuButtonNastaveniHesel
            // 
            this.menuButtonNastaveniHesel.Name = "menuButtonNastaveniHesel";
            this.menuButtonNastaveniHesel.Size = new System.Drawing.Size(48, 20);
            this.menuButtonNastaveniHesel.Text = "Hesla";
            this.menuButtonNastaveniHesel.Click += new System.EventHandler(this.menuButtonNastaveniHesel_Click);
            // 
            // hlavniOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 485);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "hlavniOkno";
            this.Text = "Cisco CLI Guide";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem souborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem komunikaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem menuButtonNastaveniRS;
        private System.Windows.Forms.ToolStripMenuItem menuButtonNastaveniLog;
        private System.Windows.Forms.ToolStripMenuItem menuButtonNastaveniPlaintext;
        private System.Windows.Forms.ToolStripMenuItem menuButtonNastaveniHesel;
    }
}