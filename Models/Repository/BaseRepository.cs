using Models.ORM;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;

namespace Models
{
    public abstract class BaseRepository<T> where T : class
    {
        protected PandemiaEntities context { get; set; }
        protected DbSet<T> dbSet;

        public BaseRepository(PandemiaEntities context)
        {
            this.context = context;
            dbSet = this.context.Set<T>();
        }
        public void Crear(T entity)
        {
            dbSet.Add(entity);
            SaveChanges(context);
        }

        public virtual void Eliminar(int id)
        {
            T entidadAEliminar = ObtenerPorId(id);
            if (entidadAEliminar != null)
            {
                dbSet.Remove(entidadAEliminar);
                SaveChanges(context);
            }
        }

        public abstract void Modificar(T entity);

        public T ObtenerPorId(int id)
        {
            return dbSet.Find(id);
        }

        public List<T> ObtenerTodos()
        {
            return dbSet.ToList();
        }

        public void SaveChanges(PandemiaEntities context)
        {
            try
            {
                context.SaveChanges();
            } catch
            {
                throw;
            }
        }
    }
}