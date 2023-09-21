using Models;

namespace DataAccess.Repository.IRepository
{
    public interface IProduct : IRepository<Product>
    {
        void Update(Product obj);
    }
}
