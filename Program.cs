using ProblemaFuncionario;

namespace FuncionarioOriObj;

class Program
{
    static void Main(string[] args)
    {

        Funcionario f = new Funcionario();
        Console.WriteLine("Salario funcionario!");
        Console.WriteLine("Nome: ");
        string nome = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Salario bruto: ");
        double salarioB = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Imposto: ");
        double imposto = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Nome: {nome}\nSalario bruto: {salarioB}\nImposto: {imposto}\nSalario liquido: {f.CalcularSalarioLiquido(salarioB, imposto)}\n");
        f.AumentarSalario(nome, salarioB, imposto);

    }
}
