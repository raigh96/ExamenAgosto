using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Dominio
{
    public interface Generic<Foo>
    {
        IQueryable<Foo> GetAll();
        Foo GetSingle(int fooId);
        IQueryable<Foo> FindBy(Expression<Func<Foo, bool>> predicate);
        void Add(Foo entity);
        void Delete(Foo entity);
        void Edit(Foo entity);
        void Save();
    }
}
