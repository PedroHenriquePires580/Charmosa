﻿using CharmosaApp.MVC.ViewModels.Base;
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
        [DisplayName("Código do Funcionário")]
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
        [Range(0,Double.MaxValue,ErrorMessage ="O salario deve estar entre {1} e 99999999 reais")]
        [DisplayName("Salário")]
        public double Salario { get; set; }
    }
}
