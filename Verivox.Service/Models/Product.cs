using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verivox.Contracts;

namespace Verivox.Services.Models
{
    public class Product : IProduct
    {
        public string TariffName { get; set; }

        public double AnnualCost { get; set; }
    }
}
