

namespace Assignment_1;

class Program
{

    static void Main(string[] args)
    {

        PartA partA = new PartA();
        PartB partB = new PartB();

        //Option menu
        Console.WriteLine("What part would you like to run? Please enter the letter.");
        Console.WriteLine("A");
        Console.WriteLine("B");
        Console.Write("Choice: ");

        char option;

        //makes an input a char
        char.TryParse(Console.ReadLine(), out option);
        option = char.ToLower(option);

        //this starts the option program
        switch(option)
        {

            case 'a':
                partA.Run();
                break;

            case 'b':
                partB.Run();
                break;
        }

    }

}