using System;

namespace Calculator
{
    public class Program {


        static void Main(string[] args)
        {
            int choise;
            Numbers numbers;
            do
            {
                Console.WriteLine("Gör ditt val");
                Console.WriteLine("1) Addition");
                Console.WriteLine("2) Subtraktion");
                Console.WriteLine("3) Multiplikation");
                Console.WriteLine("4) Division");
                Console.WriteLine("0) Avsluta");

                try
                {
                    choise = int.Parse(Console.ReadLine());
                }
                catch
                {
                    choise = 5;
                    Console.WriteLine("Nu har du gjort något fel.");
                }
                switch (choise)
                {
                    case 1:
                        numbers = ReadNumbers("Du valde addition. Skriv in två tal som du vill addera. Talen skall skrivas med mellanslag emellan dem.");
                        Console.WriteLine("Summan av talen är: " + Add(numbers));
                        break;
                    case 2:
                        numbers = ReadNumbers("Du valde subtraction. Skriv in två tal som du vill subtrahera. Talen skall skrivas med mellanslag emellan dem.");
                        Console.WriteLine("Differnsen av talen är: " + Subtract(numbers));
                        break;
                    case 3:
                        numbers = ReadNumbers("Du valde multiplikation. Skriv in två tal som du vill multiplicera. Talen skall skrivas med mellanslag emellan dem.");
                        Console.WriteLine("Produkten av talen är: " + Multiply(numbers));
                        break;
                    case 4:
                        numbers = ReadNumbers("Du valde division. Skriv in två tal som du vill dividera. Talen skall skrivas med mellanslag emellan dem.");
                        Console.WriteLine("Kvoten av talen är: " + Divide(numbers));                                          
                        break;
                    default:                        
                        break;


                }
            } while (choise != 0);
        }

        public struct Numbers
        {
            public double number1;
            public double number2;
        }

        public static Numbers ReadNumbers(string instructions)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(instructions);
                    string[] array = Console.ReadLine().Split(' ');
                    Numbers numbers = new Numbers();
                    numbers.number1 = double.Parse(array[0]);
                    numbers.number2 = double.Parse(array[1]);
                    return numbers;
                }
                catch
                {
                    Console.WriteLine("Felaktig indata!");
                }
            }
        }
        public static double Add(Numbers numbers)
        {
            return numbers.number1 + numbers.number2;

        }

        public static double Add(double[] numbers)
        {
            double result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            return result;
        }

        public static double Subtract(Numbers numbers)
        {
            return numbers.number1 - numbers.number2;
        }

        public static double Subtract(double[] numbers)
        {
            double result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result -= numbers[i];
            }
            return result;
        }
        public static double Multiply(Numbers numbers)
        {
            return numbers.number1 * numbers.number2;
        }

        public static double Divide(Numbers numbers)
        {
            if (numbers.number2 == 0)
            {
                Console.WriteLine("Nu dividerar du med noll!");
            }
            return numbers.number1 / numbers.number2;

        }
    }
}


