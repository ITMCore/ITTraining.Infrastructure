using ITTrainingDBContext.DBContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITTraining.Infrastructure
{
	public interface IAdminUserProfileQueryRepository : IQueryRepsitory<Adminuseraccounts>
	{

	}

	public interface IAdminUserProfileRepository : ITrainingSourceQueryRepository, IUpdateRepository<Adminuseraccounts>
	{

	}
}
