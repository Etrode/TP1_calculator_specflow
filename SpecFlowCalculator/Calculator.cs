using System;
using System.Collections.Generic;

namespace SpecFlowCalculator
{
    public class Calculator
    {
        public List<int> InputsNumbers { get; set; }

        public List<string> Operators { get; set; }

        public int Add()
        {
            int result = 0;
            foreach (int number in this.InputsNumbers)
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

        public int Calculate()
        {
            // Calculation with InputsNumbers and Operators (+ * - /)
            if (InputsNumbers.Count == 1)
            {
                // Only one element
                return InputsNumbers[0];
            }
            else if (InputsNumbers.Count == 0 || !(Operators.Count == InputsNumbers.Count -1))
            {
                // 0 element OR the number of operators is incorrect
                return 0;
            }

            try
            {
                int result = 0;
                bool first = true;
                int operatorIndex = 0;
                foreach (int number in this.InputsNumbers)
                {
                    if (first)
                    {
                        first = false;
                        result = number;
                    }
                    else
                    {
                        string operat = Operators[operatorIndex];
                        switch(operat)
                        {
                            case "+":
                                result += number;
                                break;
                            case "-":
                                result -= number;
                                break;
                            case "*":
                                result *= number;
                                break;
                            case "/":
                                result /= number;
                                break;
                            default:
                                return 0;
                        }
                        operatorIndex++;
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