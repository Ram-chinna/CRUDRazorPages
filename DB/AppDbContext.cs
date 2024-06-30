using CRUDRazorPages.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDRazorPages.DB
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions options) : base(options)
		{
        }
		public virtual DbSet<Product> Products { get; set; }
	}
}
