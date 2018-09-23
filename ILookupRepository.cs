using ITTrainingDBContext.DBContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITTraining.Infrastructure
{
	public interface ILookupQueryRepository : IQueryRepsitory<Lookupconstants>
	{
		IEnumerable<Lookupconstants> FindAllLookuspByCodeType(string codeType);
		Lookupconstants FindLookupByCodeValueAndType(string codeValue, string codeType);
	}

	public interface ILookupRepository : ILookupQueryRepository, IUpdateRepository<Lookupconstants>
	{
	}
}
