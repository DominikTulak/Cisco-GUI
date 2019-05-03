namespace CiscoCLIGuide.View
{
    partial class oknoNastaveniHesla
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
            this.checkBoxKonzole = new System.Windows.Forms.CheckBox();
            this.checkBoxEXEC = new System.Windows.Forms.CheckBox();
            this.checkBoxTelnet = new System.Windows.Forms.CheckBox();
            this.textBoxKonzole = new System.Windows.Forms.TextBox();
            this.textBoxEXEC = new System.Windows.Forms.TextBox();
            this.textBoxTelnet = new System.Windows.Forms.TextBox();
            this.buttonUlozit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxKonzole
            // 
            this.checkBoxKonzole.AutoSize = true;
            this.checkBoxKonzole.Location = new System.Drawing.Point(27, 32);
            this.checkBoxKonzole.Name = "checkBoxKonzole";
            this.checkBoxKonzole.Size = new System.Drawing.Size(64, 17);
            this.checkBoxKonzole.TabIndex = 0;
            this.checkBoxKonzole.Text = "Konzole";
            this.checkBoxKonzole.UseVisualStyleBackColor = true;
            this.checkBoxKonzole.CheckedChanged += new System.EventHandler(this.checkBoxKonzole_CheckedChanged);
            // 
            // checkBoxEXEC
            // 
            this.checkBoxEXEC.AutoSize = true;
            this.checkBoxEXEC.Location = new System.Drawing.Point(27, 75);
            this.checkBoxEXEC.Name = "checkBoxEXEC";
            this.checkBoxEXEC.Size = new System.Drawing.Size(116, 17);
            this.checkBoxEXEC.TabIndex = 1;
            this.checkBoxEXEC.Text = "Privilegovaný režim";
            this.checkBoxEXEC.UseVisualStyleBackColor = true;
            this.checkBoxEXEC.CheckedChanged += new System.EventHandler(this.checkBoxKonzole_CheckedChanged);
            // 
            // checkBoxTelnet
            // 
            this.checkBoxTelnet.AutoSize = true;
            this.checkBoxTelnet.Location = new System.Drawing.Point(27, 120);
            this.checkBoxTelnet.Name = "checkBoxTelnet";
            this.checkBoxTelnet.Size = new System.Drawing.Size(56, 17);
            this.checkBoxTelnet.TabIndex = 2;
            this.checkBoxTelnet.Text = "Telnet";
            this.checkBoxTelnet.UseVisualStyleBackColor = true;
            this.checkBoxTelnet.CheckedChanged += new System.EventHandler(this.checkBoxKonzole_CheckedChanged);
            // 
            // textBoxKonzole
            // 
            this.textBoxKonzole.Enabled = false;
            this.textBoxKonzole.Location = new System.Drawing.Point(168, 30);
            this.textBoxKonzole.Name = "textBoxKonzole";
            this.textBoxKonzole.Size = new System.Drawing.Size(100, 20);
            this.textBoxKonzole.TabIndex = 3;
            this.textBoxKonzole.UseSystemPasswordChar = true;
            // 
            // textBoxEXEC
            // 
            this.textBoxEXEC.Enabled = false;
            this.textBoxEXEC.Location = new System.Drawing.Point(168, 75);
            this.textBoxEXEC.Name = "textBoxEXEC";
            this.textBoxEXEC.Size = new System.Drawing.Size(100, 20);
            this.textBoxEXEC.TabIndex = 4;
            this.textBoxEXEC.UseSystemPasswordChar = true;
            // 
            // textBoxTelnet
            // 
            this.textBoxTelnet.Enabled = false;
            this.textBoxTelnet.Location = new System.Drawing.Point(168, 118);
            this.textBoxTelnet.Name = "textBoxTelnet";
            this.textBoxTelnet.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelnet.TabIndex = 5;
            this.textBoxTelnet.UseSystemPasswordChar = true;
            // 
            // buttonUlozit
            // 
            this.buttonUlozit.Location = new System.Drawing.Point(109, 171);
            this.buttonUlozit.Name = "buttonUlozit";
            this.buttonUlozit.Size = new System.Drawing.Size(75, 23);
            this.buttonUlozit.TabIndex = 6;
            this.buttonUlozit.Text = "Uložit hesla";
            this.buttonUlozit.UseVisualStyleBackColor = true;
            this.buttonUlozit.Click += new System.EventHandler(this.buttonUlozit_Click);
            // 
            // oknoNastaveniHesla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 233);
            this.Controls.Add(this.buttonUlozit);
            this.Controls.Add(this.textBoxTelnet);
            this.Controls.Add(this.textBoxEXEC);
            this.Controls.Add(this.textBoxKonzole);
            this.Controls.Add(this.checkBoxTelnet);
            this.Controls.Add(this.checkBoxEXEC);
            this.Controls.Add(this.checkBoxKonzole);
            this.Name = "oknoNastaveniHesla";
            this.Text = "Nastavení hesel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxKonzole;
        private System.Windows.Forms.CheckBox checkBoxEXEC;
        private System.Windows.Forms.CheckBox checkBoxTelnet;
        private System.Windows.Forms.TextBox textBoxKonzole;
        private System.Windows.Forms.TextBox textBoxEXEC;
        private System.Windows.Forms.TextBox textBoxTelnet;
        private System.Windows.Forms.Button buttonUlozit;
    }
}