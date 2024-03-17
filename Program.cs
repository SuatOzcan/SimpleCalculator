namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float first = GetUserInput1();
            float second = GetUserInput2();
            char selection = SelectMathematicalOperation();
            float result = PerformMathematicalOperation(selection, first, second );
            Console.WriteLine(result);
            Console.WriteLine("Press any key to close the application.");
            Console.ReadKey();
        }

        private static float PerformMathematicalOperation(char c, float first, float second)
        {
            if(c == 'a')
            {
                return Add(first, second);
            }
            else if(c == 's')
            {
                return Subtract(first, second);
            }
            else if(c == 'm')
            {
                return Multiply(first, second);
            }
            else if(c == 'd')
            {
                return Divide(first, second);
            }
            else
            {
                return -1;
            }
        }

        private static float Divide(float first, float second)
        {
            return first / second;
        }

        private static float Multiply(float first, float second)
        {
            return first * second;
        }

        private static float Subtract(float first, float second)
        {
            return first - second;
        }

        private static float Add(float first, float second)
        {
            return first + second;
        }

        private static char SelectMathematicalOperation()
        {
            char userCharChoice = ConvertUserInputStringToChar();

            if (userCharChoice == 'a' || userCharChoice == 's' || userCharChoice == 'm' ||
                userCharChoice == 'd')
            {
                return userCharChoice;
            }
            else
            {
                return SelectMathematicalOperation();
            }
        }

        private static char ConvertUserInputStringToChar()
        {
            Console.WriteLine("Please type a for [a]ddition, s for [s]ubtraction,\n " +
                            "m for [m]ultiplication, d for [d]ivision. ");

            string userOperationChoice = Console.ReadLine();
            if (userOperationChoice.Length > 0)
            {
                char userCharChoice = userOperationChoice.ElementAt(0);
                return userCharChoice;
            }
            else
            {
                return ConvertUserInputStringToChar();
            }
        }

        private static float GetUserInput1()
        {
            Console.WriteLine("Please input a whole number.");
            string inputStringNumber1 = Console.ReadLine();
            bool check = float.TryParse(inputStringNumber1, out float inputNumber1);
            if (check)
                return inputNumber1;
            else
                return GetUserInput1();
        }
        private static float GetUserInput2()
        {
            Console.WriteLine("Please input the second whole number.");
            string inputStringNumber2 = Console.ReadLine();
            bool check = float.TryParse(inputStringNumber2, out float inputNumber2);
            if (check)
                return inputNumber2;
            else
                return GetUserInput2();
        }
    }
}