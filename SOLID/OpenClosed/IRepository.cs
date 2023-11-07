namespace OpenClosed
{
    public class Product
    {

    }
    internal interface IRepository<T>
    {
        T Get(int id);
        IList<T> GetAll();
        void Create(T entity);
    }

    public class ADORepository : IRepository<Product>
    {
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetAll()
        {
            throw new NotImplementedException();
        }
    }

    public class EFRepository : IRepository<Product>
    {
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
