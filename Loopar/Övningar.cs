class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nVälj en övning att köra:" +
                "\n1. Skriv talen 20 till 30" +
                "\n2. Jämna tal" +
                "\n3.Var tredje \"Hej\"" +
                "\n4. Gångertabell" +
                "\n5. Summa" +
                "\n6. Riskorn på schackbräde" +
                "\n7. Fylld box" +
                "\n8. Randig box" +
                "\n9. Rutig box" +
                "\n10. Ihålig box" +
                "\n11. Sifferpyramid" +
                "\n12. Nio Sifferpyramider" +
                "\n13. Primtal" +
                "\n14. Spel - Gissa tal" +
                "\n15. Sten, sax, påse" +
                "\n0. Avsluta");


            Console.Write("\nAnge nummer: ");
            string input = Console.ReadLine();

            if (input == "0")
                break;

            switch (input)
            {
                case "1": PrintNumbers20To30(); 
                    break;
                case "2": PrintEvenNumbers(); 
                    break;
                case "3": EveryThirdHej(); 
                    break;
                case "4": MultiplicationTable(); 
                    break;
                case "5": SumTo1000(); 
                    break;
                case "6": RiceOnChessboard(); 
                    break;
                case "7": FilledBox(); 
                    break;
                case "8": StripedBox(); 
                    break;
                case "9": CheckeredBox(); 
                    break;
                case "10": HollowBox(); 
                    break;
                case "11": NumberPyramid(); 
                    break;
                case "12": NineNumberPyramids(); 
                    break;
                case "13": PrimeNumbers(); 
                    break;
                case "14": GuessingGame(); 
                    break;
                case "15": RockPaperScissors(); 
                    break;
                default: Console.WriteLine("Ogiltigt val, försök igen."); 
                    break;
            }
        }
    }

    static void PrintNumbers20To30()
    {
        Console.WriteLine("\n1. Skriv talen 20 till 30");

        for (int i = 20; i <= 30; i++)
        {
            Console.WriteLine(i);
        }
    }

    static void PrintEvenNumbers()
    {
        Console.WriteLine("\n2. Jämna tal");

        for (int i = 0; i <= 30; i += 2)
        {
            Console.WriteLine(i);
        }
    }

    static void EveryThirdHej()
    {
        Console.WriteLine("\n3. Var tredje \"Hej\"");

        for (int i = 0; i <= 30; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine("Hej");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }

    static void MultiplicationTable()
    {
        Console.WriteLine("\n4. Gångertabell");

        Console.Write("Mata in ett tal: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{i} * {number} = {number * i}");
        }
    }

    static void SumTo1000()
    {
        Console.WriteLine("\n5. Summa");

        int sum = 0;

        for (int i = 1; i <= 1000; i++)
        {
            sum += i;
        }

        Console.WriteLine($"Summan av alla tal 1 till 1000 är {sum}");
    }

    static void RiceOnChessboard()
    {
        Console.WriteLine("\n6. Riskorn på schackbräde");

        Int128 sum = 1;

        for (int i = 1; i <= 64; i++)
        {
            sum *= 2;
            Console.WriteLine($"Ruta {i}: {sum}");
        }
    }

    static void FilledBox()
    {
        Console.WriteLine("\n7. Fylld box");

        Console.Write("Mata in höjd: ");
        int height = int.Parse(Console.ReadLine());

        Console.Write("Mata in bredd: ");
        int width = int.Parse(Console.ReadLine());

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                Console.Write("X");
            }
            Console.WriteLine();
        }
    }

    static void StripedBox()
    {
        Console.WriteLine("\n8. Randig box");

        Console.Write("Mata in höjd: ");
        int height = int.Parse(Console.ReadLine());

        Console.Write("Mata in bredd: ");
        int width = int.Parse(Console.ReadLine());

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if (x % 2 == 0)
                {
                    Console.Write("X");
                }
                else
                {
                    Console.Write("O");
                }
            }
            Console.WriteLine();
        }
    }

    static void CheckeredBox()
    {
        Console.WriteLine("\n9. Rutig Box");

        Console.Write("Mata in höjd: ");
        int height = int.Parse(Console.ReadLine());

        Console.Write("Mata in bredd: ");
        int width = int.Parse(Console.ReadLine());

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if ((x + y) % 2 == 0)
                {
                    Console.Write("X");
                }
                else
                {
                    Console.Write("O");
                }
            }
            Console.WriteLine();
        }
    }

    static void HollowBox()
    {
        Console.WriteLine("\n10. Ihålig box");

        Console.Write("Mata in höjd: ");
        int height = int.Parse(Console.ReadLine());

        Console.Write("Mata in bredd: ");
        int width = int.Parse(Console.ReadLine());

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if (y == 0 || y == height - 1 || x == 0 || x == width - 1)
                {
                    Console.Write("X");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    static void NumberPyramid()
    {
        Console.WriteLine("\n11.Sifferpyramid");

        string numbers = "";

        for (int i = 1; i <= 9; i++)
        {
            numbers += i.ToString();
            Console.WriteLine(numbers);
        }
    }

    static void NineNumberPyramids()
    {
        Console.WriteLine("\n12.Nio Sifferpyramider");

        string numbers = "";

        for (int pyramid = 1; pyramid <= 9; pyramid++)
        {
            for (int row = 1; row <= pyramid; row++)
            {
                numbers += row.ToString();
                Console.Write(numbers + "\n");
            }
            Console.WriteLine();
            numbers = "";
        }
    }

    static void PrimeNumbers()
    {
        Console.WriteLine("\n13. Primtal");

        int count = 0;
        int num = 2;

        while (count < 20)
        {
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine(num);
                count++;
            }
            num++;
        }
    }

    static void GuessingGame()
    {
        Console.WriteLine("\n14. Spel - Gissa tal");

        Console.Write("Spela själv eller låt datorn spela mot sig själv? (själv/dator)");
        string choice = Console.ReadLine().ToLower();

        Random random = new Random();

        int numberToGuess = random.Next(1, 101);
        int attempts = 0;

        while (choice == "själv")
        {
            Console.Write("Gissa ett tal mellan 1 och 100: ");
            int playerGuess = int.Parse(Console.ReadLine());
            attempts++;
            if (playerGuess < numberToGuess)
            {
                Console.WriteLine("För lågt! Försök igen.");
            }
            else if (playerGuess > numberToGuess)
            {
                Console.WriteLine("För högt! Försök igen.");
            }
            else
            {
                Console.WriteLine($"Grattis! Du gissade rätt på {attempts} försök.");
                break;
            }
        }

        while (choice == "dator")
        {
            int computerGuess;
            int lowestPossibleNumber = 1;
            int highestPossibleNumber = 101;

            do
            {
                computerGuess = random.Next(lowestPossibleNumber, highestPossibleNumber);
                attempts++;
                Console.WriteLine($"Datorn gissar: {computerGuess}");
                if (computerGuess < numberToGuess)
                {
                    Console.WriteLine("För lågt!");
                    lowestPossibleNumber = computerGuess;
                }
                else if (computerGuess > numberToGuess)
                {
                    Console.WriteLine("För högt!");
                    highestPossibleNumber = computerGuess;
                }
                else
                {
                    Console.WriteLine($"Datorn gissade rätt på {attempts} försök.");
                    break;
                }
            } while (computerGuess != numberToGuess);
            break;
        }
    }

    static void RockPaperScissors()
    {
        Console.WriteLine("\n15. Sten, sax, påse");

        string[] choices = { "sten", "sax", "påse" };

        Random random = new Random();

        while (true)
        {
            Console.Write("Välj sten, sax eller påse: ");
            string playerChoice = Console.ReadLine().ToLower();

            if (playerChoice == "")
            {
                break;
            }
            else if (playerChoice != "sten" && playerChoice != "sax" && playerChoice != "påse")
            {
                Console.WriteLine("Ogiltigt val, försök igen.");
                continue;
            }

            string computerChoice = choices[random.Next(choices.Length)];

            if (playerChoice == computerChoice)
            {
                Console.WriteLine($"Oavgjort! Båda valde {playerChoice}.");
            }
            else if (playerChoice == "sten" && computerChoice == "sax" ||
                     playerChoice == "sax" && computerChoice == "påse" ||
                     playerChoice == "påse" && computerChoice == "sten")
            {
                Console.WriteLine($"Du vann! Datorn valde {computerChoice}.");
            }
            else
            {
                Console.WriteLine($"Datorn vann! Datorn valde {computerChoice}.");
            }
            Console.WriteLine();
        }
    }
}