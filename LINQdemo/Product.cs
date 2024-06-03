﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQdemo
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"Id : {Id}, Name : {Name}, Company : {Company}, Price : {Price}";
        }
    }

}
