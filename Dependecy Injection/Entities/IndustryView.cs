using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependecy_Injection.Entities
{
    public class IndustryView
    {
        public int Id { get; private set; }
        public string CNPJ { get; private set; }
        public string Address { get; private set; }
        public double TotalValueProducts { get; set; }



        public override string ToString()
        {
            return $"Industry: {Id}, CNPJ: {CNPJ}, Address: {Address}, Total value: {TotalValueProducts.ToString("F2")}";
        }


    }
}
