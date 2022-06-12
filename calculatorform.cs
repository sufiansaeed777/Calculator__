using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ultcalculator
{
    public partial class mycalculator : Form
    {
        public mycalculator()
        {
            InitializeComponent();
        }

        private void mycalculator_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        bool isfirst = true;
        double num1, num2;
        char opr;
        private void one_Click(object sender, EventArgs e)
        {
            if(isfirst)
            {
                
                screen.Text = "";
                isfirst = false;

            }
            screen.Text += one.Text;
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (isfirst)
            {
                
                screen.Text = "";
                isfirst = false;
            }
            screen.Text += two.Text;
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (isfirst)
            {
                
                screen.Text = "";
                isfirst = false;
            }
            screen.Text += three.Text;
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (isfirst)
            {
                
                screen.Text = "";
                isfirst = false;
            }
            screen.Text += four.Text;
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (isfirst)
            {
                
                screen.Text = "";
                isfirst = false;
            }
            screen.Text += five.Text;
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (isfirst)
            {
                
                screen.Text = "";
                isfirst = false;
            }
            screen.Text += six.Text;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (isfirst)
            {
               
                screen.Text = "";
                isfirst = false;
            }
            screen.Text += seven.Text;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (isfirst)
            {
                
                screen.Text = "";
                isfirst = false;
            }
            screen.Text += eight.Text;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (isfirst)
            {
                
                screen.Text = "";
                isfirst = false;
            }
            screen.Text += nine.Text;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (isfirst)
            {
                return;
                screen.Text = "";
                isfirst = false;
            }
            screen.Text += zero.Text;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            screen.Text = "";
            isfirst = true;
        }

        
        private void plus_Click(object sender, EventArgs e)
        {
            num1 = Int32.Parse(screen.Text);
            opr = '+';
            isfirst = true;
            
        }

        private void minus_Click(object sender, EventArgs e)
        {
            num1 = Int32.Parse(screen.Text);
              opr = '-';
                isfirst = true;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            num1 = Int32.Parse(screen.Text);
                opr = '*';
                isfirst = true;
        }

        private void division_Click(object sender, EventArgs e)
        {
            num1 = Int32.Parse(screen.Text);
                opr = '/';
               isfirst = true;
        }

        private void square_Click(object sender, EventArgs e)
        {
            num1 = Int32.Parse(screen.Text);
            opr = 's';
            isfirst = true;
        }

        private void log_Click(object sender, EventArgs e)
        {
            num1 = Int32.Parse(screen.Text);
            opr = 'l';
            isfirst = true;
            //return num1;
            
        }

        private void exp_Click(object sender, EventArgs e)
        {
            num1 = Int32.Parse(screen.Text);
            opr = 'e';
            isfirst = true;
        }

        //private void minus_Click(object sender, EventArgs e)
        //{
        //    num1 = Int32.Parse(screen.Text);
        //    opr = '-';
        //    isfirst = true;

        //}
        //private void multiply_Click(object sender, EventArgs e)
        //{
        //    num1 = Int32.Parse(screen.Text);
        //    opr = '*';
        //    isfirst = true;

        //}
        //private void division_Click(object sender, EventArgs e)
        //{
        //    num1 = Int32.Parse(screen.Text);
        //    opr = '/';
        //    isfirst = true;

        //}



        private void equal_Click(object sender, EventArgs e)
        {
            num2 = Int32.Parse(screen.Text);
            double res=0;
            switch (opr)
            {
                case '+':
                    res = num1 + num2;
                    break;
                case '-':
                    res = num1 - num2;
                    break;
                case '*':
                    res = num1 * num2;
                    break;
                case '/':
                    res = num1 / num2;
                    break;
                case 's':
                    res = num1 * num1;
                    break;
                case 'l':
                    res = Math.Log(num1);
                    break;
                case 'e':
                    res = Math.Pow(num1,num2);
                    break;

            }
            screen.Text = res.ToString();
            isfirst = true;
        }

    }
}
