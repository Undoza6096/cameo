using System;
using System.Linq;
using System.Collections.Generic;

namespace HelloWold
{
    public static class Program 
    {         
        public static void Main()
        {
        	string type = "Normal";
        	int outerKill = 1;
        	
            Console.WriteLine("Hello Cameo (" + type + ")");
            Console.WriteLine("Adjust Number:");
            int adjustNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Get Adjust:" + adjustNumber);
            
            Console.WriteLine("Level 1");
            Console.WriteLine("trademark []");
            
            // At Written of here.
            string check1 = Console.ReadLine();
            
            if (check1 == "2")
            {
            	Console.WriteLine("Level 2");
            	Console.WriteLine("Completed: trademark [" + check1 + "]");
            	Console.WriteLine("Lang: Typescript");
            	Console.WriteLine("let a = ");
            }
            
            // Level 2 Input
            string check2 = Console.ReadLine();
            
            if (check2 == "128")
            {
            	Console.WriteLine("Level 3");
            	Console.WriteLine("Completed: let a = " + check2);
            	Console.WriteLine("Lang: Python");
            	Console.WriteLine("print()");
            }
            
            // Level 3 Input
            string check3 = Console.ReadLine();
            
            if (check3 == "72 + 2")
            {
            	Console.WriteLine("Level 4");
            	Console.WriteLine("Completed: print(" + check3 + ")");
            	Console.WriteLine("Lang: Text");
            	Console.WriteLine("HTML5 + ");
            }
            
            // Level 4 Input
            string check4 = Console.ReadLine();
            
            if (check4 == "Vue")
            {
            	Console.WriteLine("Level 5");
            	Console.WriteLine("Completed: HTML5 + " + check4);
            	Console.WriteLine("Lang: Text (Exist!)");
            	
            	// While of based underline.
            	Console.WriteLine("Under");
            }
            
            // About maxium the 2 digit number of line to big text long.
            // Level 5 Input
            string check5 = Console.ReadLine();
            
            if (check5 == "line")
            {
            	Console.WriteLine("Level 6");
            	Console.WriteLine("Completed: Under" + check5);
            	Console.WriteLine("Lang: Typescript");
            	Console.WriteLine("var i = ");
            }
            
            // About Android about full y with android more height.
            // Level 6 Input
            string check6 = Console.ReadLine();
            
            if (check6 == "36")
            {
            	Console.WriteLine("Level 7");
            	Console.WriteLine("Completed: var i = " + check6);
            	Console.WriteLine("Lang: Text");
            	Console.WriteLine("Hello % ");
            }
            
            // Level 7 Input
            string check7 = Console.ReadLine();
            
            if (check7 == "11")
            {
            	Console.WriteLine("Level 8");
            	Console.WriteLine("Completed: Hello % " + check7);
            	Console.WriteLine("Lang: Typescript");
            	Console.WriteLine("let outed = ");
            }
            
            // Level 8 Input
            string check8 = Console.ReadLine();
            
            if (check8 == "2 / 3")
            {
            	Console.WriteLine("Level 9");
            	Console.WriteLine("Completed: let outed = " + check8);
            	Console.WriteLine("Lang: Typescript (Exist!)");
            	Console.WriteLine("var j = 0");
            }
            
            // About Fixes of I Pad.
            // Level 9 Input
            string check9 = Console.ReadLine();
            
            if (check9 == "3 * 4")
            {
            	Console.WriteLine("Level 10");
            	Console.WriteLine("Completed: var j = " + check9);
            	Console.WriteLine("Lang: Text");
            	Console.WriteLine("G()");
            }
            
            // Level 10 Input
            string check10 = Console.ReadLine();
            
            if (check10 == "7")
            {
            	Console.WriteLine("You Win!");
            }
        }
    }
}