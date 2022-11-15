using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperatura
{
    public class Conversor
    {
        public void ToCelcius()
        {
            Console.WriteLine("Digite a temperatura em Fahrenheit a ser convertida para Celcius:");
            double Fahrenheit = Convert.ToDouble(Console.ReadLine());
            double Celsius = (Fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"A temperatura em Celsius é {Celsius}");
            Console.ReadLine();
        }

        public void ToFahrenheit()
        {
            Console.WriteLine("Digite a temperatura em Celsius a ser convertida para Fahrenheit:");
            double Celsius = Convert.ToDouble(Console.ReadLine());
            double Fahrenheit = (9/5 * Celsius) + 32;
            Console.WriteLine($"A temperatura em Fahrenheit é {Fahrenheit}");
            Console.ReadLine();
        }
    }
}
