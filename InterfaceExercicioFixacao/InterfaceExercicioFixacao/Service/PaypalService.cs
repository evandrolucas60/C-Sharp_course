using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercicioFixacao.Service
{
    class PaypalService : IOnlinePaymentService
    {
        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;

        public double Payment(double amount)
        {
            return amount *  FeePercentage;
        }

        public double Interest(double amount, int months)
        {
           return amount  * MonthlyInterest * months;
        }
    }
}
