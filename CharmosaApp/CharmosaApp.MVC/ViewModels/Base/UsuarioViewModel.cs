﻿using System;
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
        public string UsuarioCodFuncao { get; set; }

        [Required(ErrorMessage ="O campo Login é obrigatório")]
        [MaxLength(50, ErrorMessage = "O tamanho máximo é de {50} caracteres")]
        public string Login { get; set; }

        [Required(ErrorMessage = "O campo Senha é obrigatório")]
        [MaxLength(50, ErrorMessage = "O tamanho máximo é de {50} caracteres")]
        public string Senha { get; set; }

    }
}
