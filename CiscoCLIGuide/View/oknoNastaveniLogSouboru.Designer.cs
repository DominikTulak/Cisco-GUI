namespace CiscoCLIGuide.View
{
    partial class oknoNastaveniLogSouboru
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
            this.buttonUlozitCestu = new System.Windows.Forms.Button();
            this.checkBoxLogovani = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCesta = new System.Windows.Forms.TextBox();
            this.buttonZvolit = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // buttonUlozitCestu
            // 
            this.buttonUlozitCestu.Location = new System.Drawing.Point(198, 155);
            this.buttonUlozitCestu.Name = "buttonUlozitCestu";
            this.buttonUlozitCestu.Size = new System.Drawing.Size(110, 23);
            this.buttonUlozitCestu.TabIndex = 0;
            this.buttonUlozitCestu.Text = "Uložit nastavení";
            this.buttonUlozitCestu.UseVisualStyleBackColor = true;
            this.buttonUlozitCestu.Click += new System.EventHandler(this.buttonUlozitCestu_Click);
            // 
            // checkBoxLogovani
            // 
            this.checkBoxLogovani.AutoSize = true;
            this.checkBoxLogovani.Location = new System.Drawing.Point(36, 33);
            this.checkBoxLogovani.Name = "checkBoxLogovani";
            this.checkBoxLogovani.Size = new System.Drawing.Size(127, 17);
            this.checkBoxLogovani.TabIndex = 1;
            this.checkBoxLogovani.Text = "Logovat do souboru?";
            this.checkBoxLogovani.UseVisualStyleBackColor = true;
            this.checkBoxLogovani.CheckedChanged += new System.EventHandler(this.checkBoxLogovani_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cesta k souboru:";
            // 
            // textBoxCesta
            // 
            this.textBoxCesta.Location = new System.Drawing.Point(36, 99);
            this.textBoxCesta.Name = "textBoxCesta";
            this.textBoxCesta.ReadOnly = true;
            this.textBoxCesta.Size = new System.Drawing.Size(360, 20);
            this.textBoxCesta.TabIndex = 3;
            // 
            // buttonZvolit
            // 
            this.buttonZvolit.Location = new System.Drawing.Point(413, 97);
            this.buttonZvolit.Name = "buttonZvolit";
            this.buttonZvolit.Size = new System.Drawing.Size(75, 23);
            this.buttonZvolit.TabIndex = 4;
            this.buttonZvolit.Text = "Zvolit";
            this.buttonZvolit.UseVisualStyleBackColor = true;
            this.buttonZvolit.Click += new System.EventHandler(this.buttonZvolit_Click);
            // 
            // oknoNastaveniLogSouboru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 213);
            this.Controls.Add(this.buttonZvolit);
            this.Controls.Add(this.textBoxCesta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxLogovani);
            this.Controls.Add(this.buttonUlozitCestu);
            this.Name = "oknoNastaveniLogSouboru";
            this.Text = "oknoNastaveniLogSouboru";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUlozitCestu;
        private System.Windows.Forms.CheckBox checkBoxLogovani;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCesta;
        private System.Windows.Forms.Button buttonZvolit;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}