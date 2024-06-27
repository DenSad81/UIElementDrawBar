using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        DrawBar(30, colorOfActivBar: ConsoleColor.Red, posCursorY: 1);
        DrawBar(50, colorOfActivBar: ConsoleColor.Green, posCursorY: 3);
    }

    static void DrawBar(int persentsOfFill, int lenghtOfBar = 10, char signOfActivBar = '#', char signOPpasivBar = '_', ConsoleColor colorOfActivBar = ConsoleColor.Green, int posCursorX = 0, int posCursorY = 0)
    {
        char signOfBeginOfBar = '[';
        char signOfEndOfBar = ']';
        int hungretPersents = 100;

        Console.SetCursorPosition(posCursorX, posCursorY);
        ConsoleColor memoryOfColor = Console.BackgroundColor;
        Console.BackgroundColor = colorOfActivBar;
        Console.Write(signOfBeginOfBar);

        persentsOfFill = (persentsOfFill * lenghtOfBar) / hungretPersents;

        if (persentsOfFill > lenghtOfBar)
            persentsOfFill = lenghtOfBar;

        Filling(0, persentsOfFill, signOfActivBar);
        Console.BackgroundColor = memoryOfColor;
        Filling(persentsOfFill, lenghtOfBar, signOPpasivBar);

        Console.Write(signOfEndOfBar);
        Console.WriteLine();
    }

    static void Filling(int start, int finish, char simbol)
    {
        for (int i = start; i < finish; i++)
            Console.Write(simbol);
    }
}