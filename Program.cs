namespace Topic_4._5___Intro_to_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press ENTER to draw an animal:");
            Console.ReadLine();
            drawShark(50);
            Console.WriteLine("Press ENTER to draw another animal:");
            Console.ReadLine();
            drawCat(50);
            Console.WriteLine("Press ENTER to draw a third animal:");
            Console.ReadLine();
            drawDog(50);

            Console.WriteLine("Press ENTER to continue.");
            Console.Clear();
            Console.WriteLine("Knock knock!");
            Console.WriteLine("PRESS ENTER TO ASK 'Who's there?'");
            Console.ReadLine();
            joke(50);
        }

        public static void drawShark(int drawShark)
        {
            Console.WriteLine("      .");
            Console.WriteLine("\\_____)\\_____");
            Console.WriteLine("/--v____ __`<");
            Console.WriteLine("        )/");
            Console.WriteLine("        '");
            Console.WriteLine("");
        }

        public static void drawCat (int drawCat)
        {
            Console.WriteLine("");
            Console.WriteLine(" /\\_/\\");
            Console.WriteLine("( o.o )");
            Console.WriteLine(" > ^ <");
            Console.WriteLine("");
        }

        public static void drawDog (int drawDog)
        {
            Console.WriteLine("  __      _");
            Console.WriteLine("o'')}____//");
            Console.WriteLine(" `_/      )");
            Console.WriteLine(" (_(_/-(_/");
            Console.WriteLine("");
        }

        public static void joke (int joke)
        {
            Console.WriteLine("Interupting cow-");
            Thread.Sleep(750);
            Console.WriteLine("MOOOOOOOOOOO !!!");
        }



    }
}
 