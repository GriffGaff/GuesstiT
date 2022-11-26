using System;

namespace GuesstiT
{
    class Program
    {
        static void Main(string[] args){
            AppInfo();
            WelcomeMessage();
            Game1();
            //Game2();
        }
        static void AppInfo(){
            //App info
            string appName = "GuesstiT";
            string appVersion = "1.0.0";
            string appAuthor = "GriffGaff";

            //Change text color
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            //Print app nfo
            Console.WriteLine("The " + appName + ": Version " + appVersion + " is written and developed by " + appAuthor);
            Console.WriteLine("The {0}: Version {1} by {2}", appName, appVersion, appAuthor);
            //Reset text color
            Console.ResetColor();
        }
        static void WelcomeMessage(){
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("\nWelcome " + name + ". Let's play...\n");
        }
        static void PrintColorMessage(ConsoleColor color, string message){
            //Change text color 
            Console.ForegroundColor = color;
            //retry
            Console.WriteLine(message);
            //Reset text color
            Console.ResetColor();
        }
        static void Game1(){
            while (true)
            {
                //Let's play
                //random assignment enables us to select a number at random
                //correctNumber is set to be a random number;
                Random random = new Random();
                int correctNumber = random.Next(1, 10);
                int guess = 0;
                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber){
                    string input = Console.ReadLine();
                    //to make sure input is a number
                    if (!int.TryParse(input, out guess)){
                        //print error message
                        PrintColorMessage(ConsoleColor.Red, "Enter an actual number. ");

                        continue;
                    }
                    guess = Int32.Parse(input);
                    //match guess to correct number
                    if (guess != correctNumber){
                        //Change text color 
                        PrintColorMessage(ConsoleColor.Red, "Wrong guess, try again. ");
                        if (correctNumber == 1){
                            PrintColorMessage(ConsoleColor.Green, "Hint: three letter word, one consonant.");
                        }
                        if (correctNumber == 2){
                            PrintColorMessage(ConsoleColor.Green, "Hint: three letter word, popular saying \'once bitten ... shy\'.");
                        }
                        if (correctNumber == 3){
                            PrintColorMessage(ConsoleColor.Green, "Hint: five letter word, chelsea sponsors.");
                        }
                        if (correctNumber == 4){
                            PrintColorMessage(ConsoleColor.Green, "Hint: add a \'k\' to the end and you can eat with it.");
                        }
                        if (correctNumber == 5){
                            PrintColorMessage(ConsoleColor.Green, "Hint: How do you _slap_ someone?.");
                        }
                        if (correctNumber == 6){
                            PrintColorMessage(ConsoleColor.Green, "Hint: invert the last digit in binary op.");
                        }
                        if (correctNumber == 7){
                            PrintColorMessage(ConsoleColor.Green, "Hint: How many kingdoms are in Game of Thrones?");
                        }
                        if (correctNumber == 8){
                            PrintColorMessage(ConsoleColor.Green, "Hint: You really should _hate_ the devil.");
                        }
                        if (correctNumber == 9){
                            PrintColorMessage(ConsoleColor.Green, "Hint: say the digit 3 times and pay tribute to JuiceWrld.");
                        }
                        if (correctNumber == 10){
                            PrintColorMessage(ConsoleColor.Green, "Hint: _Than Q_ for playing.");
                        }
                    }
                    else{
                        PrintColorMessage(ConsoleColor.Green, "Correct guess. \n");
                        //wanna play again?
                        Console.WriteLine("Advance to the next [Y or N] ");

                        string answer = Convert.ToString(Console.ReadLine().ToUpper());

                        if (answer == "Y")
                        { continue; }
                        else if (answer == "N")
                        { return; }
                        else{
                            PrintColorMessage(ConsoleColor.Red, "Input Y or N. ");
                        }
                    }
                }
            }
        }
    }
}
    /*
        static void Game2(){
            while (true){
                string[] names ={ "Abdulrahman", "Naemah", "Abdulgaffar", "Zainudeen", "Mardhiyyah" };
                int answer1 = Convert.ToInt32(names[0]);
                string answer2 = names[1];
                string answer3 = names[2];
                // first name is array 0>1>2>3>4

                Random random = new Random(Convert.ToInt32(names));
                int correctName = random.Next();

                Console.WriteLine("\nGuess a name with the hints provided.");
                Console.Write("Enter guess: ");
                string guess = Console.ReadLine();

                while (correctName==answer1){
                    if (guess != answer1){

                    }
    */