using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercicioFixacao.Service
{
    interface IOnlinePaymentService
    {
        double Payment(double amount);
        double Interest(double amount, int months);
    }
}
