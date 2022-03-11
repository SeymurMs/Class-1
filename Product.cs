using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    internal class Product
    {
        
        public string name;
        public string BrandName = "BrandName";
        public double price;
            public string GetInfo()
        {
            string Info = $"Name:{name} BrandName:{BrandName} Price:{price}$";
            return Info;
        }
    }
}
