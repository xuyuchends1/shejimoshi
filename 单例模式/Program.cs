﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.getInstance();
            Singleton s2 = Singleton.getInstance();

        }
    }
}
