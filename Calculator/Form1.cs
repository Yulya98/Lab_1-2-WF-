using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Form1 : Form
    {
        static Integer ex = new Integer();
        
        public Form1()
        {
            ex.StartMethod += ex.MessageException;
            InitializeComponent();
            textBox1.Text = "0";
            textBox2.Text = "0";
        }

        //Buttons For Text Change
        #region
        private void textBox1_Change_numbur_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "";
                }
                else
                {
                    ex.num1 = Convert.ToDouble(textBox1.Text);
                }
            }
            catch
            {
                ex.Exception();
            }
        }

        private void textBox2_Change_number_2(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "")
                {
                    textBox2.Text = "";
                }
                else
                {
                    ex.num2 = Convert.ToDouble(textBox2.Text);
                }
            }
            catch
            {
                ex.Exception();
            }
        }
        #endregion

        //Buttons For Operations Methods
        #region
        private void button1_For_Sum_Method(object sender, EventArgs e)
        {
            textBox3.Text = ex.Sum().ToString();
            Integer.listArray.Add(Convert.ToDouble(textBox3.Text));
            ex.UpadateCount();
        }

        private void button4_For_Delete_Method(object sender, EventArgs e)
        {
            textBox3.Text = ex.Delete().ToString();
            Integer.listArray.Add(Convert.ToDouble(textBox3.Text));
            ex.UpadateCount();
        }

        private void button2_For_Substruct_Method(object sender, EventArgs e)
        {
            textBox3.Text = ex.Substruct().ToString();
            Integer.listArray.Add(Convert.ToDouble(textBox3.Text));
            ex.UpadateCount();
        }

        private void button5_For_Step_Method(object sender, EventArgs e)
        {
            textBox3.Text = ex.Step().ToString();
            Integer.listArray.Add(Convert.ToDouble(textBox3.Text));
            ex.UpadateCount();
        }

        private void button3_For_Multiply_Method(object sender, EventArgs e)
        {
            textBox3.Text = ex.Multiply().ToString();
            Integer.listArray.Add(Convert.ToDouble(textBox3.Text));
            ex.UpadateCount();
        }
        #endregion

        //Button For Previous Value
        #region
        private void button6_For_Prvious_Value(object sender, EventArgs e)
        {
            if (ex.count-2 >= 0)
            { 
         
                    textBox3.Text = Integer.listArray[ex.count - 2].ToString();
                    ex.count--;
            }
            else
                MessageBox.Show("Далее значений нет");
        }
        #endregion


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
