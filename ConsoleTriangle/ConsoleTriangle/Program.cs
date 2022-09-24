using Triangle;
namespace ConsoleTriangle
{


    class Program
    {
        static void Main()
        {
            PascalClass PascalTriangle = new PascalClass();
            PascalTriangle.row = 9;
            PascalTriangle.triangle = new int[9, 9];

            PascalTriangle.FillTriangle();
            Console.ReadLine();
            PascalTriangle.Magic();
            Console.ReadLine();



        }

    }

}

