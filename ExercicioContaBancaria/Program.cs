using ExercicioContaBancaria;
using System;
using System.Globalization;

namespace ContaBancaria {
    internal class Program {
        static void Main(string[] args) {

            ContaBancariaN conta;

            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();


            Console.Write("Haverá depósito inicial (s/n)? ");
            char sdeposito = char.Parse(Console.ReadLine());


            
            if (sdeposito == 's' || sdeposito == 'S') {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancariaN(titular, numeroConta, depositoInicial);
            }
            else {
                conta = new ContaBancariaN(titular, numeroConta);
            }
                                  

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Sacar(saque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);



        }
    }
}