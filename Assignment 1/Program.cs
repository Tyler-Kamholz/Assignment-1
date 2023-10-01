

namespace Assignment_1;

class Program
{

    static void Main(string[] args)
    {

        PartA partA = new PartA();
        PartB partB = new PartB();

        //Option menu
        prints();

        char option;

        //makes an input a char
        char.TryParse(Console.ReadLine(), out option);
        option = char.ToLower(option);

        //this starts the option program
        while (option != 'q')
        {
            switch (option)
            {

                case 'a':
                    Console.WriteLine();
                    partA.Run();
                    prints();
                    char.TryParse(Console.ReadLine(), out option);
                    option = char.ToLower(option);
                    break;

                case 'b':
                    Console.WriteLine();
                    partB.Run();
                    prints();
                    char.TryParse(Console.ReadLine(), out option);
                    option = char.ToLower(option);
                    break;
            }
        }

        //print statement
        void prints()
        {
            Console.WriteLine();
            Console.WriteLine("What part would you like to run? Please enter the letter. (Q to quit)");
            Console.WriteLine("A");
            Console.WriteLine("B");
            Console.Write("Choice: ");
        }


    }

}