using System.Text.RegularExpressions;
internal class Övningar
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nVälj en övning att köra:" +
                "\n1. En bokstav på varje rad" +
                "\n2. Siffror till text" +
                "\n3. Baklänges" +
                "\n4. Dölj vokaler" +
                "\n5. Palindrom" +
                "\n6. Miniräknare" +
                "\n7. Omvänd ordning" +
                "\n8. Fördröjd utskrift" +
                "\n9. Bokstavspyramid" +
                "\n10 Färgade bokstäver" +
                "\n11. Start & stopp" +
                "\n12. Växla färg");

            Console.Write("\nAnge nummer: ");
            string input = Console.ReadLine();

            if (input == "0")
                break;

            switch (input)
            {
                case "1":
                    OneLetterOnEachRow();
                    break;
                case "2":
                    NumbersToText();
                    break;
                case "3":
                    Backwards();
                    break;
                case "4":
                    HideVowels();
                    break;
                case "5":
                    Palindrome();
                    break;
                case "6":
                    Calculator();
                    break;
                case "7":
                    ReversedOrder();
                    break;
                case "8":
                    DelayedOutput();
                    break;
                case "9":
                    LetterPyramid();
                    break;
                case "10":
                    ColoredLetters();
                    break;
                case "11":
                    StartAndStop();
                    break;
                case "12":
                    SwitchColor();
                    break;
            }
        }
    }

    static void OneLetterOnEachRow()
    {
        Console.Write("Skriv något: ");
        string input = Console.ReadLine();

        foreach (char c in input)
        {
            Console.WriteLine(c);
        }
    }

    static void NumbersToText()
    {
        string[] numbers = { "noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio" };

        while (true)
        {
            Console.Write("Skriv en siffra mellan ett och nio: ");
            string number = Console.ReadLine();
            string output = "";
            int count = 0;
            foreach (char c in number)
            {
                count++;
                int num = int.Parse(c.ToString());
                output += numbers[num];
                if (count != number.Length)
                    output += "-";
            }
            Console.WriteLine(output);
            break;
        }
    }

    static void Backwards()
    {
        Console.Write("Skriv något: ");
        string input = Console.ReadLine();
        char[] inputCharacters = input.ToCharArray();
        string backwardsInput = "";
        for (int i = inputCharacters.Length - 1; i >= 0; i--)
        {
            backwardsInput += inputCharacters[i];
        }
        Console.WriteLine(backwardsInput);
    }

    static void HideVowels()
    {
        Console.Write("Skriv något: ");
        string input = Console.ReadLine();
        string output = "";
        string robberSpeakOutput = "";
        foreach (char c in input)
        {
            if ("aeiouåäöAEIOUÅÄÖ".Contains(c))
            {
                output += "*";
                robberSpeakOutput += c;
            }
            else if (c != ' ')
            {
                robberSpeakOutput += c + "o" + c;
            }
            else
            {
                output += c;
                robberSpeakOutput += c;
            }
        }
        Console.WriteLine("Dolda vokaler: " + output);
        Console.WriteLine("Rövarspråk: " + robberSpeakOutput);
    }

    static void Palindrome()
    {
        Console.Write("Skriv ett ord: ");
        string input = Console.ReadLine();
        char[] inputCharacters = input.ToCharArray();
        string backwardsInput = "";
        bool isPalindrome = true;
        for (int i = 0; i < inputCharacters.Length; i++)
        {
            if (inputCharacters[i] != inputCharacters[inputCharacters.Length - 1 - i])
            {
                isPalindrome = false;
                break;
            }
        }
        if (isPalindrome)
        {
            Console.WriteLine($"{input} är ett palindrom");

        }
        else
        {
            Console.WriteLine($"{input} är inte ett palindrom");
        }

    }

    static void Calculator()
    {
        Console.Write("Vad vill du räkna ut?: ");
        string input = Console.ReadLine();
        string[] subStrings = Regex.Split(input, "( )");

        double firstNumber = double.Parse(subStrings[0]);
        double secondNumber = double.Parse(subStrings[4]);
        string operation = subStrings[2];
        if (operation == "+")
        {
            Console.WriteLine($"= {firstNumber + secondNumber}");
        }
        else if (operation == "-")
        {
            Console.WriteLine($"= {firstNumber - secondNumber}");
        }
        else if (operation == "/")
        {
            Console.WriteLine($"= {firstNumber / secondNumber}");
        }
        else if (operation == "*")
        {
            Console.WriteLine($"= {firstNumber * secondNumber}");
        }
    }

    static void ReversedOrder()
    {
        int count = 0;
        string[] words = new string[7];
        while (count < 7)
        {
            Console.WriteLine($"Skriv ett ord ({count}/7):");
            string input = Console.ReadLine();
            words[count] = input;
            count++;
        }
        Array.Reverse(words);
        foreach (string word in words)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }

    static void DelayedOutput()
    {
        string[] words = new string[10];
        int count = 0;
        while (true)
        {
            Console.WriteLine("Skriv ett tal: ");
            string input = Console.ReadLine();

            for (int i = words.Length - 1; i > 0; i--)
            {
                words[i] = words[i - 1];
            }
            words[0] = input;

            count++;
            if (count >= 10)
            {
                Console.WriteLine("10 inmatningar sen: " + words[9]);
            }
            else
            {
                Console.WriteLine("Du har inte skrivit in 10 ord än");
            }
        }
    }

    static void LetterPyramid()
    {
        string helloWorld = "Hello World";
        char[] letters = helloWorld.ToCharArray();

        string output = "";
        for (int i = 0; i < letters.Length; i++)
        {
            output += letters[i];
            Console.WriteLine(output);
        }
    }

    static void ColoredLetters()
    {
        Console.Write("Mata in en text: ");
        char[] inputChars = Console.ReadLine().ToCharArray();
        Console.Write("Välj en bokstav: ");
        char chosenLetter = char.Parse(Console.ReadLine());

        foreach (char c in inputChars)
        {
            if (c == chosenLetter)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(c);
                Console.ResetColor();
            }
            else
            {
                Console.Write(c);
            }
        }
    }

    static void StartAndStop()
    {
        Console.Write("Mata in en text: ");
        char[] inputChars = Console.ReadLine().ToCharArray();
        Console.Write("Välj startindex: ");
        int startIndex = int.Parse(Console.ReadLine());
        Console.Write("Välj stoppindex: ");
        int stopIndex = int.Parse(Console.ReadLine());

        for (int i = 0; i < inputChars.Length; i++)
        {
            if (i >= startIndex && i <= stopIndex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(inputChars[i]);
                Console.ResetColor();
            }
            else
            {
                Console.Write(inputChars[i]);
            }
        }
    }

    static void SwitchColor()
    {
        Console.Write("Mata in en text: ");
        char[] inputChars = Console.ReadLine().ToCharArray();
        Console.Write("Välj bokstav: ");
        char letter = char.Parse(Console.ReadLine());
        bool firstLetterFound = false;
        bool secondLetterFound = false;
        int count = 0;
        foreach (char c in inputChars)
        { 
            if (!firstLetterFound && c == letter)
            {
                for (int i = count + 1; i < inputChars.Length; i++)
                {
                    if (inputChars[i] == c)
                    {
                        firstLetterFound = true;
                        secondLetterFound = true;
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                }
                Console.Write(c);
            }
            else if (firstLetterFound && secondLetterFound && c == letter) 
            {
                Console.Write(c);
                firstLetterFound = false;
                secondLetterFound = false;
                Console.ResetColor();
            }
            else if (firstLetterFound && secondLetterFound && c != letter)
            {
                Console.Write(c);
            }
            else
            {
                Console.ResetColor();
                Console.Write(c);
            }
            count++;
        }
        Console.ResetColor();
    }

}

