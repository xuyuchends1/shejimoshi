using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 原型模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume r1 = new Resume("aa");
            r1.SetPersionInfo("1", 25);
            r1.SetWorkExpersience("a", "b");

            //深度clone
            Resume r2 = (Resume)r1.Clone();

            r1.name = "bb";
            r1.SetPersionInfo("2", 20);
            r1.SetWorkExpersience("c", "d");
        }
    }
}
