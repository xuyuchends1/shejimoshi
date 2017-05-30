using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 原型模式
{
    // 简历
    class Resume:ICloneable
    {
        public string name;
        public string sex;
        public int age;
        public string timeArea;
        public string company;

        public Resume(string name)
        {
            this.name = name;
        }
        public void SetPersionInfo(string sex,int age)
        {
            this.sex = sex;
            this.age = age;
        }
        public void SetWorkExpersience(string timeArea,string company)
        {
            this.timeArea = timeArea;
            this.company = company;
        }
        public void Display()
        {
            Console.WriteLine("{0}{1}{2}", name, sex, age);
            Console.WriteLine("{0}{1}", timeArea, company);
        }

        //深复制
        public object Clone()
        {
            // 浅复制
            return this.MemberwiseClone();
        }
    }
}
