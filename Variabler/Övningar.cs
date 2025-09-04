class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nVälj en övning:" +
                "\n1. Hälsa på användaren" +
                "\n2. Multiplicera två tal" +
                "\n3. Verifiera lösenord" +
                "\n4. Jämför tal" +
                "\n5. Dubblera och halvera tal" +
                "\n6. Miniräknare" +
                "\n7. Summa och medelvärde" +
                "\n0. Avsluta");

            Console.Write("\nAnge nummer: ");
            string input = Console.ReadLine();

            if (input == "0")
                break;

            switch (input)
            {
                case "1":
                    GreetUser();
                    break;
                case "2":
                    MultiplyNumbers();
                    break;
                case "3":
                    VerifyPassword();
                    break;
                case "4":
                    CompareNumber();
                    break;
                case "5":
                    DoubleAndHalve();
                    break;
                case "6":
                    Calculator();
                    break;
                case "7":
                    SumAndAverage();
                    break;
                default:
                    Console.WriteLine("Ogiltigt val, försök igen.");
                    break;
            }
        }
    }

    static void GreetUser()
    {
        Console.WriteLine("\n1. Hälsa på användaren");

        Console.Write("Skriv ditt namn: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hej, {name}!");
    }

    static void MultiplyNumbers()
    {
        Console.WriteLine("\n2. Multiplicera två tal");

        Console.Write("Skriv in första talet: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Skriv in andra talet: ");
        int secondNumber = int.Parse(Console.ReadLine());

        int product = firstNumber * secondNumber;
        Console.WriteLine($"{firstNumber} * {secondNumber} = {product}");
    }

    static void VerifyPassword()
    {
        Console.WriteLine("\n3. Verifiera lösenord");

        Console.Write("Lösenord: ");

        string enteredPassword = Console.ReadLine();
        string correctPassword = "NEU25G";

        if (enteredPassword == correctPassword)
        {
            Console.WriteLine("Lösenordet är korrekt");
        }
        else
        {
            Console.WriteLine("Fel lösenord!");
        }
    }

    static void CompareNumber()
    {
        Console.WriteLine("\n4. Jämför tal");

        Console.Write("Skriv ett tal: ");
        int number = int.Parse(Console.ReadLine());
        if (number < 100)
        {
            Console.WriteLine("Ditt tal är mindre än 100");
        }
        else if (number > 100)
        {
            Console.WriteLine("Ditt tal är större än 100");
        }
        else
        {
            Console.WriteLine("Ditt tal är 100");
        }
    }

    static void DoubleAndHalve()
    {
        Console.WriteLine("\n5. Dubblera och halvera tal");

        Console.Write("Skriv in ett tal: ");
        double number = double.Parse(Console.ReadLine());

        Console.WriteLine($"{number * 2} är dubbel så mycket som {number}.");
        Console.WriteLine($"{number / 2} är hälften så mycket som {number}.");
    }

    static void Calculator()
    {
        Console.WriteLine("\n6. Miniräknare");

        Console.Write("Första talet: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("\nVälj +, -, *, /: ");
        string operation = Console.ReadLine();

        Console.Write("\nAndra talet: ");
        double secondNumber = double.Parse(Console.ReadLine());

        switch (operation)
        {
            case "+":
                Console.WriteLine($"\n{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
                break;
            case "-":
                Console.WriteLine($"\n{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
                break;
            case "*":
                Console.WriteLine($"\n{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                break;
            case "/":
                if (secondNumber != 0)
                {
                    Console.WriteLine($"\n{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
                }
                else
                {
                    Console.WriteLine("\nFel: Division med noll är inte tillåten.");
                }
                break;
            default:
                Console.WriteLine("\nFel: Ogiltig operation.");
                break;
        }
    }

    static void SumAndAverage()
    {
        Console.WriteLine("\n7. Summa och medelvärde");

        double sum = 0;
        int numbersCount = 0;

        while (true)
        {
            Console.Write("Skriv in ett tal (eller något annat för att avsluta): ");
            if (double.TryParse(Console.ReadLine(), out double number))
            {
                sum += number;
                numbersCount++;
                Console.WriteLine($"Summa hittills: {sum}");
            }
            else
            {
                break;
            }
        }

        if (numbersCount > 0)
            Console.WriteLine($"Medelvärde: {sum / numbersCount}");
        else
            Console.WriteLine("Inga tal angavs.");
    }
}
