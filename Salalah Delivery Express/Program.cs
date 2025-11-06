using Salalah_Delivery_Express.Models_C;

namespace Salalah_Delivery_Express
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Customer customer1 = new Customer("Hamza", "Salalah Industrial Area");
            Customer customer2 = new Customer("Azhar", "Salalah City");

            Driver driver1 = new Driver("Azhar", "97081474");
            Driver driver2 = new Driver("Nasser", "12344321");

            Delivery delivery1 = new Delivery(customer1, driver1);
            Delivery delivery2 = new Delivery(customer2, driver2);
            Delivery delivery3 = new Delivery(customer1, driver1);

            delivery1.UpdateStatus(DeliveryStatus.OnTheWay);
            delivery2.UpdateStatus(DeliveryStatus.Delivered);

            delivery1.PrintDetails();
            delivery2.PrintDetails();
            delivery3.PrintDetails();

            driver1.PrintDeliveries();
        }
    }
}

