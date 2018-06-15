using System;
using System.Linq;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		string[] colors = { "orange", "blue", "yellow", "purple", "green", "red" };
		
		// var sixLetterColors = from color in colors
        //                       where color.Count() == 6
        //                       where color != "purple"
        //                       select color.First();

        // var anotherSixLetterColors = colors
        //                               .Where(color => color.Count() == 6 && color != "purple")
        //                               .Select(color => color.First());


        // foreach (var color in sixLetterColors)
        // {
        //     Console.WriteLine(color);
        // }

        string[] colors2 = colors;

        colors[0] = "hello";
        colors2[1] = "world";
	
        Console.WriteLine("Hello World");
		
	}
}
