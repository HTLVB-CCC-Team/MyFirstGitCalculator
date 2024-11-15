

Console.WriteLine("MyFirstGitCalculator!");


float operand1;
float operand2;
string @operator;

Console.Write("Operand1: ");
operand1 = InputHelper.ReadNumber();

Console.Write("Operator: ");
@operator = InputHelper.ReadString();

Console.Write("Operand2: ");
operand2 = InputHelper.ReadNumber();


float result = CalculationWorker.Calculate(operand1, operand2, @operator);
Console.WriteLine($"Result = {result}");