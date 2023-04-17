using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustCoding0401
{
    internal class Item
    {
        private string EmployeeName { get; set; }
        private string ProductName { get; set; }
        private string Description { get; set; }
        private double Price { get; set; }
        private int Quantity { get; set; }

        public Item(string pName, string description, double price, int quantity)
        {
            ProductName = pName;
            this.Description = description;
            this.Price = price;
            this.Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Product Name: {ProductName}\nDescription: {Description}\nPrice: {Price:C}\nQuantity: {Quantity}\n";
        }
    }
}
