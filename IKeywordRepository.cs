using ITTrainingDBContext.DBContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITTraining.Infrastructure
{
    public interface IKeywordQueryRepository : IQueryRepsitory<Keywords>
	{
		IEnumerable<Keywords> FindAllKeywordForSubjectId(int subjectId);
		IEnumerable<Keywords> FindAllKeywordForSubject(Subjects subjectId);
	}

	public interface IKeywordRepository : IKeywordQueryRepository, IUpdateRepository<Keywords>
	{
	}
}
