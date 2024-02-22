using ConsoleApp_brincandoGit.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_brincandoGit.DataAccess
{
    public abstract class AbstractRepository<T> : IBaseRepository<T> where T : EntityBase
    {
        public void Excluir(T entity)
        {
            throw new NotImplementedException();
        }

        public T ObterPor(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Salvar(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
