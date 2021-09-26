namespace Mod6Lab_Vehicles2
{
    public class Porsche : Vehicle
    {
        public double ZeroToSixty {get; set;}
       
        public override void Drive()
        {
            System.Console.WriteLine($"The {Make} handles great while driving on the track.");
        }

         public override void Notice()
         {
             System.Console.WriteLine($"The {Make} is fast and goes from 0 to 60 in {ZeroToSixty}!");
         }
         public override void Speed() {
             System.Console.WriteLine($"The {Make} can reach speeds of 87 mph.");
         }

         //Make = "1950 Porsche 356" 0-60 mph 13.9
    }
}
