namespace Mod6Lab_Vehicles2
{
     public class Toyota:Vehicle
    {
        public double ZeroToSixty = 7.7;
        
        
        public override void Drive()
        {
            Make = "2019 Toyota 4Runner TRD Off-Road Premium";
            System.Console.WriteLine($"The {Make} handles great while driving.");
        }

         public override void Notice()
         {
             Make = "2019 Toyota 4Runner TRD Off-Road Premium";
             System.Console.WriteLine($"The {Make} is practical, good looking and goes from 0 to 60 in {ZeroToSixty}!");
         }
         public override void Speed() {}
        
    }
}