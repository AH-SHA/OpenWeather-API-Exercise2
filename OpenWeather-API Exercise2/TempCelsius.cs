using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeather_API_Exercise2
{
    public static class TempCelsius
    {
        public static double ConvertFahrenToCel(double zipResult)
        {
            //Note, the use of '0.556' reflects the decimal version of '5/9'
            /*Because we have listed the 'double" as input and output for the method,
            C# reads a fraction as two integers, so it won't compute the formula without you first converting the fraction into a decimal*/
            //Original conversion formula is: ((fahrenheit temprature - 32) * 5/9)


            var celsiusAnswer = (((zipResult) - 32) * 0.556);
            return celsiusAnswer;
        }



    }
}
