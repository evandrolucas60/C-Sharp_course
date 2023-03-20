namespace DataObject {
    internal class Program {
        static void Main(string[] args) {

            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);

            /*
             * Instanciação
                • Construtores
                • DateTime(ano, mes, dia)
                • DateTime(ano, mes, dia, hora, minuto, segundo) [opcional: kind]
                • DateTime(ano, mes, dia, hora, minuto, segundo, milissegundo) [opcional: kind]
                • Builders
                • DateTime.Now
                • DateTime.UtcNow
                • DateTime.Today [time: 00:00:00]
                • DateTime.Parse(string)
                • DateTime.ParseExact(string, string)
           
             
                Demo - Now, UtcNow, Today

                DateTime d1 = DateTime.Now;
                DateTime d2 = DateTime.UtcNow;
                DateTime d3 = DateTime.Today;
                Console.WriteLine(d1);
                Console.WriteLine(d2);
                Console.WriteLine(d3);
                

                Demo - Parse

                DateTime d1 = DateTime.Parse("2000-08-15");
                DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");
                DateTime d3 = DateTime.Parse("15/08/2000");
                DateTime d4 = DateTime.Parse("15/08/2000 13:05:58");
             

                Demo - ParseExact

                DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd",
                CultureInfo.InvariantCulture);
                DateTime d2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",
                CultureInfo.InvariantCulture);
             */


        }
    }
}