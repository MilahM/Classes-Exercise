namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.Make = "Honda";
            car.Model = "Accord";
            car.Year = 2021;

            Console.WriteLine($"The car is a: {car.Make} {car.Model} {car.Year}.");
        }
    }
}
