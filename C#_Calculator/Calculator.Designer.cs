namespace C__Calculator
{
    partial class Calculator
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
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Trebuchet MS", 50F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(776, 85);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 141);
            button1.Name = "button1";
            button1.Size = new Size(150, 62);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(179, 141);
            button2.Name = "button2";
            button2.Size = new Size(150, 62);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(345, 141);
            button3.Name = "button3";
            button3.Size = new Size(150, 62);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(12, 209);
            button4.Name = "button4";
            button4.Size = new Size(150, 62);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(179, 209);
            button5.Name = "button5";
            button5.Size = new Size(150, 62);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(345, 209);
            button6.Name = "button6";
            button6.Size = new Size(150, 62);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(12, 277);
            button7.Name = "button7";
            button7.Size = new Size(150, 62);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(179, 277);
            button8.Name = "button8";
            button8.Size = new Size(150, 62);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(345, 277);
            button9.Name = "button9";
            button9.Size = new Size(150, 62);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(179, 345);
            button10.Name = "button10";
            button10.Size = new Size(150, 62);
            button10.TabIndex = 10;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(12, 345);
            button11.Name = "button11";
            button11.Size = new Size(150, 62);
            button11.TabIndex = 11;
            button11.Text = ".";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(345, 345);
            button12.Name = "button12";
            button12.Size = new Size(150, 62);
            button12.TabIndex = 12;
            button12.Text = "-";
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(701, 141);
            button13.Name = "button13";
            button13.Size = new Size(77, 62);
            button13.TabIndex = 13;
            button13.Text = "+";
            button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Location = new Point(701, 209);
            button14.Name = "button14";
            button14.Size = new Size(77, 62);
            button14.TabIndex = 14;
            button14.Text = "+";
            button14.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 792);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Calculator";
            RightToLeftLayout = true;
            Text = "Calculator";
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
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
    }
}