using System;

namespace TonyGotcha
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(@"
▓█████▄  ██▀███   █    ██  ███▄    █  ██ ▄█▀   ▄▄▄█████▓ ▒█████   ███▄    █▓██   ██▓
▒██▀ ██▌▓██ ▒ ██▒ ██  ▓██▒ ██ ▀█   █  ██▄█▒    ▓  ██▒ ▓▒▒██▒  ██▒ ██ ▀█   █ ▒██  ██▒
░██   █▌▓██ ░▄█ ▒▓██  ▒██░▓██  ▀█ ██▒▓███▄░    ▒ ▓██░ ▒░▒██░  ██▒▓██  ▀█ ██▒ ▒██ ██░
░▓█▄   ▌▒██▀▀█▄  ▓▓█  ░██░▓██▒  ▐▌██▒▓██ █▄    ░ ▓██▓ ░ ▒██   ██░▓██▒  ▐▌██▒ ░ ▐██▓░
░▒████▓ ░██▓ ▒██▒▒▒█████▓ ▒██░   ▓██░▒██▒ █▄     ▒██▒ ░ ░ ████▓▒░▒██░   ▓██░ ░ ██▒▓░
 ▒▒▓  ▒ ░ ▒▓ ░▒▓░░▒▓▒ ▒ ▒ ░ ▒░   ▒ ▒ ▒ ▒▒ ▓▒     ▒ ░░   ░ ▒░▒░▒░ ░ ▒░   ▒ ▒   ██▒▒▒ 
 ░ ▒  ▒   ░▒ ░ ▒░░░▒░ ░ ░ ░ ░░   ░ ▒░░ ░▒ ▒░       ░      ░ ▒ ▒░ ░ ░░   ░ ▒░▓██ ░▒░ 
 ░ ░  ░   ░░   ░  ░░░ ░ ░    ░   ░ ░ ░ ░░ ░      ░      ░ ░ ░ ▒     ░   ░ ░ ▒ ▒ ░░  
   ░       ░        ░              ░ ░  ░                   ░ ░           ░ ░ ░     
 ░                                                                          ░ ░     ");
            System.Console.WriteLine("Tony is a sad, sad man. Right now, he's not at his best to say the least. \nTherefore, you need to take care of him and make sure he never gets sober.");
            System.Console.WriteLine("\nIf he do get sober, he will never listen to you.\n");
            Tony t = new Tony();

            System.Console.WriteLine("What's Mr. Tony's nickname?");

            Console.ForegroundColor = ConsoleColor.Magenta;
            t.name = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine("Urrrgghh... Heyyyyy... I like my new nickname hehehe... *burp*, " + t.name + ", It's interesting...");

            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("Now it's time to interact with " + t.name + ". What would you like to do?");

            while (t.GetAlive() = true)
            {     
            
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("     [a]Teach a new word\n     [b]Say hello\n     [c]Give a drink\n     [d]Nothing");

            string answer = Console.ReadLine();

            switch (answer)
            {
                case "a":

                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("LEARN:");
                    string addword;

                    addword = Console.ReadLine();

                    t.Teach(addword);

                    t.Hi();

                    break;
                case "b":



                    break;
                case "c":



                    break;
                case "d":



                    break;
                default:
                    break;


            }
            }


            
            Console.ReadLine();




        }
    }
}
