using System;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string me = "HTML";
            Console.WriteLine("Hello, " + me +".");
            Console.WriteLine("I am C#.");
            Console.WriteLine("You are " + me + ", right?");
            Console.Write("Too bad I'm harder to learn then you.");
            Console.Write(me + ", I think you are better than me.");
            Console.WriteLine(" You have more stuff than me.");
            Console.WriteLine("*sigh*");
            Console.WriteLine("If I had those, I'd be the best one. But, I don't think I have a reason to do this.");
            Console.WriteLine("Say, what do you have?");
            string userName = Console.ReadLine();
            Console.WriteLine(userName + ", cool. But I can't run inputs on webpages like you. Can you teach me?");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                Console.WriteLine("Wait, really? I'll call you my master then!");
            } else if (answer == "no")
            {
                Console.WriteLine("Okay then. *sigh*");
            } else {
                Console.WriteLine("What does that even mean?");
            };

        }
    }
}
