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
                .AddDefaultUI()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<database>()
                .AddDefaultTokenProviders();


            services.AddScoped<IUnitofWork,UnitofWork>();


        }
    }
}
