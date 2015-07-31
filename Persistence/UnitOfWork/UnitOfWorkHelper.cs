using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Persistence.UnitOfWork
{
    public class UnitOfWorkHelper
    {
        public ApplicationDbContext _sessionContext;
        public event EventHandler<ObjectCreatedEventArgs> ObjectCreated;

        public IApplicationDbContext DbContext
        {
            get
            {
                if (_sessionContext == null)
                {
                    _sessionContext=new ApplicationDbContext();
                    ((IObjectContextAdapter) _sessionContext).ObjectContext.ObjectMaterialized +=
                        (sender, e) => OnObjectCreated(e.Entity);
                }
                return _sessionContext;
            }
            
            
            }

        private void OnObjectCreated(object entity)
        {
            if (ObjectCreated != null)
                ObjectCreated(this, new ObjectCreatedEventArgs(entity));
        }
    }

}
