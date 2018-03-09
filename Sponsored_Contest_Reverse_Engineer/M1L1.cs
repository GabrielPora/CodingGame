using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Player
{
    static void Main(string[] args)
    {
        int firstInitInput = int.Parse(Console.ReadLine());
        int secondInitInput = int.Parse(Console.ReadLine());
        int thirdInitInput = int.Parse(Console.ReadLine());

        // game loop
        while (true)
        {
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();
            string thirdInput = Console.ReadLine();
            string fourthInput = Console.ReadLine();
            for (int i = 0; i < thirdInitInput; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int fifthInput = int.Parse(inputs[0]);
                int sixthInput = int.Parse(inputs[1]);
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
            // Console.Error.WriteLine("Debug messages...");
            Console.WriteLine("A");
            Console.WriteLine("B");
            Console.WriteLine("B");
            Console.WriteLine("C");
            Console.WriteLine("C");
            Console.WriteLine("D");
            Console.WriteLine("E");
            Console.WriteLine("E");
            Console.WriteLine("E");
            Console.WriteLine("B");
            // Console.WriteLine("The first input is: {0}" , firstInitInput);
            // Console.WriteLine("The second input is: {0}" , secondInitInput);
            // Console.WriteLine("The third input is: {0}" , thirdInitInput);

            // Console.WriteLine("A, B, C, D or E");
        }
    }
}