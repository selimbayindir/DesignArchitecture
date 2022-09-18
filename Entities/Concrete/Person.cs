using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Person :IEntity
    {
        public Person()
        {

        }
        public Person(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }

        public int Id { get; set; }
        public String Name { get; set; }
        public String LastName { get; set; }
    }
}
