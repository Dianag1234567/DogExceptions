using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogExceptions
{
    class Dog
    {
        private int age;
        private string name;
        public int Age
        {
            get { return this.age; }
            set
            {
                if(value>=0 && value <= 100)
                {
                    this.age = value;
                }
                if (value<0)
                {
                    throw new ArgumentException("Numarul este negativ");
                }
                if (value>100)
                {
                    throw new ApplicationException("Numarul este mai mare de 100");
                }
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length>=2)
                {
                    this.name = value;
                }
                else
                {
                    throw new ApplicationException("Numele este mai scurt de 2 caractere");
                }
            }
        }

        public Dog(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }
    }
}
