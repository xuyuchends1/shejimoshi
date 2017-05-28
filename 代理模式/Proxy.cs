using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代理模式
{
    /// <summary>
    /// 代理
    /// </summary>
    class Proxy:IGiveGift
    {
        Pursuit p;
        public Proxy(SchoolGirl mm)
        {
            p = new Pursuit(mm);
        }

        public void GiveChocolate()
        {
            p.GiveChocolate();
        }

        public void GiveDolls()
        {
            p.GiveDolls();
        }

        public void GiveFlowers()
        {
            p.GiveFlowers();
        }
    }
}
