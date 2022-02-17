using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verivox.Services.Models;
using Verivox.Contracts;

namespace Verivox.Services
{
    public class ConsumptionService : IConsumptionService
    {   
        public IEnumerable<IProduct> GetProducts(double consumptionOverYear)
        {
            return new List<Product> {
                { new BasicElectricity(consumptionOverYear) },
                { new PackagedElectricity(consumptionOverYear) }
            }.OrderBy(s => s.AnnualCost);
        }
    }
}
