using Dependecy_Injection.Entities.Interface;

using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependecy_Injection.Entities
{


    class Industry 
    {

        public int Id { get; private set; }
        public string CNPJ { get; private set; }
        public Address Address{ get; private set; }

        public double TotalValueProducts { get; set; }

        public Industry(int id, string cnpj, Address address, List<Product> p) 
        {
            Id = id;
            CNPJ = cnpj;
            Address = address;
            

        }





    }
}
