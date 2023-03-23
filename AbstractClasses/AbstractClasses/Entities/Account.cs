using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses.Entities
{
    //Classes abstratas - São classes que não podem ser instanciadas
    /*
     * É uma forma de garantir herança total: somente subclasses não
       abstratas podem ser instanciadas, mas nunca a superclasse abstrata
     */
    abstract class Account 
    {

        //variáveis de Instância
        public int Number { get; private set; }
        public String Holder { get; private set; }
        public double Balance { get; protected set; }


        //Construtores
        public Account() { }

        public Account(int number, string holder, double balance)
        {
            this.Number = number;
            Holder = holder;
            Balance = balance;
        }

        //Métodos
        public virtual void WithDraw(double amount)
        {
            this.Balance -= amount + 5;
        }

        public virtual void Deposit(double amount)
        {
            this.Balance += amount;
        }
    }
}
