using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // array of string

        string[] myArray = new string[2]; // index 0, 1

        myArray[0] = "Erik";
        myArray[1] = "Zambrano";

        for(var index = 0; index < myArray.Length; index++)
        {
            Console.WriteLine(myArray[index]);
        }


        int[,] myNumberArray = new int[1, 2];

        myNumberArray[0, 0] = 2345;
        myNumberArray[0, 1] = 6789;

        //for loop on two dimension


        List<string> myList = new List<string>();

        myList.Add("Erik");
        myList.Add("Zambrano"); //index 0, 1
        myList[0] = "Eric";

        for(var y =0; y < myList.Count; y++)
        {

        }


        Console.ReadLine();


    }
}
