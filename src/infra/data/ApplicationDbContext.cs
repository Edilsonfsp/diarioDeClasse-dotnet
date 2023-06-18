using diarioClasse.domain.courses;
using diarioClasse.domain.entity;
using diarioClasse.domain.students;
using diarioClasse.domain.teachers;
using Microsoft.EntityFrameworkCore;

namespace diarioClasse.infra.data;

public class ApplicationDbContext : DbContext
{
	public DbSet<Course> Courses { get; set; }  //Aqui sao as tabelas
	public DbSet<Student> Students { get; set; }
	public DbSet<Teacher>	Teachers { get; set; }

	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

	protected override void OnModelCreating(ModelBuilder builder)
	{
		builder.Entity<Entity>().Property(e => e.Description).HasMaxLength(255); //configuracao dos campos da tabela
		//builder.Entity<Product>().Property(p => p.Name).HasMaxLength(120).IsRequired();
	}

	protected override void ConfigureConventions(ModelConfigurationBuilder configuration)
	{
		configuration.Properties<string>()
			.HaveMaxLength(100);
	}
}
