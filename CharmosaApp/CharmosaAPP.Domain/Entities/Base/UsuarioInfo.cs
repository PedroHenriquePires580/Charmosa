using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharmosaAPP.Domain.Entities.Base
{
    public abstract class UsuarioInfo : Usuario
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public string UF { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public int Numero { get; set; }
        public DateTime DataNascimento { get; set; }

    }
}
