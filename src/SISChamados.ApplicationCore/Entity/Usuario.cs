﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SISChamados.ApplicationCore.Entity
{
    public class Usuario
    {
        public Usuario()
        {

        }

        public int IdUsuario { get; set; }

        public string NomeUsuario { get; set; }

        public string CPF { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

    }
}
