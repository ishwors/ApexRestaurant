using Microsoft.Extensions.DependencyInjection;
using ApexRestaurant.Services.SCustomer;
using ApexRestaurant.Services.SMeal;
using ApexRestaurant.Services.SMealDish;
using ApexRestaurant.Services.SMenu;
using ApexRestaurant.Services.SMenuItem;
using ApexRestaurant.Services.SStaff;
using ApexRestaurant.Services.SStaffRole;

namespace ApexRestaurant.Services
{
    public static class ServicesModule
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IMealService, MealService>();
            services.AddTransient<IMealDishService, MealDishService>();
            services.AddTransient<IMenuService, MenuService>();
            services.AddTransient<IMenuItemService, MenuItemService>();
            services.AddTransient<IStaffService, StaffService>();
            services.AddTransient<IStaffRoleService, StaffRoleService>();
        }
    }
}