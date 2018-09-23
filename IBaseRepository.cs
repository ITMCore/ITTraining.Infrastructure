using System;
using System.Collections.Generic;
using System.Linq;

namespace ITTraining.Infrastructure
{
    public interface IQueryRepsitory<T>
    {
		IEnumerable<T> FindAll(Func<T, bool> match);
		IEnumerable<T> FindById(object resourceIdenitifer);
	}

	public interface IUpdateRepository<T> : IQueryRepsitory<T>
	{
		void Add(T resource);
		void Save(T resource);
		void Remove(T resource);
	}
}
