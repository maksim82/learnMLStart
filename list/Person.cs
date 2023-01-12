using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    internal class Person
    {
        private string _name;
        private int _age;

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public string toaString()
        {
            return "Имя пользователя - " + _name + " / Возраст - " + _age;
        }
    }
}
