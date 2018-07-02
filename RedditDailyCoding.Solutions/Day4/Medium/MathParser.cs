using System;

namespace RedditDailyCoding.Solutions.Day4.Medium
{
    public class MathParser
    {

        static public string[] operatorList = new string[] { "+", "-", "*", "x", @"/", "^" };

        // Doesn't work with brackets yet :(

        public static void Run()
        {
            string calculation = "2+4*8-8+10+10/14**3";

            calculation.Replace("**", "^");

            Console.WriteLine(RecMath(calculation));

        }

        // Divide and conquer

        static string RecMath(string math)
        {
            string op = "";
            int index = 0;

            string left;
            string right;

            bool isOpFlag = false;

            // Checks for an operator

            foreach (string _op in operatorList)
            {
                if (math.Contains(_op))
                {
                    op = _op;
                    index = math.IndexOf(op);
                    isOpFlag = true;
                    break;
                }
            }

            // If no operator is found, end recursion

            if (isOpFlag == false)
            {
                return math;
            }

            // Else call for further subdivision

            left = math.Substring(0, index);
            right = math.Substring(index + 1);

            return Operate(op, RecMath(left), RecMath(right));

        }

        public static string Operate(string _op, string _word1, string _word2)
        {
            float num1 = float.Parse(_word1);
            float num2 = float.Parse(_word2);

            if (_op == "-")
                return (num1 - num2).ToString();

            else if (_op == "+")
                return (num1 + num2).ToString();

            else if (_op == "*" || _op == "x")
                return (num1 * num2).ToString();

            else if (_op == @"/")
                return (num1 / num2).ToString();

            else if (_op == "^")
                return (Math.Pow(num1, num2)).ToString();

            else
                return "0";

        }
    }
}
