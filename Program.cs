using System;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {

           infoVersion();

           userInfo();

            while (true)
            {

                //create new random object

                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                //init guess var 
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {


                    String input = Console.ReadLine();

                    //make sure it number
                    if (!int.TryParse(input, out guess))
                    {
                        colorMessage(ConsoleColor.Red, "Not a Number, Please try again");
                        
                        //keep going
                        continue;
                    }

                    guess = Int32.Parse(input);

                    //match correct number
                    if (guess != correctNumber)
                    {
                        colorMessage(ConsoleColor.Red, "Wrong Number, Please try again");
                        
                    }
                }

                colorMessage(ConsoleColor.Magenta, "You are CORRECT!!");
               

                Console.WriteLine("Do you want to play again Y or N");

                string answer = Console.ReadLine();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N") {
                    return;
                }
                else
                {
                    return;
                }

            }


        }

        public static void infoVersion() {

            //set app vars
            String appName = "Number Guesser";
            String appVersion = "1.0.0";
            String appAuthor = "Shihan Thathsara";

            //change text color
            Console.ForegroundColor = ConsoleColor.Cyan;

            //write out app info
            Console.WriteLine("{0} version {1} by {2}", appName, appVersion, appAuthor);

            //rest color
            Console.ResetColor();

        }

        public static void userInfo(){
            //Ask user name 
            Console.WriteLine("Enter your name");

            //get user input
            String numberInput = Console.ReadLine();
            Console.WriteLine("hello {0} let's Play a game...", numberInput);
        }
        public static void colorMessage(ConsoleColor color, String message) {
            //change text color
            Console.ForegroundColor = color;

            //write out app info
            Console.WriteLine(message);

            //rest color
            Console.ResetColor();
        }
    }
}
