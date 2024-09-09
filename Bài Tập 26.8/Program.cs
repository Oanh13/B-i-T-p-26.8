using System;

namespace Bài_Tập_26._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bai_1();
            Bai_2();
            Bai_3();
            Bai_4();
            Bai_5();
            Bai_6();
            Bai_7();
            Bai_8();
            Bai_9();
            Bai_10();
        }
        static void Bai_1()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is an even number.");
            }
            else
            {
                Console.WriteLine($"{number} is an odd number.");
            }

        }

        static void Bai_2()
        {
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int largest;

            if (num1 > num2 && num1 > num3)
            {
                largest = num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                largest = num2;
            }
            else
            {
                largest = num3;
            }

            Console.WriteLine($"The largest number is: {largest}");
        }

        static void Bai_3()
        {
            Console.Write("Enter the X coordinate: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Y coordinate: ");
            int y = Convert.ToInt32(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine($"The point ({x}, {y}) lies in the First Quadrant.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"The point ({x}, {y}) lies in the Second Quadrant.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"The point ({x}, {y}) lies in the Third Quadrant.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine($"The point ({x}, {y}) lies in the Fourth Quadrant.");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine($"The point ({x}, {y}) lies on the Y axis.");
            }
            else if (y == 0 && x != 0)
            {
                Console.WriteLine($"The point ({x}, {y}) lies on the X axis.");
            }
            else
            {
                Console.WriteLine($"The point ({x}, {y}) is at the Origin.");
            }
        }

        static void Bai_4()
        {
            Console.Write("Enter the length of the first side: ");
            int side1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the length of the second side: ");
            int side2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the length of the third side: ");
            int side3 = Convert.ToInt32(Console.ReadLine());

            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("The triangle is Equilateral.");
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                Console.WriteLine("The triangle is Isosceles.");
            }
            else
            {
                Console.WriteLine("The triangle is Scalene.");
            }
        }
        static void Bai_5()
        {
            int sum = 0;
            double average;

            Console.WriteLine("Enter 10 numbers:");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Enter number {i}: ");
                int number = Convert.ToInt32(Console.ReadLine());
                sum += number;
            }

            average = sum / 10.0;

            Console.WriteLine($"Sum of the 10 numbers is: {sum}");
            Console.WriteLine($"Average of the 10 numbers is: {average}");
        }

        static void Bai_6()
        {
            Console.Write("Enter an integer to display its multiplication table: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Multiplication table of {number}:");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }
        
        static void Bai_7()
        {
            Console.WriteLine("Enter number to display a pattern triangles");
            int number = int.Parse(Console.ReadLine());
            int r_1 = 1;
            int r_2 = 1;
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(r_1 + " ");
                    r_1++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 1; i <= number; i++)
            {
                for (int j = i; j <= number + 1; j++)
                {
                    Console.Write(" ");
                }
                for (int g = 1; g <= i; g++)
                {
                    Console.Write(r_2 + " ");
                    r_2++;
                }
                Console.WriteLine();
            }
        }
        static void Bai_8()
        {
            Console.Write("Enter the number of terms for the Harmonic series: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double sum = 0.0;

            Console.WriteLine("Harmonic series:");
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"1/{i} ");
                sum += 1.0 / i;

                if (i < n)
                    Console.Write("+ ");
            }

            Console.WriteLine($"\nSum of the Harmonic series up to {n} terms is: {sum}");
        }
        static void Bai_9()
        {
            Console.Write("Enter the lower bound of the range: ");
            int lowerBound = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the upper bound of the range: ");
            int upperBound = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Perfect numbers between {lowerBound} and {upperBound}:");

            for (int num = lowerBound; num <= upperBound; num++)
            {
                int sum = 0;

                for (int i = 1; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        sum += i;
                    }
                }

                if (sum == num && num != 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
        static void Bai_10()
        {
            Console.Write("Enter a number to check if it is prime: ");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isPrime = true;

            if (number <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
        }
    }
}
