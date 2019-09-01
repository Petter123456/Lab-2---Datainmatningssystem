using System;
using System.ComponentModel;
using System.Linq;

namespace Lab_2___Datainmatningssystem
{
    class Program
    {
        public enum Character{troll, dragon, worm, hobbit, cow}
        public static string[] namesTeam = new string[5];
        public static int[] ageTeam = new int[5];
        public static double[] levelTeam = new double[5];
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome, we heard that you are a team of 5 playing WOW");
            Console.WriteLine("Please enter some data that we ask you for about your team members to find out some interesting facts");

            NamesOfTeam();
            AgeOfTeam();
            LevelOfTeam();
            TeamCharacter();

            Console.WriteLine("Thank you for playing");
            Console.ReadKey();
        }

        public static void NamesOfTeam()
        {
            for (int i = 0; i < namesTeam.Length; i++)
                {
                    while (i < namesTeam.Length)
                    {
                        bool exceptionthrown = false;
                        Console.WriteLine("Please enter the names of the 5 players in your team");
                        namesTeam[i] = Console.ReadLine();
                        try
                        {
                            if (namesTeam[i].Equals(""))
                            {
                                throw new Exception();
                            }
                        }
                        catch (Exception)
                        {
                            exceptionthrown = true;
                            Console.WriteLine("Input cannot be empty");
                        }
                        if (!exceptionthrown)
                        {
                            i++;
                        }
                    }
                }

           

            //Calculations With string array
            for (int j = 0; j < namesTeam.Length; j++)
            {
                int i, l;
                string str1 = "";
                string str = namesTeam[j];

                l = str.Length - 1;

                for (i = l; i >= 0; i--)
                {
                    str1 = str1 + str[i];
                }
                str = str1;
                Console.WriteLine($"Your teams names in reverse are: {str}");
            }
            Console.WriteLine("Press any key to continue"); 
            Console.ReadKey();
            Console.Clear(); 

        }

        public static void AgeOfTeam()
        {
            for (int i = 0; i < ageTeam.Length; i++)
            {
                while (i < ageTeam.Length)
                {
                    bool exceptionthrown = false;
                    Console.WriteLine("Please enter the age of the players in your team");

                    var userInput = Console.ReadLine();
                    try
                    {
                        int isNum = Int32.Parse(userInput);
                    }
                    catch (FormatException)
                    {
                        exceptionthrown = true;
                        Console.WriteLine($"Age cannot be {userInput} please enter a number");
                    }
                    if (!exceptionthrown)
                    {
                        ageTeam[i] = Int32.Parse(userInput);
                        i++;
                    }
                }
            }

            int sum = 0;

            for (int i = 0; i < ageTeam.Length; i++)
            {
                sum += ageTeam[i];
            }
            Console.WriteLine($"The total age of your team is: {sum}");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();

        }

        public static void LevelOfTeam()
        {


            //Exception Hanling level team
            for (int i = 0; i < levelTeam.Length; i++)
            {
                while (i < levelTeam.Length)
                {
                    bool exceptionthrown = false;
                    Console.WriteLine("Please enter the level of each players character in your team");

                    var userInput = Console.ReadLine();
                    try
                    {
                        double isDouble = double.Parse(userInput);
                    }
                    catch (FormatException)
                    {
                        exceptionthrown = true;
                        Console.WriteLine($"Level cannot be {userInput} please enter a number with a maximum of one decimal (,)");
                    }
                    if (!exceptionthrown)
                    {
                        levelTeam[i] = double.Parse(userInput);
                        i++;
                    }
                }
            }

            //Calculation for levelTeam 
            double sum = 0;
            double average = 0;
            for (int i = 0; i < levelTeam.Length; i++)
            {
                sum += levelTeam[i];
                average = sum / levelTeam.Length;
            }

            Console.WriteLine($"The average level of your team is: {average}");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();



        }

        public static void TeamCharacter()
        {

            var lengthOfEnum = Enum.GetNames(typeof(Character)).Length;
            string[] userResponses = new string[5];
            string userInput = "";

            //Exception Hanling enum Character
            for (int i = 0; i < lengthOfEnum; i++)
            {
                while (i < lengthOfEnum)
                {
                    bool exceptionthrown = false;
                    Console.WriteLine("Which character does your team members use");
                    userInput = Console.ReadLine();
                    userInput.ToLower();
                    try
                    {
                        Enum.Parse(typeof(Character), userInput);
                    }
                    catch (Exception)
                    {
                        exceptionthrown = true;
                        Console.WriteLine($"{userInput} is not a valid character in the game, please enter Troll, Hobit, Dragon, Cow or Worm");
                    }
                    if (!exceptionthrown)
                    {
                        userResponses[i] = userInput;

                        i++;


                    }
                }
            }


            int counter = 0;
            int longestOccurance = 0;
            string mostFrequent = "";

            for (int i = 0; i < userResponses.Length; i++)
            {
                counter = 0;
                for (int j = 0; j < userResponses.Length; j++)
                {
                    if (userResponses[j].Equals(userResponses[i]))
                    {
                        counter++;
                    }
                }
                if (counter > longestOccurance)
                {
                    longestOccurance = counter;
                    mostFrequent = userResponses[i];
                }
            }

            Console.WriteLine($"The character most used by your team is: {mostFrequent}");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();

        }
    }
}



            //namn (vanligaste bokstaven bland namnen), nivå (medelnivå), ålder (summera åldern), karaktär (minst vanliga karaktären)






