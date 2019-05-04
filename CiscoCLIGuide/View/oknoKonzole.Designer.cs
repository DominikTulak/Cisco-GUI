namespace CiscoCLIGuide.View
{
    partial class oknoKonzole
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
            this.tbVystup = new System.Windows.Forms.TextBox();
            this.tbVstup = new System.Windows.Forms.TextBox();
            this.cbDarkMode = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbVystup
            // 
            this.tbVystup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVystup.Location = new System.Drawing.Point(0, 36);
            this.tbVystup.Margin = new System.Windows.Forms.Padding(0);
            this.tbVystup.Multiline = true;
            this.tbVystup.Name = "tbVystup";
            this.tbVystup.Size = new System.Drawing.Size(800, 413);
            this.tbVystup.TabIndex = 0;
            this.tbVystup.TextChanged += new System.EventHandler(this.tbVystup_TextChanged);
            // 
            // tbVstup
            // 
            this.tbVstup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbVstup.Location = new System.Drawing.Point(0, 449);
            this.tbVstup.Name = "tbVstup";
            this.tbVstup.Size = new System.Drawing.Size(800, 20);
            this.tbVstup.TabIndex = 1;
            this.tbVstup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbVstup_KeyDown);
            // 
            // cbDarkMode
            // 
            this.cbDarkMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDarkMode.AutoSize = true;
            this.cbDarkMode.Location = new System.Drawing.Point(708, 13);
            this.cbDarkMode.Name = "cbDarkMode";
            this.cbDarkMode.Size = new System.Drawing.Size(76, 17);
            this.cbDarkMode.TabIndex = 3;
            this.cbDarkMode.Text = "DarkMode";
            this.cbDarkMode.UseVisualStyleBackColor = true;
            this.cbDarkMode.CheckedChanged += new System.EventHandler(this.cbDarkMode_CheckedChanged);
            // 
            // oknoKonzole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.cbDarkMode);
            this.Controls.Add(this.tbVstup);
            this.Controls.Add(this.tbVystup);
            this.Name = "oknoKonzole";
            this.Text = "oknoKonzole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbVystup;
        private System.Windows.Forms.TextBox tbVstup;
        private System.Windows.Forms.CheckBox cbDarkMode;
    }
}