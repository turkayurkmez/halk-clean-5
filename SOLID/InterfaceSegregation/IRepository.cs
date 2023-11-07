namespace InterfaceSegregation
{
    public class Product
    {

    }

    public class Comment { }
    public interface IRepository<T>
    {
        T Get(int id);
        IList<T> GetAll();
        void Create(T entity);



    }

    public interface ISearchByName<T>
    {
        IList<T> SearchByName(string name);
    }

    public class ProductRepository : IRepository<Product>, ISearchByName<Product>
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

        public IList<Product> SearchByName(string name)
        {
            throw new NotImplementedException();
        }
    }

    public class CommentRepository : IRepository<Comment>
    {
        public void Create(Comment entity)
        {

        }

        public Comment Get(int id)
        {
            return new Comment();
        }

        public IList<Comment> GetAll()
        {
            var list = new List<Comment>();
            return (IList<Comment>)list;
        }


    }


}
