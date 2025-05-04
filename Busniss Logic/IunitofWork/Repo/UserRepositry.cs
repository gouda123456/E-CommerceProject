
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace E_CommerceProject.Busniss_Logic.IunitofWork.Repo
{
    public class UserRepositry : Mainrepositry<User>, IUserRepositry
    {

        public database db { get; set; }
        public UserManager<User> usermanager { get; set; }

        public UserRepositry(database database , UserManager<User> manager) : base(database)
        {
            db = database;
            usermanager = manager;

        }


        public async Task<User?> FindByEmailAsync(string email)
        {
            var user = await usermanager.FindByEmailAsync(email);

            return user;
        }

        public async Task<User?> FindByPhoneAsync(string phone)
        {
            var user = await usermanager.Users
                .Where(u => u.PhoneNumber == phone)
                .FirstOrDefaultAsync();

            return user;
        }

        public async Task<User?> FindByUserNameAsync(string userName)
        {
            var user = await usermanager.FindByNameAsync(userName);
            return user;
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await usermanager.Users.ToListAsync();
        }

        public async Task<List<User>> GetUsersByRole(string Role)
        {
            var users = await usermanager.GetUsersInRoleAsync(Role);
            return users.ToList();
        }


    }
}
