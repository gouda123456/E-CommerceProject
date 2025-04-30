using E_CommerceProject.Data;

namespace E_CommerceProject.Busniss_Logic.IunitofWork.IRepo
{
    public interface IUserRepositry : IMainrepositry<User>
    {
        
        
        Task<User?> FindByEmailAsync(string email);
        Task<User?> FindByPhoneAsync(string phone);
        Task<User?> FindByUserNameAsync(string userName);

        Task<List<User>> GetAllUsers();
        Task<List<User>> GetUsersByRole(string Role);

    }

}

