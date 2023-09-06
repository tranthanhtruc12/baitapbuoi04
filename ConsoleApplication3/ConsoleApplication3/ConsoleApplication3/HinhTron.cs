       using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class HinhTron
    {
        private double _bankinh;
        public Toado tam;
        public double Bankinh
        {
            get { return _bankinh; } 
            set {
                if (value > 0)
                    _bankinh = value;
                else Console.WriteLine("Ban kinh phai lon hon 0");
            }
        }
        public HinhTron (Toado tam, double bankinh)
        {
            this.tam = tam;
            this._bankinh = bankinh;
        }
        public double tinhDienTich()
        {
            return Bankinh * Bankinh * 3.14;
        }
        public double tinhChuVi()
        {
            return Bankinh * 2 * 3.14;
        }
    }
}
