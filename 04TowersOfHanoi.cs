using System;
using System.Collections.Generic;

public class Program
{
    public static Dictionary<string, List<int>> stacks = new Dictionary<string, List<int>>()
    {
        { "a", new List<int>() {4, 3, 2, 1} },
        { "b", new List<int>() {} },
        { "c", new List<int>() {} }
    };
    
    public static void Main()
    {
        printStacks();
        // Your code here
    }
    
    public static bool GameOver() {
        // Your code here;
        return false;
    }
    
    public static void movePiece(string start, string finish) {
        // Your code here
    }
    
    public static bool isLegal(string start, string finish) {
        // Your code here
        return false;
    }
    
    public static void printStacks ()
    {
        string[] letters = new string[] {"a", "b", "c"};
        for( var i = 0; i < letters.Length; i++ )
        {
            List<string> blocks = new List<string>();
            for( var j = 0; j < stacks[letters[i]].Count; j++ )
            {
                blocks.Add(stacks[letters[i]][j].ToString());
            }
            Console.WriteLine(letters[i] + ": " + String.Join("|", blocks));	
        }
    }
}
