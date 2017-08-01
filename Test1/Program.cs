using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Report rep = new Report();

            rep.PrintReport();


            //Console.OutputEncoding = Encoding.UTF8;
            //Menu menuObj = new Menu();
            //menuObj.MainMenu();
            //menuObj.ExitProject();

            Console.ReadKey();
        }
    }
}
