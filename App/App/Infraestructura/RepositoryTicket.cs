using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using App.Dominio;

namespace Infraestructuras
{
    class TicketRepository : IRepositoryTicket
    {
        public void Add(Ticket entity)
        {
            throw new System.ArgumentException("");
        }

        public void Delete(Ticket entity)
        {
            throw new System.ArgumentException("");
        }

        public IQueryable FindBy(Expression predicate)
        {
            throw new System.ArgumentException("");
        }

        public List<Ticket> getAll()
        {
            throw new System.ArgumentException("");
        }

        public void Save(Ticket entity)
        {
            throw new System.ArgumentException("");
        }

        public void Update(Ticket entity)
        {
            throw new System.ArgumentException("");
        }
    }
}