namespace JustCoding0401
{
    //A lucid inventory management system
    internal class Program
    {
        static void Main(string[] args)
        {
            Item[] items = new Item[3];

            Console.Write("Employee Name: ");
            string eName = Console.ReadLine();

            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"\nEnter details for item {i + 1}:");
                Console.Write("Product Name: ");
                string pName = Console.ReadLine();
                Console.Write("Description: ");
                string description = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                items[i] = new Item(pName, description, price, quantity);
            }

            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("Inventory Received: \n");
            Console.WriteLine($"Inventory received by: {eName}");

            foreach (Item item in items)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}