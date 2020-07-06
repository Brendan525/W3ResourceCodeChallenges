using System;

namespace W3ResourceChallenges
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.Write("Write a C# Sharp program to print Hello and your name in a separate line."); // Question 1

            //Console.Write("\n");

            //string name;

            //Console.WriteLine("Enter your name");
            //name = Console.ReadLine();

            //Console.WriteLine($"Hello " + name);



            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //Console.Write("Write a C# Sharp program to print the sum of two numbers."); // Question 2

            //Console.Write("\n");

            //int num1, num2;

            //Console.WriteLine("Enter a number");
            //num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("\n");

            //Console.WriteLine("Enter another number");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("\n");

            //Console.WriteLine(num1 + num2);



            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //Console.Write("Write a C# Sharp program to print the result of dividing two numbers."); // Question 3

            //Console.Write("\n");

            //int num1, num2;

            //Console.WriteLine("Enter a number");
            //num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("\n");

            //Console.WriteLine("Enter another number");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("\n");

            //Console.WriteLine(num1 / num2);



            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //Console.Write("Write a C# Sharp program to print the result of the specified operations"); // Question 4

            //Console.Write("\n");

            //Console.WriteLine(-1 + (4 * 6));

            //Console.WriteLine((35 + 5) / 7);

            //Console.WriteLine(14 - 4 * 6 / 11 );

            //Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);



            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //int num1, num2, swap;

            //Console.Write("Write a C# Sharp program to swap two numbers"); // Question 5

            //Console.Write("\n");

            //Console.WriteLine("Enter the first number: ");
            //num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("\n");

            //Console.WriteLine("Enter the second number: ");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("\n");

            //swap = num1; // Swap(nothing) becomes num1
            //num1 = num2; // num1 becomes num2
            //num2 = swap; // num2 is equal to swap

            //Console.WriteLine(num1);
            //Console.WriteLine(num2);



            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //int num1, num2, num3;

            //Console.Write("Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user."); // Question 6

            //Console.Write("\n");

            //Console.WriteLine("Enter the first number: ");
            //num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("\n");

            //Console.WriteLine("Enter the second number: ");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("\n");

            //Console.WriteLine("Enter the third number: ");
            //num3 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("\n");

            //Console.WriteLine(num1 * num2 * num3);



            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //int num1, num2;

            //Console.Write("Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user"); // Question 7

            //Console.Write("\n");

            //Console.WriteLine("Enter the first number: ");
            //num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("\n");

            //Console.WriteLine("Enter the second number: ");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(num1 + num2);
            //Console.WriteLine(num1 - num2);
            //Console.WriteLine(num1 * num2);
            //Console.WriteLine(num1 / num2);



            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            int num;

            Console.Write("Write a C# Sharp program that takes a number as input and print its multiplication table"); // Question 8

            Console.Write("\n");

            Console.WriteLine("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");



            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine($"{num} * {i} = " + num * i);
                i++;
            }



        }
    }
}
