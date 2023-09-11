namespace kalkulatorbiasa
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            textBox2 = new TextBox();
            but_7 = new Button();
            but_8 = new Button();
            but_9 = new Button();
            but_3 = new Button();
            but_2 = new Button();
            but_1 = new Button();
            but_6 = new Button();
            but_5 = new Button();
            but_4 = new Button();
            kosong = new Button();
            but_c = new Button();
            button6 = new Button();
            but_dot = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(61, 40);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 29);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(247, 123);
            button1.Name = "button1";
            button1.Size = new Size(43, 39);
            button1.TabIndex = 1;
            button1.Text = "÷";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(247, 180);
            button2.Name = "button2";
            button2.Size = new Size(43, 41);
            button2.TabIndex = 2;
            button2.Text = "×";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(247, 235);
            button3.Name = "button3";
            button3.Size = new Size(43, 41);
            button3.TabIndex = 3;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(247, 293);
            button4.Name = "button4";
            button4.Size = new Size(43, 40);
            button4.TabIndex = 4;
            button4.Text = "+";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(185, 351);
            button5.Name = "button5";
            button5.Size = new Size(105, 40);
            button5.TabIndex = 5;
            button5.Text = "=";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(61, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(229, 27);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // but_7
            // 
            but_7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            but_7.Location = new Point(61, 180);
            but_7.Name = "but_7";
            but_7.Size = new Size(43, 39);
            but_7.TabIndex = 7;
            but_7.Text = "7";
            but_7.UseVisualStyleBackColor = true;
            but_7.Click += but_7_Click;
            // 
            // but_8
            // 
            but_8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            but_8.Location = new Point(124, 180);
            but_8.Name = "but_8";
            but_8.Size = new Size(43, 39);
            but_8.TabIndex = 8;
            but_8.Text = "8";
            but_8.UseVisualStyleBackColor = true;
            but_8.Click += but_8_Click;
            // 
            // but_9
            // 
            but_9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            but_9.Location = new Point(185, 180);
            but_9.Name = "but_9";
            but_9.Size = new Size(43, 39);
            but_9.TabIndex = 9;
            but_9.Text = "9";
            but_9.UseVisualStyleBackColor = true;
            but_9.Click += but_9_Click;
            // 
            // but_3
            // 
            but_3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            but_3.Location = new Point(185, 293);
            but_3.Name = "but_3";
            but_3.Size = new Size(43, 39);
            but_3.TabIndex = 12;
            but_3.Text = "3";
            but_3.UseVisualStyleBackColor = true;
            but_3.Click += but_3_Click;
            // 
            // but_2
            // 
            but_2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            but_2.Location = new Point(124, 293);
            but_2.Name = "but_2";
            but_2.Size = new Size(43, 39);
            but_2.TabIndex = 11;
            but_2.Text = "2";
            but_2.UseVisualStyleBackColor = true;
            but_2.Click += but_2_Click;
            // 
            // but_1
            // 
            but_1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            but_1.Location = new Point(61, 293);
            but_1.Name = "but_1";
            but_1.Size = new Size(43, 39);
            but_1.TabIndex = 10;
            but_1.Text = "1";
            but_1.UseVisualStyleBackColor = true;
            but_1.Click += but_1_Click;
            // 
            // but_6
            // 
            but_6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            but_6.Location = new Point(185, 235);
            but_6.Name = "but_6";
            but_6.Size = new Size(43, 39);
            but_6.TabIndex = 15;
            but_6.Text = "6";
            but_6.UseVisualStyleBackColor = true;
            but_6.Click += but_6_Click;
            // 
            // but_5
            // 
            but_5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            but_5.Location = new Point(124, 235);
            but_5.Name = "but_5";
            but_5.Size = new Size(43, 39);
            but_5.TabIndex = 14;
            but_5.Text = "5";
            but_5.UseVisualStyleBackColor = true;
            but_5.Click += but_5_Click;
            // 
            // but_4
            // 
            but_4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            but_4.Location = new Point(61, 235);
            but_4.Name = "but_4";
            but_4.Size = new Size(43, 39);
            but_4.TabIndex = 13;
            but_4.Text = "4";
            but_4.UseVisualStyleBackColor = true;
            but_4.Click += but_4_Click;
            // 
            // kosong
            // 
            kosong.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kosong.Location = new Point(61, 351);
            kosong.Name = "kosong";
            kosong.Size = new Size(43, 39);
            kosong.TabIndex = 16;
            kosong.Text = "0";
            kosong.UseVisualStyleBackColor = true;
            kosong.Click += kosong_Click;
            // 
            // but_c
            // 
            but_c.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            but_c.Location = new Point(61, 123);
            but_c.Name = "but_c";
            but_c.Size = new Size(106, 39);
            but_c.TabIndex = 17;
            but_c.Text = "C";
            but_c.UseVisualStyleBackColor = true;
            but_c.Click += but_c_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Arial", 7F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(185, 123);
            button6.Name = "button6";
            button6.Size = new Size(43, 39);
            button6.TabIndex = 18;
            button6.Text = "DEL";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // but_dot
            // 
            but_dot.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            but_dot.Location = new Point(124, 351);
            but_dot.Name = "but_dot";
            but_dot.Size = new Size(43, 39);
            but_dot.TabIndex = 20;
            but_dot.Text = ".";
            but_dot.UseVisualStyleBackColor = true;
            but_dot.Click += but_dot_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 427);
            Controls.Add(but_dot);
            Controls.Add(button6);
            Controls.Add(but_c);
            Controls.Add(kosong);
            Controls.Add(but_6);
            Controls.Add(but_5);
            Controls.Add(but_4);
            Controls.Add(but_3);
            Controls.Add(but_2);
            Controls.Add(but_1);
            Controls.Add(but_9);
            Controls.Add(but_8);
            Controls.Add(but_7);
            Controls.Add(textBox2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox textBox2;
        private Button but_7;
        private Button but_8;
        private Button but_9;
        private Button but_3;
        private Button but_2;
        private Button but_1;
        private Button but_6;
        private Button but_5;
        private Button but_4;
        private Button kosong;
        private Button but_c;
        private Button button6;
        private Button but_dot;
    }
}