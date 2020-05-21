using Dependecy_Injection.Entities;
using Dependecy_Injection.Service;
using System.Collections.Generic;
using System;
using AutoMapper;

namespace Dependecy_Injection
{
    class Program
    {
        static void Main(string[] args)
        {


            //only work with concrete class not work for dependency injector Pattern
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Industry, IndustryView>()
            .ForMember(i => i.Address,m => m.MapFrom(iv => iv.Address.Street + iv.Address.City))
            .ForMember(i => i.TotalValueProducts, m => m.MapFrom(iv=> iv.TotalValueProducts)));
            var map = new Mapper(config);

            List<Product> products = new List<Product>()
            {
                new Product(){Id=1,Name="Matel",Value = 235.00 },
                new Product(){Id=2,Name="Celular",Value = 1960.00 },
                new Product(){Id=3,Name="Computador",Value = 3555.99}
            };

            Address ad = new Address() { City = "Varzea", Kind = "House", State = "Sao Paulo", Number = 118, Street = "Vitorio Rossi" };
            Industry ind = new Industry(1,"12334567",ad,products);
            IndustryService industryService = new IndustryService(ind, products);


           
            Console.WriteLine(industryService.GetByID(2));
            Console.WriteLine();
            foreach(var p in industryService.GetAll())
                Console.WriteLine(p);
            
            industryService.Add(new Product() { Id = 4, Name = "Barbie", Value = 145.00 });
            Console.WriteLine();
            foreach (var p in industryService.GetAll())
                Console.WriteLine(p);
            Console.WriteLine();
            industryService.Remove(industryService.GetByID(1));
            foreach (var p in industryService.GetAll())
                Console.WriteLine(p);
            Console.WriteLine();

            var indView = map.Map<Industry, IndustryView>(ind);

            Console.WriteLine(indView);










            Console.ReadKey();

        }
    }
}
