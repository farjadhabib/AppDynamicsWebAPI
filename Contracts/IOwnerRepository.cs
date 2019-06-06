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
    }
}