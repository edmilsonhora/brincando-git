using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_brincandoGit.DomainModel
{
    public interface IRepository
    {
        IAlunoRepository Alunos { get; }
        IProfessorRepository Professores { get; }
    }
}
