using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharmosaAPP.Domain.Entities.Base
{
    public abstract class ClasseBase
    {
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string LogInInclusao { get; set; }
        public string LogInAlteracao { get; set; }
        public bool RegistroAtivo { get; set; }
    }
}
