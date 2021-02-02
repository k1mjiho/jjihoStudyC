using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    class Calculator
    {
        public Double plusResult(Double num1, Double num2)
        {
            Console.Write(num1 + num2);
            return num1 + num2;
        }

        public Double minusResult(Double num1, Double num2)
        {
            return num1 - num2;
        }
        
        public Double divideResult(Double num1, Double num2)
        {
            return num1 % num2;
        }
        
        public Double multipleResult(Double num1, Double num2)
        {
            return num1 * num2;
        }


    }
}
