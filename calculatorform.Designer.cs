namespace ultcalculator
{
    partial class mycalculator
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
            this.screen = new System.Windows.Forms.TextBox();
            this.one = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.toggle = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            this.exp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.Location = new System.Drawing.Point(75, 30);
            this.screen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.screen.Name = "screen";
            this.screen.ReadOnly = true;
            this.screen.Size = new System.Drawing.Size(709, 26);
            this.screen.TabIndex = 0;
            this.screen.Text = "0";
            this.screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(84, 90);
            this.one.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(135, 43);
            this.one.TabIndex = 1;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(423, 90);
            this.three.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(135, 43);
            this.three.TabIndex = 2;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(250, 90);
            this.two.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(135, 43);
            this.two.TabIndex = 3;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(423, 143);
            this.six.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(135, 43);
            this.six.TabIndex = 4;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(250, 143);
            this.five.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(135, 43);
            this.five.TabIndex = 5;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(84, 143);
            this.four.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(135, 43);
            this.four.TabIndex = 6;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(84, 196);
            this.seven.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(135, 43);
            this.seven.TabIndex = 7;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(250, 196);
            this.eight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(135, 43);
            this.eight.TabIndex = 8;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(423, 196);
            this.nine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(135, 43);
            this.nine.TabIndex = 9;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(604, 90);
            this.clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(160, 72);
            this.clear.TabIndex = 10;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(604, 170);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(78, 32);
            this.plus.TabIndex = 11;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(606, 213);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(78, 32);
            this.multiply.TabIndex = 13;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(688, 213);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(78, 32);
            this.division.TabIndex = 14;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(606, 289);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(160, 65);
            this.equal.TabIndex = 15;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(688, 170);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(78, 32);
            this.minus.TabIndex = 16;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(250, 250);
            this.zero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(135, 43);
            this.zero.TabIndex = 17;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // toggle
            // 
            this.toggle.Location = new System.Drawing.Point(651, 251);
            this.toggle.Name = "toggle";
            this.toggle.Size = new System.Drawing.Size(78, 32);
            this.toggle.TabIndex = 18;
            this.toggle.Text = "-/+";
            this.toggle.UseVisualStyleBackColor = true;
            // 
            // square
            // 
            this.square.Location = new System.Drawing.Point(100, 310);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(75, 23);
            this.square.TabIndex = 19;
            this.square.Text = "x^2";
            this.square.UseVisualStyleBackColor = true;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(264, 310);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(75, 23);
            this.log.TabIndex = 20;
            this.log.Text = "log";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // exp
            // 
            this.exp.Location = new System.Drawing.Point(449, 310);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(75, 23);
            this.exp.TabIndex = 21;
            this.exp.Text = "exp";
            this.exp.UseVisualStyleBackColor = true;
            this.exp.Click += new System.EventHandler(this.exp_Click);
            // 
            // mycalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 366);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.log);
            this.Controls.Add(this.square);
            this.Controls.Add(this.toggle);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.four);
            this.Controls.Add(this.five);
            this.Controls.Add(this.six);
            this.Controls.Add(this.two);
            this.Controls.Add(this.three);
            this.Controls.Add(this.one);
            this.Controls.Add(this.screen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "mycalculator";
            this.Text = "my ultimate calculator";
            this.Load += new System.EventHandler(this.mycalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox screen;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button toggle;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Button exp;
    }
}

