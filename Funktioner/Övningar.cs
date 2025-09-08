using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Funktioner
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\nVälj en övning att köra:" +
                    "\n1. Slå ihop för- och efternamn" +
                    "\n2. Slå ihop för- och efternamn - returnera" +
                    "\n3. Kolla om strängen är längre än ett givet antal tecken" +
                    "\n4. Omvandla Celsius till Fahrenheit" +
                    "\n5. Lägg in bindesträck mellan tecken i en sträng" +
                    "\n6. Egen version av String.Join();" +
                    "\n7. Beräkna medelvärde av int-array" +
                    "\n8. Siffror till text" +
                    "\n9. Heltal till text" +
                    "\n10.Hitta index för alla förekomster av ett givet tecken" + 
                    "\n11. Kasta tärning + " +
                    "\n12. Rita en box" +
                    "\n13. Flytta runt ett @ med piltangenterna");

                Console.Write("\nAnge nummer: ");
                string input = Console.ReadLine();

                if (input == "0")
                    break;

                switch (input)
                {
                    case "1":
                        PrintName("Adam", "Adolfsson");
                        break;
                    case "2":
                        Console.WriteLine(GetFullNameAsString("Adam", "Adolfsson"));
                        break;
                    case "3":
                        Console.WriteLine(IsStringLongerThanNumber("word", 3));
                        break;
                    case "4":
                        Console.Write("Skriv in grader i Celsius: ");
                        double celsius = double.Parse(Console.ReadLine());
                        double farenheit = double.Round(CelsiusToFarhenheit(celsius), 2);
                        Console.WriteLine($"{celsius}C = {farenheit}f");
                        break;
                    case "5":
                        Console.Write("Skriv ett ord: ");
                        string word = Console.ReadLine();
                        Console.WriteLine(AddHyphensBetweenChars(word));
                        break;
                    case "6":
                        Console.WriteLine(JoinStrings("->", "Sverige", "Norge", "Finland"));
                        break;
                    case "7":
                        double average = CalculateAverage(1, 2, 3, 4);
                        Console.WriteLine("avarage of 1, 2, 3, 4 and 5 is: " + average);
                        break;
                    case "8":
                        string[] words = NumbersToWords(6543);
                        foreach (string w in words)
                        {
                            Console.Write(w + " ");
                        }
                        break;
                    case "9":
                        Console.WriteLine(IntToText(9813));
                        break;
                    case "10":
                        int[] indexes = IndexesOf("Hello World1", 'o');
                        foreach (int index in indexes)
                        {
                            Console.Write(index + " ");
                        }
                        break;
                    case "11":
                        Console.WriteLine(ThrowMultipleDice(3, 10));
                        break;
                    case "12":
                        DrawBox(14, 8);
                        break;
                    case "13":
                        MoveCharacterInBox();
                        break;
                }
            }
        }

        static void PrintName(string firstName, string lastName)
        {
            Console.WriteLine($"{firstName} {lastName}");
        }

        static string GetFullNameAsString(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }

        static bool IsStringLongerThanNumber(string input, int i)
        {
            if (input.Length > i)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static double CelsiusToFarhenheit(double celsius)
        {
            return (celsius * 1.8) + 32;
        }

        static string AddHyphensBetweenChars(string input)
        {
            string output = "";
            int count = 1;
            foreach (char c in input)
            {
                if (count != input.Length)
                {
                    output += c + "-";
                }
                else
                {
                    output += c;
                }
                count++;
            }
            return output;
        }

        static string JoinStrings(string seperator, params string?[] strings)
        {
            string output = "";

            for (int i = 0; i < strings.Length; i++)
            {
                if (i != strings.Length - 1)
                {
                    output += strings[i] + seperator;
                }
                else
                {
                    output += strings[i];
                }
            }
            return output;
        }

        static double CalculateAverage(params int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum / numbers.Length;
        }

        static string[] NumbersToWords(int number)
        {
            string[] numbersAsText = { "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio" };
            string intToString = number.ToString();
            string[] words = new string[intToString.Length];

            for (int i = 0; i < intToString.Length; i++)
            {
                words[i] = numbersAsText[int.Parse(intToString[i].ToString()) - 1];
            }

            return words;
        }

        static string IntToText(ushort input)
        {
            string[] tens = { "twenty", "thrirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string[] elevenToNineteen = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string output = "";
            string inputString = input.ToString();

            if (inputString.Length > 3)
            {
                output += inputString[0] + " thousand ";
            }
            if (inputString.Length > 2)
            {
                output += inputString[1] + " hundred ";
            }
            if (inputString.Length > 1)
            {
                int number = int.Parse(inputString[2].ToString());
                int lastNumber = inputString[inputString.Length - 1];

                if (number == 1 && lastNumber != 0)
                {
                    output += elevenToNineteen[int.Parse(inputString[inputString.Length - 1].ToString())];
                }
                else
                {
                    output += tens[number - 2];
                    output += " " + inputString[3];
                }
            }

            return output;
        }

        static int[] IndexesOf(string text, char c)
        {
            List<int> indexes = new();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == c)
                {
                    indexes.Add(i);
                }
            }

            return indexes.ToArray();
        }

        static int ThrowDice(int sides = 6)
        {
            Random random = new();
            int diceRoll = random.Next(1, sides + 1);
            return diceRoll;
        }

        static int ThrowMultipleDice(int timesToRoll, int sides = 6)
        {
            int sum = 0;
            for (int i = 0; i < timesToRoll; i++)
            {
                sum += ThrowDice(sides);
            }

            return sum;
        }

        static void DrawBox(int width, int height)
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (y == 0 || y == height - 1 || x == 0 || x == width - 1)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();

            }
        }
        static void MoveCharacterInBox()
        {
            Console.CursorVisible = false;
            int boxWidth = 14;
            int boxHeight = 8;
            int xPos = 3;
            int yPos = 2;
            int lastXPos = 3;
            int lastYpos = 2;
            Console.Clear();
            DrawBox(14, 8);
            while (true)
            {
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.LeftArrow && xPos > 1)
                {
                    lastXPos = xPos;
                    lastYpos = yPos;
                    xPos--;
                }
                if (key.Key == ConsoleKey.RightArrow && xPos < boxWidth - 2)
                {
                    lastXPos = xPos;
                    lastYpos = yPos;
                    xPos++;
                }
                if (key.Key == ConsoleKey.UpArrow && yPos > 1)
                {
                    lastXPos = xPos;
                    lastYpos = yPos;
                    yPos--;
                }
                if (key.Key == ConsoleKey.DownArrow && yPos < boxHeight - 2)
                {
                    lastXPos = xPos;
                    lastYpos = yPos;
                    yPos++;
                }
                if (key.Key == ConsoleKey.Q)
                {
                    Console.Clear();
                    break;
                }
                Console.SetCursorPosition(lastXPos, lastYpos);
                Console.Write("-");
                Console.SetCursorPosition(lastXPos + 1, lastYpos);
                Console.Write("-");
                Console.SetCursorPosition(xPos, yPos);
                Console.Write("@");
                
            }
        }        
            #region Helper functions
            static string CharToString(char charToString)
            {
                string output = "";

                switch (charToString)
                {
                    case '1':
                        output = "one";
                        break;
                    case '2':
                        output = "two";
                        break;
                    case '3':
                        output = "three";
                        break;
                    case '4':
                        output = "four";
                        break;
                    case '5':
                        output = "five";
                        break;
                    case '6':
                        output = "six";
                        break;
                    case '7':
                        output = "seven";
                        break;
                    case '8':
                        output = "eight";
                        break;
                    case '9':
                        output = "nine";
                        break;
                }
                return output;
            }


            #endregion

    }
}
