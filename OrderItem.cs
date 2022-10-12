using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    public class OrderItem
    {
        public event System.EventHandler Create;
        public event System.EventHandler GetInfo;
        public event System.EventHandler SetInfo;

        public ComponentPart ComponentPart
        {
            get => default;
            set
            {
            }
        }

        public int itemNumber()
        {
            throw new System.NotImplementedException();
        }
        public double price()
        {
            throw new System.NotImplementedException();
        }
        public int quantity()
        {
            throw new System.NotImplementedException();
        }
    }
}