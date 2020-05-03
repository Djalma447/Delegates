using System;
using Course.Services;

namespace Course
{
    class Program
    {

        delegate double BinaryNumericOperation(double n1, double n2); // Delegate - Referência para uma Função que recebe dois 'double's' e retorna um número double

        static void Main(string[] args)
        {
            double a = 12;
            double b = 10;

            BinaryNumericOperation op = CalculationService.Sum; // Declaração de um objeto, do Tipo do Delegate criado, usado como referência para o Método Static

            double r1 = op(a, b); // Usando o Método Static através do objeto tipo Delegate declarado
            Console.WriteLine(r1);
        }
    }
}
