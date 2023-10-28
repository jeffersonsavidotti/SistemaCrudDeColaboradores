using Microsoft.EntityFrameworkCore;
using GeradorDeFolha.Models;

namespace GeradorDeFolha.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> opts) : base(opts)
    {

    }

    public DbSet<CadastroModel> CadastroModel { get; set; }

}
