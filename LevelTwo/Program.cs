using System;
using Spectre.Console;

namespace LevelTwo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CanvasImage image = new CanvasImage("tux.jpg");
            image.MaxWidth(40);
            AnsiConsole.Write(image);
        }
    }
}
