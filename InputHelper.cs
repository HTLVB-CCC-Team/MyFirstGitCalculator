
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

        } while (float.TryParse(input, out number));

        return number;
    }

    internal static string ReadString(string prompt)
    {
        // TODO ReadString
        throw new NotImplementedException();
    }
}