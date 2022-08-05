using DunawaySolutionsWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace DunawaySolutionsWeb.Data;

public class ApplicationDbContext :DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
}
