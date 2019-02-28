using CharmosaApp.MVC.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CharmosaApp.MVC.ViewModels
{
    public class FuncionarioViewModel : UsuarioViewModel
    {
        [Key]
        public int FuncionarioID { get; set; }

        [Required(ErrorMessage ="O campo Nome é obrigatório")]
        [MaxLength(250,ErrorMessage = "Tamanho máximo é de {1} caracteres")]
        [MinLength(3, ErrorMessage = "Tamanho mínimo é de {1} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Sobrenome é obrigatório")]
        [MaxLength(250, ErrorMessage = "Tamanho máximo é de {1} caracteres")]
        [MinLength(3, ErrorMessage = "Tamanho mínimo é de {1} caracteres")]

        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "O campo Salário é obrigatorio")]
        [Range(0,99999,ErrorMessage ="O salario deve estar entre {1} e {2} reais")]
        [DisplayName("Salário")]
        public decimal Salario { get; set; }
    }
}
