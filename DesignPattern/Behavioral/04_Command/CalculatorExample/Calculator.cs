using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral._04_Command.CalculatorExample
{
    public class Calculator
    {
        private int result = 0;
        public int Action(int num, string operation)
        {
            result=operation switch
            {
                "+" => result+=num,
                "-" => result-=num,
                "*" => result*=num,
                "/" => result/=num,
                _ => result,
            };
            return result;
        }
    }
}
