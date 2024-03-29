using DatingApp.API.vscode.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.vscode.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Value> Values { get; set; }
    }
}