
using Dump_Catastro_CORE.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dump_Catastro_INFRASTRUCTURE.Data;

public partial class DbcatastroContext : DbContext
{
    public DbcatastroContext()
    {
    }

    public DbcatastroContext(DbContextOptions<DbcatastroContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccountEmailaddress> AccountEmailaddresses { get; set; }

    public virtual DbSet<Adquisicion> Adquisicions { get; set; }

    public virtual DbSet<AuthGroup> AuthGroups { get; set; }

    public virtual DbSet<AuthGroup1> AuthGroups1 { get; set; }

    public virtual DbSet<AuthGroupPermission> AuthGroupPermissions { get; set; }

    public virtual DbSet<AuthGroupPermission1> AuthGroupPermissions1 { get; set; }

    public virtual DbSet<AuthPermission> AuthPermissions { get; set; }

    public virtual DbSet<AuthPermission1> AuthPermissions1 { get; set; }

    public virtual DbSet<AuthUser> AuthUsers { get; set; }

    public virtual DbSet<AuthUser1> AuthUsers1 { get; set; }

    public virtual DbSet<AuthUserGroup> AuthUserGroups { get; set; }

    public virtual DbSet<AuthUserGroup1> AuthUserGroups1 { get; set; }

    public virtual DbSet<AuthUserUserPermission> AuthUserUserPermissions { get; set; }

    public virtual DbSet<AuthUserUserPermission1> AuthUserUserPermissions1 { get; set; }

    public virtual DbSet<CaracterTitular> CaracterTitulars { get; set; }

    public virtual DbSet<CertCatastral> CertCatastrals { get; set; }

    public virtual DbSet<Conservacion> Conservacions { get; set; }

    public virtual DbSet<Construcciones19> Construcciones19s { get; set; }

    public virtual DbSet<Construcciones191> Construcciones19s1 { get; set; }

    public virtual DbSet<Construcciones20> Construcciones20s { get; set; }

    public virtual DbSet<ConstruccionesPlantas19> ConstruccionesPlantas19s { get; set; }

    public virtual DbSet<ConstruccionesPlantas20> ConstruccionesPlantas20s { get; set; }

    public virtual DbSet<Construccionesvista19> Construccionesvista19s { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<Distrito> Distritos { get; set; }

    public virtual DbSet<DjangoAdminLog> DjangoAdminLogs { get; set; }

    public virtual DbSet<DjangoAdminLog1> DjangoAdminLogs1 { get; set; }

    public virtual DbSet<DjangoContentType> DjangoContentTypes { get; set; }

    public virtual DbSet<DjangoContentType1> DjangoContentTypes1 { get; set; }

    public virtual DbSet<DjangoMigration> DjangoMigrations { get; set; }

    public virtual DbSet<DjangoMigration1> DjangoMigrations1 { get; set; }

    public virtual DbSet<DjangoSession> DjangoSessions { get; set; }

    public virtual DbSet<DjangoSession1> DjangoSessions1 { get; set; }

    public virtual DbSet<DjangoSite> DjangoSites { get; set; }

    public virtual DbSet<DjangoSite1> DjangoSites1 { get; set; }

    public virtual DbSet<DocumentoPropiedad> DocumentoPropiedads { get; set; }

    public virtual DbSet<EdiCarpinterium> EdiCarpinteria { get; set; }

    public virtual DbSet<EdiCimiento> EdiCimientos { get; set; }

    public virtual DbSet<EdiCubierta> EdiCubiertas { get; set; }

    public virtual DbSet<EdiEstructura> EdiEstructuras { get; set; }

    public virtual DbSet<EdiMuro> EdiMuros { get; set; }

    public virtual DbSet<EdiMurosExt> EdiMurosExts { get; set; }

    public virtual DbSet<EdiMurosInt> EdiMurosInts { get; set; }

    public virtual DbSet<Formulariocatastral> Formulariocatastrals { get; set; }

    public virtual DbSet<EdiPiso> EdiPisos { get; set; }

    public virtual DbSet<Ejevia> Ejevias { get; set; }

    public virtual DbSet<Especiale> Especiales { get; set; }

    public virtual DbSet<Especialesvista19> Especialesvista19s { get; set; }

    public virtual DbSet<Forma> Formas { get; set; }

    public virtual DbSet<Imagene> Imagenes { get; set; }

    public virtual DbSet<Impuesto> Impuestos { get; set; }

    public virtual DbSet<Instalacione> Instalaciones { get; set; }

    public virtual DbSet<Localidade> Localidades { get; set; }

    public virtual DbSet<Manzanasvista19> Manzanasvista19s { get; set; }

    public virtual DbSet<Manzano> Manzanos { get; set; }

    public virtual DbSet<MaterialVium> MaterialVia { get; set; }

    public virtual DbSet<Mejora> Mejoras { get; set; }

    public virtual DbSet<Mejorasvista19> Mejorasvista19s { get; set; }

    public virtual DbSet<Otcatastro> Otcatastros { get; set; }

    public virtual DbSet<Planta> Plantas { get; set; }

    public virtual DbSet<Plantasvista19> Plantasvista19s { get; set; }

    public virtual DbSet<Provincia> Provincias { get; set; }

    public virtual DbSet<Revestimiento> Revestimientos { get; set; }

    public virtual DbSet<Terrenos19> Terrenos19s { get; set; }

    public virtual DbSet<Terrenos191> Terrenos19s1 { get; set; }

    public virtual DbSet<Terrenos192> Terrenos19s2 { get; set; }

    public virtual DbSet<Terrenos20> Terrenos20s { get; set; }

    public virtual DbSet<TerrenosEspeciales19> TerrenosEspeciales19s { get; set; }

    public virtual DbSet<TerrenosEspeciales20> TerrenosEspeciales20s { get; set; }

    public virtual DbSet<TerrenosMejoras19> TerrenosMejoras19s { get; set; }

    public virtual DbSet<TerrenosMejoras20> TerrenosMejoras20s { get; set; }

    public virtual DbSet<Terrenosvista19> Terrenosvista19s { get; set; }

    public virtual DbSet<TipoConstruccion> TipoConstruccions { get; set; }

    public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; }

    public virtual DbSet<TipoVium> TipoVia { get; set; }

    public virtual DbSet<Titular> Titulars { get; set; }

    public virtual DbSet<Titular1> Titulars1 { get; set; }

    public virtual DbSet<Titulares2> Titulares2s { get; set; }

    public virtual DbSet<Topografium> Topografia { get; set; }

    public virtual DbSet<Ubicacion> Ubicacions { get; set; }

    public virtual DbSet<Uso> Usos { get; set; }

    public virtual DbSet<Zona> Zonas { get; set; }

    public virtual DbSet<Zonificacion> Zonificacions { get; set; }

    public virtual DbSet<VistaTerreno> VistaTerrenos { get; set; }

    public virtual DbSet<VistaCatastro> VistaCatastros { get; set; }
    public virtual DbSet<VistaConstruccione> VistaConstrucciones { get; set; }
    public virtual DbSet<VistaConstruccionesJbo> VistaConstruccionesJbos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Server=ec2-100-24-63-57.compute-1.amazonaws.com;Port=5432;Database=dbcatastro;User Id=postgres;Password=administrador;", x => x.UseNetTopologySuite());

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresExtension("postgis");
        
        modelBuilder.Entity<AccountEmailaddress>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_emailaddress_pkey");

            entity.ToTable("account_emailaddress", "catastro");

            entity.HasIndex(e => e.Email, "account_emailaddress_email_03be32b2_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Email, "account_emailaddress_email_key").IsUnique();

            entity.HasIndex(e => e.UserId, "account_emailaddress_user_id_2c513194");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(254)
                .HasColumnName("email");
            entity.Property(e => e.Primary).HasColumnName("primary");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.Verified).HasColumnName("verified");

            entity.HasOne(d => d.User).WithMany(p => p.AccountEmailaddresses)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("account_emailaddress_user_id_2c513194_fk_auth_user_id");
        });

        modelBuilder.Entity<Adquisicion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("adquisicion_pk");

            entity.ToTable("adquisicion", "catastro");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Adquisicion1)
                .HasColumnType("character varying")
                .HasColumnName("adquisicion");
            entity.Property(e => e.Codigo)
                .HasColumnType("character varying")
                .HasColumnName("codigo");
        });

        modelBuilder.Entity<AuthGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_group_pkey");

            entity.ToTable("auth_group");

            entity.HasIndex(e => e.Name, "auth_group_name_a6ea08ec_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Name, "auth_group_name_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AuthGroup1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_group_pkey");

            entity.ToTable("auth_group", "catastro");

            entity.HasIndex(e => e.Name, "auth_group_name_a6ea08ec_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Name, "auth_group_name_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AuthGroupPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_group_permissions_pkey");

            entity.ToTable("auth_group_permissions", "catastro");

            entity.HasIndex(e => e.GroupId, "auth_group_permissions_group_id_b120cbf9");

            entity.HasIndex(e => new { e.GroupId, e.PermissionId }, "auth_group_permissions_group_id_permission_id_0cd325b0_uniq").IsUnique();

            entity.HasIndex(e => e.PermissionId, "auth_group_permissions_permission_id_84c5c92e");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.PermissionId).HasColumnName("permission_id");

            entity.HasOne(d => d.Group).WithMany(p => p.AuthGroupPermissions)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_group_permissions_group_id_b120cbf9_fk_auth_group_id");

            entity.HasOne(d => d.Permission).WithMany(p => p.AuthGroupPermissions)
                .HasForeignKey(d => d.PermissionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_group_permissio_permission_id_84c5c92e_fk_auth_perm");
        });

        modelBuilder.Entity<AuthGroupPermission1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_group_permissions_pkey");

            entity.ToTable("auth_group_permissions");

            entity.HasIndex(e => e.GroupId, "auth_group_permissions_group_id_b120cbf9");

            entity.HasIndex(e => new { e.GroupId, e.PermissionId }, "auth_group_permissions_group_id_permission_id_0cd325b0_uniq").IsUnique();

            entity.HasIndex(e => e.PermissionId, "auth_group_permissions_permission_id_84c5c92e");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.PermissionId).HasColumnName("permission_id");

            entity.HasOne(d => d.Group).WithMany(p => p.AuthGroupPermission1s)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_group_permissions_group_id_b120cbf9_fk_auth_group_id");

            entity.HasOne(d => d.Permission).WithMany(p => p.AuthGroupPermission1s)
                .HasForeignKey(d => d.PermissionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_group_permissio_permission_id_84c5c92e_fk_auth_perm");
        });

        modelBuilder.Entity<AuthPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_permission_pkey");

            entity.ToTable("auth_permission");

            entity.HasIndex(e => e.ContentTypeId, "auth_permission_content_type_id_2f476e4b");

            entity.HasIndex(e => new { e.ContentTypeId, e.Codename }, "auth_permission_content_type_id_codename_01ab375a_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codename)
                .HasMaxLength(100)
                .HasColumnName("codename");
            entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");

            entity.HasOne(d => d.ContentType).WithMany(p => p.AuthPermissions)
                .HasForeignKey(d => d.ContentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_permission_content_type_id_2f476e4b_fk_django_co");
        });

        modelBuilder.Entity<AuthPermission1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_permission_pkey");

            entity.ToTable("auth_permission", "catastro");

            entity.HasIndex(e => e.ContentTypeId, "auth_permission_content_type_id_2f476e4b");

            entity.HasIndex(e => new { e.ContentTypeId, e.Codename }, "auth_permission_content_type_id_codename_01ab375a_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codename)
                .HasMaxLength(100)
                .HasColumnName("codename");
            entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");

            entity.HasOne(d => d.ContentType).WithMany(p => p.AuthPermission1s)
                .HasForeignKey(d => d.ContentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_permission_content_type_id_2f476e4b_fk_django_co");
        });

        modelBuilder.Entity<AuthUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_user_pkey");

            entity.ToTable("auth_user", "catastro");

            entity.HasIndex(e => e.Username, "auth_user_username_6821ab7c_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Username, "auth_user_username_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateJoined).HasColumnName("date_joined");
            entity.Property(e => e.Email)
                .HasMaxLength(254)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(150)
                .HasColumnName("first_name");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.IsStaff).HasColumnName("is_staff");
            entity.Property(e => e.IsSuperuser).HasColumnName("is_superuser");
            entity.Property(e => e.LastLogin).HasColumnName("last_login");
            entity.Property(e => e.LastName)
                .HasMaxLength(150)
                .HasColumnName("last_name");
            entity.Property(e => e.Password)
                .HasMaxLength(128)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(150)
                .HasColumnName("username");
        });

        modelBuilder.Entity<AuthUser1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_user_pkey");

            entity.ToTable("auth_user");

            entity.HasIndex(e => e.Username, "auth_user_username_6821ab7c_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Username, "auth_user_username_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateJoined).HasColumnName("date_joined");
            entity.Property(e => e.Email)
                .HasMaxLength(254)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(150)
                .HasColumnName("first_name");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.IsStaff).HasColumnName("is_staff");
            entity.Property(e => e.IsSuperuser).HasColumnName("is_superuser");
            entity.Property(e => e.LastLogin).HasColumnName("last_login");
            entity.Property(e => e.LastName)
                .HasMaxLength(150)
                .HasColumnName("last_name");
            entity.Property(e => e.Password)
                .HasMaxLength(128)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(150)
                .HasColumnName("username");
        });

        modelBuilder.Entity<AuthUserGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_user_groups_pkey");

            entity.ToTable("auth_user_groups", "catastro");

            entity.HasIndex(e => e.GroupId, "auth_user_groups_group_id_97559544");

            entity.HasIndex(e => e.UserId, "auth_user_groups_user_id_6a12ed8b");

            entity.HasIndex(e => new { e.UserId, e.GroupId }, "auth_user_groups_user_id_group_id_94350c0c_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Group).WithMany(p => p.AuthUserGroups)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_user_groups_group_id_97559544_fk_auth_group_id");

            entity.HasOne(d => d.User).WithMany(p => p.AuthUserGroups)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_user_groups_user_id_6a12ed8b_fk_auth_user_id");
        });

        modelBuilder.Entity<AuthUserGroup1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_user_groups_pkey");

            entity.ToTable("auth_user_groups");

            entity.HasIndex(e => e.GroupId, "auth_user_groups_group_id_97559544");

            entity.HasIndex(e => e.UserId, "auth_user_groups_user_id_6a12ed8b");

            entity.HasIndex(e => new { e.UserId, e.GroupId }, "auth_user_groups_user_id_group_id_94350c0c_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Group).WithMany(p => p.AuthUserGroup1s)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_user_groups_group_id_97559544_fk_auth_group_id");

            entity.HasOne(d => d.User).WithMany(p => p.AuthUserGroup1s)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_user_groups_user_id_6a12ed8b_fk_auth_user_id");
        });

        modelBuilder.Entity<AuthUserUserPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_user_user_permissions_pkey");

            entity.ToTable("auth_user_user_permissions", "catastro");

            entity.HasIndex(e => e.PermissionId, "auth_user_user_permissions_permission_id_1fbb5f2c");

            entity.HasIndex(e => e.UserId, "auth_user_user_permissions_user_id_a95ead1b");

            entity.HasIndex(e => new { e.UserId, e.PermissionId }, "auth_user_user_permissions_user_id_permission_id_14a6b632_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PermissionId).HasColumnName("permission_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Permission).WithMany(p => p.AuthUserUserPermissions)
                .HasForeignKey(d => d.PermissionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_user_user_permi_permission_id_1fbb5f2c_fk_auth_perm");

            entity.HasOne(d => d.User).WithMany(p => p.AuthUserUserPermissions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_user_user_permissions_user_id_a95ead1b_fk_auth_user_id");
        });

        modelBuilder.Entity<AuthUserUserPermission1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_user_user_permissions_pkey");

            entity.ToTable("auth_user_user_permissions");

            entity.HasIndex(e => e.PermissionId, "auth_user_user_permissions_permission_id_1fbb5f2c");

            entity.HasIndex(e => e.UserId, "auth_user_user_permissions_user_id_a95ead1b");

            entity.HasIndex(e => new { e.UserId, e.PermissionId }, "auth_user_user_permissions_user_id_permission_id_14a6b632_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PermissionId).HasColumnName("permission_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Permission).WithMany(p => p.AuthUserUserPermission1s)
                .HasForeignKey(d => d.PermissionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_user_user_permi_permission_id_1fbb5f2c_fk_auth_perm");

            entity.HasOne(d => d.User).WithMany(p => p.AuthUserUserPermission1s)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_user_user_permissions_user_id_a95ead1b_fk_auth_user_id");
        });

        modelBuilder.Entity<CaracterTitular>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("caracter_titular_pk");

            entity.ToTable("caracter_titular", "catastro");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Caracter)
                .HasColumnType("character varying")
                .HasColumnName("caracter");
            entity.Property(e => e.Codigo)
                .HasColumnType("character varying")
                .HasColumnName("codigo");
        });

        modelBuilder.Entity<CertCatastral>(entity =>
        {
            entity.HasKey(e => e.Uuid).HasName("cert_catastral_pkey");

            entity.ToTable("cert_catastral", "ctrl");

            entity.Property(e => e.Uuid)
                .ValueGeneratedNever()
                .HasColumnName("uuid");
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("CURRENT_DATE")
                .HasColumnName("fecha");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<Conservacion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("conservacion", "catastro");

            entity.Property(e => e.Estado)
                .HasColumnType("character varying")
                .HasColumnName("estado");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Valor).HasColumnName("valor");
        });

        modelBuilder.Entity<Construcciones19>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("construcciones19_pkey");

            entity.ToTable("construcciones19", "catastro");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aire).HasColumnName("aire");
            entity.Property(e => e.Anyo)
                .HasColumnType("character varying")
                .HasColumnName("anyo");
            entity.Property(e => e.Ascensores).HasColumnName("ascensores");
            entity.Property(e => e.Banyos).HasColumnName("banyos");
            entity.Property(e => e.Calefaccion).HasColumnName("calefaccion");
            entity.Property(e => e.Cod).HasColumnName("cod");
            entity.Property(e => e.Codigo)
                .HasColumnType("character varying")
                .HasColumnName("codigo");
            entity.Property(e => e.Conservacion).HasColumnName("conservacion");
            entity.Property(e => e.Dormitorios).HasColumnName("dormitorios");
            entity.Property(e => e.Escalera).HasColumnName("escalera");
            entity.Property(e => e.Geom)
                .HasColumnType("geometry(MultiPolygon,32719)")
                .HasColumnName("geom");
            entity.Property(e => e.Lavanderia).HasColumnName("lavanderia");
            entity.Property(e => e.Plantas).HasColumnName("plantas");
            entity.Property(e => e.Revestimiento).HasColumnName("revestimiento");
            entity.Property(e => e.Sanitarios).HasColumnName("sanitarios");
            entity.Property(e => e.Servicio).HasColumnName("servicio");
            entity.Property(e => e.Superficie).HasColumnName("superficie");
            entity.Property(e => e.Tanque).HasColumnName("tanque");
            entity.Property(e => e.Tipo).HasColumnName("tipo");
            entity.Property(e => e.Uso).HasColumnName("uso");
        });

        modelBuilder.Entity<Construcciones191>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("construcciones19", "secure");

            entity.Property(e => e.Aire).HasColumnName("aire");
            entity.Property(e => e.Anyo)
                .HasColumnType("character varying")
                .HasColumnName("anyo");
            entity.Property(e => e.Ascensores).HasColumnName("ascensores");
            entity.Property(e => e.Banyos).HasColumnName("banyos");
            entity.Property(e => e.Calefaccion).HasColumnName("calefaccion");
            entity.Property(e => e.Cod).HasColumnName("cod");
            entity.Property(e => e.Codigo)
                .HasColumnType("character varying")
                .HasColumnName("codigo");
            entity.Property(e => e.Conservacion).HasColumnName("conservacion");
            entity.Property(e => e.Dormitorios).HasColumnName("dormitorios");
            entity.Property(e => e.Escalera).HasColumnName("escalera");
            entity.Property(e => e.Geom)
                .HasColumnType("geometry(MultiPolygon,32719)")
                .HasColumnName("geom");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Lavanderia).HasColumnName("lavanderia");
            entity.Property(e => e.Plantas).HasColumnName("plantas");
            entity.Property(e => e.Revestimiento).HasColumnName("revestimiento");
            entity.Property(e => e.Sanitarios).HasColumnName("sanitarios");
            entity.Property(e => e.Servicio).HasColumnName("servicio");
            entity.Property(e => e.Superficie).HasColumnName("superficie");
            entity.Property(e => e.Tanque).HasColumnName("tanque");
            entity.Property(e => e.Tipo).HasColumnName("tipo");
            entity.Property(e => e.Uso).HasColumnName("uso");
        });

        modelBuilder.Entity<Construcciones20>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("construcciones20_pkey");

            entity.ToTable("construcciones20", "catastro");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Anyo).HasColumnName("anyo");
            entity.Property(e => e.Banyos).HasColumnName("banyos");
            entity.Property(e => e.Cod).HasColumnName("cod");
            entity.Property(e => e.Codigo)
                .HasColumnType("character varying")
                .HasColumnName("codigo");
            entity.Property(e => e.Conservacion).HasColumnName("conservacion");
            entity.Property(e => e.Dormitorios).HasColumnName("dormitorios");
            entity.Property(e => e.Geom)
                .HasColumnType("geometry(MultiPolygon,32720)")
                .HasColumnName("geom");
            entity.Property(e => e.Plantas).HasColumnName("plantas");
            entity.Property(e => e.Revestimiento).HasColumnName("revestimiento");
            entity.Property(e => e.Superficie).HasColumnName("superficie");
            entity.Property(e => e.Uso).HasColumnName("uso");
        });

        modelBuilder.Entity<ConstruccionesPlantas19>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("construcciones_plantas19_pkey");

            entity.ToTable("construcciones_plantas19", "catastro");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Anyo)
                .HasColumnType("character varying")
                .HasColumnName("anyo");
            entity.Property(e => e.Carpinteria).HasColumnName("carpinteria");
            entity.Property(e => e.Cimiento).HasColumnName("cimiento");
            entity.Property(e => e.Cubierta).HasColumnName("cubierta");
            entity.Property(e => e.Estructura).HasColumnName("estructura");
            entity.Property(e => e.IdConstruccion).HasColumnName("id_construccion");
            entity.Property(e => e.IdPlanta).HasColumnName("id_planta");
            entity.Property(e => e.Muros).HasColumnName("muros");
            entity.Property(e => e.MurosExt).HasColumnName("muros_ext");
            entity.Property(e => e.MurosInt).HasColumnName("muros_int");
            entity.Property(e => e.Pisos).HasColumnName("pisos");
            entity.Property(e => e.Superficie)
                .HasColumnType("character varying")
                .HasColumnName("superficie");
        });

        modelBuilder.Entity<ConstruccionesPlantas20>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("construcciones_plantas20_pkey");

            entity.ToTable("construcciones_plantas20", "catastro");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Carpinteria).HasColumnName("carpinteria");
            entity.Property(e => e.Cimiento).HasColumnName("cimiento");
            entity.Property(e => e.Cubierta).HasColumnName("cubierta");
            entity.Property(e => e.Estructura).HasColumnName("estructura");
            entity.Property(e => e.IdConstruccion).HasColumnName("id_construccion");
            entity.Property(e => e.IdPlanta).HasColumnName("id_planta");
            entity.Property(e => e.Muros).HasColumnName("muros");
            entity.Property(e => e.MurosExt).HasColumnName("muros_ext");
            entity.Property(e => e.MurosInt).HasColumnName("muros_int");
            entity.Property(e => e.Pisos).HasColumnName("pisos");
        });

        modelBuilder.Entity<Construccionesvista19>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("construccionesvista19", "catastro");

            entity.Property(e => e.Aire).HasColumnName("aire");
            entity.Property(e => e.Anyo)
                .HasColumnType("character varying")
                .HasColumnName("anyo");
            entity.Property(e => e.Ascensores).HasColumnName("ascensores");
            entity.Property(e => e.Banyos).HasColumnName("banyos");
            entity.Property(e => e.Calefaccion).HasColumnName("calefaccion");
            entity.Property(e => e.Cod).HasColumnName("cod");
            entity.Property(e => e.Codigo)
                .HasColumnType("character varying")
                .HasColumnName("codigo");
            entity.Property(e => e.Conservacion).HasColumnName("conservacion");
            entity.Property(e => e.Dormitorios).HasColumnName("dormitorios");
            entity.Property(e => e.Escalera).HasColumnName("escalera");
            entity.Property(e => e.Estado)
                .HasColumnType("character varying")
                .HasColumnName("estado");
            entity.Property(e => e.Geom)
                .HasColumnType("geometry(MultiPolygon,32719)")
                .HasColumnName("geom");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Id2).HasColumnName("id2");
            entity.Property(e => e.Lavanderia).HasColumnName("lavanderia");
            entity.Property(e => e.Nombrerevestimieto)
                .HasColumnType("character varying")
                .HasColumnName("nombrerevestimieto");
            entity.Property(e => e.Nombreuso)
                .HasColumnType("character varying")
                .HasColumnName("nombreuso");
            entity.Property(e => e.Plantas).HasColumnName("plantas");
            entity.Property(e => e.Revestimiento).HasColumnName("revestimiento");
            entity.Property(e => e.Sanitarios).HasColumnName("sanitarios");
            entity.Property(e => e.Servicio).HasColumnName("servicio");
            entity.Property(e => e.Superficie).HasColumnName("superficie");
            entity.Property(e => e.Tanque).HasColumnName("tanque");
            entity.Property(e => e.Tipo).HasColumnName("tipo");
            entity.Property(e => e.Tipoconstruccion)
                .HasColumnType("character varying")
                .HasColumnName("tipoconstruccion");
            entity.Property(e => e.Uso).HasColumnName("uso");
            entity.Property(e => e.Valorconservacion).HasColumnName("valorconservacion");
            entity.Property(e => e.Valortipoconstruccion).HasColumnName("valortipoconstruccion");
            entity.Property(e => e.Valoruso).HasColumnName("valoruso");
        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("departamentos_pk");

            entity.ToTable("departamentos", "catastro");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasColumnType("character varying")
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Distrito>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("distritos_pk");

            entity.ToTable("distritos", "catastro");

            entity.Property(e => e.Codigo)
                .ValueGeneratedNever()
                .HasColumnName("codigo");
            entity.Property(e => e.Departamento).HasColumnName("departamento");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasColumnType("character varying")
                .HasColumnName("nombre");
            entity.Property(e => e.Provincia).HasColumnName("provincia");

            entity.HasOne(d => d.DepartamentoNavigation).WithMany(p => p.Distritos)
                .HasForeignKey(d => d.Departamento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("distritos_fk");

            entity.HasOne(d => d.ProvinciaNavigation).WithMany(p => p.Distritos)
                .HasForeignKey(d => d.Provincia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("distritos_fk_1");
        });

        modelBuilder.Entity<DjangoAdminLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("django_admin_log_pkey");

            entity.ToTable("django_admin_log");

            entity.HasIndex(e => e.ContentTypeId, "django_admin_log_content_type_id_c4bce8eb");

            entity.HasIndex(e => e.UserId, "django_admin_log_user_id_c564eba6");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActionFlag).HasColumnName("action_flag");
            entity.Property(e => e.ActionTime).HasColumnName("action_time");
            entity.Property(e => e.ChangeMessage).HasColumnName("change_message");
            entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");
            entity.Property(e => e.ObjectId).HasColumnName("object_id");
            entity.Property(e => e.ObjectRepr)
                .HasMaxLength(200)
                .HasColumnName("object_repr");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.ContentType).WithMany(p => p.DjangoAdminLogs)
                .HasForeignKey(d => d.ContentTypeId)
                .HasConstraintName("django_admin_log_content_type_id_c4bce8eb_fk_django_co");

            entity.HasOne(d => d.User).WithMany(p => p.DjangoAdminLogs)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("django_admin_log_user_id_c564eba6_fk_auth_user_id");
        });

        modelBuilder.Entity<DjangoAdminLog1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("django_admin_log_pkey");

            entity.ToTable("django_admin_log", "catastro");

            entity.HasIndex(e => e.ContentTypeId, "django_admin_log_content_type_id_c4bce8eb");

            entity.HasIndex(e => e.UserId, "django_admin_log_user_id_c564eba6");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActionFlag).HasColumnName("action_flag");
            entity.Property(e => e.ActionTime).HasColumnName("action_time");
            entity.Property(e => e.ChangeMessage).HasColumnName("change_message");
            entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");
            entity.Property(e => e.ObjectId).HasColumnName("object_id");
            entity.Property(e => e.ObjectRepr)
                .HasMaxLength(200)
                .HasColumnName("object_repr");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.ContentType).WithMany(p => p.DjangoAdminLog1s)
                .HasForeignKey(d => d.ContentTypeId)
                .HasConstraintName("django_admin_log_content_type_id_c4bce8eb_fk_django_co");

            entity.HasOne(d => d.User).WithMany(p => p.DjangoAdminLog1s)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("django_admin_log_user_id_c564eba6_fk_auth_user_id");
        });

        modelBuilder.Entity<DjangoContentType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("django_content_type_pkey");

            entity.ToTable("django_content_type", "catastro");

            entity.HasIndex(e => new { e.AppLabel, e.Model }, "django_content_type_app_label_model_76bd3d3b_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AppLabel)
                .HasMaxLength(100)
                .HasColumnName("app_label");
            entity.Property(e => e.Model)
                .HasMaxLength(100)
                .HasColumnName("model");
        });

        modelBuilder.Entity<DjangoContentType1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("django_content_type_pkey");

            entity.ToTable("django_content_type");

            entity.HasIndex(e => new { e.AppLabel, e.Model }, "django_content_type_app_label_model_76bd3d3b_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AppLabel)
                .HasMaxLength(100)
                .HasColumnName("app_label");
            entity.Property(e => e.Model)
                .HasMaxLength(100)
                .HasColumnName("model");
        });

        modelBuilder.Entity<DjangoMigration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("django_migrations_pkey");

            entity.ToTable("django_migrations");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.App)
                .HasMaxLength(255)
                .HasColumnName("app");
            entity.Property(e => e.Applied).HasColumnName("applied");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<DjangoMigration1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("django_migrations_pkey");

            entity.ToTable("django_migrations", "catastro");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.App)
                .HasMaxLength(255)
                .HasColumnName("app");
            entity.Property(e => e.Applied).HasColumnName("applied");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<DjangoSession>(entity =>
        {
            entity.HasKey(e => e.SessionKey).HasName("django_session_pkey");

            entity.ToTable("django_session");

            entity.HasIndex(e => e.ExpireDate, "django_session_expire_date_a5c62663");

            entity.HasIndex(e => e.SessionKey, "django_session_session_key_c0390e0f_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.Property(e => e.SessionKey)
                .HasMaxLength(40)
                .HasColumnName("session_key");
            entity.Property(e => e.ExpireDate).HasColumnName("expire_date");
            entity.Property(e => e.SessionData).HasColumnName("session_data");
        });

        modelBuilder.Entity<DjangoSession1>(entity =>
        {
            entity.HasKey(e => e.SessionKey).HasName("django_session_pkey");

            entity.ToTable("django_session", "catastro");

            entity.HasIndex(e => e.ExpireDate, "django_session_expire_date_a5c62663");

            entity.HasIndex(e => e.SessionKey, "django_session_session_key_c0390e0f_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.Property(e => e.SessionKey)
                .HasMaxLength(40)
                .HasColumnName("session_key");
            entity.Property(e => e.ExpireDate).HasColumnName("expire_date");
            entity.Property(e => e.SessionData).HasColumnName("session_data");
        });

        modelBuilder.Entity<DjangoSite>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("django_site_pkey");

            entity.ToTable("django_site");

            entity.HasIndex(e => e.Domain, "django_site_domain_a2e37b91_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Domain, "django_site_domain_a2e37b91_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Domain)
                .HasMaxLength(100)
                .HasColumnName("domain");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<DjangoSite1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("django_site_pkey");

            entity.ToTable("django_site", "catastro");

            entity.HasIndex(e => e.Domain, "django_site_domain_a2e37b91_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Domain, "django_site_domain_a2e37b91_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Domain)
                .HasMaxLength(100)
                .HasColumnName("domain");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<DocumentoPropiedad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("documento_propiedad_pk");

            entity.ToTable("documento_propiedad", "catastro");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codigo)
                .HasColumnType("character varying")
                .HasColumnName("codigo");
            entity.Property(e => e.Documento)
                .HasColumnType("character varying")
                .HasColumnName("documento");
        });

        modelBuilder.Entity<EdiCarpinterium>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("edi_carpinteria", "catastro");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Material)
                .HasColumnType("character varying")
                .HasColumnName("material");
            entity.Property(e => e.Valor).HasColumnName("valor");
        });

        modelBuilder.Entity<EdiCimiento>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("edi_cimientos", "catastro");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Material)
                .HasColumnType("character varying")
                .HasColumnName("material");
            entity.Property(e => e.Valor).HasColumnName("valor");
        });

        modelBuilder.Entity<EdiCubierta>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("edi_cubiertas", "catastro");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Material)
                .HasColumnType("character varying")
                .HasColumnName("material");
            entity.Property(e => e.Valor).HasColumnName("valor");
        });

        modelBuilder.Entity<EdiEstructura>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("edi_estructura", "catastro");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Material)
                .HasColumnType("character varying")
                .HasColumnName("material");
            entity.Property(e => e.Valor).HasColumnName("valor");
        });

        modelBuilder.Entity<EdiMuro>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("edi_muros", "catastro");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Material)
                .HasColumnType("character varying")
                .HasColumnName("material");
            entity.Property(e => e.Valor).HasColumnName("valor");
        });

        modelBuilder.Entity<EdiMurosExt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("edi_muros_ext", "catastro");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Material)
                .HasColumnType("character varying")
                .HasColumnName("material");
            entity.Property(e => e.Valor).HasColumnName("valor");
        });

        modelBuilder.Entity<EdiMurosInt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("edi_muros_int", "catastro");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Material)
                .HasColumnType("character varying")
                .HasColumnName("material");
            entity.Property(e => e.Valor).HasColumnName("valor");
        });

        modelBuilder.Entity<EdiPiso>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("edi_pisos", "catastro");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Material)
                .HasColumnType("character varying")
                .HasColumnName("material");
            entity.Property(e => e.Valor).HasColumnName("valor");
        });

        modelBuilder.Entity<Ejevia>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ejevias_pkey");

            entity.ToTable("ejevias", "catastro");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Geom)
                .HasColumnType("geometry(LineString,32719)")
                .HasColumnName("geom");
            entity.Property(e => e.Manzana).HasColumnName("manzana");
            entity.Property(e => e.Nombre)
                .HasColumnType("character varying")
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Especiale>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("especiales", "catastro");

            entity.Property(e => e.Codigo)
                .HasColumnType("character varying")
                .HasColumnName("codigo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasColumnType("character varying")
                .HasColumnName("nombre");
            entity.Property(e => e.Valor).HasColumnName("valor");
        });

        modelBuilder.Entity<Especialesvista19>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("especialesvista19", "catastro");

            entity.Property(e => e.Anyo)
                .HasColumnType("character varying")
                .HasColumnName("anyo");
            entity.Property(e => e.Carpinteria).HasColumnName("carpinteria");
            entity.Property(e => e.Cimiento).HasColumnName("cimiento");
            entity.Property(e => e.Codigo)
                .HasColumnType("character varying")
                .HasColumnName("codigo");
            entity.Property(e => e.Codigoespecial)
                .HasColumnType("character varying")
                .HasColumnName("codigoespecial");
            entity.Property(e => e.Conservacion).HasColumnName("conservacion");
            entity.Property(e => e.Cubierta).HasColumnName("cubierta");
            entity.Property(e => e.Estructura).HasColumnName("estructura");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdEsp).HasColumnName("id_esp");
            entity.Property(e => e.Materialcarpinteria)
                .HasColumnType("character varying")
                .HasColumnName("materialcarpinteria");
            entity.Property(e => e.Materialcimientos)
                .HasColumnType("character varying")
                .HasColumnName("materialcimientos");
            entity.Property(e => e.Materialcubiertas)
                .HasColumnType("character varying")
                .HasColumnName("materialcubiertas");
            entity.Property(e => e.Materialestructura)
                .HasColumnType("character varying")
                .HasColumnName("materialestructura");
            entity.Property(e => e.Materialmuros)
                .HasColumnType("character varying")
                .HasColumnName("materialmuros");
            entity.Property(e => e.Materialmurosext)
                .HasColumnType("character varying")
                .HasColumnName("materialmurosext");
            entity.Property(e => e.Materialmurosint)
                .HasColumnType("character varying")
                .HasColumnName("materialmurosint");
            entity.Property(e => e.Materialpisos)
                .HasColumnType("character varying")
                .HasColumnName("materialpisos");
            entity.Property(e => e.Muros).HasColumnName("muros");
            entity.Property(e => e.MurosExt).HasColumnName("muros_ext");
            entity.Property(e => e.MurosInt).HasColumnName("muros_int");
            entity.Property(e => e.Nombre)
                .HasColumnType("character varying")
                .HasColumnName("nombre");
            entity.Property(e => e.Pisos).HasColumnName("pisos");
            entity.Property(e => e.Superficie)
                .HasColumnType("character varying")
                .HasColumnName("superficie");
            entity.Property(e => e.Valor).HasColumnName("valor");
            entity.Property(e => e.Valorcarpinteria).HasColumnName("valorcarpinteria");
            entity.Property(e => e.Valorcimientos).HasColumnName("valorcimientos");
            entity.Property(e => e.Valorcubiertas).HasColumnName("valorcubiertas");
            entity.Property(e => e.Valorestructura).HasColumnName("valorestructura");
            entity.Property(e => e.Valormuros).HasColumnName("valormuros");
            entity.Property(e => e.Valormurosext).HasColumnName("valormurosext");
            entity.Property(e => e.Valormurosint).HasColumnName("valormurosint");
            entity.Property(e => e.Valorpisos).HasColumnName("valorpisos");
        });

        modelBuilder.Entity<Forma>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("forma_pk");

            entity.ToTable("forma", "catastro");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codigo)
                .HasColumnType("character varying")
                .HasColumnName("codigo");
            entity.Property(e => e.Forma1)
                .HasColumnType("character varying")
                .HasColumnName("forma");
            entity.Property(e => e.Valor).HasColumnName("valor");
        });

        modelBuilder.Entity<Imagene>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("imagenes", "catastro");

            entity.Property(e => e.Construccion19).HasColumnName("construccion19");
            entity.Property(e => e.Construccion20).HasColumnName("construccion20");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Imagen).HasColumnName("imagen");
            entity.Property(e => e.Terreno19)
                .HasColumnType("character varying")
                .HasColumnName("terreno19");
            entity.Property(e => e.Terreno20)
                .HasColumnType("character varying")
                .HasColumnName("terreno20");
        });

        modelBuilder.Entity<Impuesto>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("impuestos", "catastro");

            entity.Property(e => e.Anyo)
                .HasColumnType("character varying")
                .HasColumnName("anyo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Pagado).HasColumnName("pagado");
            entity.Property(e => e.Terrenos19)
                .HasColumnType("character varying")
                .HasColumnName("terrenos19");
            entity.Property(e => e.Terrenos20)
                .HasColumnType("character varying")
                .HasColumnName("terrenos20");
        });

        modelBuilder.Entity<Instalacione>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("instalaciones", "catastro");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasColumnType("character varying")
                .HasColumnName("nombre");
            entity.Property(e => e.Valor).HasColumnName("valor");
        });

        modelBuilder.Entity<Localidade>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("localidades", "catastro");

            entity.Property(e => e.Departamento).HasColumnName("departamento");
            entity.Property(e => e.Descripcion)
                .HasColumnType("character varying")
                .HasColumnName("descripcion");
            entity.Property(e => e.Distrito).HasColumnName("distrito");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Municipio)
                .HasColumnType("character varying")
                .HasColumnName("municipio");
            entity.Property(e => e.Provincia).HasColumnName("provincia");
        });

        modelBuilder.Entity<Manzanasvista19>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("manzanasvista19", "catastro");

            entity.Property(e => e.Manzano)
                .HasColumnType("character varying")
                .HasColumnName("manzano");
            entity.Property(e => e.StMulti).HasColumnName("st_multi");
        });

        modelBuilder.Entity<Manzano>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("manzanos_pkey");

            entity.ToTable("manzanos", "catastro");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Geom)
                .HasColumnType("geometry(MultiPolygon,32719)")
                .HasColumnName("geom");
            entity.Property(e => e.Manzana)
                .HasColumnType("character varying")
                .HasColumnName("manzana");
            entity.Property(e => e.Perimetro).HasColumnName("perimetro");
            entity.Property(e => e.Status)
                .HasColumnType("character varying")
                .HasColumnName("status");
            entity.Property(e => e.Superficie).HasColumnName("superficie");
        });

        modelBuilder.Entity<MaterialVium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("material_via_pk");

            entity.ToTable("material_via", "catastro");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Material)
                .HasColumnType("character varying")
                .HasColumnName("material");
            entity.Property(e => e.Valor).HasColumnName("valor");
        });

        modelBuilder.Entity<Mejora>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mejoras", "catastro");

            entity.Property(e => e.Codigo)
                .HasColumnType("character varying")
                .HasColumnName("codigo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasColumnType("character varying")
                .HasColumnName("nombre");
            entity.Property(e => e.Superficie)
                .HasColumnType("character varying")
                .HasColumnName("superficie");
            entity.Property(e => e.Valor).HasColumnName("valor");
        });

        modelBuilder.Entity<Mejorasvista19>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("mejorasvista19", "catastro");

            entity.Property(e => e.Anyo)
                .HasColumnType("character varying")
                .HasColumnName("anyo");
            entity.Property(e => e.Carpinteria).HasColumnName("carpinteria");
            entity.Property(e => e.Cimiento).HasColumnName("cimiento");
            entity.Property(e => e.Codigo)
                .HasColumnType("character varying")
                .HasColumnName("codigo");
            entity.Property(e => e.Codigoespecial)
                .HasColumnType("character varying")
                .HasColumnName("codigoespecial");
            entity.Property(e => e.Conservacion).HasColumnName("conservacion");
            entity.Property(e => e.Cubierta).HasColumnName("cubierta");
            entity.Property(e => e.Estructura).HasColumnName("estructura");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdMejora).HasColumnName("id_mejora");
            entity.Property(e => e.Materialcarpinteria)
                .HasColumnType("character varying")
                .HasColumnName("materialcarpinteria");
            entity.Property(e => e.Materialcimientos)
                .HasColumnType("character varying")
                .HasColumnName("materialcimientos");
            entity.Property(e => e.Materialcubiertas)
                .HasColumnType("character varying")
                .HasColumnName("materialcubiertas");
            entity.Property(e => e.Materialestructura)
                .HasColumnType("character varying")
                .HasColumnName("materialestructura");
            entity.Property(e => e.Materialmuros)
                .HasColumnType("character varying")
                .HasColumnName("materialmuros");
            entity.Property(e => e.Materialmurosext)
                .HasColumnType("character varying")
                .HasColumnName("materialmurosext");
            entity.Property(e => e.Materialmurosint)
                .HasColumnType("character varying")
                .HasColumnName("materialmurosint");
            entity.Property(e => e.Materialpisos)
                .HasColumnType("character varying")
                .HasColumnName("materialpisos");
            entity.Property(e => e.Muros).HasColumnName("muros");
            entity.Property(e => e.MurosExt).HasColumnName("muros_ext");
            entity.Property(e => e.MurosInt).HasColumnName("muros_int");
            entity.Property(e => e.Nombre)
                .HasColumnType("character varying")
                .HasColumnName("nombre");
            entity.Property(e => e.Pisos).HasColumnName("pisos");
            entity.Property(e => e.Superficie)
                .HasColumnType("character varying")
                .HasColumnName("superficie");
            entity.Property(e => e.Valor).HasColumnName("valor");
            entity.Property(e => e.Valorcarpinteria).HasColumnName("valorcarpinteria");
            entity.Property(e => e.Valorcimientos).HasColumnName("valorcimientos");
            entity.Property(e => e.Valorcubiertas).HasColumnName("valorcubiertas");
            entity.Property(e => e.Valorestructura).HasColumnName("valorestructura");
            entity.Property(e => e.Valormuros).HasColumnName("valormuros");
            entity.Property(e => e.Valormurosext).HasColumnName("valormurosext");
            entity.Property(e => e.Valormurosint).HasColumnName("valormurosint");
            entity.Property(e => e.Valorpisos).HasColumnName("valorpisos");
        });

        modelBuilder.Entity<Otcatastro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("otcatastro_pkey");

            entity.ToTable("otcatastro", "catastro");

            entity.HasIndex(e => e.Idlote, "otcatastro_un").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Idlote).HasColumnName("idlote");
            entity.Property(e => e.Idusuario).HasColumnName("idusuario");

            entity.HasOne(d => d.IdloteNavigation).WithOne(p => p.Otcatastro)
                .HasForeignKey<Otcatastro>(d => d.Idlote)
                .HasConstraintName("otcatastro_idlote_fk");

            entity.HasOne(d => d.IdusuarioNavigation).WithMany(p => p.Otcatastros)
                .HasForeignKey(d => d.Idusuario)
                .HasConstraintName("otcatastro_idusuario_fkey");
        });

        modelBuilder.Entity<Planta>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("plantas", "catastro");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Planta1)
                .HasColumnType("character varying")
                .HasColumnName("planta");
        });

        modelBuilder.Entity<Plantasvista19>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("plantasvista19", "catastro");

            entity.Property(e => e.Carpinteria).HasColumnName("carpinteria");
            entity.Property(e => e.Cimiento).HasColumnName("cimiento");
            entity.Property(e => e.Cubierta).HasColumnName("cubierta");
            entity.Property(e => e.Estructura).HasColumnName("estructura");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdConstruccion).HasColumnName("id_construccion");
            entity.Property(e => e.IdPlanta).HasColumnName("id_planta");
            entity.Property(e => e.Materialcarpinteria)
                .HasColumnType("character varying")
                .HasColumnName("materialcarpinteria");
            entity.Property(e => e.Materialcimientos)
                .HasColumnType("character varying")
                .HasColumnName("materialcimientos");
            entity.Property(e => e.Materialcubiertas)
                .HasColumnType("character varying")
                .HasColumnName("materialcubiertas");
            entity.Property(e => e.Materialestructura)
                .HasColumnType("character varying")
                .HasColumnName("materialestructura");
            entity.Property(e => e.Materialmuros)
                .HasColumnType("character varying")
                .HasColumnName("materialmuros");
            entity.Property(e => e.Materialmurosext)
                .HasColumnType("character varying")
                .HasColumnName("materialmurosext");
            entity.Property(e => e.Materialmurosint)
                .HasColumnType("character varying")
                .HasColumnName("materialmurosint");
            entity.Property(e => e.Materialpisos)
                .HasColumnType("character varying")
                .HasColumnName("materialpisos");
            entity.Property(e => e.Muros).HasColumnName("muros");
            entity.Property(e => e.MurosExt).HasColumnName("muros_ext");
            entity.Property(e => e.MurosInt).HasColumnName("muros_int");
            entity.Property(e => e.Pisos).HasColumnName("pisos");
            entity.Property(e => e.Planta)
                .HasColumnType("character varying")
                .HasColumnName("planta");
            entity.Property(e => e.Valorcarpinteria).HasColumnName("valorcarpinteria");
            entity.Property(e => e.Valorcimientos).HasColumnName("valorcimientos");
            entity.Property(e => e.Valorcubiertas).HasColumnName("valorcubiertas");
            entity.Property(e => e.Valorestructura).HasColumnName("valorestructura");
            entity.Property(e => e.Valormuros).HasColumnName("valormuros");
            entity.Property(e => e.Valormurosext).HasColumnName("valormurosext");
            entity.Property(e => e.Valormurosint).HasColumnName("valormurosint");
            entity.Property(e => e.Valorpisos).HasColumnName("valorpisos");
        });

        modelBuilder.Entity<Provincia>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("provincias_pk");

            entity.ToTable("provincias", "catastro");

            entity.Property(e => e.Codigo)
                .ValueGeneratedNever()
                .HasColumnName("codigo");
            entity.Property(e => e.Departamento).HasColumnName("departamento");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasColumnType("character varying")
                .HasColumnName("nombre");

            entity.HasOne(d => d.DepartamentoNavigation).WithMany(p => p.Provincia)
                .HasForeignKey(d => d.Departamento)
                .HasConstraintName("provincias_fk");
        });

        modelBuilder.Entity<Revestimiento>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("revestimiento", "catastro");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Revestimiento1)
                .HasColumnType("character varying")
                .HasColumnName("revestimiento");
        });

        modelBuilder.Entity<Terrenos19>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("terrenos19_pkey");

            entity.ToTable("terrenos19", "catastro");

            entity.HasIndex(e => e.Codigo, "terrenos19_un").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Agua).HasColumnName("agua");
            entity.Property(e => e.Alcantarillado).HasColumnName("alcantarillado");
            entity.Property(e => e.Barrio)
                .HasColumnType("character varying")
                .HasColumnName("barrio");
            entity.Property(e => e.Base)
                .HasColumnType("character varying")
                .HasColumnName("base");
            entity.Property(e => e.Codigo)
                .HasColumnType("character varying")
                .HasColumnName("codigo");
            entity.Property(e => e.Direccion)
                .HasColumnType("character varying")
                .HasColumnName("direccion");
            entity.Property(e => e.Energia).HasColumnName("energia");
            entity.Property(e => e.Este)
                .HasColumnType("character varying")
                .HasColumnName("este");
            entity.Property(e => e.FechaTest).HasColumnName("fecha_test");
            entity.Property(e => e.FolioDdrr)
                .HasColumnType("character varying")
                .HasColumnName("folio_ddrr");
            entity.Property(e => e.Fondo).HasColumnName("fondo");
            entity.Property(e => e.Forma).HasColumnName("forma");
            entity.Property(e => e.Frente).HasColumnName("frente");
            entity.Property(e => e.Geom)
                .HasColumnType("geometry(MultiPolygon,32719)")
                .HasColumnName("geom");
            entity.Property(e => e.Internet).HasColumnName("internet");
            entity.Property(e => e.Manzano)
                .HasColumnType("character varying")
                .HasColumnName("manzano");
            entity.Property(e => e.MaterialVia).HasColumnName("material_via");
            entity.Property(e => e.NTest)
                .HasColumnType("character varying")
                .HasColumnName("n_test");
            entity.Property(e => e.Norte)
                .HasColumnType("character varying")
                .HasColumnName("norte");
            entity.Property(e => e.Oeste)
                .HasColumnType("character varying")
                .HasColumnName("oeste");
            entity.Property(e => e.Predio)
                .HasColumnType("character varying")
                .HasColumnName("predio");
            entity.Property(e => e.Subpredio)
                .HasColumnType("character varying")
                .HasColumnName("subpredio");
            entity.Property(e => e.Superficie).HasColumnName("superficie");
            entity.Property(e => e.Suptest).HasColumnName("suptest");
            entity.Property(e => e.Sur)
                .HasColumnType("character varying")
                .HasColumnName("sur");
            entity.Property(e => e.Telefono).HasColumnName("telefono");
            entity.Property(e => e.Titular).HasColumnName("titular");
            entity.Property(e => e.Topografia).HasColumnName("topografia");
            entity.Property(e => e.Transporte).HasColumnName("transporte");
            entity.Property(e => e.Ubicacion).HasColumnName("ubicacion");
            entity.Property(e => e.Via).HasColumnName("via");
            entity.Property(e => e.Zona).HasColumnName("zona");

            entity.HasOne(d => d.FormaNavigation).WithMany(p => p.Terrenos19s)
                .HasForeignKey(d => d.Forma)
                .HasConstraintName("t19_forma_fk");

            entity.HasOne(d => d.MaterialViaNavigation).WithMany(p => p.Terrenos19s)
                .HasForeignKey(d => d.MaterialVia)
                .HasConstraintName("t19_material_via_fk");

            entity.HasOne(d => d.TopografiaNavigation).WithMany(p => p.Terrenos19s)
                .HasForeignKey(d => d.Topografia)
                .HasConstraintName("t19_topo_fk");

            entity.HasOne(d => d.UbicacionNavigation).WithMany(p => p.Terrenos19s)
                .HasForeignKey(d => d.Ubicacion)
                .HasConstraintName("t19_ubicacion_fk");

            entity.HasOne(d => d.ViaNavigation).WithMany(p => p.Terrenos19s)
                .HasForeignKey(d => d.Via)
                .HasConstraintName("t19_via_fk");

            entity.HasOne(d => d.ZonaNavigation).WithMany(p => p.Terrenos19s)
                .HasForeignKey(d => d.Zona)
                .HasConstraintName("t19_zona_fk");
        });

        modelBuilder.Entity<Terrenos191>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("terrenos19", "siim");

            entity.Property(e => e.Agua).HasColumnName("agua");
            entity.Property(e => e.Alcantarillado).HasColumnName("alcantarillado");
            entity.Property(e => e.Barrio)
                .HasColumnType("character varying")
                .HasColumnName("barrio");
            entity.Property(e => e.Base)
                .HasColumnType("character varying")
                .HasColumnName("base");
            entity.Property(e => e.Codigo)
                .HasColumnType("character varying")
                .HasColumnName("codigo");
            entity.Property(e => e.Direccion)
                .HasColumnType("character varying")
                .HasColumnName("direccion");
            entity.Property(e => e.Energia).HasColumnName("energia");
            entity.Property(e => e.Este)
                .HasColumnType("character varying")
                .HasColumnName("este");
            entity.Property(e => e.FechaTest).HasColumnName("fecha_test");
            entity.Property(e => e.FolioDdrr)
                .HasColumnType("character varying")
                .HasColumnName("folio_ddrr");
            entity.Property(e => e.Fondo).HasColumnName("fondo");
            entity.Property(e => e.Forma).HasColumnName("forma");
            entity.Property(e => e.Frente).HasColumnName("frente");
            entity.Property(e => e.Geom)
                .HasColumnType("geometry(MultiPolygon,32719)")
                .HasColumnName("geom");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Internet).HasColumnName("internet");
            entity.Property(e => e.Manzano)
                .HasColumnType("character varying")
                .HasColumnName("manzano");
            entity.Property(e => e.MaterialVia).HasColumnName("material_via");
            entity.Property(e => e.NTest)
                .HasColumnType("character varying")
                .HasColumnName("n_test");
            entity.Property(e => e.Norte)
                .HasColumnType("character varying")
                .HasColumnName("norte");
            entity.Property(e => e.Oeste)
                .HasColumnType("character varying")
                .HasColumnName("oeste");
            entity.Property(e => e.Predio)
                .HasColumnType("character varying")
                .HasColumnName("predio");
            entity.Property(e => e.Subpredio)
                .HasColumnType("character varying")
                .HasColumnName("subpredio");
            entity.Property(e => e.Superficie).HasColumnName("superficie");
            entity.Property(e => e.Suptest).HasColumnName("suptest");
            entity.Property(e => e.Sur)
                .HasColumnType("character varying")
                .HasColumnName("sur");
            entity.Property(e => e.Telefono).HasColumnName("telefono");
            entity.Property(e => e.Titular).HasColumnName("titular");
            entity.Property(e => e.Topografia).HasColumnName("topografia");
            entity.Property(e => e.Transporte).HasColumnName("transporte");
            entity.Property(e => e.Ubicacion).HasColumnName("ubicacion");
            entity.Property(e => e.Via).HasColumnName("via");
            entity.Property(e => e.Zona).HasColumnName("zona");
        });

        modelBuilder.Entity<Terrenos192>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("terrenos19", "secure");

            entity.Property(e => e.Agua).HasColumnName("agua");
            entity.Property(e => e.Alcantarillado).HasColumnName("alcantarillado");
            entity.Property(e => e.Barrio)
                .HasColumnType("character varying")
                .HasColumnName("barrio");
            entity.Property(e => e.Base)
                .HasColumnType("character varying")
                .HasColumnName("base");
            entity.Property(e => e.Codigo)
                .HasColumnType("character varying")
                .HasColumnName("codigo");
            entity.Property(e => e.Direccion)
                .HasColumnType("character varying")
                .HasColumnName("direccion");
            entity.Property(e => e.Energia).HasColumnName("energia");
            entity.Property(e => e.Este)
                .HasColumnType("character varying")
                .HasColumnName("este");
            entity.Property(e => e.FechaTest).HasColumnName("fecha_test");
            entity.Property(e => e.FolioDdrr)
                .HasColumnType("character varying")
                .HasColumnName("folio_ddrr");
            entity.Property(e => e.Fondo).HasColumnName("fondo");
            entity.Property(e => e.Forma).HasColumnName("forma");
            entity.Property(e => e.Frente).HasColumnName("frente");
            entity.Property(e => e.Geom)
                .HasColumnType("geometry(MultiPolygon,32719)")
                .HasColumnName("geom");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Internet).HasColumnName("internet");
            entity.Property(e => e.Manzano)
                .HasColumnType("character varying")
                .HasColumnName("manzano");
            entity.Property(e => e.MaterialVia).HasColumnName("material_via");
            entity.Property(e => e.NTest)
                .HasColumnType("character varying")
                .HasColumnName("n_test");
            entity.Property(e => e.Norte)
                .HasColumnType("character varying")
                .HasColumnName("norte");
            entity.Property(e => e.Oeste)
                .HasColumnType("character varying")
                .HasColumnName("oeste");
            entity.Property(e => e.Predio)
                .HasColumnType("character varying")
                .HasColumnName("predio");
            entity.Property(e => e.Subpredio)
                .HasColumnType("character varying")
                .HasColumnName("subpredio");
            entity.Property(e => e.Superficie).HasColumnName("superficie");
            entity.Property(e => e.Suptest).HasColumnName("suptest");
            entity.Property(e => e.Sur)
                .HasColumnType("character varying")
                .HasColumnName("sur");
            entity.Property(e => e.Telefono).HasColumnName("telefono");
            entity.Property(e => e.Titular).HasColumnName("titular");
            entity.Property(e => e.Topografia).HasColumnName("topografia");
            entity.Property(e => e.Transporte).HasColumnName("transporte");
            entity.Property(e => e.Ubicacion).HasColumnName("ubicacion");
            entity.Property(e => e.Via).HasColumnName("via");
            entity.Property(e => e.Zona).HasColumnName("zona");
        });

        modelBuilder.Entity<Terrenos20>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("terrenos20_pkey");

            entity.ToTable("terrenos20", "catastro");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Agua).HasColumnName("agua");
            entity.Property(e => e.Alcantarillado).HasColumnName("alcantarillado");
            entity.Property(e => e.Barrio)
                .HasColumnType("character varying")
                .HasColumnName("barrio");
            entity.Property(e => e.Base)
                .HasColumnType("character varying")
                .HasColumnName("base");
            entity.Property(e => e.Codigo)
                .HasColumnType("character varying")
                .HasColumnName("codigo");
            entity.Property(e => e.Direccion)
                .HasColumnType("character varying")
                .HasColumnName("direccion");
            entity.Property(e => e.Energia).HasColumnName("energia");
            entity.Property(e => e.Este)
                .HasColumnType("character varying")
                .HasColumnName("este");
            entity.Property(e => e.Fondo)
                .HasColumnType("character varying")
                .HasColumnName("fondo");
            entity.Property(e => e.Forma).HasColumnName("forma");
            entity.Property(e => e.Frente)
                .HasColumnType("character varying")
                .HasColumnName("frente");
            entity.Property(e => e.Geom)
                .HasColumnType("geometry(MultiPolygon,32720)")
                .HasColumnName("geom");
            entity.Property(e => e.Internet).HasColumnName("internet");
            entity.Property(e => e.Manzano)
                .HasColumnType("character varying")
                .HasColumnName("manzano");
            entity.Property(e => e.Norte)
                .HasColumnType("character varying")
                .HasColumnName("norte");
            entity.Property(e => e.Oeste)
                .HasColumnType("character varying")
                .HasColumnName("oeste");
            entity.Property(e => e.Predio)
                .HasColumnType("character varying")
                .HasColumnName("predio");
            entity.Property(e => e.Subpredio)
                .HasColumnType("character varying")
                .HasColumnName("subpredio");
            entity.Property(e => e.Superficie).HasColumnName("superficie");
            entity.Property(e => e.Suptest)
                .HasColumnType("character varying")
                .HasColumnName("suptest");
            entity.Property(e => e.Sur)
                .HasColumnType("character varying")
                .HasColumnName("sur");
            entity.Property(e => e.Telefono).HasColumnName("telefono");
            entity.Property(e => e.Titular).HasColumnName("titular");
            entity.Property(e => e.Topografia).HasColumnName("topografia");
            entity.Property(e => e.Transporte).HasColumnName("transporte");
            entity.Property(e => e.Ubicacion).HasColumnName("ubicacion");
            entity.Property(e => e.Via).HasColumnName("via");
        });

        modelBuilder.Entity<TerrenosEspeciales19>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("terrenos_especiales19_pkey");

            entity.ToTable("terrenos_especiales19", "catastro");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('catastro.especiales_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Anyo)
                .HasColumnType("character varying")
                .HasColumnName("anyo");
            entity.Property(e => e.Carpinteria).HasColumnName("carpinteria");
            entity.Property(e => e.Cimiento).HasColumnName("cimiento");
            entity.Property(e => e.Codigo)
                .HasColumnType("character varying")
                .HasColumnName("codigo");
            entity.Property(e => e.Conservacion).HasColumnName("conservacion");
            entity.Property(e => e.Cubierta).HasColumnName("cubierta");
            entity.Property(e => e.Estructura).HasColumnName("estructura");
            entity.Property(e => e.IdEsp).HasColumnName("id_esp");
            entity.Property(e => e.Muros).HasColumnName("muros");
            entity.Property(e => e.MurosExt).HasColumnName("muros_ext");
            entity.Property(e => e.MurosInt).HasColumnName("muros_int");
            entity.Property(e => e.Pisos).HasColumnName("pisos");
            entity.Property(e => e.Superficie)
                .HasColumnType("character varying")
                .HasColumnName("superficie");
        });

        modelBuilder.Entity<TerrenosEspeciales20>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("terrenos_especiales20_pkey");

            entity.ToTable("terrenos_especiales20", "catastro");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Anyo).HasColumnName("anyo");
            entity.Property(e => e.Carpinteria).HasColumnName("carpinteria");
            entity.Property(e => e.Cimiento).HasColumnName("cimiento");
            entity.Property(e => e.Codigo)
                .HasColumnType("character varying")
                .HasColumnName("codigo");
            entity.Property(e => e.Conservacion).HasColumnName("conservacion");
            entity.Property(e => e.Cubierta).HasColumnName("cubierta");
            entity.Property(e => e.Estructura).HasColumnName("estructura");
            entity.Property(e => e.IdEsp).HasColumnName("id_esp");
            entity.Property(e => e.Muros).HasColumnName("muros");
            entity.Property(e => e.MurosExt).HasColumnName("muros_ext");
            entity.Property(e => e.MurosInt).HasColumnName("muros_int");
            entity.Property(e => e.Pisos).HasColumnName("pisos");
            entity.Property(e => e.Plantas).HasColumnName("plantas");
            entity.Property(e => e.Uso).HasColumnName("uso");
        });

        modelBuilder.Entity<TerrenosMejoras19>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("terrenos_mejoras19_pkey");

            entity.ToTable("terrenos_mejoras19", "catastro");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('catastro.terrenos_mejoras_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Anyo)
                .HasColumnType("character varying")
                .HasColumnName("anyo");
            entity.Property(e => e.Carpinteria).HasColumnName("carpinteria");
            entity.Property(e => e.Cimiento).HasColumnName("cimiento");
            entity.Property(e => e.Codigo)
                .HasColumnType("character varying")
                .HasColumnName("codigo");
            entity.Property(e => e.Conservacion).HasColumnName("conservacion");
            entity.Property(e => e.Cubierta).HasColumnName("cubierta");
            entity.Property(e => e.Estructura).HasColumnName("estructura");
            entity.Property(e => e.IdMejora).HasColumnName("id_mejora");
            entity.Property(e => e.Muros).HasColumnName("muros");
            entity.Property(e => e.MurosExt).HasColumnName("muros_ext");
            entity.Property(e => e.MurosInt).HasColumnName("muros_int");
            entity.Property(e => e.Pisos).HasColumnName("pisos");
            entity.Property(e => e.Superficie)
                .HasColumnType("character varying")
                .HasColumnName("superficie");
        });

        modelBuilder.Entity<TerrenosMejoras20>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("terrenos_mejoras20_pkey");

            entity.ToTable("terrenos_mejoras20", "catastro");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Anyo).HasColumnName("anyo");
            entity.Property(e => e.Carpinteria).HasColumnName("carpinteria");
            entity.Property(e => e.Cimiento).HasColumnName("cimiento");
            entity.Property(e => e.Codigo)
                .HasColumnType("character varying")
                .HasColumnName("codigo");
            entity.Property(e => e.Conservacion).HasColumnName("conservacion");
            entity.Property(e => e.Cubierta).HasColumnName("cubierta");
            entity.Property(e => e.Estructura).HasColumnName("estructura");
            entity.Property(e => e.IdMejora).HasColumnName("id_mejora");
            entity.Property(e => e.Muros).HasColumnName("muros");
            entity.Property(e => e.MurosExt).HasColumnName("muros_ext");
            entity.Property(e => e.MurosInt).HasColumnName("muros_int");
            entity.Property(e => e.Pisos).HasColumnName("pisos");
            entity.Property(e => e.Plantas).HasColumnName("plantas");
            entity.Property(e => e.Uso).HasColumnName("uso");
        });

        modelBuilder.Entity<Terrenosvista19>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("terrenosvista19", "catastro");

            entity.Property(e => e.Adquisicion).HasColumnName("adquisicion");
            entity.Property(e => e.Agua).HasColumnName("agua");
            entity.Property(e => e.Alcantarillado).HasColumnName("alcantarillado");
            entity.Property(e => e.Apellidos)
                .HasColumnType("character varying")
                .HasColumnName("apellidos");
            entity.Property(e => e.Barrio)
                .HasColumnType("character varying")
                .HasColumnName("barrio");
            entity.Property(e => e.Base)
                .HasColumnType("character varying")
                .HasColumnName("base");
            entity.Property(e => e.Caracter).HasColumnName("caracter");
            entity.Property(e => e.Codigo)
                .HasColumnType("character varying")
                .HasColumnName("codigo");
            entity.Property(e => e.Codigoadquisicion)
                .HasColumnType("character varying")
                .HasColumnName("codigoadquisicion");
            entity.Property(e => e.Codigocaracter)
                .HasColumnType("character varying")
                .HasColumnName("codigocaracter");
            entity.Property(e => e.Codigodocumento)
                .HasColumnType("character varying")
                .HasColumnName("codigodocumento");
            entity.Property(e => e.Codigodocumnetopropiedad)
                .HasColumnType("character varying")
                .HasColumnName("codigodocumnetopropiedad");
            entity.Property(e => e.Codigoforma)
                .HasColumnType("character varying")
                .HasColumnName("codigoforma");
            entity.Property(e => e.Codigoubicacion)
                .HasColumnType("character varying")
                .HasColumnName("codigoubicacion");
            entity.Property(e => e.Descrtopo)
                .HasColumnType("character varying")
                .HasColumnName("descrtopo");
            entity.Property(e => e.Direccion)
                .HasColumnType("character varying")
                .HasColumnName("direccion");
            entity.Property(e => e.Documento).HasColumnName("documento");
            entity.Property(e => e.DocumentoProp).HasColumnName("documento_prop");
            entity.Property(e => e.Documentopropiedad)
                .HasColumnType("character varying")
                .HasColumnName("documentopropiedad");
            entity.Property(e => e.Energia).HasColumnName("energia");
            entity.Property(e => e.Este)
                .HasColumnType("character varying")
                .HasColumnName("este");
            entity.Property(e => e.FechaTest).HasColumnName("fecha_test");
            entity.Property(e => e.FolioDdrr)
                .HasColumnType("character varying")
                .HasColumnName("folio_ddrr");
            entity.Property(e => e.Fondo).HasColumnName("fondo");
            entity.Property(e => e.Forma).HasColumnName("forma");
            entity.Property(e => e.Frente).HasColumnName("frente");
            entity.Property(e => e.Geom)
                .HasColumnType("geometry(MultiPolygon,32719)")
                .HasColumnName("geom");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Idzona).HasColumnName("idzona");
            entity.Property(e => e.Internet).HasColumnName("internet");
            entity.Property(e => e.Manzano)
                .HasColumnType("character varying")
                .HasColumnName("manzano");
            entity.Property(e => e.MaterialVia).HasColumnName("material_via");
            entity.Property(e => e.Materialvia1)
                .HasColumnType("character varying")
                .HasColumnName("materialvia");
            entity.Property(e => e.NTest)
                .HasColumnType("character varying")
                .HasColumnName("n_test");
            entity.Property(e => e.Nombre)
                .HasColumnType("character varying")
                .HasColumnName("nombre");
            entity.Property(e => e.Nombreadquisicion)
                .HasColumnType("character varying")
                .HasColumnName("nombreadquisicion");
            entity.Property(e => e.Nombrecaracter)
                .HasColumnType("character varying")
                .HasColumnName("nombrecaracter");
            entity.Property(e => e.Nombreforma)
                .HasColumnType("character varying")
                .HasColumnName("nombreforma");
            entity.Property(e => e.Nombretopo)
                .HasColumnType("character varying")
                .HasColumnName("nombretopo");
            entity.Property(e => e.Nombreubicacion)
                .HasColumnType("character varying")
                .HasColumnName("nombreubicacion");
            entity.Property(e => e.Norte)
                .HasColumnType("character varying")
                .HasColumnName("norte");
            entity.Property(e => e.Oeste)
                .HasColumnType("character varying")
                .HasColumnName("oeste");
            entity.Property(e => e.OtUsuario).HasColumnName("ot_usuario");
            entity.Property(e => e.Perimetro).HasColumnName("perimetro");
            entity.Property(e => e.Predio)
                .HasColumnType("character varying")
                .HasColumnName("predio");
            entity.Property(e => e.Subpredio)
                .HasColumnType("character varying")
                .HasColumnName("subpredio");
            entity.Property(e => e.Superficie).HasColumnName("superficie");
            entity.Property(e => e.Suptest).HasColumnName("suptest");
            entity.Property(e => e.Sur)
                .HasColumnType("character varying")
                .HasColumnName("sur");
            entity.Property(e => e.Telefono).HasColumnName("telefono");
            entity.Property(e => e.TipoDoc).HasColumnName("tipo_doc");
            entity.Property(e => e.Tipodocumento)
                .HasColumnType("character varying")
                .HasColumnName("tipodocumento");
            entity.Property(e => e.Tipovia)
                .HasColumnType("character varying")
                .HasColumnName("tipovia");
            entity.Property(e => e.Titular).HasColumnName("titular");
            entity.Property(e => e.Topografia).HasColumnName("topografia");
            entity.Property(e => e.Transporte).HasColumnName("transporte");
            entity.Property(e => e.Ubicacion).HasColumnName("ubicacion");
            entity.Property(e => e.Valorcatastralzona).HasColumnName("valorcatastralzona");
            entity.Property(e => e.Valorcomercialzona).HasColumnName("valorcomercialzona");
            entity.Property(e => e.Valorforma).HasColumnName("valorforma");
            entity.Property(e => e.Valormaterialvial).HasColumnName("valormaterialvial");
            entity.Property(e => e.Valortopo).HasColumnName("valortopo");
            entity.Property(e => e.Valorubicacion).HasColumnName("valorubicacion");
            entity.Property(e => e.Valorvia).HasColumnName("valorvia");
            entity.Property(e => e.Via).HasColumnName("via");
            entity.Property(e => e.Zona).HasColumnName("zona");
        });

        modelBuilder.Entity<TipoConstruccion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tipo_construccion", "catastro");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Tipo)
                .HasColumnType("character varying")
                .HasColumnName("tipo");
            entity.Property(e => e.Valor).HasColumnName("valor");
        });

        modelBuilder.Entity<TipoDocumento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tipo_documento_pk");

            entity.ToTable("tipo_documento", "catastro");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codigo)
                .HasColumnType("character varying")
                .HasColumnName("codigo");
            entity.Property(e => e.Tipo)
                .HasColumnType("character varying")
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<TipoVium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tipo_via_pk");

            entity.ToTable("tipo_via", "catastro");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Tipo)
                .HasColumnType("character varying")
                .HasColumnName("tipo");
            entity.Property(e => e.Valor).HasColumnName("valor");
        });

        modelBuilder.Entity<Titular>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("titular", "catastro");

            entity.Property(e => e.Adquisicion).HasColumnName("adquisicion");
            entity.Property(e => e.Apellidos)
                .HasColumnType("character varying")
                .HasColumnName("apellidos");
            entity.Property(e => e.Caracter).HasColumnName("caracter");
            entity.Property(e => e.Documento).HasColumnName("documento");
            entity.Property(e => e.DocumentoProp).HasColumnName("documento_prop");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasColumnType("character varying")
                .HasColumnName("nombre");
            entity.Property(e => e.TipoDoc).HasColumnName("tipo_doc");

            entity.HasOne(d => d.AdquisicionNavigation).WithMany()
                .HasForeignKey(d => d.Adquisicion)
                .HasConstraintName("titular_adquisicion_fkey");

            entity.HasOne(d => d.CaracterNavigation).WithMany()
                .HasForeignKey(d => d.Caracter)
                .HasConstraintName("titular_caracter_fkey");

            entity.HasOne(d => d.DocumentoPropNavigation).WithMany()
                .HasForeignKey(d => d.DocumentoProp)
                .HasConstraintName("titular_documento_prop_fkey");

            entity.HasOne(d => d.TipoDocNavigation).WithMany()
                .HasForeignKey(d => d.TipoDoc)
                .HasConstraintName("titular_tipo_doc_fkey");
        });

        modelBuilder.Entity<Titular1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("titular", "secure");

            entity.Property(e => e.Adquisicion).HasColumnName("adquisicion");
            entity.Property(e => e.Apellidos)
                .HasColumnType("character varying")
                .HasColumnName("apellidos");
            entity.Property(e => e.Caracter).HasColumnName("caracter");
            entity.Property(e => e.Documento).HasColumnName("documento");
            entity.Property(e => e.DocumentoProp).HasColumnName("documento_prop");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasColumnType("character varying")
                .HasColumnName("nombre");
            entity.Property(e => e.TipoDoc).HasColumnName("tipo_doc");
        });

        modelBuilder.Entity<Titulares2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("titulares2", "siim");

            entity.Property(e => e.Adquisicion).HasColumnName("adquisicion");
            entity.Property(e => e.Apellidos)
                .HasColumnType("character varying")
                .HasColumnName("apellidos");
            entity.Property(e => e.Caracter).HasColumnName("caracter");
            entity.Property(e => e.Documento).HasColumnName("documento");
            entity.Property(e => e.DocumentoProp).HasColumnName("documento_prop");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasColumnType("character varying")
                .HasColumnName("nombre");
            entity.Property(e => e.TipoDoc).HasColumnName("tipo_doc");
        });

        modelBuilder.Entity<Topografium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("topografia_pk");

            entity.ToTable("topografia", "catastro");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasColumnType("character varying")
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasColumnType("character varying")
                .HasColumnName("nombre");
            entity.Property(e => e.Valor).HasColumnName("valor");
        });

        modelBuilder.Entity<Ubicacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ubicacion_pk");

            entity.ToTable("ubicacion", "catastro");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codigo)
                .HasColumnType("character varying")
                .HasColumnName("codigo");
            entity.Property(e => e.Ubicacion1)
                .HasColumnType("character varying")
                .HasColumnName("ubicacion");
            entity.Property(e => e.Valor).HasColumnName("valor");
        });

        modelBuilder.Entity<Uso>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("uso", "catastro");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Uso1)
                .HasColumnType("character varying")
                .HasColumnName("uso");
            entity.Property(e => e.Valor).HasColumnName("valor");
        });

        modelBuilder.Entity<Zona>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("zonas_pk");

            entity.ToTable("zonas", "catastro");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Etiqueta)
                .HasColumnType("character varying")
                .HasColumnName("etiqueta");
            entity.Property(e => e.ValorCatastral).HasColumnName("valor_catastral");
            entity.Property(e => e.ValorComercial).HasColumnName("valor_comercial");
        });

        modelBuilder.Entity<Zonificacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("zonificacion_pkey");

            entity.ToTable("zonificacion", "catastro");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Clase)
                .HasMaxLength(3)
                .HasColumnName("clase");
            entity.Property(e => e.Geom)
                .HasColumnType("geometry(MultiPolygon,32719)")
                .HasColumnName("geom");
            entity.Property(e => e.Subclase).HasColumnName("subclase");
            entity.Property(e => e.ValorCatastral).HasColumnName("valor_catastral");
            entity.Property(e => e.ValorComercial).HasColumnName("valor_comercial");
        });

        modelBuilder.Entity<VistaTerreno>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vista_terrenos", "catastro");

            entity.Property(e => e.Adquisicion)
                .HasColumnType("character varying")
                .HasColumnName("adquisicion");
            entity.Property(e => e.Agua).HasColumnName("agua");
            entity.Property(e => e.Alcantarillado).HasColumnName("alcantarillado");
            entity.Property(e => e.Apellidos)
                .HasColumnType("character varying")
                .HasColumnName("apellidos");
            entity.Property(e => e.Barrio)
                .HasColumnType("character varying")
                .HasColumnName("barrio");
            entity.Property(e => e.Base)
                .HasColumnType("character varying")
                .HasColumnName("base");
            entity.Property(e => e.Codigo)
                .HasColumnType("character varying")
                .HasColumnName("codigo");
            entity.Property(e => e.Codigoadquisicion)
                .HasColumnType("character varying")
                .HasColumnName("codigoadquisicion");
            entity.Property(e => e.Codigoforma)
                .HasColumnType("character varying")
                .HasColumnName("codigoforma");
            entity.Property(e => e.Direccion)
                .HasColumnType("character varying")
                .HasColumnName("direccion");
            entity.Property(e => e.Documento).HasColumnName("documento");
            entity.Property(e => e.Energia).HasColumnName("energia");
            entity.Property(e => e.Este)
                .HasColumnType("character varying")
                .HasColumnName("este");
            entity.Property(e => e.Fondo).HasColumnName("fondo");
            entity.Property(e => e.Forma)
                .HasColumnType("character varying")
                .HasColumnName("forma");
            entity.Property(e => e.Frente).HasColumnName("frente");
            entity.Property(e => e.Geometry)
                .HasColumnType("geometry(MultiPolygon,32719)")
                .HasColumnName("geometry");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Internet).HasColumnName("internet");
            entity.Property(e => e.Manzano)
                .HasColumnType("character varying")
                .HasColumnName("manzano");
            entity.Property(e => e.Material)
                .HasColumnType("character varying")
                .HasColumnName("material");
            entity.Property(e => e.Nombre)
                .HasColumnType("character varying")
                .HasColumnName("nombre");
            entity.Property(e => e.Norte)
                .HasColumnType("character varying")
                .HasColumnName("norte");
            entity.Property(e => e.Oeste)
                .HasColumnType("character varying")
                .HasColumnName("oeste");
            entity.Property(e => e.Predio)
                .HasColumnType("character varying")
                .HasColumnName("predio");
            entity.Property(e => e.Subpredio)
                .HasColumnType("character varying")
                .HasColumnName("subpredio");
            entity.Property(e => e.Superficie).HasColumnName("superficie");
            entity.Property(e => e.Suptest).HasColumnName("suptest");
            entity.Property(e => e.Sur)
                .HasColumnType("character varying")
                .HasColumnName("sur");
            entity.Property(e => e.Telefono).HasColumnName("telefono");
            entity.Property(e => e.Tipo)
                .HasColumnType("character varying")
                .HasColumnName("tipo");
            entity.Property(e => e.Transporte).HasColumnName("transporte");
            entity.Property(e => e.Valor).HasColumnName("valor");
            entity.Property(e => e.Valortipovia).HasColumnName("valortipovia");
        });

        modelBuilder.Entity<VistaCatastro>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vista_catastro", "catastro");

            entity.Property(e => e.Codigo)
                .HasColumnType("character varying")
                .HasColumnName("codigo");
            entity.Property(e => e.Documento).HasColumnName("documento");
            entity.Property(e => e.Geometry)
                .HasColumnType("geometry(MultiPolygon,32719)")
                .HasColumnName("geometry");
            entity.Property(e => e.Nombre)
                .HasColumnType("character varying")
                .HasColumnName("nombre");
            entity.Property(e => e.Properties)
                .HasColumnType("jsonb")
                .HasColumnName("properties");
            entity.Property(e => e.Type).HasColumnName("type");
        });


        modelBuilder.Entity<VistaConstruccione>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vista_construcciones", "catastro");

            entity.Property(e => e.Aire).HasColumnName("aire");
            entity.Property(e => e.Anyo)
                .HasColumnType("character varying")
                .HasColumnName("anyo");
            entity.Property(e => e.Ascensores).HasColumnName("ascensores");
            entity.Property(e => e.Calefaccion).HasColumnName("calefaccion");
            entity.Property(e => e.Cod).HasColumnName("cod");
            entity.Property(e => e.Codigo)
                .HasColumnType("character varying")
                .HasColumnName("codigo");
            entity.Property(e => e.Conservacion).HasColumnName("conservacion");
            entity.Property(e => e.Dormitorios).HasColumnName("dormitorios");
            entity.Property(e => e.Escalera).HasColumnName("escalera");
            entity.Property(e => e.Estadoconservacion)
                .HasColumnType("character varying")
                .HasColumnName("estadoconservacion");
            entity.Property(e => e.Geometry)
                .HasColumnType("geometry(MultiPolygon,32719)")
                .HasColumnName("geometry");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Idconservacion).HasColumnName("idconservacion");
            entity.Property(e => e.Idrevestimiento).HasColumnName("idrevestimiento");
            entity.Property(e => e.Lavanderia).HasColumnName("lavanderia");
            entity.Property(e => e.Plantas).HasColumnName("plantas");
            entity.Property(e => e.Revestimiento)
                .HasColumnType("character varying")
                .HasColumnName("revestimiento");
            entity.Property(e => e.Sanitarios).HasColumnName("sanitarios");
            entity.Property(e => e.Servicio).HasColumnName("servicio");
            entity.Property(e => e.Tanque).HasColumnName("tanque");
        });


        modelBuilder.Entity<VistaConstruccionesJbo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vista_construcciones_jbo", "catastro");

            entity.Property(e => e.Codigo)
                .HasColumnType("character varying")
                .HasColumnName("codigo");
            entity.Property(e => e.Geometry)
                .HasColumnType("geometry(MultiPolygon,32719)")
                .HasColumnName("geometry");
            entity.Property(e => e.Properties)
                .HasColumnType("jsonb")
                .HasColumnName("properties");
            entity.Property(e => e.Type).HasColumnName("type");
        });


        modelBuilder.Entity<Formulariocatastral>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("formulariocatastral_pkey");

            entity.ToTable("formulariocatastral", "catastro");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codigo)
                .HasMaxLength(255)
                .HasColumnName("codigo");
            entity.Property(e => e.FormJson)
                .HasColumnType("json")
                .HasColumnName("form_json");
        });


        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
