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
		//swaps two entered numbers
    Console.WriteLine("\nSwap two entered numbers");
    //user enters their first number
    Console.Write("Enter the first number: ");
    int number1 = int.Parse(Console.ReadLine());
    //user enters their second number
    Console.Write("Enter the second number: ");
    int number2 = int.Parse(Console.ReadLine());
    Console.WriteLine("After swaping");
    //display swapped numbers
    Console.WriteLine("First number: {0}", number2);
    Console.WriteLine("Second number: {0}", number1);

    //display multiplications of three numbers entered by the user.
    Console.WriteLine("\nMultiplication of entered numbers");
    Console.Write("Input first number to multiply: ");
    int mul1 = int.Parse(Console.ReadLine());
    Console.Write("Input second number to multiply: ");
    int mul2 = int.Parse(Console.ReadLine());
    Console.Write("Enter third number to multiply: ");
    int mul3 = int.Parse(Console.ReadLine());
    int result = (mul1 * mul2 * mul3);
    Console.WriteLine("Results: \n{0} * {1} * {2} = {3}",mul1,mul2,mul3,result);

    //OUtput of adding, subtracting, multiplying and dividing two numbers entered by user.
    Console.WriteLine("\nSubtracting, Adding, Multiplying and Dividing Number.");
    Console.Write("Enter first number: ");
    int userNum1 = int.Parse(Console.ReadLine());
    Console.Write("Enter second number: ");
    int userNum2 = int.Parse(Console.ReadLine());

    //subtracting
    int subResult = userNum1 - userNum2;

    //adding
    int addResult = userNum1 + userNum2;
    //multiplying
    int mulResult = userNum1 * userNum2;
    //dividing
    int divResult = userNum1 /userNum2;

    //displaying subtracting calculation
    Console.WriteLine("{0} - {1} = {2}", userNum1, userNum2, subResult);
    //displaying adding calculation
    Console.WriteLine("{0} + {1} = {2}", userNum1, userNum2,addResult);

    //displaying multiplication calculation
    Console.WriteLine("{0} * {1} = {2}", userNum1, userNum2,mulResult);
//displaying division calculation
    Console.WriteLine("{0} / {1} = {2}", userNum1, userNum2,divResult);
  }
}
