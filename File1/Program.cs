using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars car1 = new Cars("M5","BMW",70,14);

            Random rn = new Random();
            Console.WriteLine(rn.Next(0,300));

            string userInput;
            do
            {
                Console.WriteLine("1.Go");
                Console.WriteLine("2.Top up");
                Console.WriteLine("3.Stop");
                Console.WriteLine("4.Exit");
                Console.Write(">>>>>>>>>");
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        car1.Go();

                        break;
                    case "2":
                        Console.WriteLine("Masina benzin vuruldu");
                        break;
                    case "3":
                        Console.WriteLine("Getdiyi km");
                        break;
                    case "4":
                        Console.WriteLine("Xismetden istifadeye gore tesekkur edirik");
                        break;

                    default:
                        Console.WriteLine("Yuxaridaki reqemlerden birini yazin");
                        break;
                }


            } while (userInput != "5");

        }
    }
}
