using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipaltiHomeAssignment.Models
{
    public class Name
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object? otherName)
        {
            if (!(otherName is Name))
            {
                return false;
            }
            else
            {
                Name newName = (Name)otherName;
                bool equality = (this.FirstName.Equals(newName.FirstName) && this.LastName.Equals(newName.LastName));
                return equality;
            }
        }
    }
}
