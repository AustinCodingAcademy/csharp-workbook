using System;

public class Program
{
    public static string playerTurn = "X";
    public static string[][] board = new string[][]
        {
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "}
        };

    public static void Main()
    {
        // Enter code here
        DrawBoard();
        GetInput();

    }

    public static void GetInput()
    {
        Console.WriteLine("Player " + playerTurn);
        Console.WriteLine("Enter Row:");
        int row = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter Column:");
        int column = Int32.Parse(Console.ReadLine());
        // Enter code here
        return;
    }

    public static void PlaceMark(int row, int column)
    {
        // Enter code here
        return;
    }

    public static bool CheckForWin()
    {
        // Enter code here
        return false;
    }

    public static bool HorizontalWin()
    {
        // Enter code here
        return false;
    }

    public static bool VerticalWin()
    {
        // Enter code here
        return false;
    }

    public static bool DiagonalWin()
    {
        // Enter code here
        return false;
    }

    public static void DrawBoard()
    {
        Console.WriteLine("  0 1 2");
        Console.WriteLine("0 " + String.Join("|", board[0]));
        Console.WriteLine("  -----");
        Console.WriteLine("1 " + String.Join("|", board[1]));
        Console.WriteLine("  -----");
        Console.WriteLine("2 " + String.Join("|", board[2]));
        return;
    }
}
