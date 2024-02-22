using ConsoleApp_brincandoGit.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_brincandoGit.DataAccess.Repositories
{
    internal class AlunoRepository : AbstractRepository<Aluno>, IAlunoRepository
    {
        public List<Aluno> ObterPor(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
