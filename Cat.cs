using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // ASCII Art Cat (4 orientations)
        string[] catArt = new string[]
        {
            @"
 /\_/\  
( o.o ) 
 > ^ < 
",
            @"
  > ^ < 
 ( o.o ) 
 /\_/\
",
            @"
 > ^ < 
( o.o ) 
 /\_/\
",
            @"
 /\_/\
 ( o.o ) 
  > ^ < 
"
        };

        int currentOrientation = 0;
        while (true)
        {
            Console.Clear();  // Clear the screen to make it look like spinning
            Console.WriteLine(catArt[currentOrientation]);
            currentOrientation = (currentOrientation + 1) % catArt.Length; // Rotate through 4 orientations
            Thread.Sleep(500); // Wait for 500ms before rotating again
        }
    }
}
