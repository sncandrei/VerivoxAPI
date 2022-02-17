namespace Verivox.Services.Models
{
    public class BasicElectricity : Product
    {            
        // Name: “basic electricity tariff”
        // Calculation model: base costs per month 5 € + consumption costs 22 cent/kWh
        public BasicElectricity(double currentConsumption)
        {
            TariffName = "Basic Electricity Tarrif";
            AnnualCost = 5 * 12 + currentConsumption * 0.22;
        }
    }
}
