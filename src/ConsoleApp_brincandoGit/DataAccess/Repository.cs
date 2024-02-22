using ConsoleApp_brincandoGit.DataAccess.Repositories;
using ConsoleApp_brincandoGit.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_brincandoGit.DataAccess
{
    public class Repository : IRepository
    {
        private IAlunoRepository _alunos;
        private IProfessorRepository _professores;

        public IAlunoRepository Alunos => _alunos ?? (_alunos = new AlunoRepository());
        public IProfessorRepository Professores => _professores ?? (_professores = new ProfessorRepository());
    }
}
