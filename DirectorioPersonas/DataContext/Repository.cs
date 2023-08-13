namespace WinFormsClient.DataContext;

public class Repository : DbContext
{
    public Repository(DbContextOptions<Repository> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Persona>().ToTable("tGRLpersonas", "dbo").HasKey(persona => persona.IdPersona);
        modelBuilder.Entity<Socio>().ToTable("tSCSsocios", "dbo").HasKey(socio => socio.IdSocio);
        modelBuilder.Entity<Sucursal>().ToTable("tCTLsucursales", "dbo").HasKey(sucursal => sucursal.IdSucursal);
        modelBuilder.Entity<TipoDetalle>().ToTable("tCTLtiposD", "dbo").HasKey(detalle => detalle.IdTipoD);
        modelBuilder.Entity<EstatusActual>().ToTable("tCTLestatusActual", "dbo").HasKey(estatusActual => estatusActual.IdEstatusActual);


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
        });

        modelBuilder.Entity<Domicilios>(builder =>
            {
                builder.ToTable("tCATdomicilios", "dbo").HasKey(domicilio => domicilio.IdDomicilio);
               
                builder.HasOne(domicilio => domicilio.TipoDetalle)
                    .WithMany()
                    .HasForeignKey(domicilio => domicilio.IdTipoD);
                    
                builder.HasOne(domicilio => domicilio.EstatusActual)
                    .WithMany()
                    .HasForeignKey(domicilio => domicilio.IdEstatusActual);

                builder.Property(domicilio => domicilio.Domicilio)
                    .HasComputedColumnSql("(concat([Calle],' ',[NumeroExterior],' ',[NumeroInterior],' ',[Asentamiento],' CP ',[CodigoPostal],' ',[Ciudad],' ',[Municipio],' ',[Estado])");
            }
        );
    }
}