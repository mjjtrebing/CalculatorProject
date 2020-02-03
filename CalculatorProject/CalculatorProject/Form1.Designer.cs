namespace CalculatorProject
{
    partial class CalculatorApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorApp));
            this.displayBox = new System.Windows.Forms.TextBox();
            this.one_Box = new System.Windows.Forms.Button();
            this.minus_Box = new System.Windows.Forms.Button();
            this.six_Box = new System.Windows.Forms.Button();
            this.five_Box = new System.Windows.Forms.Button();
            this.four_Box = new System.Windows.Forms.Button();
            this.divide_Box = new System.Windows.Forms.Button();
            this.three_Box = new System.Windows.Forms.Button();
            this.two_Box = new System.Windows.Forms.Button();
            this.eight_Box = new System.Windows.Forms.Button();
            this.nine_Box = new System.Windows.Forms.Button();
            this.plus_Box = new System.Windows.Forms.Button();
            this.multiply_Box = new System.Windows.Forms.Button();
            this.zero_Box = new System.Windows.Forms.Button();
            this.decimalPoint_Box = new System.Windows.Forms.Button();
            this.equals_Box = new System.Windows.Forms.Button();
            this.seven_Box = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayBox
            // 
            this.displayBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.displayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBox.Location = new System.Drawing.Point(22, 32);
            this.displayBox.Multiline = true;
            this.displayBox.Name = "displayBox";
            this.displayBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.displayBox.Size = new System.Drawing.Size(328, 35);
            this.displayBox.TabIndex = 0;
            this.displayBox.Text = "0.0";
            this.displayBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // one_Box
            // 
            this.one_Box.Location = new System.Drawing.Point(22, 143);
            this.one_Box.Name = "one_Box";
            this.one_Box.Size = new System.Drawing.Size(69, 56);
            this.one_Box.TabIndex = 1;
            this.one_Box.Text = "1";
            this.one_Box.UseVisualStyleBackColor = true;
            this.one_Box.Click += new System.EventHandler(this.one_Box_Click);
            // 
            // minus_Box
            // 
            this.minus_Box.Location = new System.Drawing.Point(281, 215);
            this.minus_Box.Name = "minus_Box";
            this.minus_Box.Size = new System.Drawing.Size(69, 56);
            this.minus_Box.TabIndex = 2;
            this.minus_Box.Text = "-";
            this.minus_Box.UseVisualStyleBackColor = true;
            // 
            // six_Box
            // 
            this.six_Box.Location = new System.Drawing.Point(194, 215);
            this.six_Box.Name = "six_Box";
            this.six_Box.Size = new System.Drawing.Size(69, 56);
            this.six_Box.TabIndex = 3;
            this.six_Box.Text = "6";
            this.six_Box.UseVisualStyleBackColor = true;
            // 
            // five_Box
            // 
            this.five_Box.Location = new System.Drawing.Point(109, 215);
            this.five_Box.Name = "five_Box";
            this.five_Box.Size = new System.Drawing.Size(69, 56);
            this.five_Box.TabIndex = 4;
            this.five_Box.Text = "5";
            this.five_Box.UseVisualStyleBackColor = true;
            // 
            // four_Box
            // 
            this.four_Box.Location = new System.Drawing.Point(22, 215);
            this.four_Box.Name = "four_Box";
            this.four_Box.Size = new System.Drawing.Size(69, 56);
            this.four_Box.TabIndex = 5;
            this.four_Box.Text = "4";
            this.four_Box.UseVisualStyleBackColor = true;
            // 
            // divide_Box
            // 
            this.divide_Box.Location = new System.Drawing.Point(281, 143);
            this.divide_Box.Name = "divide_Box";
            this.divide_Box.Size = new System.Drawing.Size(69, 56);
            this.divide_Box.TabIndex = 6;
            this.divide_Box.Text = "/";
            this.divide_Box.UseVisualStyleBackColor = true;
            // 
            // three_Box
            // 
            this.three_Box.Location = new System.Drawing.Point(194, 143);
            this.three_Box.Name = "three_Box";
            this.three_Box.Size = new System.Drawing.Size(69, 56);
            this.three_Box.TabIndex = 7;
            this.three_Box.Text = "3";
            this.three_Box.UseVisualStyleBackColor = true;
            // 
            // two_Box
            // 
            this.two_Box.Location = new System.Drawing.Point(109, 143);
            this.two_Box.Name = "two_Box";
            this.two_Box.Size = new System.Drawing.Size(69, 56);
            this.two_Box.TabIndex = 8;
            this.two_Box.Text = "2";
            this.two_Box.UseVisualStyleBackColor = true;
            this.two_Box.Click += new System.EventHandler(this.two_Box_Click);
            // 
            // eight_Box
            // 
            this.eight_Box.Location = new System.Drawing.Point(109, 286);
            this.eight_Box.Name = "eight_Box";
            this.eight_Box.Size = new System.Drawing.Size(69, 56);
            this.eight_Box.TabIndex = 16;
            this.eight_Box.Text = "8";
            this.eight_Box.UseVisualStyleBackColor = true;
            // 
            // nine_Box
            // 
            this.nine_Box.Location = new System.Drawing.Point(194, 286);
            this.nine_Box.Name = "nine_Box";
            this.nine_Box.Size = new System.Drawing.Size(69, 56);
            this.nine_Box.TabIndex = 15;
            this.nine_Box.Text = "9";
            this.nine_Box.UseVisualStyleBackColor = true;
            // 
            // plus_Box
            // 
            this.plus_Box.Location = new System.Drawing.Point(281, 286);
            this.plus_Box.Name = "plus_Box";
            this.plus_Box.Size = new System.Drawing.Size(69, 56);
            this.plus_Box.TabIndex = 14;
            this.plus_Box.Text = "+";
            this.plus_Box.UseVisualStyleBackColor = true;
            this.plus_Box.Click += new System.EventHandler(this.plus_Box_Click);
            // 
            // multiply_Box
            // 
            this.multiply_Box.Location = new System.Drawing.Point(22, 358);
            this.multiply_Box.Name = "multiply_Box";
            this.multiply_Box.Size = new System.Drawing.Size(69, 56);
            this.multiply_Box.TabIndex = 13;
            this.multiply_Box.Text = "*";
            this.multiply_Box.UseVisualStyleBackColor = true;
            // 
            // zero_Box
            // 
            this.zero_Box.Location = new System.Drawing.Point(109, 358);
            this.zero_Box.Name = "zero_Box";
            this.zero_Box.Size = new System.Drawing.Size(69, 56);
            this.zero_Box.TabIndex = 12;
            this.zero_Box.Text = "0";
            this.zero_Box.UseVisualStyleBackColor = true;
            // 
            // decimalPoint_Box
            // 
            this.decimalPoint_Box.Location = new System.Drawing.Point(194, 358);
            this.decimalPoint_Box.Name = "decimalPoint_Box";
            this.decimalPoint_Box.Size = new System.Drawing.Size(69, 56);
            this.decimalPoint_Box.TabIndex = 11;
            this.decimalPoint_Box.Text = ".";
            this.decimalPoint_Box.UseVisualStyleBackColor = true;
            // 
            // equals_Box
            // 
            this.equals_Box.Location = new System.Drawing.Point(281, 358);
            this.equals_Box.Name = "equals_Box";
            this.equals_Box.Size = new System.Drawing.Size(69, 56);
            this.equals_Box.TabIndex = 10;
            this.equals_Box.Text = "=";
            this.equals_Box.UseVisualStyleBackColor = true;
            this.equals_Box.Click += new System.EventHandler(this.equals_Box_Click);
            // 
            // seven_Box
            // 
            this.seven_Box.Location = new System.Drawing.Point(22, 286);
            this.seven_Box.Name = "seven_Box";
            this.seven_Box.Size = new System.Drawing.Size(69, 56);
            this.seven_Box.TabIndex = 9;
            this.seven_Box.Text = "7";
            this.seven_Box.UseVisualStyleBackColor = true;
            // 
            // CalculatorApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 485);
            this.Controls.Add(this.eight_Box);
            this.Controls.Add(this.nine_Box);
            this.Controls.Add(this.plus_Box);
            this.Controls.Add(this.multiply_Box);
            this.Controls.Add(this.zero_Box);
            this.Controls.Add(this.decimalPoint_Box);
            this.Controls.Add(this.equals_Box);
            this.Controls.Add(this.seven_Box);
            this.Controls.Add(this.two_Box);
            this.Controls.Add(this.three_Box);
            this.Controls.Add(this.divide_Box);
            this.Controls.Add(this.four_Box);
            this.Controls.Add(this.five_Box);
            this.Controls.Add(this.six_Box);
            this.Controls.Add(this.minus_Box);
            this.Controls.Add(this.one_Box);
            this.Controls.Add(this.displayBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CalculatorApp";
            this.Text = "SUPER CALCULATOR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox displayBox;
        private System.Windows.Forms.Button one_Box;
        private System.Windows.Forms.Button minus_Box;
        private System.Windows.Forms.Button six_Box;
        private System.Windows.Forms.Button five_Box;
        private System.Windows.Forms.Button four_Box;
        private System.Windows.Forms.Button divide_Box;
        private System.Windows.Forms.Button three_Box;
        private System.Windows.Forms.Button two_Box;
        private System.Windows.Forms.Button eight_Box;
        private System.Windows.Forms.Button nine_Box;
        private System.Windows.Forms.Button plus_Box;
        private System.Windows.Forms.Button multiply_Box;
        private System.Windows.Forms.Button zero_Box;
        private System.Windows.Forms.Button decimalPoint_Box;
        private System.Windows.Forms.Button equals_Box;
        private System.Windows.Forms.Button seven_Box;
    }
}

