﻿using CharmosaAPP.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharmosaAPP.Domain.Entities
{
    public class Cliente : UsuarioInfo
    {
        public int ClienteID { get; set; }

    }
}
