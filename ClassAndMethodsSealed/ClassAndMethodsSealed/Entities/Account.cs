using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodsSealed.Entities
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
        public virtual void WithDraw(double amount)
        {
            this.Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            this.Balance += amount;
        }
    }
}
