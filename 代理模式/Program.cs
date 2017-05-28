using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代理模式
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolGirl jiaojiao = new SchoolGirl();
            jiaojiao.Name = "jiaojiao";
            Proxy p = new Proxy(jiaojiao);
            p.GiveChocolate();
            p.GiveDolls();
            p.GiveFlowers();
            Console.ReadKey();
        }
    }
}
