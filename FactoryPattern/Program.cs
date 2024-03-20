namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell us the number of Car doors:");
            var doorCount = int.Parse(Console.ReadLine());
            var vehicle = VehicleFactory.GetVehicle(doorCount);
            vehicle.Drive();
        }
    }
}
