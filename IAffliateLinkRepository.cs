using ITTrainingDBContext.DBContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITTraining.Infrastructure
{
	public interface IAffliateLinkQueryRepository : IQueryRepsitory<Affiliatelinks>
	{

	}

	public interface IAffliateLinkRepository : ITrainingSourceQueryRepository, IUpdateRepository<Affiliatelinks>
	{

	}
}
