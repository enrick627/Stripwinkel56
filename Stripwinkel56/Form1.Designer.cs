namespace Stripwinkel56
{
    partial class Form_stripwinkel
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
            this.label_EenheidsprijsExclBTW = new System.Windows.Forms.Label();
            this.label_aantal = new System.Windows.Forms.Label();
            this.label_subtotaal_exclBTW = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_totaalBedrag = new System.Windows.Forms.Label();
            this.textBox_Eenheidsprijs = new System.Windows.Forms.TextBox();
            this.textBox_TotaalBedrag = new System.Windows.Forms.TextBox();
            this.textBox_BTWincl = new System.Windows.Forms.TextBox();
            this.textBox_Subtotaal = new System.Windows.Forms.TextBox();
            this.textBox_Aantal = new System.Windows.Forms.TextBox();
            this.button_Totberek = new System.Windows.Forms.Button();
            this.label_EURinclBTW = new System.Windows.Forms.Label();
            this.label_EURsubtotoexcl = new System.Windows.Forms.Label();
            this.label_EUReenheidsprijs = new System.Windows.Forms.Label();
            this.label_EURtotbedrag = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_EenheidsprijsExclBTW
            // 
            this.label_EenheidsprijsExclBTW.AutoSize = true;
            this.label_EenheidsprijsExclBTW.Location = new System.Drawing.Point(18, 29);
            this.label_EenheidsprijsExclBTW.Name = "label_EenheidsprijsExclBTW";
            this.label_EenheidsprijsExclBTW.Size = new System.Drawing.Size(157, 17);
            this.label_EenheidsprijsExclBTW.TabIndex = 0;
            this.label_EenheidsprijsExclBTW.Text = "Eenheidsprijs Excl BTW";
            // 
            // label_aantal
            // 
            this.label_aantal.AutoSize = true;
            this.label_aantal.Location = new System.Drawing.Point(21, 62);
            this.label_aantal.Name = "label_aantal";
            this.label_aantal.Size = new System.Drawing.Size(48, 17);
            this.label_aantal.TabIndex = 1;
            this.label_aantal.Text = "Aantal";
            // 
            // label_subtotaal_exclBTW
            // 
            this.label_subtotaal_exclBTW.AutoSize = true;
            this.label_subtotaal_exclBTW.Location = new System.Drawing.Point(18, 93);
            this.label_subtotaal_exclBTW.Name = "label_subtotaal_exclBTW";
            this.label_subtotaal_exclBTW.Size = new System.Drawing.Size(132, 17);
            this.label_subtotaal_exclBTW.TabIndex = 2;
            this.label_subtotaal_exclBTW.Text = "Subtotaal Excl BTW";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bedrag per stuk incl BTW";
            // 
            // label_totaalBedrag
            // 
            this.label_totaalBedrag.AutoSize = true;
            this.label_totaalBedrag.Location = new System.Drawing.Point(21, 244);
            this.label_totaalBedrag.Name = "label_totaalBedrag";
            this.label_totaalBedrag.Size = new System.Drawing.Size(97, 17);
            this.label_totaalBedrag.TabIndex = 5;
            this.label_totaalBedrag.Text = "Totaal bedrag";
            // 
            // textBox_Eenheidsprijs
            // 
            this.textBox_Eenheidsprijs.Location = new System.Drawing.Point(285, 29);
            this.textBox_Eenheidsprijs.Name = "textBox_Eenheidsprijs";
            this.textBox_Eenheidsprijs.Size = new System.Drawing.Size(100, 22);
            this.textBox_Eenheidsprijs.TabIndex = 6;
            // 
            // textBox_TotaalBedrag
            // 
            this.textBox_TotaalBedrag.Location = new System.Drawing.Point(285, 241);
            this.textBox_TotaalBedrag.Name = "textBox_TotaalBedrag";
            this.textBox_TotaalBedrag.Size = new System.Drawing.Size(100, 22);
            this.textBox_TotaalBedrag.TabIndex = 7;
            // 
            // textBox_BTWincl
            // 
            this.textBox_BTWincl.Location = new System.Drawing.Point(285, 154);
            this.textBox_BTWincl.Name = "textBox_BTWincl";
            this.textBox_BTWincl.Size = new System.Drawing.Size(100, 22);
            this.textBox_BTWincl.TabIndex = 8;
            // 
            // textBox_Subtotaal
            // 
            this.textBox_Subtotaal.Location = new System.Drawing.Point(285, 93);
            this.textBox_Subtotaal.Name = "textBox_Subtotaal";
            this.textBox_Subtotaal.Size = new System.Drawing.Size(100, 22);
            this.textBox_Subtotaal.TabIndex = 10;
            this.textBox_Subtotaal.TextChanged += new System.EventHandler(this.textBox_Subtotaal_TextChanged);
            // 
            // textBox_Aantal
            // 
            this.textBox_Aantal.Location = new System.Drawing.Point(285, 62);
            this.textBox_Aantal.Name = "textBox_Aantal";
            this.textBox_Aantal.Size = new System.Drawing.Size(100, 22);
            this.textBox_Aantal.TabIndex = 11;
            // 
            // button_Totberek
            // 
            this.button_Totberek.Location = new System.Drawing.Point(33, 290);
            this.button_Totberek.Name = "button_Totberek";
            this.button_Totberek.Size = new System.Drawing.Size(220, 31);
            this.button_Totberek.TabIndex = 12;
            this.button_Totberek.Text = "click voor alle berekeningen";
            this.button_Totberek.UseVisualStyleBackColor = true;
            this.button_Totberek.Click += new System.EventHandler(this.button_Totberek_Click);
            // 
            // label_EURinclBTW
            // 
            this.label_EURinclBTW.AutoSize = true;
            this.label_EURinclBTW.Location = new System.Drawing.Point(391, 159);
            this.label_EURinclBTW.Name = "label_EURinclBTW";
            this.label_EURinclBTW.Size = new System.Drawing.Size(37, 17);
            this.label_EURinclBTW.TabIndex = 13;
            this.label_EURinclBTW.Text = "EUR";
            this.label_EURinclBTW.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_EURsubtotoexcl
            // 
            this.label_EURsubtotoexcl.AutoSize = true;
            this.label_EURsubtotoexcl.Location = new System.Drawing.Point(392, 97);
            this.label_EURsubtotoexcl.Name = "label_EURsubtotoexcl";
            this.label_EURsubtotoexcl.Size = new System.Drawing.Size(37, 17);
            this.label_EURsubtotoexcl.TabIndex = 14;
            this.label_EURsubtotoexcl.Text = "EUR";
            // 
            // label_EUReenheidsprijs
            // 
            this.label_EUReenheidsprijs.AutoSize = true;
            this.label_EUReenheidsprijs.Location = new System.Drawing.Point(391, 32);
            this.label_EUReenheidsprijs.Name = "label_EUReenheidsprijs";
            this.label_EUReenheidsprijs.Size = new System.Drawing.Size(37, 17);
            this.label_EUReenheidsprijs.TabIndex = 15;
            this.label_EUReenheidsprijs.Text = "EUR";
            // 
            // label_EURtotbedrag
            // 
            this.label_EURtotbedrag.AutoSize = true;
            this.label_EURtotbedrag.Location = new System.Drawing.Point(392, 246);
            this.label_EURtotbedrag.Name = "label_EURtotbedrag";
            this.label_EURtotbedrag.Size = new System.Drawing.Size(37, 17);
            this.label_EURtotbedrag.TabIndex = 16;
            this.label_EURtotbedrag.Text = "EUR";
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(383, 297);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 17;
            this.button_close.Text = "close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // Form_stripwinkel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 333);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.label_EURtotbedrag);
            this.Controls.Add(this.label_EUReenheidsprijs);
            this.Controls.Add(this.label_EURsubtotoexcl);
            this.Controls.Add(this.label_EURinclBTW);
            this.Controls.Add(this.button_Totberek);
            this.Controls.Add(this.textBox_Aantal);
            this.Controls.Add(this.textBox_Subtotaal);
            this.Controls.Add(this.textBox_BTWincl);
            this.Controls.Add(this.textBox_TotaalBedrag);
            this.Controls.Add(this.textBox_Eenheidsprijs);
            this.Controls.Add(this.label_totaalBedrag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_subtotaal_exclBTW);
            this.Controls.Add(this.label_aantal);
            this.Controls.Add(this.label_EenheidsprijsExclBTW);
            this.Name = "Form_stripwinkel";
            this.Text = "Stripwinkel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_EenheidsprijsExclBTW;
        private System.Windows.Forms.Label label_aantal;
        private System.Windows.Forms.Label label_subtotaal_exclBTW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_totaalBedrag;
        private System.Windows.Forms.TextBox textBox_Eenheidsprijs;
        private System.Windows.Forms.TextBox textBox_TotaalBedrag;
        private System.Windows.Forms.TextBox textBox_BTWincl;
        private System.Windows.Forms.TextBox textBox_Subtotaal;
        private System.Windows.Forms.TextBox textBox_Aantal;
        private System.Windows.Forms.Button button_Totberek;
        private System.Windows.Forms.Label label_EURinclBTW;
        private System.Windows.Forms.Label label_EURsubtotoexcl;
        private System.Windows.Forms.Label label_EUReenheidsprijs;
        private System.Windows.Forms.Label label_EURtotbedrag;
        private System.Windows.Forms.Button button_close;
    }
}

