using CRUDSimples.Model;
using Microsoft.EntityFrameworkCore;

namespace ProjetoCRUD.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Clientes> Clientes { get; set; }
}
