using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Toado
    {
        private string ten;
        private float x;
        private float y;
        public Toado(string Ten, float x, float y)
        { }
        public void setY(float X)
        {
            this.x = x;
        }
        public void setY(float y)
        {
            this.y = y;
        }
        public void setTen(string ten)
        {
            this.ten = ten; 
        }
        public Toado()
        { }
        public void nhap()
        {
            Console.WriteLine("Nhap Ten");
            ten = Console.ReadLine();
            Console.WriteLine("Nhap X");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Y");
            y = float.Parse(Console.ReadLine());
        }
    }
}
