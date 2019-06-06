using System;
using System.Collections.Generic;
using Entities.Models;

namespace Entities.ExtendedModels
{
    public class OwnerExtended
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }

        public IEnumerable<Account> Accounts { get; set; }

        public OwnerExtended()
        {
        }

        public OwnerExtended(Owner owner)
        {
            ID = owner.ID;
            Name = owner.Name;
            DateOfBirth = owner.DateOfBirth;
            Address = owner.Address;
        }
    }
}
