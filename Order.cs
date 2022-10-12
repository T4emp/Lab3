using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    public class Order
    {
        public event System.EventHandler Create;
        public event System.EventHandler GetInfo;
        public event System.EventHandler SetInfo;

        public OrderItem OrderItem
        {
            get => default;
            set
            {
            }
        }

        public DateOnly orderComplete()
        {
            throw new System.NotImplementedException();
        }
        public DateOnly orderDate()
        {
            throw new System.NotImplementedException();
        }
        public int orderNumber()
        {
            throw new System.NotImplementedException();
        }
    }
}