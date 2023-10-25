namespace ConversionApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            richTextBox6 = new RichTextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            richTextBox7 = new RichTextBox();
            label10 = new Label();
            richTextBox8 = new RichTextBox();
            richTextBox9 = new RichTextBox();
            label11 = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(601, 151);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1107, 68);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(964, 267);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(744, 54);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(964, 355);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(744, 46);
            richTextBox3.TabIndex = 3;
            richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new Point(964, 445);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(744, 50);
            richTextBox4.TabIndex = 4;
            richTextBox4.Text = "";
            // 
            // richTextBox5
            // 
            richTextBox5.Location = new Point(1423, 703);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.Size = new Size(303, 59);
            richTextBox5.TabIndex = 5;
            richTextBox5.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(601, 289);
            label1.Name = "label1";
            label1.Size = new Size(135, 32);
            label1.TabIndex = 6;
            label1.Text = "Byte Data";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(601, 369);
            label2.Name = "label2";
            label2.Size = new Size(239, 32);
            label2.TabIndex = 7;
            label2.Text = "Hexadecimal Data";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(601, 463);
            label3.Name = "label3";
            label3.Size = new Size(295, 32);
            label3.TabIndex = 8;
            label3.Text = "Base64-Encoded Data";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1173, 569);
            label4.Name = "label4";
            label4.Size = new Size(553, 32);
            label4.TabIndex = 9;
            label4.Text = "Convert Decimal to Little-Endian Byte Array.";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.OrangeRed;
            button2.Location = new Point(1528, 85);
            button2.Name = "button2";
            button2.Size = new Size(181, 51);
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
            label5.Location = new Point(847, 51);
            label5.Name = "label5";
            label5.Size = new Size(441, 31);
            label5.TabIndex = 11;
            label5.Text = "Enter input from these following forms.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.LightSeaGreen;
            label6.Location = new Point(586, 96);
            label6.Name = "label6";
            label6.Size = new Size(912, 38);
            label6.TabIndex = 12;
            label6.Text = "1. Byte Data / 2. Hexadecimal Data / 3. Base64-Encoded Data / 4. Base64";
            // 
            // richTextBox6
            // 
            richTextBox6.Location = new Point(1423, 627);
            richTextBox6.Name = "richTextBox6";
            richTextBox6.Size = new Size(303, 59);
            richTextBox6.TabIndex = 13;
            richTextBox6.Text = "";
            richTextBox6.TextChanged += richTextBox6_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(49, 549);
            label7.Name = "label7";
            label7.Size = new Size(1743, 20);
            label7.TabIndex = 14;
            label7.Text = resources.GetString("label7.Text");
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(1289, 649);
            label8.Name = "label8";
            label8.Size = new Size(79, 37);
            label8.TabIndex = 15;
            label8.Text = "Input";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(1289, 725);
            label9.Name = "label9";
            label9.Size = new Size(101, 37);
            label9.TabIndex = 16;
            label9.Text = "Output";
            // 
            // richTextBox7
            // 
            richTextBox7.Location = new Point(110, 649);
            richTextBox7.Name = "richTextBox7";
            richTextBox7.Size = new Size(399, 58);
            richTextBox7.TabIndex = 17;
            richTextBox7.Text = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(110, 589);
            label10.Name = "label10";
            label10.Size = new Size(399, 38);
            label10.TabIndex = 18;
            label10.Text = "Enter data to generate SHA256";
            // 
            // richTextBox8
            // 
            richTextBox8.Location = new Point(110, 725);
            richTextBox8.Name = "richTextBox8";
            richTextBox8.Size = new Size(399, 48);
            richTextBox8.TabIndex = 19;
            richTextBox8.Text = "";
            // 
            // richTextBox9
            // 
            richTextBox9.Location = new Point(560, 649);
            richTextBox9.Name = "richTextBox9";
            richTextBox9.Size = new Size(323, 120);
            richTextBox9.TabIndex = 20;
            richTextBox9.Text = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(631, 596);
            label11.Name = "label11";
            label11.Size = new Size(53, 20);
            label11.TabIndex = 21;
            label11.Text = "output";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1749, 789);
            Controls.Add(label11);
            Controls.Add(richTextBox9);
            Controls.Add(richTextBox8);
            Controls.Add(label10);
            Controls.Add(richTextBox7);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(richTextBox6);
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
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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
        private RichTextBox richTextBox6;
        private Label label7;
        private Label label8;
        private Label label9;
        private RichTextBox richTextBox7;
        private Label label10;
        private RichTextBox richTextBox8;
        private RichTextBox richTextBox9;
        private Label label11;
    }
}