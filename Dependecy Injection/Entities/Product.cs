using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependecy_Injection.Entities
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Value = {Value.ToString("F2")}";
        }

    }
}
