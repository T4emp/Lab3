using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    public class Client
    {
        public event System.EventHandler AddClient;
        public event System.EventHandler GetInfo;
        public event System.EventHandler RemoveClient;

        public Order Order
        {
            get => default;
            set
            {
            }
        }

        public string address()
        {
            throw new System.NotImplementedException();
        }
        public string name()
        {
            throw new System.NotImplementedException();
        }
        public string phone()
        {
            throw new System.NotImplementedException();
        }
    }
}