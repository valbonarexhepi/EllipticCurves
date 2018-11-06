namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.rtb_Public_1 = new System.Windows.Forms.RichTextBox();
            this.rtb_Plain_1 = new System.Windows.Forms.RichTextBox();
            this.rtb_Cipher_1 = new System.Windows.Forms.RichTextBox();
            this.rtb_Public_2 = new System.Windows.Forms.RichTextBox();
            this.rtb_Cipher_2 = new System.Windows.Forms.RichTextBox();
            this.rtb_Plain_2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(713, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Execute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtb_Public_1
            // 
            this.rtb_Public_1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.rtb_Public_1.Location = new System.Drawing.Point(51, 50);
            this.rtb_Public_1.Name = "rtb_Public_1";
            this.rtb_Public_1.Size = new System.Drawing.Size(333, 56);
            this.rtb_Public_1.TabIndex = 1;
            this.rtb_Public_1.Text = "";
            this.rtb_Public_1.TextChanged += new System.EventHandler(this.rtb_Public_1_TextChanged);
            // 
            // rtb_Plain_1
            // 
            this.rtb_Plain_1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.rtb_Plain_1.Location = new System.Drawing.Point(51, 218);
            this.rtb_Plain_1.Name = "rtb_Plain_1";
            this.rtb_Plain_1.Size = new System.Drawing.Size(259, 39);
            this.rtb_Plain_1.TabIndex = 2;
            this.rtb_Plain_1.Text = "";
            // 
            // rtb_Cipher_1
            // 
            this.rtb_Cipher_1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.rtb_Cipher_1.Location = new System.Drawing.Point(51, 296);
            this.rtb_Cipher_1.Name = "rtb_Cipher_1";
            this.rtb_Cipher_1.Size = new System.Drawing.Size(259, 39);
            this.rtb_Cipher_1.TabIndex = 3;
            this.rtb_Cipher_1.Text = "";
            // 
            // rtb_Public_2
            // 
            this.rtb_Public_2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.rtb_Public_2.Location = new System.Drawing.Point(399, 50);
            this.rtb_Public_2.Name = "rtb_Public_2";
            this.rtb_Public_2.Size = new System.Drawing.Size(339, 56);
            this.rtb_Public_2.TabIndex = 5;
            this.rtb_Public_2.Text = "";
            // 
            // rtb_Cipher_2
            // 
            this.rtb_Cipher_2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.rtb_Cipher_2.Location = new System.Drawing.Point(399, 218);
            this.rtb_Cipher_2.Name = "rtb_Cipher_2";
            this.rtb_Cipher_2.Size = new System.Drawing.Size(259, 39);
            this.rtb_Cipher_2.TabIndex = 6;
            this.rtb_Cipher_2.Text = "";
            // 
            // rtb_Plain_2
            // 
            this.rtb_Plain_2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.rtb_Plain_2.Location = new System.Drawing.Point(399, 296);
            this.rtb_Plain_2.Name = "rtb_Plain_2";
            this.rtb_Plain_2.Size = new System.Drawing.Size(259, 39);
            this.rtb_Plain_2.TabIndex = 7;
            this.rtb_Plain_2.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Public Key1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Public Key2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "PlainText";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "CipherText";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "CipherText";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "PlainText";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Hash1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(396, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Hash2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(838, 414);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_Plain_2);
            this.Controls.Add(this.rtb_Cipher_2);
            this.Controls.Add(this.rtb_Public_2);
            this.Controls.Add(this.rtb_Cipher_1);
            this.Controls.Add(this.rtb_Plain_1);
            this.Controls.Add(this.rtb_Public_1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Zgjerimi i klasave te .NET per perkrahjen e lakoreve eliptike";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtb_Public_1;
        private System.Windows.Forms.RichTextBox rtb_Plain_1;
        private System.Windows.Forms.RichTextBox rtb_Cipher_1;
        private System.Windows.Forms.RichTextBox rtb_Public_2;
        private System.Windows.Forms.RichTextBox rtb_Cipher_2;
        private System.Windows.Forms.RichTextBox rtb_Plain_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

