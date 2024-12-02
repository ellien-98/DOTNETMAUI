﻿using System.Collections;

namespace Exercise1_12
{
    class Program
    {
        static void Main(string[] args)
        {

			//string[] menuOptions = {"Potatoes with Cheddar", "Mushroom Risotto", "Pizza", "Press 0 to exit" };
			ArrayList menuOptions = new ArrayList() {"Potatoes with Cheddar", "Mushroom Risotto", "Pizza", "Press 0 to exit" };
            Console.WriteLine($"Please select your dish");
			for (int i = 0; i < menuOptions.Count; i++)
        	{
            	Console.WriteLine($"{i + 1} --> {menuOptions[i]}");
        	}
			// Console.WriteLine("Please select a food option:");
			string menuChoice = Console.ReadLine();
			switch (menuChoice)
    		{
        		case "1":
            		Console.WriteLine($"Your selection: {menuOptions[0]}");
            		break;
        		case "2":
            		Console.WriteLine($"Your selection: {menuOptions[1]}");
            		break;
        		case "3":
            		Console.WriteLine($"Your selection: {menuOptions[2]}");
            		break;
        		case "0":
            		Console.WriteLine("Exiting the program.");
            		break;
        		default:
            		Console.WriteLine("Wrong selection!");
            		break;
    		}
        }
    }
}