using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SISChamados.ApplicationCore.Entity;

namespace SISChamados.InfraStructure.Data
{
    public class ChamadoContexto : DbContext
    {
        public ChamadoContexto(DbContextOptions<ChamadoContexto> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Chamado> Chamados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("TbUsuario");
            modelBuilder.Entity<Chamado>().ToTable("TbChamado");
        }
    }
}
