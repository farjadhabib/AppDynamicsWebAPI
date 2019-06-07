using Entities.Models;
using Entities.ExtendedModels;
using System.Collections.Generic;

namespace Contracts
{
	public interface IOwnerRepository : IRepositoryBase<Owner>
	{
        IEnumerable<Owner> GetAllOwners();
        Owner GetOwnerById(int ownerId);
        OwnerExtended GetOwnerWithDetails(int ownerId);
        void CreateOwner(Owner owner);
        void UpdateOwner(Owner dbOwner, Owner owner);
        void DeleteOwner(Owner owner);
    }
}