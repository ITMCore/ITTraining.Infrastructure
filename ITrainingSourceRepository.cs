using ITTrainingDBContext.DBContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITTraining.Infrastructure
{
	public interface ITrainingSourceQueryRepository : IQueryRepsitory<Traningsources>
	{

	}

	public interface ITrainingSourceRepository : ITrainingSourceQueryRepository, IUpdateRepository<Traningsources>
	{

	}
}
