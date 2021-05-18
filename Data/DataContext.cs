using Microsoft.EntityFrameworkCore;
using empresasAPi.Models;

namespace empresasAPi.Data
{
    // Como convertemos um BD em um DataContext?
    // EFCore: pacote; 
    // ORM: Mapeamento ENTRE o Objeto (classes/atributos) E O Relacional (tabeas/colunas)
    // Mapeamento Objeto Relacional
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        // tabela 
        // DbSet -> converte tabela em objetos/classes 
        public DbSet<User> Users { get; set; }

        // tabela 
        // DbSet -> converte tabela em objetos/classes 
        public DbSet<Sector> Sectors { get; set; }       
    }
}