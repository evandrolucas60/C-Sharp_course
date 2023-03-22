using System;

namespace HerancaAccountExercice.Entities
{
    class Account
    {

        //variáveis de Instância
        public int number { get; private set; }
        public String Holder { get; private set; }
        public double Balance { get; protected set; }


        //Construtores
        public Account() { }

        public Account(int number, string holder, double balance)
        {
            this.number = number;
            Holder = holder;
            Balance = balance;
        }

        //Métodos
        public void WithDraw(double amount)
        {
            this.Balance -= amount;
        }

        public void Deposit(double amount)
        {
            this.Balance += amount;
        }
    }
}
