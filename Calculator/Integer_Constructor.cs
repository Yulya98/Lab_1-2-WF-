using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public delegate void DelegForErrorMethod(); 
    public partial class Integer: Operation
    {
        //Data
        #region
        public event DelegForErrorMethod StartMethod;
        public double num1;
        public double num2;
        public static List<double> listArray = new List<double>();
        #endregion
        public Integer()
        {
            listArray = new List<double>();
        }
        //Methods For Delegate
        #region
        public void Exception()
        {
            StartMethod();
        }
        public void MessageException()
        {
            MessageBox.Show("Incorrect Data");
        }
        #endregion
        //Method For = Button
        #region
        public int count=0;
        public void UpadateCount()
        {
            count = Integer.listArray.Count;
        }
        #endregion
    }
}
