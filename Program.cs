using System;
using System.Collections.Generic;

namespace FirstConsoleProject
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//BASIC CALCULATOR
			//Reading in a number
			//Console.Write("Enter a number\n");
			//int num01;
			//num01 = Convert.ToInt32(Console.ReadLine());
			//Console.Write("Enter another number\n");
			//int num02 = Convert.ToInt32(Console.ReadLine());
			//Printing num1 + num 2
			//Console.Write("\nThe answer is: " + (num01 + num02));



			//IF STATEMENTS
			//Console.Write("How old are you\n");
			//int age = Convert.ToInt32(Console.ReadLine());
			//if (age >= 18)
			//{
			//	Console.WriteLine("You are an adult");
			//}
			//else
			//{
			//	Console.WriteLine("You are not an adult");
			//}


			//FOR LOOPS
			//for (int i = 0; i < 10; i++)
			//{
			//	Console.WriteLine("Example of a For Loop");
			//}


			//WHILE LOOPS
			//int i = 1;
			//while (i != 10)
			//{
			//	Console.WriteLine(i);
			//	i++;
			//}

			//METHOD CALLS
			//thisIsAMethod();


			//ARRAYS
			//int[] arrayExample = new int[10];
			//for (int i = 0; i < arrayExample.Length; i++){
			//	arrayExample[i] = i;
			//}
			//for (int i = 0; i < arrayExample.Length; i++)
			//{
			//	Console.WriteLine(arrayExample[i]);
			//}


			//LISTS
			//List<int> numbers = new List<int>();
			//numbers.Add(1);
			//numbers.Add(7);
			//numbers.Add(14);
			//Console.WriteLine(numbers[1]);

			createGrid();

		}
		public static void thisIsAMethod()
		{
			Console.WriteLine("This is a method");
		}

		public static void createGrid()
		{
			int width = 5;
			int height = 5;

			int[,] grid = new int[width, height];
			grid[2, 3] = 10;
			for (int x = 0; x < width; x++)
			{
				for (int y = 0; y < height; y++)
				{
					Console.Write(grid[x, y] + " ");
				}
				Console.WriteLine();
			}
		}
	}
}
