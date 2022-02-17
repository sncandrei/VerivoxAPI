namespace Verivox.Services.Models
{
    public class PackagedElectricity : Product
    {
        // Name: “Packaged tariff”
        // Calculation model: 800 € for up to 4000 kWh/year and above 4000 kWh/year additionally 30 cent/kWh
        public PackagedElectricity(double currentConsumption)
        {
            var additionalKwhConsumption = currentConsumption > 4000 ? currentConsumption - 4000 : 0;

            TariffName = "Packaged Tarrif";
            AnnualCost = 800 + (additionalKwhConsumption * 0.30);
        }
    }
}
