using ConsoleApp_brincandoGit.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_brincandoGit.DataAccess.Repositories
{
    internal class ProfessorRepository : AbstractRepository<Professor>, IProfessorRepository
    {
        public List<Professor> ObterPor(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
