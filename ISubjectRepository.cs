using System;
using System.Collections.Generic;
using System.Text;
using ITTrainingDBContext.DBContext;

namespace ITTraining.Infrastructure
{
    public interface ISubjectQueryRepository : IQueryRepsitory<Subjects>
	{
		IEnumerable<Subjects> FindAllSubjectsForKeyword(string keywordPattern);
		IEnumerable<Subjects> FindAllSubjectByName(string subjeName);
	}

	public interface ISubjectRepository : ISubjectQueryRepository, IUpdateRepository<Subjects>
	{
		
	}
}
