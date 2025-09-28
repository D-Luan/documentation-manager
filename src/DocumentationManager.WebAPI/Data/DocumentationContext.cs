using DocumentationManager.WebAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace DocumentationManager.WebAPI.Data;

public class DocumentationContext : DbContext
{
    public DocumentationContext(DbContextOptions<DocumentationContext> options)
        : base(options)
    {
    }

    public DbSet<DocumentationLink> DocumentationLinks { get; set; }
}
