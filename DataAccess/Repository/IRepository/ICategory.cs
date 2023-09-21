using Models;

namespace DataAccess.Repository.IRepository
{
    public interface ICategory : IRepository<Category>
    {
        void Update(Category obj);
    }
}
