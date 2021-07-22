using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Person
    {
        private int _id;

        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }

        private string _name;

        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }

        private string _address;

        public string Address
        {
            set { _address = value; }
            get { return _address; }
        }


        private string _email;

        public string Email
        {
            set { _email = value; }
            get { return _email; }
        }


        private int _age;

        public int Age
        {
            set { _age = value; }
            get { return _age; }
        }

        private string _birthday;

        public string Birthday
        {
            set { _birthday = value; }
            get { return _birthday; }
        }

        public Person(int id, string name, string address, string email, int age, string birthday)
        {
            Id = id;
            Name = name;
            Address = address;
            Email = email;
            Age = age;
            Birthday = birthday;
        }

    }
}
