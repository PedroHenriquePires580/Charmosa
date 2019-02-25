namespace CharmosaAPP.Domain.Entities
{
    public class Funcionario : Usuario
    {
        public int FuncionarioID { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public decimal Salario { get; set; }
    }
}
