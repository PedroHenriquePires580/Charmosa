using CharmosaAPP.Domain.Entities.Base;

namespace CharmosaAPP.Domain.Entities
{
    public class Funcionario : UsuarioInfo
    {
        public int FuncionarioID { get; set; }
        public double Salario { get; set; }
    }
}
