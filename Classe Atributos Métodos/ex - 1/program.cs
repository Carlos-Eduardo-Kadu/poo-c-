using EstudosPoo;
using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("--------Dados do primeiro funcionário--------");
            f1.nome = Console.ReadLine()!;
            f1.salario = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine("--------Dados do segundo funcionário--------");
            f2.nome = Console.ReadLine()!;
            f2.salario = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            double mediaSalario = (f1.salario + f2.salario) / 2;

            Console.WriteLine($"Salário médio = {mediaSalario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
