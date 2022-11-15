using System;
using ConversorTemperatura;

Console.WriteLine($"1 - para converter Fahrenheit par Celsius" + Environment.NewLine +
    "2 - para converter Celsius par Fahrenheit" + Environment.NewLine +
    "3 - sair");

string escolha = "0";

Conversor conversor1 = new Conversor();
while (escolha != "3")
{
    Console.WriteLine("Digite a opção desejada abaixo:");
    escolha = Console.ReadLine();
    switch (escolha)
    {
        case "1":
            conversor1.ToCelcius();
            break;
        case "2":
            conversor1.ToFahrenheit();
            break;
        default:
            Console.WriteLine("Escolha uma opção válida!!!");
            break;
    }
}

