using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Domain.Models
{
    public abstract class Product
    {
        private int _id;
        public int Id { get; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        private int _totalincome;

        protected int TotalIncome { get; set; }


        public Product(string name, int price, int count)
        {
            _id++;
            Id=_id;
            TotalIncome = _totalincome;
            Name = name;
            Price = price;
            Count = count;
        }

        public abstract string ShowInfo();
        public abstract void Sell();
    }
}
