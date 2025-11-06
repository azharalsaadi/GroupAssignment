using Salalah_Book_Café.Models_B;

namespace Salalah_Book_Café
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            MenuItem coffee = new MenuItem("Espresso", DrinkType.Coffee,3.5m);
            MenuItem tea = new MenuItem("Green Tea", DrinkType.Tea, 2.8m);

          
            Book book1 = new Book("The Alchemist", "Paulo Coelho");
            Book book2 = new Book("1984", "George Orwell");
            Book book3 = new Book("Atomic Habits", "James Clear");

            Customer customer1 = new Customer("Nasser");
            Customer customer2 = new Customer("Noor");

            
            customer1.OrderDrink(coffee);
            customer1.BorrowBook(book1);
            customer1.BorrowBook(book2);
            customer1.BorrowBook(book3); 

            customer2.OrderDrink(tea);
            customer2.BorrowBook(book2); 

            
            customer1.PrintInfo();
            customer2.PrintInfo();

            
            customer1.ReturnBooks();
            customer2.ReturnBooks();

            
            Console.WriteLine("Book Status After Return:");
            book1.PrintInfo();
            book2.PrintInfo();
            book3.PrintInfo();
        }
    }
}
