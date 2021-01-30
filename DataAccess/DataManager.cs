using Core.Abstraction.Repositories;

namespace DataAccess
{
    public class DataManager
    {
        public IRepository Repository { get; set; }
        public DataManager(IRepository repository)
        {
            Repository = repository;
        }
    }
}
