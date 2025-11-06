using Dhofar_Car_Rental.Models_A;

namespace Dhofar_Car_Rental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Car car1 = new Car("Toyota", "Corolla", 40);
            Car car2 = new Car("Honda", "Civic", 70);
            Car car3 = new Car("Nissan", "Altima", 20);

           
            Customer cust1 = new Customer("Ali", "96812345678");
            Customer cust2 = new Customer("Fatima", "96887654321");

            
            List<RentalRecord> rentals = new List<RentalRecord>();
            rentals.Add(new RentalRecord(cust1, car1, 3)); 
            rentals.Add(new RentalRecord(cust2, car3, 2)); 

           
            Console.WriteLine("Rental Records:");
            foreach (var rental in rentals)
            {
                rental.PrintInfo();
            }

            Console.WriteLine("\nAvailable Cars:");
            List<Car> allCars = new List<Car> { car1, car2, car3 };
            foreach (var car in allCars)
            {
                if (car.Status == CarStatus.Available)
                    car.PrintInfo();
            }

       
            decimal revenue = 0;
            foreach (var rental in rentals) revenue += rental.TotalCost;
            Console.WriteLine($"\nTotal Revenue: ${revenue}");
        }
    }
}
