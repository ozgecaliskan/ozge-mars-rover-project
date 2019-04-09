using mars_rover.Enums;
using mars_rover.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mars_rover
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1. Rover için Başlangıç Konumu Giriniz X?= ");
            int R1X = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1. Rover için Başlangıç Konumu Giriniz Y?= ");
            int R1Y = Convert.ToInt32(Console.ReadLine());

            Plateau plateau = new Plateau(5, 5);
            Position position = new Position(R1X, R1Y);

            Console.WriteLine("1. Rover için Yön Belirtiniz? ");
            string R1D = Console.ReadLine();
            DirectionEnum direction1 = DirectionEnum.N;
            switch (R1D)
            {
                case "N":
                    direction1 = DirectionEnum.N;
                    break;
                case "E":
                    direction1 = DirectionEnum.E;
                    break;
                case "S":
                    direction1 = DirectionEnum.S;
                    break;
                case "W":
                    direction1 = DirectionEnum.W;
                    break;
                    
            }


            // 1. Rover için bir örnek çıkardı
            Rover rover1 = new Rover(plateau, position, direction1);

            Console.WriteLine("Rover 1 İçin Komtları Giriniz:");
            string roverOneCommandLine= Console.ReadLine();

            rover1.Process(roverOneCommandLine.ToUpper());
            Console.WriteLine(rover1.CurrentPosition()); // prints 1 3 N

            // 2. Rover için bir örnek çıkardı

            Console.WriteLine("2. Rover için Başlangıç Konumu Giriniz X?= ");
            int R2X = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. Rover için Başlangıç Konumu Giriniz Y?= ");
            int R2Y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. Rover için Yön Belirtiniz? ");
            string R2D = Console.ReadLine();
            DirectionEnum direction2 = DirectionEnum.N;
            switch (R2D)
            {
                case "N":
                    direction2 = DirectionEnum.N;
                    break;
                case "E":
                    direction2 = DirectionEnum.E;
                    break;
                case "S":
                    direction2 = DirectionEnum.S;
                    break;
                case "W":
                    direction2 = DirectionEnum.W;
                    break;

            }



            Position position2 = new Position(R2X, R2Y);
            Rover rover2 = new Rover(plateau, position2, direction2);

            Console.WriteLine("Rover 2 İçin Komtları Giriniz:");
            string roverTwoCommandLine = Console.ReadLine();
            rover1.Process(roverTwoCommandLine.ToUpper());

            Console.WriteLine(rover2.CurrentPosition());
            Console.ReadKey();
        }
    }
}
