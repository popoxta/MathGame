﻿namespace MathGame.Shared;

public static class ConsoleExtensions
{
    public static void WriteLineWordByWord(string line, int speed = 100, ConsoleColor color = ConsoleColor.White)
    {
        Console.ForegroundColor = color;
        foreach (var character in line)
        {
            Console.Write(character);
            Thread.Sleep(speed);
        }

        Console.ResetColor();
    }
}