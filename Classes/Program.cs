namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the Car class
            Car myCar = new Car();

            // Set values in the properties for the object
            myCar.Make = "Toyota";
            myCar.Model = "Camry";
            myCar.Year = 2021;

            // Print the values of each property to the Console
            Console.WriteLine($"Make: {myCar.Make}");
            Console.WriteLine($"Model: {myCar.Model}");
            Console.WriteLine($"Year: {myCar.Year}");
        }
    }
}


/* Output
Make: Toyota
Model: Camry
Year: 2021
*/