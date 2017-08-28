using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using App.Dominio;


namespace Infraestructuras
{
    class RepositoryCaja : IRepositoryCaja
    {
        public void Add(Caja entity)
        {
            throw new System.ArgumentException("");
        }

        public void Delete(Caja entity)
        {
            throw new System.ArgumentException("");
        }

        public IQueryable FindBy(Expression predicate)
        {
            throw new System.ArgumentException("");
        }

        public List<Caja> getAll()
        {
            throw new System.ArgumentException("");
        }

        public void Save(Caja entity)
        {
            throw new System.ArgumentException("");
        }

        public void Update(Caja entity)
        {
            throw new System.ArgumentException("");
        }
    }
}