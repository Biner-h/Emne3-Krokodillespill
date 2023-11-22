
void start()
{
    Console.WriteLine($"Skriv 'start' for å starte. Svar ved å bruke <,> eller =.\n");
    var userInput = Console.ReadLine();
    if (userInput == "start")
    {
        Console.WriteLine();
        main();
    }
}

    void main()
{
    Random random = new Random();
    int score = 0;
    bool game = true;

    while (game)
    {
        var number1 = random.Next(0, 12);
        var number2 = random.Next(0, 12); 
        Console.WriteLine($"{number1}_{number2}\n");
        var answer = Console.ReadLine();

        if (number1 < number2 && answer == "<")
        {
            score++;
            Console.WriteLine();
            Console.WriteLine($"Det er rikitg! Du har {score} poeng.\n");
        }
        else if (number1 > number2 && answer == ">")
        {
            score++;
            Console.WriteLine();
            Console.WriteLine($"Det er rikitg! Du har {score} poeng.\n");
        }
        else if (number1 == number2 && answer == "=")
        {
            score++;
            Console.WriteLine();
            Console.WriteLine($"Det er rikitg! Du har {score} poeng.\n");
        }
        else if (answer != "<" && answer != ">" && answer != "=")
        {
            Console.WriteLine($"Spillet er over! Du fikk {score} poeng. Vil du spile igjen? (Ja/Nei)\n");
            var playAgain = Console.ReadLine();
            playAgain.ToLower();

            if (playAgain == "ja\n")
            {
                start();
            }
            else if (playAgain == "nei")
            {
                break;
            }
        }
        else
        {
            score--;
            Console.WriteLine();
            Console.WriteLine($"Det er helt feil! Du har {score} poeng.\n");
        }
    }
}
start();