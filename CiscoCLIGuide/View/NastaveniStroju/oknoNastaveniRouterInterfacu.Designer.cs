namespace CiscoCLIGuide.View
{
    partial class oknoNastaveniRouterInterfacu
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
            this.comboBoxDruhIf = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOznaceniIf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxPovolitIf = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.textBoxMaska = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonUlozit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Druh interfacu:";
            // 
            // comboBoxDruhIf
            // 
            this.comboBoxDruhIf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDruhIf.FormattingEnabled = true;
            this.comboBoxDruhIf.Items.AddRange(new object[] {
            "FastEthernet",
            "GigabitEthernet",
            "Serial"});
            this.comboBoxDruhIf.Location = new System.Drawing.Point(157, 26);
            this.comboBoxDruhIf.Name = "comboBoxDruhIf";
            this.comboBoxDruhIf.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDruhIf.TabIndex = 1;
            this.comboBoxDruhIf.Text = "FastEthernet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Označení interfacu:";
            // 
            // textBoxOznaceniIf
            // 
            this.textBoxOznaceniIf.Location = new System.Drawing.Point(157, 59);
            this.textBoxOznaceniIf.Name = "textBoxOznaceniIf";
            this.textBoxOznaceniIf.Size = new System.Drawing.Size(121, 20);
            this.textBoxOznaceniIf.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Povolit interface:";
            // 
            // checkBoxPovolitIf
            // 
            this.checkBoxPovolitIf.AutoSize = true;
            this.checkBoxPovolitIf.Location = new System.Drawing.Point(157, 97);
            this.checkBoxPovolitIf.Name = "checkBoxPovolitIf";
            this.checkBoxPovolitIf.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPovolitIf.TabIndex = 5;
            this.checkBoxPovolitIf.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "IP adresa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Maska:";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(157, 129);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(100, 20);
            this.textBoxIP.TabIndex = 8;
            // 
            // textBoxMaska
            // 
            this.textBoxMaska.Location = new System.Drawing.Point(157, 164);
            this.textBoxMaska.Name = "textBoxMaska";
            this.textBoxMaska.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaska.TabIndex = 9;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(157, 197);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescription.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Description:";
            // 
            // buttonUlozit
            // 
            this.buttonUlozit.Location = new System.Drawing.Point(110, 237);
            this.buttonUlozit.Name = "buttonUlozit";
            this.buttonUlozit.Size = new System.Drawing.Size(75, 23);
            this.buttonUlozit.TabIndex = 12;
            this.buttonUlozit.Text = "Uložit";
            this.buttonUlozit.UseVisualStyleBackColor = true;

            this.buttonUlozit.Click += new System.EventHandler(this.buttonUlozit_Click);
            // 
            // oknoNastaveniRouterInterfacu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 285);
            this.Controls.Add(this.buttonUlozit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxMaska);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxPovolitIf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxOznaceniIf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxDruhIf);
            this.Controls.Add(this.label1);
            this.Name = "oknoNastaveniRouterInterfacu";
            this.Text = "Nastavení if routeru";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDruhIf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOznaceniIf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxPovolitIf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.TextBox textBoxMaska;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonUlozit;
    }
}