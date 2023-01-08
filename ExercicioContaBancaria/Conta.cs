using System.Globalization;

namespace ExercicioContaBancaria {
    internal class ContaBancariaN {

        public int NumeroConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ContaBancariaN(string nome, int numeroConta) {
            Nome = nome;
            NumeroConta = numeroConta;

        }

        public ContaBancariaN(string nome, int numeroConta, double depositoInicial) : this(nome, numeroConta){
            Deposito(depositoInicial);

        }

        public void Deposito(double quantia) {
            Saldo += quantia;
        }
        public void Sacar(double saque) {
            Saldo -= saque + 5.0;
        }

                
        public override string ToString() {
            return "Conta "
                + NumeroConta
                + ", "
                + "Titular: "
                + Nome
                + ", "
                + "Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
