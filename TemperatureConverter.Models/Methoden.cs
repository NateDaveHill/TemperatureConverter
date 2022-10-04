
namespace TemperatureConverter.Models
{
    public class Methoden 
    {
        public string CtoF(decimal value)
        {
            return Convert.ToString(value * 9 / 5 + 32);
        }

        public string FtoC(decimal value)
        {
            return String.Format("{0:0.000}", (value - 32) * 5 / 9);
        }

        public string CtoK(decimal value)
        {
            return Convert.ToString(value + (decimal)273.15);
        }
    }
}