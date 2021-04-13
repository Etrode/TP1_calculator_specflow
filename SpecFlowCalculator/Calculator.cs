using System;
using System.Collections.Generic;

namespace SpecFlowCalculator
{
    public class Calculator
    {
        public List<int> InputsNumbers { get; set; }

        public int Add()
        {
            int result = 0;
            foreach(int number in this.InputsNumbers)
            {
                result += number;
            }
            return result;
        }

        public int Sub()
        {
            int result = 0;
            bool first = true;
            foreach (int number in this.InputsNumbers)
            {
                if (first)
                {
                    first = false;
                    result = number;
                }
                else
                {
                    result -= number;
                }
            }
            return result;
        }

        public int Multiply()
        {
            int result = 0;
            bool first = true;
            foreach (int number in this.InputsNumbers)
            {
                if (first)
                {
                    first = false;
                    result = number;
                }
                else
                {
                    result *= number;
                }
            }
            return result;
        }

        public int Divide()
        {
            try
            {
                int result = 0;
                bool first = true;
                foreach (int number in this.InputsNumbers)
                {
                    if (first)
                    {
                        first = false;
                        result = number;
                    }
                    else
                    {
                        result /= number;
                    }
                }
                return result;
            }
            catch (DivideByZeroException)
            {
                return 0;
            }
        }

    }
}