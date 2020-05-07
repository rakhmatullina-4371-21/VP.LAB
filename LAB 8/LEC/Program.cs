using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace LEC
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> numbers = Enumerable.Range(1, 10000);
            // Последовательный запрос 
            var seqQ = from n in numbers
                       where n % 2 == 0
                       select Math.Pow(n, 2);
            foreach (var d in numbers) 
            {
                Console.WriteLine(d);
            }
            // Объявляем запрос, который выполняется параллельно 
            var parQ = from n in numbers.AsParallel()
                       where n % 2 == 0
                       select Math.Pow(n, 2);
            foreach (var d in parQ)
            {
                Console.WriteLine(d);
            }
            Console.ReadKey();
        }
    }
}
