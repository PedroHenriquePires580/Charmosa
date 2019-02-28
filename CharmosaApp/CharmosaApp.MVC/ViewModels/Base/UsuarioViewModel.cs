using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CharmosaApp.MVC.ViewModels.Base
{
    public abstract class UsuarioViewModel
    {
        [DisplayName("Função")]
        [Required(ErrorMessage = "O código de função é obrigatório")]
        public int UsuarioCodFuncao { get; set; }

        [Required(ErrorMessage ="O campo Login é obrigatório")]
        [MaxLength(50, ErrorMessage = "O tamanho máximo é de {0} caracteres")]
        [MinLength(2, ErrorMessage = "O tamanho mínimo é de {0} caracteres")]
        public string Login { get; set; }

        [Required(ErrorMessage = "O campo Senha é obrigatório")]
        [MaxLength(50, ErrorMessage = "O tamanho máximo é de {0} caracteres")]
        [MinLength(2, ErrorMessage = "O tamanho mínimo é de {0} caracteres")]
        public string Senha { get; set; }

    }
}
