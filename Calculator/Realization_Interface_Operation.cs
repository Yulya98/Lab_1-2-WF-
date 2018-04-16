using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    partial class Integer
    {
        //Realization Interface
        #region
        public double Sum()
        {
            return num1 + num2;
        }
        public double Delete()
        {
            return num1 / num2;
        }
        public double Substruct()
        {
            return num1 - num2;
        }
        public double Multiply()
        {
            return num1 * num2;
        }
        public double Step()
        {
            return Math.Pow(num1, num2);
        }
       #endregion
    }
}
