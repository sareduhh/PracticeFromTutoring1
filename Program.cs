using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_Three_Word_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Word Problem #1
             int CupsNeeded = 7;
             int CupsAdded = 2;

             Console.WriteLine(CupsNeeded - CupsAdded);
            

            
           // #2
            int Bill = 13;
            int Friends = 4;

            Console.WriteLine(Bill * Friends);
            

            //#3
            int DiaperCost = 8;
            int MyMoney = 40;

            Console.WriteLine(MyMoney / DiaperCost);


            //#4

            int BeforeWknd = 29;
            int AfterWknd = 41;

            Console.WriteLine(AfterWknd - BeforeWknd);


            //#5

            int JuliaMiles = 47;
            int MilesMore = 30;

            Console.WriteLine(JuliaMiles - MilesMore);


            //#6

            int MyCash = 12;
            int BoxCost = 3;

            Console.WriteLine(MyCash / BoxCost);


            //#7

            double SaladPrice = 5.12;
            double MoneyLeft = 27.10;

            Console.WriteLine(MoneyLeft + SaladPrice);


            //#8

            int totalStudents = 331;
            int studentCars = 7;
            int buses = 6;

            Console.WriteLine((totalStudents - studentCars) / buses);

            //#9

            int AliyahMoney = 24;
            int LeftOver = 10;
            int Pencils = 7;

            Console.WriteLine((AliyahMoney - LeftOver) / Pencils);

            //#10
            
            int TotalSum = 72;
            int ConsecNum = 3;

            Console.WriteLine()
            



            //#11

            //#12
            int boxesLeft = 22;
            int boxesBought = 7;
            double boxesDestroyed = 0.5;

            Console.WriteLine((boxesLeft / boxesDestroyed) - boxesBought);


            //Practice English to C#
            int height = 60;
            if (height >= 60);
            {
                Console.WriteLine("You can ride the rollercoaster!");
            }

            */


            //Age Distribution Practice



            Console.WriteLine("How old are you?");

            int UserAge = int.Parse(Console.ReadLine());

            if (UserAge >= 0 && UserAge <= 2)
            {
                Console.WriteLine("Still in Mama's arms");
            }
            else if (UserAge ==3 || UserAge ==4)
            {
                Console.WriteLine("Preschool Maniac");
            }
            else if (UserAge >= 5 && UserAge <=11)
            {
                Console.WriteLine("Elementary School");
            }
            else if (UserAge >= 12 && UserAge <=14)
            {
                Console.WriteLine("Middle School");
            }
            else if (UserAge >=15 && UserAge <=18)
            {
                Console.WriteLine("High School");
            }
            else if (UserAge >=19 && UserAge <=22)
            {
                Console.WriteLine("College");
            }
            else if (UserAge >=23 && UserAge <=65)
            {
                Console.WriteLine("Working for the Man");
            }



            
            

        }
    }
}
