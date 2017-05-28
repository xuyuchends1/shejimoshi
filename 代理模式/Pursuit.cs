using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代理模式
{
    //追求者
    class Pursuit : IGiveGift
    {
        SchoolGirl mm;
        public Pursuit(SchoolGirl mm)
        {
            this.mm = mm;
        }
        public void GiveChocolate()
        {
            Console.WriteLine(mm.Name + "song ni qiaokeli");
        }

        public void GiveDolls()
        {
            Console.WriteLine(mm.Name + "song ni yang wa wa");
        }

        public void GiveFlowers()
        {
            Console.WriteLine(mm.Name + "song ni xian hua");

        }
    }
}
