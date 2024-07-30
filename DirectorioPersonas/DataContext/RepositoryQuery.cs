namespace WinFormsClient.DataContext;

public class RepositoryQuery(DbContextOptions<RepositoryQuery> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Sucursal>().ToTable("tCTLsucursales", "dbo").HasKey(sucursal => sucursal.IdSucursal);
        modelBuilder.Entity<TipoDetalle>().ToTable("tCTLtiposD", "dbo").HasKey(detalle => detalle.IdTipoD);
        modelBuilder.Entity<EstatusActual>().ToTable("tCTLestatusActual", "dbo").HasKey(estatusActual => estatusActual.IdEstatusActual);
        modelBuilder.Entity<User>().ToTable("tCTLusuarios", "dbo").HasKey(user => user.IdUsuario);
        modelBuilder.Entity<Email>().ToView("vCATEmailsAgrupados", "dbo").HasKey(email => email.IdRel);

        modelBuilder.Entity<Persona>(builder =>
        {
            builder.ToTable("tGRLpersonas", "dbo")
                .HasKey(persona => persona.IdPersona);
            
            builder.ToTable(table => table.HasTrigger("NombreTrigger"));


            builder.HasOne(persona => persona.Email)
                .WithMany()
                .HasForeignKey(socio => socio.IdRelDomicilios);

        });

        modelBuilder.Entity<Socio>(builder =>
        {
            builder.ToTable("tSCSsocios", "dbo").HasKey(socio => socio.IdSocio);

            builder.HasOne(socio => socio.Persona)
                .WithMany()
                .HasForeignKey(socio => socio.IdPersona);

            builder.HasOne(socio => socio.Sucursal)
                .WithMany()
                .HasForeignKey(socio => socio.IdSucursal);

        });

        modelBuilder.Entity<Credito>(builder =>
        {
            builder.ToTable("tAYCcuentas", "dbo").HasKey(credito => credito.IdCuenta);
            builder.HasOne(credito => credito.Socio)
                .WithMany()
                .HasForeignKey(socio => socio.IdSocio);

            builder
                  .HasOne(td => td.TipoCredito)
                .WithMany()
                .HasForeignKey(td => td.IdTipoDAIC);
        });
    }
}