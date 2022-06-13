using Microsoft.EntityFrameworkCore;
using Tokenlab.API.Models;

namespace Tokenlab.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Evento> Eventos { get; set; }
    }
}