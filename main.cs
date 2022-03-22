using System;

class Program {
  public static void Main (string[] args) {
		Console.WriteLine("Remastering C# Basics ");
		Console.WriteLine("================================\n\n");
		int num = 12, num2 = 13, num5 = -5, total = num +num2;
		int cal1 = num5 + num * num2, cal2 = (num + num5)%num2;
		double num3 = 15, num4 = 3;
		double divide = num3 /num4;
		//Display hello world and my name
		Console.WriteLine("Hello World: \nDuduzile January\n");
		//display the sum of two numbers
		Console.WriteLine("Sum of two numbers:");
		Console.WriteLine("{0} + {1} = {2}\n",num, num2,total);
		//display result of dividing two numbers
		Console.WriteLine("Division of two numbers:");
		Console.WriteLine("{0} / {1} = {2}\n", num3, num4, divide); 
		//displays the results of specified operations
		Console.WriteLine("Long calculations:");
		Console.WriteLine("{0} + {1} * {2} = {3}", num5,num,num2, cal1);
		Console.WriteLine("( " + num + " + " + num5 + " )" + "% " + num2 + " = " + cal2);
		
  }
}
