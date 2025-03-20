namespace MathGame.Shared;

public static class ConsoleExtensions
{
    public static async Task WriteLineWordByWord(string line, int speed = 100, ConsoleColor color = ConsoleColor.White)
    {
        Console.ForegroundColor = color;
        foreach (var character in line)
        {
            Console.Write(character);
            await Task.Delay(speed);
        }

        Console.WriteLine();

        Console.ResetColor();
    }
}