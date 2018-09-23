using ITTrainingDBContext.DBContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITTraining.Infrastructure
{
	public interface ITrainingQueryRepository : IQueryRepsitory<Traningitems>
	{
		IEnumerable<Traningitems> FindAllTrainingItemsbySource(int SourceId);
	}

	public interface ITrainingRepository : ITrainingQueryRepository, IUpdateRepository<Traningitems>
	{

	}
}
