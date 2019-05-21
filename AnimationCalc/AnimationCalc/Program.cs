using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sort;

namespace AnimationCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] d = { 2, 3, 1, 9, 8, 4, 10 };
            List<double> listd = new List<double>();
            
            foreach(double j in d)
            {
                listd.Add(j);
            }

            sortMethod sortTest = new InsertSort();
            sortTest.sort(ref listd);

            foreach(double num in listd)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }
    }
}
