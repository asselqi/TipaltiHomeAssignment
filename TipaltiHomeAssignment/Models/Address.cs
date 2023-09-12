using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipaltiHomeAssignment.Models
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }

        public override bool Equals(object? otherAddress)
        {
            if (!(otherAddress is Address))
            {
                return false;
            }
            else
            {
                Address newAddress = (Address)otherAddress;
                bool equality = (this.Street.Equals(newAddress.Street) && this.City.Equals(newAddress.City));
                return equality;
            }
        }
    }
}
