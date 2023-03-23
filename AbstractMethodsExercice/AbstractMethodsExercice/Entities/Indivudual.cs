using System;

namespace AbstractMethodsExercice.Entities
{
    class Indivudual : TaxPayer
    {
        public double HealthExpenditures { get; set; }


        public Indivudual(string name, double anualIncome, double healthExpenditures)
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (HealthExpenditures == 0)
            {

                if (AnualIncome < 20000.00)
                {
                    return AnualIncome * 0.15;
                }
                else
                {
                    return AnualIncome * 0.25;
                }

            }

            else
            {
                if (AnualIncome < 20000.00)
                {
                    return (AnualIncome * 0.15) - (HealthExpenditures * 0.50);
                }
                else
                {
                    return (AnualIncome * 0.25) - (HealthExpenditures * 0.50);
                }

            }


            

        }




    }
}
