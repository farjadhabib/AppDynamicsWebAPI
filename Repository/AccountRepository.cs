using System.Collections.Generic;
using Contracts;
using Entities;
using Entities.Models;
using System.Linq;

namespace Repository
{
	public class AccountRepository : RepositoryBase<Account>, IAccountRepository
	{
		public AccountRepository(RepositoryContext repositoryContext)
			: base(repositoryContext)
		{
		}

        public IEnumerable<Account> AccountsByOwner(int ownerId)
        {
            return FindByCondition(a => a.OwnerId==ownerId).ToList();
        }
    }
}