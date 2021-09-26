namespace Mod6Lab_Vehicles2
{

     public abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public abstract void Drive();
        public virtual void ShowColor() {}

        // 1. Create a new abstract method (require implementation)
        public abstract void Notice();
        // 2. Create a new virtual method (optional implementation)
        public virtual void Speed() {
            System.Console.WriteLine("The car goes really fast.");
        }
        // Implement in two of your concrete classes
        //TOYOTA AND PORSCHE

        public virtual void Start() // eligible for override (optional)
        {
            System.Console.WriteLine("The vehicle has started");
        }

        public void Stop() 
        {
            System.Console.WriteLine("The vehicle is stopped");
        }

    }
}