using System.Linq.Expressions;

namespace E_CommerceProject.Busniss_Logic.IunitofWork.IRepo
{
    
    public interface IMainrepositry<T> where T : class
    {
        T FindById(int id);

        T SelectOne(Expression<Func<T, bool>> match);

        IEnumerable<T> GetAll();

        IEnumerable<T> GetAll(params string[] agers);

        Task<T> FindByIdAsync(int id);

        Task<IEnumerable<T>> GetAllAsync();

        Task<IEnumerable<T>> GetAllAsync(params string[] agers);

        void AddOne(T myItem);

        void UpdateOne(T myItem);

        void DeleteOne(T myItem);

        void AddList(IEnumerable<T> myList);

        void UpdateList(IEnumerable<T> myList);

        void DeleteList(IEnumerable<T> myList);
    }
}
