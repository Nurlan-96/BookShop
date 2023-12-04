using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Domain.Models
{
    public class Book : Product
    {
        public string Author { get; set; }
        public int Pages { get; set; }
        public Book(string name, int price, int count, string author, int pages) : base(name, price, count)
        {
            Author = author;
            Pages = pages;
        }

        public override string ShowInfo()
        {
            return $"Book Name: {Name}, Author: {Author}, Pages: {Pages}, Price: {Price}, In Stock:{Count}";
        }

        public override void Sell()
        {
            if (Count < 1)
            {
                Console.WriteLine(Helpers.Helpers.Error.OutOfStock);
            }
            else
            {
                Count--;
                TotalIncome += Price;
                Console.WriteLine(TotalIncome);
            }
        }
    }
}
