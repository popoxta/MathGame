using Spectre.Console;

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
        AnsiConsole.MarkupLine("Welcome to the interplanetary Maths Quiz!");
    }
    
}