using System;
using System.Collections.Generic;
using System.Text;
/* Date: 04 Nov 2020
 * a class Citizen which implements IPerson and has a constructor which takes a string name and an int age. */
namespace PersonInfo
{
    class Citizen: IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Citizen(String name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

    }
}
