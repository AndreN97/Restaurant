using System;

namespace Restaurant.Domain
{
    class Order
    {
        public string Dish { get; set; }
        public string Table { get; set; }
        public DateTime RegisteredAt { get; } = DateTime.Now;
        public DateTime? StartedAt { get; }
        public DateTime? CompletedAt { get; }

        public Order(string dish, string table)
        {
            Dish = dish;
            Table = table;
        }
    }
}
