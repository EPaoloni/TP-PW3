using Models.ORM;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;

namespace Models.Repository
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

        public abstract void Modificar(T entity);

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

        public T ObtenerPorId(int id)
        {
            return dbSet.Find(id);
        }

        public List<T> ObtenerTodos()
        {
            return dbSet.ToList();
        }

        protected void SaveChanges(PandemiaEntities ctx)
        {
            try
            {
                ctx.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                System.Diagnostics.Debug.WriteLine("");
                System.Diagnostics.Debug.WriteLine("");
                System.Diagnostics.Debug.WriteLine("**** ENTITY FRAMEWORK DETALLE DE EXCEPCION****");

                foreach (var eve in e.EntityValidationErrors)
                {
                    System.Diagnostics.Debug.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }
    }
}