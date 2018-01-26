using System;

public class Program
{
    // possible letters in code
    public static char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
    
    // size of code
    public static int codeSize = 4;
    
    // number of allowed attempts to crack the code
    public static int allowedAttempts = 10;
    
    // number of tried guesses
    public static int numTry = 0;
    
    // test solution
    public static char[] solution = new char[] {'a', 'b', 'c', 'd'};
    
    // game board
    public static string[][] board = new string[allowedAttempts][];
    
    
    public static void Main()
    {
        char[] guess = new char[4];

        CreateBoard();
        DrawBoard();
        Console.WriteLine("Enter Guess:");
        guess = Console.ReadLine().ToCharArray();

        // leave this command at the end so your program does not close automatically
        Console.ReadLine();
    }
    
    public static bool CheckSolution(char[] guess)
    {
        // Your code here

        return false;
    }
    
    public static string GenerateHint(char[] guess)
    {
        // Your code here
        return " ";
    }
    
    public static void InsertCode(char[] guess)
    {
        // Your code here
    }
    
    public static void CreateBoard()
    {
        for (var i = 0; i < allowedAttempts; i++)
        {
            board[i] = new string[codeSize + 1];
            for (var j = 0; j < codeSize + 1; j++)
            {
                board[i][j] = " ";
            }
        }
    }
    
    public static void DrawBoard()
    {
        for (var i = 0; i < board.Length; i++)
        {
            Console.WriteLine("|" + String.Join("|", board[i]));
        }
        
    }
    
    public static void GenerateRandomCode() {
        Random rnd = new Random();
        for(var i = 0; i < codeSize; i++)
        {
            solution[i] = letters[rnd.Next(0, letters.Length)];
        }
    }
}