namespace Förberedelseövningar_Labb1
{
    using System;
    internal class Övningar
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Välj en övning att köra:" +
                    "\n1. Bokstav för bokstav - fram till space" +
                    "\n2. Bokstav för bokstav - radbyte på space" +
                    "\n3. Bokstav för bokstav - varannan stjärna" +
                    "\n4. Bokstav för bokstav - gröna o, röda l" +
                    "\n5. Bokstav för bokstav - dubbla med grön färg" +
                    "\n6. Bokstav för bokstav - grön substring" +
                    "\n7. Bokstav för bokstav - grön substring 2" +
                    "\n8. Bokstav för bokstav - grön substring 3" +
                    "\n9 Bokstavspyramid" +
                    "\n10. Ordpyramid" +
                    "\n11. Ordpyramid 2" +
                    "\n12. Rödmarkerade ord" +
                    "\n13. Rödmarkerade bokstäver" +
                    "\n14. Rödmarkerade bokstäver 2" +
                    "\n15. Rödmarkerade bokstäver 3");

                Console.Write("\nAnge nummer: ");
                string input = Console.ReadLine();

                if (input == "0")
                    break;

                switch (input)
                {
                    case "1":
                        ToSpace();
                        break;
                    case "2":
                        NewLineOnSpace();
                        break;
                    case "3":
                        EveryOtherStar();
                        break;
                    case "4":
                        GreenORedL();
                        break;
                    case "5":
                        DoubleWithGreenColor();
                        break;
                    case "6":
                        GreenSubString();
                        break;
                    case "7":
                        GreenSubstringTwo();
                        break;
                    case "8":
                        GreenSubStringThree();
                        break;
                    case "9":
                        LetterPyramid();
                        break;
                    case "10":
                        WordPyramid();
                        break;
                    case "11":
                        WordPyramidTwo();
                        break;
                    case "12":
                        WordsMarkedRed();
                        break;
                    case "13":
                        LettersMarkedRed();
                        break;
                    case "14":
                        LettersMarkedRedTwo();
                        break;
                    case "15":
                        LettersMarkedRedThree();
                        break;
                }
                Console.WriteLine();
            }

        }

        static void ToSpace()
        {
            string helloWorld = "Hello World!";

            foreach (char c in helloWorld)
            {
                if (c == ' ') return;
                Console.Write(c);
            }
        }

        static void NewLineOnSpace()
        {
            string text = "This is just some other text";

            foreach (char c in text)
            {
                if (c == ' ') Console.WriteLine();
                Console.Write(c);
            }
        }

        static void EveryOtherStar()
        {
            string text = "Detta är uppgift 3";

            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(text[i]);
                }
                else
                {
                    Console.Write("*");

                }
            }
        }

        static void GreenORedL()
        {
            string text = "Hello World!";

            foreach (char c in text)
            {
                if (c == 'o')
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (c == 'l')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ResetColor();
                }

                Console.Write(c);
            }
        }

        static void DoubleWithGreenColor()
        {
            string text = "Hello World!";

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                if (i + 1 < text.Length)
                {
                    char nextChar = text[i + 1];

                    if (currentChar == nextChar)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(currentChar);
                        Console.Write(nextChar);
                        Console.ResetColor();
                        i++;
                    }
                    else
                    {
                        Console.Write(currentChar);
                    }
                }
            }
        }

        static void GreenSubString()
        {
            string text = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                if (i + 1 < text.Length)
                {
                    char nextChar = text[i + 1];

                    if (currentChar == nextChar)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(currentChar);
                        Console.Write(nextChar);
                        Console.ResetColor();
                        i++;
                    }
                    else
                    {
                        Console.Write(currentChar);
                    }
                }
            }
        }

        static void GreenSubstringTwo()
        {
            string text = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
            string[] subtexts = text.Split(" ");

            foreach (string subtext in subtexts)
            {
                if (subtext == "chuck")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ResetColor();
                }
                Console.Write(subtext + " ");
            }
        }
        static void GreenSubStringThree()
        {

            string text = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
            Console.WriteLine(text);
            Console.Write("Vilken del vill du färga grön: ");
            string input = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                if (input.StartsWith(text[i]))
                {
                    if (input.EndsWith(text[i + input.Length - 1]))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        for (int j = i; j < input.Length + i; j++)
                        {
                            Console.Write(text[j]);
                        }
                        i += input.Length - 1;
                    }
                    else
                    {
                        Console.ResetColor();
                        Console.Write(text[i]);
                    }
                }
                else
                {
                    Console.ResetColor();
                    Console.Write(text[i]);
                }
            }

        }

        static void LetterPyramid()
        {
            string text = "Hello world!";

            int count = 1;
            foreach (char c in text)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
                count++;
            }
        }

        static void WordPyramid()
        {
            string text = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
            string[] substrings = text.Split(" ");

            int count = 1;
            foreach (string word in substrings)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.Write(word + " ");
                }
                Console.WriteLine();
                count++;
            }
        }

        static void WordPyramidTwo()
        {
            string text = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
            string[] substrings = text.Split(" ");

            int count = 1;
            for (int i = 0; i < substrings.Length; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    Console.Write(substrings[j] + " ");
                }
                Console.WriteLine();
                count++;
            }
        }

        static void WordsMarkedRed()
        {
            string text = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
            string[] substrings = text.Split(" ");

            for (int i = 0; i < substrings.Length; i++)
            {
                for (int j = 0; j < substrings.Length; j++)
                {
                    if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ResetColor();
                    }
                    Console.Write(substrings[j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void LettersMarkedRed()
        {
            string text = "abcdefghijklmnopqrstuvwxyz";

            for (int i = 0; i < text.Length - 4; i++)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    if (j < i + 5 && j >= i)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ResetColor();
                    }

                    Console.Write(text[j]);
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }

        static void LettersMarkedRedTwo()
        {
            Console.Write("Mata in text: ");
            string input = Console.ReadLine();

            char firstChar = ' ';
            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0)
                {
                    firstChar = input[i];
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(input[i]);
                }
                else if (input[i] == firstChar)
                {
                    Console.Write(input[i]);
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(input[i]);
                }
            }
            Console.ResetColor();
        }

        static void LettersMarkedRedThree()
        {
            Console.Write("Mata in text: ");
            string input = Console.ReadLine();

            char firstChar = ' ';
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (i == j)
                    {
                        firstChar = input[j];
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(input[j]);
                    }
                    else if (input[j] == firstChar)
                    {
                        Console.Write(input[j]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(input[j]);
                    }
                }
                Console.WriteLine();
                Console.ResetColor();
            }
            Console.ResetColor();
        }

    }
}
