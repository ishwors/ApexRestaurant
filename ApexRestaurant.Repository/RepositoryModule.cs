// //for Startup.cs
// using Microsoft.EntityFrameworkCore;
// using Microsoft.Extensions.DependencyInjection;
// using ApexRestaurant.Repository.RCustomer;
// using ApexRestaurant.Repository.RMeal;
// using ApexRestaurant.Repository.RMealDish;
// using ApexRestaurant.Repository.RMenu;
// using ApexRestaurant.Repository.RMenuItem;
// using ApexRestaurant.Repository.RStaff;
// using ApexRestaurant.Repository.RStaffRole;

// namespace ApexRestaurant.Repository
// {
//     public static class RepositoryModule
//     {
//         public static void Register(IServiceCollection services)
//         {

//             string migrationsAssembly = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;

//             services.AddDbContext<RestaurantContext>(options => options.UseSqlServer(
//                 @"Server=ISG-VICTUS\SQLEXPRESS;Initial Catalog=ApexRestaurantDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False",
//                 builder => builder.MigrationsAssembly(migrationsAssembly)
//             ));

//             services.AddTransient<ICustomerRepository, CustomerRepository>();
//             services.AddTransient<IMealRepository, MealRepository> ();
//             services.AddTransient<IMealDishRepository, MealDishRepository> ();
//             services.AddTransient<IMenuRepository, MenuRepository> ();
//             services.AddTransient<IMenuItemRepository, MenuItemRepository> ();
//             services.AddTransient<IStaffRepository, StaffRepository> ();
//             services.AddTransient<IStaffRoleRepository, StaffRoleRepository> ();
//         }
//     }
// }



using ApexRestaurant.Repository.RCustomer;
using ApexRestaurant.Repository.RMeal;
using ApexRestaurant.Repository.RMealDish;
using ApexRestaurant.Repository.RMenu;
using ApexRestaurant.Repository.RMenuItem;
using ApexRestaurant.Repository.RStaff;
using ApexRestaurant.Repository.RStaffRole;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ApexRestaurant.Repository
{
    public static class RepositoryModule
    {
        public static void Register(IServiceCollection services, string connection, string migrationsAssembly)
        {
            services.AddDbContext<RestaurantContext>(options =>
                options.UseSqlServer(connection, builder =>
                    builder.MigrationsAssembly(migrationsAssembly)));
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IMealRepository, MealRepository>();
            services.AddTransient<IMealDishRepository, MealDishRepository>();
            services.AddTransient<IMenuRepository, MenuRepository>();
            services.AddTransient<IMenuItemRepository, MenuItemRepository>();
            services.AddTransient<IStaffRepository, StaffRepository>();
            services.AddTransient<IStaffRoleRepository, StaffRoleRepository>();
        }
    }
}