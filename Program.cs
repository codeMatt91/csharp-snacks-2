using System;
/*
 Scrivere un codice csharp che crea un accumulatore e poi lo utilizza
 Esempio: var accumulatore1 = CreaAccumulatore();
 accumulatore1(10) => 10
 accumulatore1(40) => 50
 accumulatore1(90) => 140
 */
namespace csharp_snacks_2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // QUESTO METODO E CHIAMATO -CLOSURE- : serve ad utilizzare due funzioni Lambda che creano un aggregatore, cioe si tiene in momoria il risultato della funzione,
            // quabndo la richiamo lui prendera il valore precedente e sommera quello nuovo 
            //var Maker = () =>
            //{
            //    long totale = 0;
            //    return (int n) =>
            //    {
            //        totale += n;
            //        return totale;
            //    };
            //};
            //var acc1 = Maker();
            //var acc2 = Maker();


            //Console.WriteLine(acc1(10));
            //Console.WriteLine(acc1(10));
            //Console.WriteLine(acc1(10));
            //Console.WriteLine(acc2(10));
            //Console.WriteLine(acc2(10));
            //Console.WriteLine(acc2(10));


            // Data una lista di interi, metterli tutti al quadrato

            List<int> list = new List<int>() { 2,3,4,5,6,7,8,9 };
            List<int> list2 = MettiAlQuadrato(list);
            foreach (int i in list2)
            { 
                Console.WriteLine(i);
            }

            List<int> MettiAlQuadrato(List<int> li)
            { 
                List<int> vs = new List<int>();
                foreach (int i in li)
                {
                    int sqr = i * i;
                    vs.Add(sqr);
                }
                return vs;
            }

            // REALIZZARE UN METODO CHE ESEGUE LA FUNZIONE AL CUBO
            List<int> list3 = MettiAlCubo(list);
            foreach (int i in list3)
            {
                Console.WriteLine(i);
            }

            List<int> MettiAlCubo(List<int> li)
            {
                List<int> vs = new List<int>();
                foreach (int i in li)
                {
                    int sqr = (int)Math.Pow(i,3);
                    vs.Add(sqr);
                }
                return vs;
            }



            //Abbiamo in questo modo costruito una funzione "generale" per trasformare
            //tutti gli elementi di una stringa da numero intero a numero intero => nuovo = f(vecchio);
            //Purtroppo per come è stata costruita, questa funzione si applica esclusivamente alle lista di numeri interi 
            //e torna una lista di numeri interi
            List<int> EseguiIlCalcolo(List<int> li, Func<int, int> fun)
            {
                List<int> lout = new List<int>();
                foreach (int n in li)
                    lout.Add(fun(n));
                return lout;
            }
            List<int> lcalcolo = EseguiIlCalcolo(list, (n) => n * (n + 1) / 2);
            foreach (int n in lcalcolo)
                Console.WriteLine(n);
            
        }
    }
}
