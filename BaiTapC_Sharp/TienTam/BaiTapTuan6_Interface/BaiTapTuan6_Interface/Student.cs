using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTuan6_Interface
{
    interface IGuru99Interface
    {
        void Setter(int id, string name, int age);
        string GetName();

        int GetID();
    }

    class Guru99Tutorial : IGuru99Interface
    {
        protected int id;
        protected string name;
        protected int age;

        public Guru99Tutorial(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public void Setter(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public string GetName()
        {
            return name;
        }

        public int GetID()
        {
            return id;
        }


    }
}
