
internal class InputHelper
{
    internal static float ReadNumber(string prompt)
    {
        string input = "";
        float number;
        do
        {
            Console.Write(prompt);
            input = Console.ReadLine();

        } while (!float.TryParse(input, out number));

        return number;
    }

    internal static char ReadOperator(string prompt)
    {
        char[] operators = { '+', '-', '*', '/', '%' };
        char input;
        do
        {
            Console.Write(prompt);
            input = Console.ReadKey().KeyChar;
        } while (!operators.Contains(input));
        

        return input;
    }
}