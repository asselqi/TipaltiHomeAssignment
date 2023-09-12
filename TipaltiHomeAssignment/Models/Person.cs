using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipaltiHomeAssignment.Models
{
    public class Person
    {
        public Name FullName { get; set; }
        public Address Address { get; set; }

       /* public override bool Equals(object? otherPerson)
        {
            if (!(otherPerson is Name))
            {
                return false;
            }
            else
            {
                Person newPerson = (Person)otherPerson;
                bool equality = (this.FullName.Equals(newPerson.FullName) && this.Address.Equals(newPerson.Address));
                return equality;
            }
        }*/
    }
}
