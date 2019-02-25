using CharmosaApp.MVC.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CharmosaApp.MVC.ViewModels
{
    public class AdministradorViewModel : UsuarioViewModel
    {
        [Key]
        public int AdministradorID { get; set; }
    }
}
