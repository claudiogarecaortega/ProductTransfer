using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistence.UnitOfWork;
using Utils;

namespace Persistence.Daos
{
    public abstract class Dao<TModelo> where TModelo : class, new()
    {

        protected IUnitOfWorkHelper UnitOfWorkHelper;
        protected readonly IActivatorWrapper Activator;

        protected Dao(IUnitOfWorkHelper unitOfWorkHelper, IActivatorWrapper activator)
        {
            UnitOfWorkHelper = unitOfWorkHelper;
            Activator = activator;
        }

        public virtual TModelo Get(object id)
        {
            return UnitOfWorkHelper.DbContext.Set<TModelo>().Find(id);
        }

        public virtual TModelo Get(object[] id)
        {
            return UnitOfWorkHelper.DbContext.Set<TModelo>().Find(id);
        }

        public virtual TModelo GetForEdit(object id)
        {
            return this.Get(id);
        }

        public virtual TModelo GetForEdit(object[] id)
        {
            return this.Get(id);
        }

        public virtual TModelo GetForDelete(object id)
        {
            return this.Get(id);
        }

        public virtual TModelo GetForDelete(object[] id)
        {
            return this.Get(id);
        }

        public virtual IEnumerable<TModelo> GetAll()
        {
            return this.GetAllInternal().ToList();
        }

        protected virtual IQueryable<TModelo> GetAllInternal()
        {
            return UnitOfWorkHelper.DbContext.Set<TModelo>();
        }

        public virtual IQueryable<TModelo> GetAllQ(string filtro)
        {
            var modelos = UnitOfWorkHelper.DbContext.Set<TModelo>().AsQueryable();

            if (!string.IsNullOrEmpty(filtro))
                modelos = this.SetFiltro(modelos, filtro);

            return modelos.AsQueryable();
        }

        public virtual TModelo Create()
        {
            return Activator.CreateInstance<TModelo>();
        }

        public virtual void Add(TModelo modelo)
        {
            UnitOfWorkHelper.DbContext.Set<TModelo>().Add(modelo);
        }

        public virtual void Delete(TModelo modelo)
        {
            UnitOfWorkHelper.DbContext.Set<TModelo>().Remove(modelo);
        }

        public virtual bool SePuedeBorrar(TModelo modelo)
        {
            return true;
        }

        public virtual bool Existe(object id)
        {
            return this.Get(id) != null;
        }
        public virtual void Save()
        {
            UnitOfWorkHelper.SaveChanges();
        }
        public virtual bool Existe(object[] id)
        {
            return this.Get(id) != null;
        }

        protected virtual IQueryable<TModelo> SetFiltro(IQueryable<TModelo> modelos, string filtro)
        {
            return modelos;
        }
    }
}
