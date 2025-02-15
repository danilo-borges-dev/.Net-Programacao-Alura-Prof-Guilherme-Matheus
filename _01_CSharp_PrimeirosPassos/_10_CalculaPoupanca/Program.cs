﻿using System;
using System.Globalization;

namespace _10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 10 - Calcula Poupança");

            double valorInvestido = 1_000;
            int i = 1;

            Console.WriteLine($"Valor Investido R${valorInvestido.ToString("F2", CultureInfo.InvariantCulture)}");

            while(i <= 12)
            {
                valorInvestido += (valorInvestido * 0.0036); // 0.36% = 0.0036
                Console.WriteLine($"Valor Investido em {i} Mês(s) R${valorInvestido.ToString("F2", CultureInfo.InvariantCulture)}");
                i++;
            }
        }
    }
}
