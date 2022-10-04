
namespace TemperatureConverter.Models
{
    public class Methoden 
    {
        public string CtoF(decimal value)
        {
            return Convert.ToString(value * 9 / 5 + 32);
        }
    }
}