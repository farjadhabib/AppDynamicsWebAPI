using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoggerService;
using Contracts;

namespace AppDynamicsWebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ValuesController : ControllerBase
	{

		private ILoggerManager _logger;
		private IRepositoryWrapper _repositoryWrapper;
		public ValuesController(ILoggerManager logger, IRepositoryWrapper repositoryWrapper)
		{
			_logger = logger;
			_repositoryWrapper = repositoryWrapper;
		}
		// GET api/values
		[HttpGet]
		public IEnumerable<string> Get()
		{
			var domesticAccounts = _repositoryWrapper.Account.FindByCondition(x => x.AccountType.Equals("Domestic"));
			var owners = _repositoryWrapper.Owner.FindAll();

			_logger.LogInfo("Here is info message from our values controller.");
			_logger.LogDebug("Here is debug message from our values controller.");
			_logger.LogWarn("Here is warn message from our values controller.");
			_logger.LogError("Here is error message from our values controller.");
			return new string[] { "value1", "value2" };
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public ActionResult<string> Get(int id)
		{
			return "value";
		}

		// POST api/values
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/values/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/values/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
