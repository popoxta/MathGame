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

    private static async Task Welcome()
    {
        await ConsoleExtensions.WriteLineWordByWord("Hello!");
        await ConsoleExtensions.WriteLineWordByWord("Welcome to the Interplanetary Math Game!", 80);
    }

    private static GameOptions GetGameOption() =>
        AnsiConsole.Prompt(new SelectionPrompt<GameOptions>()
            .Title("[wheat1]Please choose a [lightcoral][bold]game option[/][/][/]")
            .AddChoices(Enum.GetValues<GameOptions>()));

    private static void PressEnterToContinue()
    {
        AnsiConsole.MarkupLine("[lightskyblue1]Press any key to continue...[/]");
        Console.ReadKey();
        Console.Clear();
    }

    public async Task MainMenu()
    {
        await Welcome();
        PressEnterToContinue();

        while (true)
        {
            switch (GetGameOption())
            {
                case GameOptions.Addition:
                case GameOptions.Subtraction:
                case GameOptions.Multiplication:
                case GameOptions.Division:
                case GameOptions.Exit:
                    AnsiConsole.MarkupLine("[lightcoral]Goodbye![/]");
                    return;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}