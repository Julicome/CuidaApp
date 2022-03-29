using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Infrastructure
{
    public class ApplicationContext : DbContext, Configuration.IDbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Tbl_Categoria_Documentos> Tbl_Categoria_Documentos { get; set; }
        public DbSet<Tbl_Cliente> Tbl_Cliente { get; set; }
        public DbSet<Tbl_Condicion> Tbl_Condicion { get; set; }
        public DbSet<Tbl_Condiciones_Usuario> Tbl_Condiciones_Usuario { get; set; }
        public DbSet<Tbl_Documento> Tbl_Documento { get; set; }
        public DbSet<Tbl_Familiar> Tbl_Familiar { get; set; }
        public DbSet<Tbl_Genero> Tbl_Genero { get; set; }
        public DbSet<Tbl_Indicadores_De_Salud> Tbl_Indicadores_De_Salud { get; set; }
        public DbSet<Tbl_Nivel_Indicador> Tbl_Nivel_Indicador { get; set; }
        public DbSet<Tbl_Seguimiento_Condicion> Tbl_Seguimiento_Condicion { get; set; }
        public DbSet<Tbl_Tipo_Documento> Tbl_Tipo_Documento { get; set; }
        public DbSet<Tbl_Tipo_Sangre> Tbl_Tipo_Sangre { get; set; }
        public DbSet<Tbl_Usuario> Tbl_Usuario { get; set; }
        public DbSet<Tbl_Visitas_Al_Medico> Tbl_Visitas_Al_Medico { get; set; }
        public void SetModified(object entity)
        {
            Entry(entity).State = EntityState.Modified;
        }

    }
}
