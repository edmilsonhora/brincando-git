using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_brincandoGit.DomainModel
{
    public interface IBaseRepository<T> where T : EntityBase
    {
        void Salvar(T entity);
        void Excluir(T entity);
        List<T> ObterTodos();
        T ObterPor(int id);
    }
}
