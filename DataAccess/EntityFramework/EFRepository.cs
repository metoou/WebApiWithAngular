using Core.Abstraction.Repositories;
using Core.Domain.Administration;
using System.Linq;

namespace DataAccess.EntityFramework
{
    public class EFRepository : IRepository
    {
        private readonly AppDbContext context;
        public EFRepository (AppDbContext context)
        {
            this.context = context;
        }
        public IQueryable<Students> GetStudents()
        {
            return context.Students;
        }
    }
}
