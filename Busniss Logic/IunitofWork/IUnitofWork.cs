using e_commerce.Data.Models;
using E_CommerceProject.Busniss_Logic.IunitofWork.IRepo;

namespace E_CommerceProject.Busniss_Logic.IunitofWork
{
    public interface IUnitofWork
    {
        IMainrepositry<Address> AddressRepo { get; }
        Task SaveAsync();
        void Save();
    }
}
