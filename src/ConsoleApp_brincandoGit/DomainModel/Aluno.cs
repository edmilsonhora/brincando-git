using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_brincandoGit.DomainModel
{
    public class Aluno : EntityBase
    {
        public string Nome { get; set; }
        public string RA { get; set; }
    }

    public interface IAlunoRepository : IBaseRepository<Aluno> { }
}
