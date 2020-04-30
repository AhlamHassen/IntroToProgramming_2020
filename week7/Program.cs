using System;

namespace week7
{
    class Program
    {
        static void Main(string[] args)
        {
             //Task1
             welcome(); 
             
             //Task2
             welcome2("John"); 

             //Task3
             int ans = SumofNums(15 ,16);
             Console.WriteLine("The sum of two numbers is: " + ans); 

             //Task4
             CountSpace("This is a test string");

            //Task5
            SumofArrayElements(5,7,3,2,9);

            //Task6
            swap(5,6);

            //Task7
            power(3, 2);

            //Task8
            fibonacci(5);

            //Task9
            prime(31);

            //Task10
            SumOfIndividulaNum(1234);

             /*Optional Tasks*/
            //Task11 Non-recursive Function
            factorial(5); 

            //Task11 Recursive Function
            int answer = factorialRecursive(5);
            Console.WriteLine("The factorial of the number is " +answer);

            //Task12 Non-recursive Function
            fibonacciTerm(10);

            //Task12 Recursive Function
            int value = FibTermRecursive(10);
            Console.WriteLine("The Fibonacci of this term is " + value);

        }

        //Task1
        static void welcome()
        {
            Console.WriteLine("Welcome Friends!");
            Console.WriteLine("Have a nice!");
        }

        //Task2
        static void welcome2(string name)
        {
            Console.WriteLine("Welcome Friend " + name + " !");
            Console.WriteLine("Have a nice day!");
        }

        //Task3
        static int SumofNums(int num1, int num2)
        {
            int ans = num1 + num2;
            return ans;
        }

        //Task4
        static void CountSpace(string input)
        {
            int count = input.Split(' ').Length;
            int ans = count - 1;
            Console.WriteLine("'" + input + "' " + "contains " + ans + " spaces");
        }

        //Task5
        static void SumofArrayElements(int e1, int e2, int e3, int e4, int e5)
        {
            int[] arr = { e1, e2, e3, e4, e5 };
            int text = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                text += arr[i];
            }
            int sum = text;
            Console.WriteLine("The sum of the elements of the array is " + sum);
        }

        //Task6
        static void swap(int num1, int num2)
        {
            Console.WriteLine("Now the 1st number is: " + num2 + " ,and the 2nd number is: " + num1);
        }

        //Task7
        static void power(int basenum, int power)
        {
            double expo = Math.Pow(basenum, power);
            Console.WriteLine("So, the number " + basenum + " ^(to the power) " + power + " = " + expo);
        }

        //Task8
        static void fibonacci(int num)
        {
            int n1 = 0, n2 = 1, i, n3;
            Console.Write(n1 + " " + n2 + " ");
            for (i = 2; i < num; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
            Console.WriteLine();
        }

        //Task9
        static void prime(int num)
        {
            int i, counter = 0, number = num;
            for (i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    counter++;
                }
            }
            if (counter > 2)
            {
                Console.WriteLine(num + " is not a prime number");
            }
            else
            {
                Console.WriteLine(num + " is a prime number");
            }
        }

        //Task10
        static void SumOfIndividulaNum(int num)
        {   int input = num;
            int a, sum = 0;
            while (num != 0)
            {
                a = num % 10;
                sum = sum + a;
                num = num / 10;
            }
            Console.WriteLine("The sum of the digits of the number "+ input + " is: "+sum);
        }

        /*Optional Tasks*/
        //Task11 non-recursive funtion
        static void factorial(int num)
        {
            int i, factoriall = 1;

            for (i = 1; i <= num; i++)
            {
                factoriall = factoriall * i;
            }

            Console.WriteLine("The factorial of " + num + "! is " +factoriall);

        }

        //Task11 Recursive function
        static int factorialRecursive(int num)
        {
            if (num == 1)
                return 1;

            return num * factorialRecursive(num - 1);
        }

        //Task12 Non-Recursive function
        static void fibonacciTerm(int num)
        {
            int n1 = 0, n2 = 1, i, n3, flen;
            int[] Fseries = new int[num + 1];
            Fseries[0] = n1;
            Fseries[1] = n2;
            flen = Fseries.Length;
            for (i = 2; i < flen; i++)
            {
                n3 = n2 + n1;
                Fseries[i] = n3;
                n1 = n2;
                n2 = n3;
            }
            Console.WriteLine("The Fibonacci of " + num + " th term is " + Fseries[num]);

        }
        
        //Task12 Recursive function
        static int FibTermRecursive(int num)
        {
            if (num <= 1)
                return num;

            return FibTermRecursive(num - 1) + FibTermRecursive(num - 2);
        }

    }

}
