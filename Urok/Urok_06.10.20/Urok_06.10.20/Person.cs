﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urok_06._10._20
{
    class Person
    {
        // свойство нашего класса
        public string name;
        public int age;

        public Person()
        {
            name = "";
            age = 0;
        }

        public Person(string new_name, int new_age)
        {
            name = new_name;
            age = new_age;
        }

        public Person(int new_age)
        {
            age = new_age;
        }

        public string GetUserData()
        {
            return name + "(" + age.ToString() + ")";
        }
    }
}
