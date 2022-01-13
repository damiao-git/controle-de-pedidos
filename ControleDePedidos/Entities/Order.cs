using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using ControleDePedidos.Entities.Enums;

namespace ControleDePedidos.Entities
    {
    class Order
        {
        public DateTime Moment { get; set; } = new DateTime();
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order()
            {
            }

        public Order(DateTime moment, OrderStatus status, Client client)
            {
            Moment = moment;
            Status = status;
            Client = client;
            }
        public void AddItem(OrderItem orderItem)
            {
            OrderItems.Add(orderItem);
            }
        public void RemoveItem(OrderItem orderItem)
            {
            OrderItems.Remove(orderItem);
            }
        public double Total()
            {
            double total = 0;
            foreach (OrderItem obj in OrderItems)
                {
                total += obj.SubTotal();
                }
            return total;
            }
        }
    }
