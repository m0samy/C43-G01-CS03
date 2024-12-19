namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Console.WriteLine("Please Enter the number : ");
            string num = Console.ReadLine();
            Console.WriteLine(num);
            #endregion

            #region Q2
            string str = "252AB";
            int result = int.Parse(str);
            Console.WriteLine(result);
            #endregion

            #region Q3
            float num1 = 2.7f;
            float num2 = 2.5f;
            float sum = num1 + num2;
            Console.WriteLine(sum);
            #endregion

            #region Q4   
            //0123456
            string str = "Mohamed";
            string subString = str.Substring(1, 3); //oha
            Console.WriteLine(subString);
            #endregion

            #region Q5
            int x = 1;
            int y = 2;
            x = y; // x = 2 , y = 2
            x = 4; // x = 4 , y = 2
            Console.WriteLine($"X = {x} , Y = {y}");
            #endregion

            #region Q6
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = arr1;
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            arr2[0] = 6;
            Console.WriteLine($"Array1 = {arr1[0]} , Array2 = {arr2[0]}");
            #endregion

            #region Q7
            string str1 = "Mohaemd";
            string str2 = "Samy";
            Console.WriteLine($"{str1} {str2}");
            #endregion

            #region Q8
            double principal = 10;
            double rate = 10;
            double time = 10;
            double interest = (principal * rate * time) / 100;
            Console.WriteLine($"Interest = {interest}");
            #endregion

            #region Q9
            double Weight = 70;
            double Height = 1.7;
            double BMI = (Weight) / (Height * Height);
            Console.WriteLine($"BMI = {BMI}");
            #endregion

            #region Q10
            double temp = 25.0;
            string message = temp < 10 ? "Just Cold" : temp > 30 ? "Just Hot" : "Just Good";
            Console.WriteLine(message);
            #endregion

            #region Q11
            DateTime DT = DateTime.Now;
            string Format1 = $"Date : {DT: dd , MM , yyyy}";
            string Format2 = $"Date : {DT: dd / MM / yyyy}";
            string Format3 = $"Date : {DT: dd - MM - yyyy}";
            Console.WriteLine(Format1);
            Console.WriteLine(Format2);
            Console.WriteLine(Format3);

            Or Solution

            Console.WriteLine("Enter the day: ");
            string day = Console.ReadLine();

            Console.WriteLine("Enter the month: ");
            string month = Console.ReadLine();

            Console.WriteLine("Enter the year: ");
            string year = Console.ReadLine();

            Console.WriteLine($"Today's date: {day} , {month} , {year}");
            Console.WriteLine($"Today's date: {day} / {month} / {year}");
            Console.WriteLine($"Today's date: {day} – {month} – {year}");
            #endregion

            #region Q12
            Console.WriteLine("Enter the number :");
            int num = int.Parse(Console.ReadLine());
            if (num % 3 == 0 && num % 4 == 0)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            #endregion

            #region Q13
            Console.WriteLine("Enter the number :");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("the number is positive");
            }
            else if (num < 0)
            {
                Console.WriteLine("the number is negative");
            }
            #endregion

            #region Q14
            Console.WriteLine("Enter the 3 numbers :");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                if (num2 > num3)
                {
                    Console.WriteLine($"the max number = {num1}");
                    Console.WriteLine($"the min number = {num3}");
                }
                else
                {
                    Console.WriteLine($"the max number = {num1}");
                    Console.WriteLine($"the min number = {num2}");
                }
            }
            else if (num2 > num1 && num2 > num3)
            {
                if (num1 > num3)
                {
                    Console.WriteLine($"the max number = {num2}");
                    Console.WriteLine($"the min number = {num3}");
                }
                else
                {
                    Console.WriteLine($"the max number = {num2}");
                    Console.WriteLine($"the min number = {num1}");
                }
            }
            else if (num3 > num1 && num3 > num2)
            {
                if (num1 > num2)
                {
                    Console.WriteLine($"the max number = {num3}");
                    Console.WriteLine($"the min number = {num2}");
                }
                else
                {
                    Console.WriteLine($"the max number = {num3}");
                    Console.WriteLine($"the min number = {num1}");
                }
            }

            #endregion

            #region Q15
            Console.WriteLine("Enter the number :");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("the number is even");
            }
            else
            {
                Console.WriteLine("the number is odd");
            }
            #endregion

            #region Q16
            Console.WriteLine("Enter the character :");
            char ch = char.Parse(Console.ReadLine().ToLower());

            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Consonant");
                    break;
            }

            #endregion

            #region Q17
            Console.Write("Enter the month number (1-12): ");
            int month = int.Parse(Console.ReadLine());

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("31");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("30");
                    break;
                case 2:
                    Console.WriteLine("29");
                    break;

            }
            #endregion

            #region Q18
            double num1, num2, result;
            string operation;

            Console.WriteLine("Simple Calculator");
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");

            Console.Write("Enter the operation (1, 2, 3, 4): ");
            operation = Console.ReadLine();

            Console.Write("Enter the first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            switch (operation)
            {
                case "1": // Addition
                    result = num1 + num2;
                    Console.WriteLine($"Result: {num1} + {num2} = {result}");
                    break;
                case "2": // Subtraction
                    result = num1 - num2;
                    Console.WriteLine($"Result: {num1} - {num2} = {result}");
                    break;
                case "3": // Multiplication
                    result = num1 * num2;
                    Console.WriteLine($"Result: {num1} * {num2} = {result}");
                    break;
                case "4": // Division
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Result: {num1} / {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation selected.");
                    break;
            }

            #endregion

            #region Q19
            Console.WriteLine("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"Numbers from 1 to {number}:");
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i + " ");
            }

            #endregion

            #region Q20
            Console.WriteLine("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"Multiplication Table for {number}:");
            for (int i = 1; i <= 12; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} x {i} = {result}");
            }
            #endregion

            #region Q21
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"Even numbers between 1 and {number}:");

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " ");
                }
            }
            #endregion

            #region Q22
            Console.Write("Enter the base number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the exponent: ");
            int num2 = int.Parse(Console.ReadLine());

            double result = Math.Pow(num1, num2);

            Console.WriteLine($"{num1} power {num2} is: {result}");
            #endregion

            #region Q23
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int reversedNumber = 0;

            while (number != 0)
            {
                int digit = number % 10;
                reversedNumber = reversedNumber * 10 + digit;
                number /= 10;
            }

            Console.WriteLine($"Reversed number is: {reversedNumber}");
            #endregion

            #region Q24
            Console.Write("Enter the starting number of the range: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter the ending number of the range: ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine($"Prime numbers between {start} and {end}:");

            for (int num = start; num <= end; num++)
            {
                if (num < 2) continue;

                bool isPrime = true;

                for (int i = 2; i * i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.Write(num + " ");
                }
            }
            #endregion

            #region Q25
            Console.Write("Enter a decimal number: ");
            int decimalNumber = int.Parse(Console.ReadLine());

            string binaryNumber = "";

            if (decimalNumber == 0)
            {
                binaryNumber = "0";
            }
            else
            {
                while (decimalNumber > 0)
                {
                    int remainder = decimalNumber % 2;

                    binaryNumber = remainder.ToString() + binaryNumber;

                    decimalNumber /= 2;
                }
            }

            Console.WriteLine($"Binary representation: {binaryNumber}");
            #endregion

            #region Q26
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] numbers = new int[size];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine($"The sum of all elements in the array is: {sum}");
            #endregion


        }
    }
}
