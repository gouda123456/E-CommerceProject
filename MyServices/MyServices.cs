using E_CommerceProject.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace E_CommerceProject.MyServices
{
    public static class MYServices
    {
        public static void AddMyServices(this IServiceCollection services, IConfiguration config)
        {

            string GoudaConnectionString = config.GetConnectionString("Gouda");

            services.AddDbContext<database>(options =>
                options.UseLazyLoadingProxies().UseSqlServer(GoudaConnectionString));

            services.AddIdentity<User, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<database>();


            


        }
    }
}
