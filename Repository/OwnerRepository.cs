using System.Collections.Generic;
using Contracts;
using Entities;
using Entities.Models;
using Entities.ExtendedModels;
using System.Linq;
using Entities.Extensions;

namespace Repository
{
	public class OwnerRepository : RepositoryBase<Owner>, IOwnerRepository
	{
		public OwnerRepository(RepositoryContext repositoryContext)
			: base(repositoryContext)
		{
		}

        public IEnumerable<Owner> GetAllOwners()
        {
            return FindAll()
                .OrderBy(ow => ow.Name)
                .ToList();
        }

        public Owner GetOwnerById(int ownerId)
        {
            return FindByCondition(owner => owner.ID.Equals(ownerId))
                    .DefaultIfEmpty(new Owner())
                    .FirstOrDefault();
        }

        public OwnerExtended GetOwnerWithDetails(int ownerId)
        {
            return new OwnerExtended(GetOwnerById(ownerId))
            {
                Accounts = RepositoryContext.Accounts
                    .Where(a => a.OwnerId == ownerId)
            };
        }

        public void CreateOwner(Owner owner)
        {
            Create(owner);
        }

        public void UpdateOwner(Owner dbOwner, Owner owner)
        {
            dbOwner.Map(owner);
            Update(dbOwner);
        }
    }
}