using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SISChamados.ApplicationCore.Entity;

namespace SISChamados.InfraStructure.Data
{
    public class UsuarioContexto : DbContext
    {
        public UsuarioContexto(DbContextOptions<UsuarioContexto> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("TbUsuario");
        }
    }
}
