using MathGame.Shared;
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

    private static void Welcome()
    {
        ConsoleExtensions.WriteLineWordByWord("Hello");
    }

    private static GameOptions GetGameOption() =>
        AnsiConsole.Prompt(new SelectionPrompt<GameOptions>()
            .Title("[wheat1]Choose a [lightcoral][bold]game option[/][/][/]")
            .AddChoices(Enum.GetValues<GameOptions>()));

    public void MainMenu()
    {
        Welcome();

        while (true)
        {
            switch (GetGameOption())
            {
                case GameOptions.Addition:
                case GameOptions.Subtraction:
                case GameOptions.Multiplication:
                case GameOptions.Division:
                case GameOptions.Exit:
                    AnsiConsole.WriteLine("[lightcoral]Goodbye![/]");
                    return;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}