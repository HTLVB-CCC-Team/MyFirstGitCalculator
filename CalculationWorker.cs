using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class CalculationWorker
{
    internal static float Calculate(float operand1, float operand2, string @operator)
    {
		float result = 0;

		try
		{
            if (@operator == "+")
                result = operand1 + operand2;
            else if (@operator == "-")
                result = operand1 - operand2;
            else if (@operator == "*")
                result = operand1 * operand2;
            else if (@operator == "%")
                result = operand1 % operand2;
            else if (@operator == "/")
            {
                if (operand2 != 0)
                    return operand1 / operand2;
                else
                    throw new DivideByZeroException("Cannot divide by zero!");
            }
        else
        {
            throw new ArgumentException("Invalid operator");
        }
    }
		catch (Exception ex)
		{
            Console.WriteLine(ex.Message);
		}

        return result;
    }
}
