using MathGame.Shared;

namespace MathGame;

public class UserInterface
{
    private enum GameOptions
    {
        Addition,
        Subtraction,
        Multiplication,
        Division,
        Exit
    }

    public void Welcome()
    {
        ConsoleExtensions.WriteLineWordByWord("Hello");
    }
}