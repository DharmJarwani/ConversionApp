﻿namespace ConversionApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            richTextBox4 = new RichTextBox();
            richTextBox5 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(315, 113);
            richTextBox1.Margin = new Padding(3, 2, 3, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1180, 71);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(589, 299);
            richTextBox2.Margin = new Padding(3, 2, 3, 2);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(906, 48);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(589, 365);
            richTextBox3.Margin = new Padding(3, 2, 3, 2);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(906, 49);
            richTextBox3.TabIndex = 3;
            richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new Point(589, 433);
            richTextBox4.Margin = new Padding(3, 2, 3, 2);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(906, 54);
            richTextBox4.TabIndex = 4;
            richTextBox4.Text = "";
            // 
            // richTextBox5
            // 
            richTextBox5.Location = new Point(589, 501);
            richTextBox5.Margin = new Padding(3, 2, 3, 2);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.Size = new Size(906, 57);
            richTextBox5.TabIndex = 5;
            richTextBox5.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(309, 308);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 6;
            label1.Text = "Byte Data";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(309, 376);
            label2.Name = "label2";
            label2.Size = new Size(188, 25);
            label2.TabIndex = 7;
            label2.Text = "Hexadecimal Data";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(309, 446);
            label3.Name = "label3";
            label3.Size = new Size(231, 25);
            label3.TabIndex = 8;
            label3.Text = "Base64-Encoded Data";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(309, 515);
            label4.Name = "label4";
            label4.Size = new Size(86, 25);
            label4.TabIndex = 9;
            label4.Text = "Base64";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.OrangeRed;
            button2.Location = new Point(829, 218);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(158, 38);
            button2.TabIndex = 10;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Chocolate;
            label5.Location = new Point(741, 38);
            label5.Name = "label5";
            label5.Size = new Size(364, 25);
            label5.TabIndex = 11;
            label5.Text = "Enter input from these following forms.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.LightSeaGreen;
            label6.Location = new Point(513, 72);
            label6.Name = "label6";
            label6.Size = new Size(716, 30);
            label6.TabIndex = 12;
            label6.Text = "1. Byte Data / 2. Hexadecimal Data / 3. Base64-Encoded Data / 4. Base64";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1530, 592);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox5);
            Controls.Add(richTextBox4);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox4;
        private RichTextBox richTextBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
        private Label label5;
        private Label label6;
    }
}