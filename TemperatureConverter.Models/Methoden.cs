
namespace TemperatureConverter.Models
{
    /// <summary>
    /// This Class contains Methods that were designed to execute the conversion between the different Temperature Units.
    /// </summary> 
    public class Methoden 
    {
        /// CtoF has a built in Logic for the Converstion between Celsius and Fahrenheit.
        /// <param name="value">Used to transfer the UserInputValue into the Method.</param>
        /// <returns>Returns the converted Value for the new Unit</returns>
        public string CtoF(decimal value)
        {
            return Convert.ToString(value * 9 / 5 + 32);
        }
        /// FtoC has a built in Logic for the Converstion between Fahrenheit and Celsius.
        /// <param name="value">Used to transfer the UserInputValue into the Method.</param>
        /// <returns>Returns the converted Value for the new Unit</returns>
        public string FtoC(decimal value)
        {
            return String.Format("{0:0.000}", (value - 32) * 5 / 9);
        }
        /// CtoK has a built in Logic for the Converstion between Celsius and Kelvin.
        /// <param name="value">Used to transfer the UserInputValue into the Method.</param>
        /// <returns>Returns the converted Value for the new Unit</returns>
        public string CtoK(decimal value)
        {
            return Convert.ToString(value + (decimal)273.15);
        }
        /// KtoC has a built in Logic for the Converstion between Kelvin and Celsius.
        /// <param name="value">Used to transfer the UserInputValue into the Method.</param>
        /// <returns>Returns the converted Value for the new Unit</returns>
        public string KtoC(decimal value)
        {
            return Convert.ToString(value - (decimal)273.15);
        }
    }
}