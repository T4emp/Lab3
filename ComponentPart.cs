using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    public class ComponentPart
    {
        public event System.EventHandler AddComponent;
        public event System.EventHandler GetInfo;
        public event System.EventHandler RemoveComponent;

        public string description()
        {
            throw new System.NotImplementedException();
        }
        public string manufacturer()
        {
            throw new System.NotImplementedException();
        }
        public string name()
        {
            throw new System.NotImplementedException();
        }
        public double price()
        {
            throw new System.NotImplementedException();
        }
    }
}