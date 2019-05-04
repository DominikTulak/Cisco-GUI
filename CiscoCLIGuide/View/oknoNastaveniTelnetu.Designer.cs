namespace CiscoCLIGuide.View
{
    partial class oknoNastaveniTelnetu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIPAdresa = new System.Windows.Forms.TextBox();
            this.ciselnikPort = new System.Windows.Forms.NumericUpDown();
            this.buttonUlozit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ciselnikPort)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP adresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // textBoxIPAdresa
            // 
            this.textBoxIPAdresa.Location = new System.Drawing.Point(85, 26);
            this.textBoxIPAdresa.Name = "textBoxIPAdresa";
            this.textBoxIPAdresa.Size = new System.Drawing.Size(100, 20);
            this.textBoxIPAdresa.TabIndex = 2;
            // 
            // ciselnikPort
            // 
            this.ciselnikPort.Location = new System.Drawing.Point(85, 60);
            this.ciselnikPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.ciselnikPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ciselnikPort.Name = "ciselnikPort";
            this.ciselnikPort.Size = new System.Drawing.Size(51, 20);
            this.ciselnikPort.TabIndex = 3;
            this.ciselnikPort.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            // 
            // buttonUlozit
            // 
            this.buttonUlozit.Location = new System.Drawing.Point(85, 101);
            this.buttonUlozit.Name = "buttonUlozit";
            this.buttonUlozit.Size = new System.Drawing.Size(75, 23);
            this.buttonUlozit.TabIndex = 4;
            this.buttonUlozit.Text = "Uložit";
            this.buttonUlozit.UseVisualStyleBackColor = true;
            this.buttonUlozit.Click += new System.EventHandler(this.buttonUlozit_Click);
            // 
            // oknoNastaveniTelnetu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 150);
            this.Controls.Add(this.buttonUlozit);
            this.Controls.Add(this.ciselnikPort);
            this.Controls.Add(this.textBoxIPAdresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "oknoNastaveniTelnetu";
            this.Text = "Nastavení telnetu";
            this.Load += new System.EventHandler(this.oknoNastaveniTelnetu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ciselnikPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIPAdresa;
        private System.Windows.Forms.NumericUpDown ciselnikPort;
        private System.Windows.Forms.Button buttonUlozit;
    }
}