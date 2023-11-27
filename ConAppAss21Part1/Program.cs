using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAss21Part1
{
    delegate int ArithmeticOperation(int num1, int num2);

    public class Program
    {
        static int Add(int a, int b) => a + b;
        static int Subtract(int a, int b) => a - b;
        static int Multiply(int a, int b) => a * b;
        static int Divide(int a, int b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                Console.WriteLine("Cannot divide by zero. Returning 0.");
                return 0;
            }
        }
        public static void Main(string[] args)
        {
            ArithmeticOperation addDelegate = Add;
            ArithmeticOperation subtractDelegate = Subtract;
            ArithmeticOperation multiplyDelegate = Multiply;
            ArithmeticOperation divideDelegate = Divide;
            Console.Write("Enter the first integer: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second integer: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose an arithmetic operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            int choice = int.Parse(Console.ReadLine());
            int result = 0;
            switch (choice)
            {
                case 1:
                    result = addDelegate(num1, num2);
                    break;
                case 2:
                    result = subtractDelegate(num1, num2);
                    break;
                case 3:
                    result = multiplyDelegate(num1, num2);
                    break;
                case 4:
                    result = divideDelegate(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose a number between 1 and 4.");
                    return;
            }
            Console.WriteLine($"Result: {result}");
            Console.ReadKey();
        }
    }
}
