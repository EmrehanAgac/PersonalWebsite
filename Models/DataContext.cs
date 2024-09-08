using _PersonalWebsite.Models;
using Microsoft.EntityFrameworkCore;

namespace _PersonalWebsite.Models
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{
		}


		public DbSet<Intro> Intro { get; set; }
		public DbSet<About> About { get; set; }
		 public DbSet<HomePage> HomePage { get; set; }
		 public DbSet<Work> Work { get; set; }
		 public DbSet<SocialMedia> SocialMedia { get; set; }
	}
}
