using System;
using System.Collections.Generic;
using System.Text;

namespace SISChamados.ApplicationCore.Entity
{
    public class Chamado
    {
        public Chamado()
        {

        }

        public int ChamadoID { get; set; }

        public string Descricao { get; set; }

        public string Solucao { get; set; }

        public DateTime DtInicio { get; set; }

        public DateTime DtFim { get; set; }

        public int UsuarioID { get; set; }

        public Usuario Usuario { get; set; }
    }
}
