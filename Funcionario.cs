using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ProblemaFuncionario
{
    public class Funcionario
    {
        //public string nome;
        public double salarioB, salarioL, imposto, porcentagem;
        public double CalcularSalarioLiquido(double salario, double imposto)
        {
            salarioL = salario - imposto;
            return salarioL;
        }

        public void AumentarSalario(string nome, double salarioB, double imposto)
        {
            Console.WriteLine("Informe a porcentagem para o novo salario bruto: ");
            porcentagem = Convert.ToInt32(Console.ReadLine());
            porcentagem = ((salarioB * porcentagem) / 100) + salarioB;
            salarioL = porcentagem - imposto;
            Console.WriteLine($"Novo salario\nNome: {nome}\nSalario bruto: {porcentagem}\nImposto: {imposto}\nSalario liquido: {salarioL}\n");
        }

    }
}