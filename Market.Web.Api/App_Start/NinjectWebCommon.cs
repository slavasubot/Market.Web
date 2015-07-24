using Market.Data.Repositories;
using System.Reflection;
using Market.Services.Categories;
using Market.Services.Purchases;
using Market.Services.Services;
using Ninject;
using Ninject.Modules;

namespace Market.Web.Api
{
    public class NinjectWebCommon
    {
        public static StandardKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            return kernel;
        }
    }

    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IAccountRepository>().To<AccountRepository>();

            Bind<IUserRepository>().To<UserRepository>();
            Bind<IUserService>().To<UserService>();

            Bind<IPurchaseRepository>().To<PurchaseRepository>();
            Bind<ICategoryRepository>().To<CategoryRepository>();
            Bind<IPurchaseService>().To<PurchaseService>();
            Bind<ICategoryService>().To<CategoryService>();

        }
    }   

}