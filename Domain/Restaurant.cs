using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Domain
{
    class RestaurantX
    {
        public string Name { get; set; }
        private Queue<Order> OrderQueue { get; } = new Queue<Order>();

        public RestaurantX(string name)
        {
            Name = name;
        }

        public void RegisterOrder(Order order)
        {
            OrderQueue.Enqueue(order);
        }
    }
}
