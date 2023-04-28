using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTakeManagements
{
    internal class Item
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        public Item(string pName, string description, double price, double quantity)
        {
            ProductName = pName;
            this.Description = description;
            this.Price = price;
            this.Quantity = quantity;
        }
        public override string ToString()
        {
            string.Format("R0.00", Price);
            string.Format("00.00g", Quantity);
            return ($"Product Name: {ProductName}\nDescription: {Description}\nPrice: {Price}\nQuantity: {Quantity}\n");
        }
    }

}
