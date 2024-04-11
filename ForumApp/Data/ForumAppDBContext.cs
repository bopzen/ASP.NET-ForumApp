using ForumApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ForumApp.Data
{
	public class ForumAppDBContext : DbContext
	{
		public ForumAppDBContext(DbContextOptions<ForumAppDBContext> options) : base(options) {}

		public DbSet<Post> Posts { get; set; }
	}
}

