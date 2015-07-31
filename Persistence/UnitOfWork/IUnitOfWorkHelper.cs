using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Persistence.UnitOfWork
{
    public interface IUnitOfWorkHelper:IDisposable
    {
        event EventHandler<ObjectCreatedEventArgs> ObjectCreated;
        T CreateInstance<T>();
        object CreateInstance(string assemblyName, string typeName);
    }
}
