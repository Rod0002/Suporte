using Microsoft.EntityFrameworkCore;

namespace SuporteAPI.Data
{
	public class SuporteDbContext : DbContext
	{
		public SuporteDbContext(DbContextOptions<SuporteDbContext> options)
			: base(options) { }

		// Aqui você vai mapear suas entidades (exemplo: Chamado, Usuario)
		public DbSet<Chamado> Chamados { get; set; }
		public DbSet<Usuario> Usuarios { get; set; }
	}
}
