using CloudProject.Models;
using Microsoft.EntityFrameworkCore;

namespace CloudProject.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Exam> Exams { get; set; }
}