using System;

namespace Mod6Lab_Vehicles2
{
    class Program
    {
        static void Main(string[] args)
        {
            Porsche porsche = new Porsche();
            Toyota toyota = new Toyota();
            Vehicle myPorsche = new Porsche();
            Vehicle myToyota = new Toyota();

            porsche.Make = "1950 Porsche 356";
            porsche.ZeroToSixty = 13.9;
            toyota.ZeroToSixty = 7.7;
            toyota.Make = "2019 Toyota 4Runner TRD Off-Road Premium";
            System.Console.WriteLine("");

            porsche.Notice();
            porsche.Speed();
            porsche.Start();
            porsche.Drive();
            System.Console.WriteLine("");

            //Vehicle cannot access the Porsche fields.
            //Vehicle gives the ZeroToSixty field a default value of 0.
            myPorsche.Notice();
            myPorsche.Speed();
            myPorsche.Start(); 
            myPorsche.Drive();
            System.Console.WriteLine("");

            //There is no instantiated Speed() for Toyota
            toyota.Notice();
            toyota.Speed();
            toyota.Start();
            System.Console.WriteLine("");

            //There is no instantiated Speed() for Toyota
            myToyota.Notice();
            myToyota.Speed();
            myToyota.Start();
            System.Console.WriteLine("");


        }
    }
}
