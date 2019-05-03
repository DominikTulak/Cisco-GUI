namespace CiscoCLIGuide.View
{
    partial class oknoNastaveniRS232
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
            this.ciselnikPort = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ciselnikDataBity = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonStopbity1 = new System.Windows.Forms.RadioButton();
            this.radioButtonStopbity2 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxParita = new System.Windows.Forms.ComboBox();
            this.buttonUlozit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ciselnikPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciselnikDataBity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Číslo sériového portu:";
            // 
            // ciselnikPort
            // 
            this.ciselnikPort.Location = new System.Drawing.Point(113, 53);
            this.ciselnikPort.Name = "ciselnikPort";
            this.ciselnikPort.Size = new System.Drawing.Size(61, 20);
            this.ciselnikPort.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "COM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rychlost portu (baud):";
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.DisplayMember = "1";
            this.comboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "38400",
            "57600",
            "115200"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(113, 113);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBaudRate.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Počet data bitů:";
            // 
            // ciselnikDataBity
            // 
            this.ciselnikDataBity.Location = new System.Drawing.Point(113, 175);
            this.ciselnikDataBity.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.ciselnikDataBity.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ciselnikDataBity.Name = "ciselnikDataBity";
            this.ciselnikDataBity.Size = new System.Drawing.Size(61, 20);
            this.ciselnikDataBity.TabIndex = 6;
            this.ciselnikDataBity.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Počet stopbitů:";
            // 
            // radioButtonStopbity1
            // 
            this.radioButtonStopbity1.AutoSize = true;
            this.radioButtonStopbity1.Checked = true;
            this.radioButtonStopbity1.Location = new System.Drawing.Point(113, 253);
            this.radioButtonStopbity1.Name = "radioButtonStopbity1";
            this.radioButtonStopbity1.Size = new System.Drawing.Size(31, 17);
            this.radioButtonStopbity1.TabIndex = 8;
            this.radioButtonStopbity1.TabStop = true;
            this.radioButtonStopbity1.Text = "1";
            this.radioButtonStopbity1.UseVisualStyleBackColor = true;
            // 
            // radioButtonStopbity2
            // 
            this.radioButtonStopbity2.AutoSize = true;
            this.radioButtonStopbity2.Location = new System.Drawing.Point(174, 253);
            this.radioButtonStopbity2.Name = "radioButtonStopbity2";
            this.radioButtonStopbity2.Size = new System.Drawing.Size(31, 17);
            this.radioButtonStopbity2.TabIndex = 9;
            this.radioButtonStopbity2.TabStop = true;
            this.radioButtonStopbity2.Text = "2";
            this.radioButtonStopbity2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Parita:";
            // 
            // comboBoxParita
            // 
            this.comboBoxParita.DisplayMember = "1";
            this.comboBoxParita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParita.FormattingEnabled = true;
            this.comboBoxParita.Items.AddRange(new object[] {
            "Žádná",
            "Sudá",
            "Lichá"});
            this.comboBoxParita.Location = new System.Drawing.Point(113, 318);
            this.comboBoxParita.Name = "comboBoxParita";
            this.comboBoxParita.Size = new System.Drawing.Size(121, 21);
            this.comboBoxParita.TabIndex = 12;
            this.comboBoxParita.ValueMember = "1";
            // 
            // buttonUlozit
            // 
            this.buttonUlozit.Location = new System.Drawing.Point(113, 374);
            this.buttonUlozit.Name = "buttonUlozit";
            this.buttonUlozit.Size = new System.Drawing.Size(101, 23);
            this.buttonUlozit.TabIndex = 13;
            this.buttonUlozit.Text = "Uložit";
            this.buttonUlozit.UseVisualStyleBackColor = true;
            this.buttonUlozit.Click += new System.EventHandler(this.buttonUlozit_Click);
            // 
            // oknoNastaveniRS232
            // 
            this.AcceptButton = this.buttonUlozit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 450);
            this.Controls.Add(this.radioButtonStopbity2);
            this.Controls.Add(this.radioButtonStopbity1);
            this.Controls.Add(this.buttonUlozit);
            this.Controls.Add(this.comboBoxParita);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ciselnikDataBity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxBaudRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ciselnikPort);
            this.Controls.Add(this.label1);
            this.Name = "oknoNastaveniRS232";
            this.Text = "Nastavení RS-232";
            ((System.ComponentModel.ISupportInitialize)(this.ciselnikPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciselnikDataBity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ciselnikPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ciselnikDataBity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonStopbity1;
        private System.Windows.Forms.RadioButton radioButtonStopbity2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxParita;
        private System.Windows.Forms.Button buttonUlozit;
    }
}