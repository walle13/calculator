using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UART_test
{
    public partial class Form1 : Form
    {
        double number1 = 0, number2 = 0,result =0;
        int inputnumber, pointnumber;

        enum Operator { none, plus, minus, multiplication, division }
        Operator mode = Operator.none;
        bool ismode = false, isequal = false, ispoint = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void num1_Click(object sender, EventArgs e)
        {
            inputnumber = 1;
            calll(inputnumber);
        }

        private void num2_Click(object sender, EventArgs e)
        {
            inputnumber = 2;
            calll(inputnumber);
        }

        private void num3_Click(object sender, EventArgs e)
        {
            inputnumber = 3;
            calll(inputnumber);
        }

        private void num4_Click(object sender, EventArgs e)
        {
            inputnumber = 4;
            calll(inputnumber);
        }

        private void num5_Click(object sender, EventArgs e)
        {
            inputnumber = 5;
            calll(inputnumber);
        }

        private void num6_Click(object sender, EventArgs e)
        {
            inputnumber = 6;
            calll(inputnumber);
        }

        private void num7_Click(object sender, EventArgs e)
        {
            inputnumber = 7;
            calll(inputnumber);
        }

        private void num8_Click(object sender, EventArgs e)
        {
            inputnumber = 8;
            calll(inputnumber);
        }

        private void num9_Click(object sender, EventArgs e)
        {
            inputnumber = 9;
            calll(inputnumber);
        }

        private void num10_Click(object sender, EventArgs e)
        {
            inputnumber = 0;
            calll(inputnumber); 
        }

        private void clean_Click(object sender, EventArgs e)
        {
            cleanall();
        }

        public void calll(int an)
        {
            if (pointnumber == 0)
            {
                if (mode == Operator.none)
                {
                    number1 = number1 * 10 + an;
                    labelout.Text = Convert.ToString(number1);
                }
                else
                {
                    number2 = number2 * 10 + an;
                    labelout.Text = Convert.ToString(number2);
                }
            }
            else
            {
                pointnumber = pointnumber + 1;
                if (mode == Operator.none)
                {
                    number1 = number1 + an / Math.Pow(10, pointnumber - 1); //Pow =Power 乘方
                    //number1 = number1 + an / Math.Pow(10, -1 * (pointnumber - 1));//这种方式也可以
                    labelout.Text = Convert.ToString(number1);
                }
                else
                {
                    number2 = number2 + an / Math.Pow(10, pointnumber - 1); //Pow =Power 乘方
                    labelout.Text = Convert.ToString(number2);
                }
            }
            
            
            
            //isequal = true;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void plus_Click(object sender, EventArgs e)
        {
            mode = Operator.plus;
            switchmode();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            mode = Operator.minus;
            switchmode();
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            mode = Operator.multiplication;
            switchmode();
        }

        private void division_Click(object sender, EventArgs e)
        {
            mode = Operator.division;
            switchmode();
        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            if (e.Control != true)//如果没按Ctrl键
                return;
            switch (key)
            {
                case Keys.NumPad1:
                    //按下小键盘0以后
                    break;
               
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '1')
            {
                num1.PerformClick();// 执行按钮“1”的操作
            }
            else if (e.KeyChar == '2')
            {
                num2.PerformClick();// 执行按钮“2”的操作
            }
            else if (e.KeyChar == '3')
            {
                num3.PerformClick();// 执行按钮“3”的操作
            }
            else if (e.KeyChar == '4')
            {
                num4.PerformClick();// 执行按钮“4”的操作
            }
            else if (e.KeyChar == '5')
            {
                num5.PerformClick();// 执行按钮“5”的操作
            }
            else if (e.KeyChar == '6')
            {
                num6.PerformClick();// 执行按钮“6”的操作
            }
            else if (e.KeyChar == '7')
            {
                num7.PerformClick();// 执行按钮“7”的操作
            }
            else if (e.KeyChar == '8')
            {
                num8.PerformClick();// 执行按钮“8”的操作
            }
            else if (e.KeyChar == '9')
            {
                num9.PerformClick();// 执行按钮“9”的操作
            }
            else if (e.KeyChar == '0')
            {
                num10.PerformClick();// 执行按钮“0”的操作
            }
            else if (e.KeyChar == '+')
            {
                plus.PerformClick();// 执行按钮“+”的操作
            }
            else if (e.KeyChar == '-')
            {
                minus.PerformClick();// 执行按钮“-”的操作
            }
            else if (e.KeyChar == '*')
            {
                multiplication.PerformClick();// 执行按钮“*”的操作
            }
            else if (e.KeyChar == '/')
            {
                division.PerformClick();// 执行按钮“/”的操作
            }
            else if (e.KeyChar == '=')
            {
                calculate.PerformClick();// 执行按钮“=”的操作
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                clean.PerformClick();// 执行按钮“Clean”的操作
            }
            else if (e.KeyChar == '.')
            {
                point.PerformClick();// 执行按钮“Clean”的操作
            }
            e.Handled = true;
        }

        private void point_Click(object sender, EventArgs e)
        {
            if (ispoint == false)
            {
                pointnumber = pointnumber + 1;
                if (mode == Operator.none)
                {
                    labelout.Text = Convert.ToString(number1) + ".";
                }
                               
            }

        }


        private void calculate_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case Operator.plus:
                    result = number1 + number2;
                    break;
                case Operator.minus:
                    result = number1 - number2;
                    break;
                case Operator.multiplication:
                    result = number1 * number2;
                    break;
                case Operator.division:
                    result = number1 / number2;
                    break;
            }
            isequal = true;
            ismode = true;
            number1 = 0;
            number2 = 0;
            labelbefore.Text = "";
            labelmode.Text = "";
            labelout.Text = Convert.ToString(result);
            mode = Operator.none;
        }

        public void cleanall()
        {
            number1 = 0;
            number2 = 0;
            result = 0;
            labelbefore.Text = "";
            labelmode.Text = "";
            labelout.Text = Convert.ToString(result);
            isequal = false;
            ismode = false;
            mode = Operator.none;
        }

        public void switchmode()
        {
            switch (mode)
            {
                case Operator.plus:
                    labelmode.Text = "+";
                    break;
                case Operator.minus:
                    labelmode.Text = "-";
                    break;
                case Operator.multiplication:
                    labelmode.Text = "*";
                    break;
                case Operator.division:
                    labelmode.Text = "/";
                    break;
            }
            if (isequal == true)
            {
                number1 = result;
            }
            ismode = true;
            number2 = 0;
            ispoint = false;
            pointnumber = 0;
            labelbefore.Text = Convert.ToString(number1);
            labelout.Text = Convert.ToString(number2);
        }
    }
}



//private void btnpre_click(object sender, eventargs e)
//{
//    this.treeview1.focus();//此句必要，要不然都不知道操作的是什么。
//    sendkeys.send("{up}");
//}
//上面是按钮去关联键盘。