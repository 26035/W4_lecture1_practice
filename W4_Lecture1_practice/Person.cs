using System;
using System.Collections.Generic;
using System.Text;

namespace W4_Lecture1_practice
{
    public class Person
    {
        private string name;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        
        public Person(string name)
        {
            this.name = name;
        }

        public string Destructor()
        {
            name = "";
            return name;
        }
         ~Person()
        {
            this.name = "";
        }
        public override string ToString()
        {
            return name;
        }

    }
}
