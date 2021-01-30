using System;
using Core.Domain.Administration;
using System.Linq;

namespace Core.Abstraction.Repositories
{
    public interface IRepository
    {
        IQueryable<Students> GetStudents();
    }
}
