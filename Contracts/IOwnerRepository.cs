using Entities.Models;
using System.Collections.Generic;

namespace Contracts
{
	public interface IOwnerRepository : IRepositoryBase<Owner>
	{
        IEnumerable<Owner> GetAllOwners();
        Owner GetOwnerById(int ownerId);
    }
}