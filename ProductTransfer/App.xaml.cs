using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Persistence.Daos;
using Persistence.Daos.Interfaces;
using Persistence.UnitOfWork;
using StructureMap;
using Utils;

namespace ProductTransfer
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        void App_Startup(object sender, StartupEventArgs eventArgs)
        {
            ContainerBootstrapper.Initialize();
            //Other logic
        }
    }

    public class ContainerBootstrapper
    {

        public static IContainer Initialize()
        {
            return new Container(c => {
                c.For<IProductDao>().Use<ProductDao>();
                c.For< IActivatorWrapper > ().Use<ActivatorWrapper>();
                c.For<IUnitOfWorkHelper>().Use<UnitOfWorkHelper>();
               // c.For<DbContext>().Use(() => System.Web.HttpContext.Current.GetOwinContext().Get<ApplicationDbContext>());
               // c.AddRegistry<UtilsRegistry>();
               // c.AddRegistry<DAORegistry>();
            }

    );
        }
    }
}
