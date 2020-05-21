
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dependecy_Injection.Entities;


namespace Dependecy_Injection.Service
{
    class IndustryService : AppBase<Product>
    {
        public Industry Industry { get; set; }
        public IndustryService(Industry industry, List<Product> p) : base(p)
        {
            Industry = industry;
        }

        public override void Add(Product t)
        {
            base.Add(t);
            SumTotalValue();
        }

        public void SumTotalValue()
        {
            double sum = list.Select(x => x.Value).Sum();
            Industry.TotalValueProducts =  sum;
        }

        public override Product GetByID(int id)
        {
            return list.Where(x => x.Id == id).FirstOrDefault();
        }

    }
}
