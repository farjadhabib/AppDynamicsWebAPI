using Entities.Models;
using System.Collections.Generic;

namespace Contracts
{
	public interface IAccountRepository : IRepositoryBase<Account>
	{
        IEnumerable<Account> AccountsByOwner(int ownerId);
    }
}