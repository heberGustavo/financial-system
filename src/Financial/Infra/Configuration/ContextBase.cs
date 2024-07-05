using Entitites.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infra.Configuration
{
	public class ContextBase : IdentityDbContext<ApplicationUser>
	{
        public ContextBase(DbContextOptions options) : base(options) { }

        #region DbSet

        public DbSet<FinancialSystem> FinancialSystems { get; set; }
        public DbSet<UserFinancialSystem> UserFinancialSystems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Expense> Expenses { get; set; }

		#endregion

		#region Protected Methods

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<ApplicationUser>().ToTable("AspNetUsers").HasKey(t => t.Id);

			base.OnModelCreating(builder);
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//Verify if there's configuration to ConnectionString
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer(GetConnectionString());
				base.OnConfiguring(optionsBuilder);
			}
		}

		#endregion

		#region Private Methods

		private string GetConnectionString() => "Password=root;Persist Security Info=True;User ID=root;Initial Catalog=DbFinancialSystem;Data Source=DESKTOP-N25IT39\\SQLEXPRESS;TrustServerCertificate=true";

		#endregion
	}
}
