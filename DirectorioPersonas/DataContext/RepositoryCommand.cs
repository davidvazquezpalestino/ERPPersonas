namespace WinFormsClient.DataContext;

public class RepositoryCommand(DbContextOptions<RepositoryCommand> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PersonaCommand>(builder =>
        {
            builder.ToTable("tGRLpersonas", "dbo")
                .HasKey(persona => persona.IdPersona);

            builder.ToTable(table => table.HasTrigger("NombreTrigger"));
        });
    }
}