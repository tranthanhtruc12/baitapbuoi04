using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
          Toado td = new Toado("Hinh Tron",5,5);
          HinhTron ht = new HinhTron(td,10.5);
          ht.XuatTTHinhTron();
          Console.ReadKey();
        }
        }
    }
}
