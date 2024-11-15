

Console.WriteLine("MyFirstGitCalculator!");


float operand1;
float operand2;
string @operator;
Console.ForegroundColor = ConsoleColor.Yellow;

operand1 = InputHelper.ReadNumber("Operand1: ");
@operator = InputHelper.ReadString("Operator: ");
operand2 = InputHelper.ReadNumber("Operand2: ");


float result = CalculationWorker.Calculate(operand1, operand2, @operator);
Console.WriteLine($"Result = {result}");