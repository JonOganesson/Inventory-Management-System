using System.ComponentModel;

namespace StockTakeManagements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            DateTime dateTime = DateTime.Now;
            Item[] items = new Item[1000000];

            Console.Write("Employee Name: ");
            string eName = Console.ReadLine();

            WhileLoop:
            while (true)
            {
                Console.WriteLine("Press 'Enter' to start, and type 'Exit' and press 'Enter' to stop.");
                userInput = Console.ReadLine();
            
                if (string.IsNullOrEmpty(userInput))
                {
                    Console.Clear();
                    Console.WriteLine("Leave the 'Product Name' empty and press 'Enter' to stop.");
                    for (int i = 0; i < items.Length; i++)
                    {
                        Console.WriteLine($"\nEnter details for item {i + 1}:");
                        Console.Write("Product Name: ");
                        string pName = Console.ReadLine();
                        if (string.IsNullOrEmpty(pName))
                        {
                            Console.Clear();
                            goto WhileLoop;
                        }
                        Console.Write("Description: ");
                        string description = Console.ReadLine();
                        Console.Write("Price: ");
                        double price = double.Parse(Console.ReadLine());
                        price = Math.Round(price, 2);
                        Console.Write("Quantity: ");
                        double quantity = double.Parse(Console.ReadLine());
                        quantity = Math.Round(quantity, 2);

                        items[i] = new Item(pName, description, price, quantity);
                    }
                }
                
                else if (userInput.ToLower() == "exit")
                {
                    break;
                }
            }


            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("Inventory Recorded: \n");
            Console.WriteLine($"Inventory Recorded by: {eName}");
            Console.WriteLine($"Inventory Recorded at: {dateTime}\n");

            foreach (Item item in items)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}