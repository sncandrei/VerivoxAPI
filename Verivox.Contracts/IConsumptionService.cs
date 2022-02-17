using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verivox.Contracts
{
    public interface IConsumptionService
    {
        IEnumerable<IProduct> GetProducts(double consumptionOverYear);
    }
}
