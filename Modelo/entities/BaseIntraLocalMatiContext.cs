using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace test;

public partial class BaseIntraLocalMatiContext : DbContext
{
    public BaseIntraLocalMatiContext()
    {
    }

    public BaseIntraLocalMatiContext(DbContextOptions<BaseIntraLocalMatiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ComisionesTipoModalidad> ComisionesTipoModalidads { get; set; }

    public virtual DbSet<MdpPersona> MdpPersonas { get; set; }

    public virtual DbSet<MdpTiposDocumento> MdpTiposDocumentos { get; set; }

    public virtual DbSet<Migration> Migrations { get; set; }

    public virtual DbSet<MugPaise> MugPaises { get; set; }

    public virtual DbSet<SaiComisionesAgrupada> SaiComisionesAgrupadas { get; set; }

    public virtual DbSet<SaiComisionesAgrupadasDetalle> SaiComisionesAgrupadasDetalles { get; set; }

    public virtual DbSet<SaiComisionesObservacione> SaiComisionesObservaciones { get; set; }

    public virtual DbSet<SaiCondicione> SaiCondiciones { get; set; }

    public virtual DbSet<SaiCotasResponsablesAcademica> SaiCotasResponsablesAcademicas { get; set; }

    public virtual DbSet<SaiCuponPago> SaiCuponPagos { get; set; }

    public virtual DbSet<SaiCuponPagoEstado> SaiCuponPagoEstados { get; set; }

    public virtual DbSet<SaiElementosCalculado> SaiElementosCalculados { get; set; }

    public virtual DbSet<SaiEstadosInscripcionFinale> SaiEstadosInscripcionFinales { get; set; }

    public virtual DbSet<SaiInscripcionesRa> SaiInscripcionesRas { get; set; }

    public virtual DbSet<SaiPeriodosTipo> SaiPeriodosTipos { get; set; }

    public virtual DbSet<SaiSancione> SaiSanciones { get; set; }

    public virtual DbSet<SaiSolicitudAlumnoRegular> SaiSolicitudAlumnoRegulars { get; set; }

    public virtual DbSet<SaiSolicitudAnaliticoParcial> SaiSolicitudAnaliticoParcials { get; set; }

    public virtual DbSet<SaiSolicitudLegalizacionPrograma> SaiSolicitudLegalizacionProgramas { get; set; }

    public virtual DbSet<SaiSolicitudMateriasAprobada> SaiSolicitudMateriasAprobadas { get; set; }

    public virtual DbSet<SaiSolicitudTramite> SaiSolicitudTramites { get; set; }

    public virtual DbSet<SaiSubcommerce> SaiSubcommerces { get; set; }

    public virtual DbSet<SaiTramitesAdicionale> SaiTramitesAdicionales { get; set; }

    public virtual DbSet<SaiTramitesEstado> SaiTramitesEstados { get; set; }

    public virtual DbSet<SaiTramitesRaPaga> SaiTramitesRaPagas { get; set; }

    public virtual DbSet<SgaAlumno> SgaAlumnos { get; set; }

    public virtual DbSet<SgaAsignacione> SgaAsignaciones { get; set; }

    public virtual DbSet<SgaCertificado> SgaCertificados { get; set; }

    public virtual DbSet<SgaComisione> SgaComisiones { get; set; }

    public virtual DbSet<SgaComisionesBh> SgaComisionesBhs { get; set; }

    public virtual DbSet<SgaComisionesPropuesta> SgaComisionesPropuestas { get; set; }

    public virtual DbSet<SgaConstancia> SgaConstancias { get; set; }

    public virtual DbSet<SgaElemento> SgaElementos { get; set; }

    public virtual DbSet<SgaElementosEstado> SgaElementosEstados { get; set; }

    public virtual DbSet<SgaElementosPlan> SgaElementosPlans { get; set; }

    public virtual DbSet<SgaElementosRevision> SgaElementosRevisions { get; set; }

    public virtual DbSet<SgaInscCursada> SgaInscCursadas { get; set; }

    public virtual DbSet<SgaInscExaman> SgaInscExamen { get; set; }

    public virtual DbSet<SgaInscripcionesEstado> SgaInscripcionesEstados { get; set; }

    public virtual DbSet<SgaLlamadosMesa> SgaLlamadosMesas { get; set; }

    public virtual DbSet<SgaLlamadosTurno> SgaLlamadosTurnos { get; set; }

    public virtual DbSet<SgaMesasExaman> SgaMesasExamen { get; set; }

    public virtual DbSet<SgaMesasExamenInstancia> SgaMesasExamenInstancias { get; set; }

    public virtual DbSet<SgaModalidadCursadum> SgaModalidadCursada { get; set; }

    public virtual DbSet<SgaPeriodo> SgaPeriodos { get; set; }

    public virtual DbSet<SgaPeriodosLectivo> SgaPeriodosLectivos { get; set; }

    public virtual DbSet<SgaPlane> SgaPlanes { get; set; }

    public virtual DbSet<SgaPlanesEstado> SgaPlanesEstados { get; set; }

    public virtual DbSet<SgaPlanesVersione> SgaPlanesVersiones { get; set; }

    public virtual DbSet<SgaPropuesta> SgaPropuestas { get; set; }

    public virtual DbSet<SgaPropuestasTipo> SgaPropuestasTipos { get; set; }

    public virtual DbSet<SgaResponsablesAcademica> SgaResponsablesAcademicas { get; set; }

    public virtual DbSet<SgaTurnosCursada> SgaTurnosCursadas { get; set; }

    public virtual DbSet<SgaUbicacione> SgaUbicaciones { get; set; }

    public virtual DbSet<SgaUbicacionesTipo> SgaUbicacionesTipos { get; set; }

    public virtual DbSet<U817SgaComisione> U817SgaComisiones { get; set; }

    public virtual DbSet<U817TramiteSolicitud> U817TramiteSolicituds { get; set; }

    public virtual DbSet<U817TramiteSolicitudDetalle> U817TramiteSolicitudDetalles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Server=localhost;Database=base_intra_local_mati;Port=5452;Username=root;Password=root;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ComisionesTipoModalidad>(entity =>
        {
            entity.HasKey(e => e.Modalidad).HasName("pk_comisiones_tipo_modalidad");

            entity.ToTable("comisiones_tipo_modalidad", "negocio");

            entity.Property(e => e.Modalidad)
                .ValueGeneratedNever()
                .HasColumnName("modalidad");
            entity.Property(e => e.Codigo)
                .HasMaxLength(4)
                .HasColumnName("codigo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<MdpPersona>(entity =>
        {
            entity.HasKey(e => e.Persona).HasName("pk_mdp_personas");

            entity.ToTable("mdp_personas", "negocio");

            entity.HasIndex(e => e.TipoDocumento, "IX_mdp_personas_tipo_documento");

            entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex").IsUnique();

            entity.HasIndex(e => e.Persona, "ifk_persona");

            entity.Property(e => e.Persona)
                .HasDefaultValueSql("nextval(('mdp_personas_seq'::text)::regclass)")
                .HasColumnName("persona");
            entity.Property(e => e.Apellido)
                .HasMaxLength(60)
                .HasColumnName("apellido");
            entity.Property(e => e.Domicilio)
                .HasMaxLength(60)
                .HasColumnName("domicilio");
            entity.Property(e => e.EmailValido)
                .HasDefaultValue((short)0)
                .HasColumnName("email_valido");
            entity.Property(e => e.EstadoCivil)
                .HasMaxLength(30)
                .HasColumnName("estado_civil");
            entity.Property(e => e.FechaNacimiento).HasColumnName("fecha_nacimiento");
            entity.Property(e => e.IdentidadGenero).HasColumnName("identidad_genero");
            entity.Property(e => e.Localidad)
                .HasColumnType("character varying")
                .HasColumnName("localidad");
            entity.Property(e => e.MailInstitucional)
                .HasColumnType("character varying")
                .HasColumnName("mail_institucional");
            entity.Property(e => e.MailPersonal)
                .HasMaxLength(100)
                .HasColumnName("mail_personal");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(30)
                .HasColumnName("nacionalidad");
            entity.Property(e => e.Nombres)
                .HasMaxLength(60)
                .HasColumnName("nombres");
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.NroDocumento)
                .HasMaxLength(20)
                .HasColumnName("nro_documento");
            entity.Property(e => e.Provincia)
                .HasMaxLength(30)
                .HasColumnName("provincia");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .HasColumnName("sexo");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .HasColumnName("telefono");
            entity.Property(e => e.TipoDocumento)
                .HasDefaultValue((short)0)
                .HasColumnName("tipo_documento");
            entity.Property(e => e.Token)
                .HasMaxLength(250)
                .HasColumnName("token");

            entity.HasOne(d => d.TipoDocumentoNavigation).WithMany(p => p.MdpPersonas)
                .HasForeignKey(d => d.TipoDocumento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("mdp_personas_mdp_tipos_documentos_fk");
        });

        modelBuilder.Entity<MdpTiposDocumento>(entity =>
        {
            entity.HasKey(e => e.TipoDocumento).HasName("pk_mdp_tipo_documento");

            entity.ToTable("mdp_tipos_documentos", "negocio");

            entity.Property(e => e.TipoDocumento)
                .ValueGeneratedNever()
                .HasColumnName("tipo_documento");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<Migration>(entity =>
        {
            entity.ToTable("Migrations", "negocio");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        modelBuilder.Entity<MugPaise>(entity =>
        {
            entity.HasKey(e => e.Pais).HasName("pk_mug_paises");

            entity.ToTable("mug_paises", "negocio");

            entity.Property(e => e.Pais).HasColumnName("pais");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<SaiComisionesAgrupada>(entity =>
        {
            entity.HasKey(e => e.ComisionAgrupada).HasName("pk_sai_comisiones_agrupadas");

            entity.ToTable("sai_comisiones_agrupadas", "negocio");

            entity.HasIndex(e => e.Elemento, "IX_sai_comisiones_agrupadas_elemento");

            entity.HasIndex(e => e.Modalidad, "IX_sai_comisiones_agrupadas_modalidad");

            entity.HasIndex(e => e.PeriodoLectivo, "IX_sai_comisiones_agrupadas_periodo_lectivo");

            entity.HasIndex(e => e.Llave, "uk_sai_comisiones_agrupadas_llave").IsUnique();

            entity.Property(e => e.ComisionAgrupada)
                .HasDefaultValueSql("nextval(('negocio.seq_sai_comision_agrupada'::text)::regclass)")
                .HasColumnName("comision_agrupada");
            entity.Property(e => e.DatosAsignacion)
                .HasColumnType("jsonb")
                .HasColumnName("datos_asignacion");
            entity.Property(e => e.Elemento).HasColumnName("elemento");
            entity.Property(e => e.Llave).HasColumnName("llave");
            entity.Property(e => e.Modalidad).HasColumnName("modalidad");
            entity.Property(e => e.PeriodoLectivo).HasColumnName("periodo_lectivo");
            entity.Property(e => e.Ubicacion).HasColumnName("ubicacion");

            entity.HasOne(d => d.ElementoNavigation).WithMany(p => p.SaiComisionesAgrupada)
                .HasForeignKey(d => d.Elemento)
                .HasConstraintName("fk_sai_comisiones_agrupadas_sga_elementos");

            entity.HasOne(d => d.ModalidadNavigation).WithMany(p => p.SaiComisionesAgrupada)
                .HasForeignKey(d => d.Modalidad)
                .HasConstraintName("fk_sai_comisiones_agrupadas_comisiones_tipo_modalidad");

            entity.HasOne(d => d.PeriodoLectivoNavigation).WithMany(p => p.SaiComisionesAgrupada)
                .HasForeignKey(d => d.PeriodoLectivo)
                .HasConstraintName("fk_sai_comisiones_agrupadas_sga_periodos_lectivos");
        });

        modelBuilder.Entity<SaiComisionesAgrupadasDetalle>(entity =>
        {
            entity.HasKey(e => new { e.ComisionAgrupada, e.Comision }).HasName("pk_sai_comisiones_agrupadas_detalle");

            entity.ToTable("sai_comisiones_agrupadas_detalle", "negocio");

            entity.HasIndex(e => e.Comision, "uk_sai_comisiones_agrupadas_detalle_comision_vigente")
                .IsUnique()
                .HasFilter("(fecha_hasta IS NULL)");

            entity.Property(e => e.ComisionAgrupada).HasColumnName("comision_agrupada");
            entity.Property(e => e.Comision).HasColumnName("comision");
            entity.Property(e => e.FechaDesde)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("fecha_desde");
            entity.Property(e => e.FechaHasta).HasColumnName("fecha_hasta");

            entity.HasOne(d => d.ComisionNavigation).WithOne(p => p.SaiComisionesAgrupadasDetalle)
                .HasForeignKey<SaiComisionesAgrupadasDetalle>(d => d.Comision)
                .HasConstraintName("fk_sai_comisiones_agrupadas_detalle_sga_comisiones");

            entity.HasOne(d => d.ComisionAgrupadaNavigation).WithMany(p => p.SaiComisionesAgrupadasDetalles)
                .HasForeignKey(d => d.ComisionAgrupada)
                .HasConstraintName("fk_sai_comisiones_agrupadas_detalle_sai_comisiones_agrupadas");
        });

        modelBuilder.Entity<SaiComisionesObservacione>(entity =>
        {
            entity.HasKey(e => e.Comision).HasName("sai_comisiones_observaciones_pkey");

            entity.ToTable("sai_comisiones_observaciones", "negocio");

            entity.Property(e => e.Comision)
                .ValueGeneratedNever()
                .HasColumnName("comision");
            entity.Property(e => e.Observacion)
                .HasMaxLength(100)
                .HasColumnName("observacion");

            entity.HasOne(d => d.ComisionNavigation).WithOne(p => p.SaiComisionesObservacione)
                .HasForeignKey<SaiComisionesObservacione>(d => d.Comision)
                .HasConstraintName("fk_sga_comisiones");
        });

        modelBuilder.Entity<SaiCondicione>(entity =>
        {
            entity.HasKey(e => e.Condicion).HasName("pk_sga_condiciones");

            entity.ToTable("sai_condiciones", "negocio");

            entity.Property(e => e.Condicion)
                .HasDefaultValueSql("nextval(('sai_condiciones_seq'::text)::regclass)")
                .HasColumnName("condicion");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(15)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<SaiCotasResponsablesAcademica>(entity =>
        {
            entity.HasKey(e => e.CotaResponsable).HasName("pk_sai_cotas_responsables_academicas");

            entity.ToTable("sai_cotas_responsables_academicas", "negocio");

            entity.HasIndex(e => e.PeriodoLectivo, "IX_sai_cotas_responsables_academicas_periodo_lectivo");

            entity.HasIndex(e => e.ResponsableAcademica, "IX_sai_cotas_responsables_academicas_responsable_academica");

            entity.HasIndex(e => new { e.Elemento, e.PeriodoLectivo, e.ResponsableAcademica }, "uk_sai_cotas_responsables_academicas_elemento_periodo_ra").IsUnique();

            entity.Property(e => e.CotaResponsable)
                .HasDefaultValueSql("nextval(('negocio.seq_sai_cota_responsable'::text)::regclass)")
                .HasColumnName("cota_responsable");
            entity.Property(e => e.Cota).HasColumnName("cota");
            entity.Property(e => e.Elemento).HasColumnName("elemento");
            entity.Property(e => e.PeriodoLectivo).HasColumnName("periodo_lectivo");
            entity.Property(e => e.ResponsableAcademica).HasColumnName("responsable_academica");

            entity.HasOne(d => d.ElementoNavigation).WithMany(p => p.SaiCotasResponsablesAcademicas)
                .HasForeignKey(d => d.Elemento)
                .HasConstraintName("fk_sai_cotas_responsables_academicas_sga_elementos");

            entity.HasOne(d => d.PeriodoLectivoNavigation).WithMany(p => p.SaiCotasResponsablesAcademicas)
                .HasForeignKey(d => d.PeriodoLectivo)
                .HasConstraintName("fk_sai_cotas_responsables_academicas_sga_periodos_lectivos");

            entity.HasOne(d => d.ResponsableAcademicaNavigation).WithMany(p => p.SaiCotasResponsablesAcademicas)
                .HasForeignKey(d => d.ResponsableAcademica)
                .HasConstraintName("fk_sai_cotas_responsables_academicas_sga_responsables_academica");
        });

        modelBuilder.Entity<SaiCuponPago>(entity =>
        {
            entity.HasKey(e => e.CuponPago).HasName("pk_sai_cupon_pago");

            entity.ToTable("sai_cupon_pago", "negocio");

            entity.HasIndex(e => e.Estado, "IX_sai_cupon_pago_estado");

            entity.HasIndex(e => e.NroFacturaPpt, "uq_sai_cupon_pago_nro_factura_ppt").IsUnique();

            entity.Property(e => e.CuponPago)
                .UseIdentityAlwaysColumn()
                .HasColumnName("cupon_pago");
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.FechaActualizacion).HasColumnName("fecha_actualizacion");
            entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");
            entity.Property(e => e.FechaPago).HasColumnName("fecha_pago");
            entity.Property(e => e.FechaVencimiento).HasColumnName("fecha_vencimiento");
            entity.Property(e => e.Importe).HasColumnName("importe");
            entity.Property(e => e.Link).HasColumnName("link");
            entity.Property(e => e.NroFacturaPpt).HasColumnName("nro_factura_ppt");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .HasColumnName("observaciones");

            entity.HasOne(d => d.EstadoNavigation).WithMany(p => p.SaiCuponPagos)
                .HasForeignKey(d => d.Estado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sai_cupon_pago_sai_cupon_pago_estados_fk");
        });

        modelBuilder.Entity<SaiCuponPagoEstado>(entity =>
        {
            entity.HasKey(e => e.Estado).HasName("sai_cupon_pago_estados_pkey");

            entity.ToTable("sai_cupon_pago_estados", "negocio");

            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .HasColumnName("descripcion");
            entity.Property(e => e.EstadoId)
                .HasMaxLength(10)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("estado_id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<SaiElementosCalculado>(entity =>
        {
            entity.HasKey(e => new { e.Alumno, e.Elemento }).HasName("sai_elementos_calculados_pk");

            entity.ToTable("sai_elementos_calculados", "negocio");

            entity.HasIndex(e => e.Condicion, "IX_sai_elementos_calculados_condicion");

            entity.HasIndex(e => e.Elemento, "IX_sai_elementos_calculados_elemento");

            entity.Property(e => e.Alumno).HasColumnName("alumno");
            entity.Property(e => e.Elemento).HasColumnName("elemento");
            entity.Property(e => e.Acreditacion)
                .HasDefaultValue(false)
                .HasColumnName("acreditacion");
            entity.Property(e => e.Condicion).HasColumnName("condicion");
            entity.Property(e => e.Regularizada)
                .HasDefaultValue(false)
                .HasColumnName("regularizada");

            entity.HasOne(d => d.AlumnoNavigation).WithMany(p => p.SaiElementosCalculados)
                .HasForeignKey(d => d.Alumno)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_sai_elementos_calculados_sga_alumnos");

            entity.HasOne(d => d.CondicionNavigation).WithMany(p => p.SaiElementosCalculados)
                .HasForeignKey(d => d.Condicion)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_sai_elementos_calculados_sai_condiciones");

            entity.HasOne(d => d.ElementoNavigation).WithMany(p => p.SaiElementosCalculados)
                .HasForeignKey(d => d.Elemento)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_sai_elementos_calculados_sga_elementos");
        });

        modelBuilder.Entity<SaiEstadosInscripcionFinale>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sai_estados_inscripcion_finales_pkey");

            entity.ToTable("sai_estados_inscripcion_finales", "negocio");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codigo)
                .HasMaxLength(2)
                .HasColumnName("codigo");
            entity.Property(e => e.Descripcion).HasColumnName("descripcion");
        });

        modelBuilder.Entity<SaiInscripcionesRa>(entity =>
        {
            entity.HasKey(e => new { e.PeriodoLectivo, e.ResponsableAcademica, e.Terminacion }).HasName("pk_sai_inscripciones_ra");

            entity.ToTable("sai_inscripciones_ra", "negocio");

            entity.HasIndex(e => e.ResponsableAcademica, "IX_sai_inscripciones_ra_responsable_academica");

            entity.Property(e => e.PeriodoLectivo).HasColumnName("periodo_lectivo");
            entity.Property(e => e.ResponsableAcademica).HasColumnName("responsable_academica");
            entity.Property(e => e.Terminacion).HasColumnName("terminacion");
            entity.Property(e => e.FechaFin)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_fin");
            entity.Property(e => e.FechaInicio)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_inicio");

            entity.HasOne(d => d.PeriodoLectivoNavigation).WithMany(p => p.SaiInscripcionesRas)
                .HasForeignKey(d => d.PeriodoLectivo)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_sga_periodos_lectivos_x_sai_inscripciones_ra");

            entity.HasOne(d => d.ResponsableAcademicaNavigation).WithMany(p => p.SaiInscripcionesRas)
                .HasForeignKey(d => d.ResponsableAcademica)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_sga_responsables_academicas_x_sai_inscripciones_ra");
        });

        modelBuilder.Entity<SaiPeriodosTipo>(entity =>
        {
            entity.HasKey(e => e.TipoPeriodo).HasName("sai_periodos_tipos_pk");

            entity.ToTable("sai_periodos_tipos", "negocio");

            entity.Property(e => e.TipoPeriodo)
                .ValueGeneratedNever()
                .HasColumnName("tipo_periodo");
            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Descripcion)
                .HasColumnType("character varying")
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<SaiSancione>(entity =>
        {
            entity.HasKey(e => new { e.Persona, e.Elemento, e.PeriodoLectivo }).HasName("pk_sai_sanciones");

            entity.ToTable("sai_sanciones", "negocio");

            entity.HasIndex(e => e.Elemento, "IX_sai_sanciones_elemento");

            entity.HasIndex(e => e.PeriodoLectivo, "IX_sai_sanciones_periodo_lectivo");

            entity.Property(e => e.Persona).HasColumnName("persona");
            entity.Property(e => e.Elemento).HasColumnName("elemento");
            entity.Property(e => e.PeriodoLectivo).HasColumnName("periodo_lectivo");

            entity.HasOne(d => d.ElementoNavigation).WithMany(p => p.SaiSanciones)
                .HasForeignKey(d => d.Elemento)
                .HasConstraintName("fk_sai_sanciones_sga_elementos");

            entity.HasOne(d => d.PeriodoLectivoNavigation).WithMany(p => p.SaiSanciones)
                .HasForeignKey(d => d.PeriodoLectivo)
                .HasConstraintName("fk_sai_sanciones_sga_periodos_lectivos");

            entity.HasOne(d => d.PersonaNavigation).WithMany(p => p.SaiSanciones)
                .HasForeignKey(d => d.Persona)
                .HasConstraintName("fk_sai_sanciones_mdp_personas");
        });

        modelBuilder.Entity<SaiSolicitudAlumnoRegular>(entity =>
        {
            entity.HasKey(e => e.Solicitud).HasName("pk_sai_solicitud_tramite_detalle");

            entity.ToTable("sai_solicitud_alumno_regular", "negocio");

            entity.Property(e => e.Solicitud)
                .ValueGeneratedNever()
                .HasColumnName("solicitud");
            entity.Property(e => e.Institucion)
                .HasMaxLength(200)
                .HasColumnName("institucion");

            entity.HasOne(d => d.SolicitudNavigation).WithOne(p => p.SaiSolicitudAlumnoRegular)
                .HasForeignKey<SaiSolicitudAlumnoRegular>(d => d.Solicitud)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sai_solicitud_alumno_regular_sai_solicitud_tramite_fk");
        });

        modelBuilder.Entity<SaiSolicitudAnaliticoParcial>(entity =>
        {
            entity.HasKey(e => e.Solicitud).HasName("pk_sai_solicitud_analitico_parcial");

            entity.ToTable("sai_solicitud_analitico_parcial", "negocio");

            entity.HasIndex(e => e.Certificado, "IX_sai_solicitud_analitico_parcial_certificado");

            entity.HasIndex(e => e.Plan, "IX_sai_solicitud_analitico_parcial_plan");

            entity.Property(e => e.Solicitud)
                .ValueGeneratedNever()
                .HasColumnName("solicitud");
            entity.Property(e => e.Certificado).HasColumnName("certificado");
            entity.Property(e => e.Institucion)
                .HasMaxLength(200)
                .HasColumnName("institucion");
            entity.Property(e => e.Plan).HasColumnName("plan");
            entity.Property(e => e.Porcentaje).HasColumnName("porcentaje");
            entity.Property(e => e.Promedio).HasColumnName("promedio");

            entity.HasOne(d => d.CertificadoNavigation).WithMany(p => p.SaiSolicitudAnaliticoParcials)
                .HasForeignKey(d => d.Certificado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sai_solicitud_analitico_parcial_sga_certificados_fk");

            entity.HasOne(d => d.PlanNavigation).WithMany(p => p.SaiSolicitudAnaliticoParcials)
                .HasForeignKey(d => d.Plan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sai_solicitud_analitico_parcial_sga_planes_fk");

            entity.HasOne(d => d.SolicitudNavigation).WithOne(p => p.SaiSolicitudAnaliticoParcial)
                .HasForeignKey<SaiSolicitudAnaliticoParcial>(d => d.Solicitud)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sai_solicitud_analitico_parcial_sai_solicitud_tramite_fk");
        });

        modelBuilder.Entity<SaiSolicitudLegalizacionPrograma>(entity =>
        {
            entity.HasKey(e => e.Solicitud).HasName("pk_sai_solicitud_legalizacion_programa");

            entity.ToTable("sai_solicitud_legalizacion_programa", "negocio");

            entity.HasIndex(e => e.Certificado, "IX_sai_solicitud_legalizacion_programa_certificado");

            entity.HasIndex(e => e.Pais, "IX_sai_solicitud_legalizacion_programa_pais");

            entity.HasIndex(e => e.PlanVersion, "IX_sai_solicitud_legalizacion_programa_plan_version");

            entity.Property(e => e.Solicitud)
                .ValueGeneratedNever()
                .HasColumnName("solicitud");
            entity.Property(e => e.Certificado).HasColumnName("certificado");
            entity.Property(e => e.CertificadoAnaliticoParcial).HasColumnName("certificado_analitico_parcial");
            entity.Property(e => e.CertificadoBajaUniversidad).HasColumnName("certificado_baja_universidad");
            entity.Property(e => e.CertificadoMateriasAprobadas).HasColumnName("certificado_materias_aprobadas");
            entity.Property(e => e.CertificadoNoSancion).HasColumnName("certificado_no_sancion");
            entity.Property(e => e.CertificadoPlanEstudio).HasColumnName("certificado_plan_estudio");
            entity.Property(e => e.Institucion)
                .HasMaxLength(200)
                .HasColumnName("institucion");
            entity.Property(e => e.Organismo)
                .HasMaxLength(200)
                .HasColumnName("organismo");
            entity.Property(e => e.Pais).HasColumnName("pais");
            entity.Property(e => e.PlanVersion).HasColumnName("plan_version");
            entity.Property(e => e.Telefono)
                .HasMaxLength(40)
                .HasColumnName("telefono");

            entity.HasOne(d => d.CertificadoNavigation).WithMany(p => p.SaiSolicitudLegalizacionProgramas)
                .HasForeignKey(d => d.Certificado)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("sai_solicitud_legalizacion_programa_sga_certificados_fk");

            entity.HasOne(d => d.PaisNavigation).WithMany(p => p.SaiSolicitudLegalizacionProgramas)
                .HasForeignKey(d => d.Pais)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("sai_solicitud_legalizacion_programa_mug_paises_fk");

            entity.HasOne(d => d.PlanVersionNavigation).WithMany(p => p.SaiSolicitudLegalizacionProgramas)
                .HasForeignKey(d => d.PlanVersion)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("sai_solicitud_legalizacion_programa_sga_planes_versiones_fk");

            entity.HasOne(d => d.SolicitudNavigation).WithOne(p => p.SaiSolicitudLegalizacionPrograma)
                .HasForeignKey<SaiSolicitudLegalizacionPrograma>(d => d.Solicitud)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("sai_solicitud_legalizacion_programa_sai_solicitud_tramite_fk");
        });

        modelBuilder.Entity<SaiSolicitudMateriasAprobada>(entity =>
        {
            entity.HasKey(e => e.Solicitud).HasName("pk_sai_solicitud_materias_aprobadas");

            entity.ToTable("sai_solicitud_materias_aprobadas", "negocio");

            entity.HasIndex(e => e.Certificado, "IX_sai_solicitud_materias_aprobadas_certificado");

            entity.HasIndex(e => e.Plan, "IX_sai_solicitud_materias_aprobadas_plan");

            entity.Property(e => e.Solicitud)
                .ValueGeneratedNever()
                .HasColumnName("solicitud");
            entity.Property(e => e.Certificado).HasColumnName("certificado");
            entity.Property(e => e.Institucion)
                .HasMaxLength(200)
                .HasColumnName("institucion");
            entity.Property(e => e.Plan)
                .HasDefaultValue(0)
                .HasColumnName("plan");
            entity.Property(e => e.Porcentaje)
                .HasDefaultValue(false)
                .HasColumnName("porcentaje");
            entity.Property(e => e.Promedio)
                .HasDefaultValue(false)
                .HasColumnName("promedio");

            entity.HasOne(d => d.CertificadoNavigation).WithMany(p => p.SaiSolicitudMateriasAprobada)
                .HasForeignKey(d => d.Certificado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sai_solicitud_materias_aprobadas_sga_certificados_fk");

            entity.HasOne(d => d.PlanNavigation).WithMany(p => p.SaiSolicitudMateriasAprobada)
                .HasForeignKey(d => d.Plan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sai_solicitud_materias_aprobadas_sga_planes_fk");

            entity.HasOne(d => d.SolicitudNavigation).WithOne(p => p.SaiSolicitudMateriasAprobada)
                .HasForeignKey<SaiSolicitudMateriasAprobada>(d => d.Solicitud)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sai_solicitud_materias_aprobadas_sai_solicitud_tramite_fk");
        });

        modelBuilder.Entity<SaiSolicitudTramite>(entity =>
        {
            entity.HasKey(e => e.Solicitud).HasName("sai_solicitud_tramite_pkey");

            entity.ToTable("sai_solicitud_tramite", "negocio");

            entity.HasIndex(e => e.Alumno, "IX_sai_solicitud_tramite_alumno");

            entity.HasIndex(e => e.Constancia, "IX_sai_solicitud_tramite_constancia");

            entity.HasIndex(e => e.CuponPago, "IX_sai_solicitud_tramite_cupon_pago").IsUnique();

            entity.HasIndex(e => e.Estado, "IX_sai_solicitud_tramite_estado");

            entity.HasIndex(e => e.Persona, "IX_sai_solicitud_tramite_persona");

            entity.Property(e => e.Solicitud)
                .UseIdentityAlwaysColumn()
                .HasColumnName("solicitud");
            entity.Property(e => e.Alumno).HasColumnName("alumno");
            entity.Property(e => e.Constancia).HasColumnName("constancia");
            entity.Property(e => e.CuponPago).HasColumnName("cupon_pago");
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.FechaActualizacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_actualizacion");
            entity.Property(e => e.FechaEntrega)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_entrega");
            entity.Property(e => e.FechaSolicitud)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_solicitud");
            entity.Property(e => e.Mail)
                .HasMaxLength(75)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("mail");
            entity.Property(e => e.Persona).HasColumnName("persona");

            entity.HasOne(d => d.AlumnoNavigation).WithMany(p => p.SaiSolicitudTramites)
                .HasForeignKey(d => d.Alumno)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sai_solicitud_tramite_sga_alumnos_fk");

            entity.HasOne(d => d.ConstanciaNavigation).WithMany(p => p.SaiSolicitudTramites)
                .HasForeignKey(d => d.Constancia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sai_solicitud_tramite_sga_constancias_fk");

            entity.HasOne(d => d.CuponPagoNavigation).WithOne(p => p.SaiSolicitudTramite)
                .HasForeignKey<SaiSolicitudTramite>(d => d.CuponPago)
                .HasConstraintName("sai_solicitud_tramite_sai_cupon_pago_fk");

            entity.HasOne(d => d.EstadoNavigation).WithMany(p => p.SaiSolicitudTramites)
                .HasForeignKey(d => d.Estado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sai_solicitud_tramite_sai_tramites_estados_fk");

            entity.HasOne(d => d.PersonaNavigation).WithMany(p => p.SaiSolicitudTramites)
                .HasForeignKey(d => d.Persona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sai_solicitud_tramite_mdp_personas_fk");

            entity.HasMany(d => d.Elementos).WithMany(p => p.Solicituds)
                .UsingEntity<Dictionary<string, object>>(
                    "SaiSolicitudLegalizacionProgramaElemento",
                    r => r.HasOne<SgaElemento>().WithMany()
                        .HasForeignKey("Elemento")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("sai_solicitud_legalizacion_programa_elemento_sga_elementos_fk"),
                    l => l.HasOne<SaiSolicitudTramite>().WithMany()
                        .HasForeignKey("Solicitud")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("sai_solicitud_legalizacion_programa_elemento_sai_solicitud_tram"),
                    j =>
                    {
                        j.HasKey("Solicitud", "Elemento").HasName("pk_sai_solicitud_legalizacion_programa_elemento");
                        j.ToTable("sai_solicitud_legalizacion_programa_elemento", "negocio");
                        j.HasIndex(new[] { "Elemento" }, "IX_sai_solicitud_legalizacion_programa_elemento_elemento");
                        j.IndexerProperty<int>("Solicitud").HasColumnName("solicitud");
                        j.IndexerProperty<int>("Elemento").HasColumnName("elemento");
                    });
        });

        modelBuilder.Entity<SaiSubcommerce>(entity =>
        {
            entity.HasKey(e => e.Subcommerce).HasName("sai_subcommerce_pk");

            entity.ToTable("sai_subcommerce", "negocio");

            entity.Property(e => e.Subcommerce).HasColumnName("subcommerce");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .HasColumnName("descripcion");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .HasColumnName("username");

            entity.HasMany(d => d.ResponsableAcademicas).WithMany(p => p.Subcommerces)
                .UsingEntity<Dictionary<string, object>>(
                    "SaiSubcommerceRa",
                    r => r.HasOne<SgaResponsablesAcademica>().WithMany()
                        .HasForeignKey("ResponsableAcademica")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("fk_sai_subcommerce_ra_sga_responsables_academicas"),
                    l => l.HasOne<SaiSubcommerce>().WithMany()
                        .HasForeignKey("Subcommerce")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("fk_sai_subcommerce_ra_sai_subcommerce"),
                    j =>
                    {
                        j.HasKey("Subcommerce", "ResponsableAcademica").HasName("sai_subcommerce_ra_pk");
                        j.ToTable("sai_subcommerce_ra", "negocio");
                        j.HasIndex(new[] { "ResponsableAcademica" }, "IX_sai_subcommerce_ra_responsable_academica");
                        j.IndexerProperty<int>("Subcommerce").HasColumnName("subcommerce");
                        j.IndexerProperty<int>("ResponsableAcademica").HasColumnName("responsable_academica");
                    });
        });

        modelBuilder.Entity<SaiTramitesAdicionale>(entity =>
        {
            entity.HasKey(e => new { e.Tramite, e.Codigo }).HasName("sai_tramites_adicionales_pk");

            entity.ToTable("sai_tramites_adicionales", "negocio");

            entity.Property(e => e.Tramite).HasColumnName("tramite");
            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .HasColumnName("codigo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .HasColumnName("descripcion");
            entity.Property(e => e.Importe)
                .HasPrecision(10, 2)
                .HasColumnName("importe");

            entity.HasOne(d => d.TramiteNavigation).WithMany(p => p.SaiTramitesAdicionales)
                .HasForeignKey(d => d.Tramite)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_sai_tramites_adicionales_sga_constancias");
        });

        modelBuilder.Entity<SaiTramitesEstado>(entity =>
        {
            entity.HasKey(e => e.Estado).HasName("pk_sai_tramites_estados");

            entity.ToTable("sai_tramites_estados", "negocio");

            entity.Property(e => e.Estado)
                .ValueGeneratedNever()
                .HasColumnName("estado");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<SaiTramitesRaPaga>(entity =>
        {
            entity.HasKey(e => new { e.Tramite, e.ResponsableAcademica }).HasName("sai_tramites_ra_paga_pk");

            entity.ToTable("sai_tramites_ra_paga", "negocio");

            entity.HasIndex(e => e.ResponsableAcademica, "IX_sai_tramites_ra_paga_responsable_academica");

            entity.Property(e => e.Tramite).HasColumnName("tramite");
            entity.Property(e => e.ResponsableAcademica).HasColumnName("responsable_academica");
            entity.Property(e => e.Importe).HasColumnName("importe");
            entity.Property(e => e.Paga).HasColumnName("paga");

            entity.HasOne(d => d.ResponsableAcademicaNavigation).WithMany(p => p.SaiTramitesRaPagas)
                .HasForeignKey(d => d.ResponsableAcademica)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_sai_tramites_ra_paga_sga_responsables_academicas");

            entity.HasOne(d => d.TramiteNavigation).WithMany(p => p.SaiTramitesRaPagas)
                .HasForeignKey(d => d.Tramite)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_sai_tramites_ra_paga_sga_constancias");
        });

        modelBuilder.Entity<SgaAlumno>(entity =>
        {
            entity.HasKey(e => e.Alumno).HasName("pk_sga_alumnos");

            entity.ToTable("sga_alumnos", "negocio");

            entity.HasIndex(e => e.Persona, "ifk_sga_alumnos_mdp_personas");

            entity.HasIndex(e => e.Calidad, "ifk_sga_alumnos_sga_alumnos_calidad");

            entity.HasIndex(e => e.PlanVersion, "ifk_sga_alumnos_sga_planes_versiones");

            entity.HasIndex(e => e.Propuesta, "ifk_sga_alumnos_sga_propuestas");

            entity.HasIndex(e => e.Ubicacion, "ifk_sga_alumnos_sga_ubicaciones");

            entity.HasIndex(e => new { e.Persona, e.Propuesta }, "iu_sga_alumnos_persona_propuesta").IsUnique();

            entity.Property(e => e.Alumno)
                .HasDefaultValueSql("nextval(('negocio.sga_alumnos_seq'::text)::regclass)")
                .HasColumnName("alumno");
            entity.Property(e => e.Calidad)
                .HasMaxLength(1)
                .HasColumnName("calidad");
            entity.Property(e => e.Persona).HasColumnName("persona");
            entity.Property(e => e.PlanVersion).HasColumnName("plan_version");
            entity.Property(e => e.Propuesta).HasColumnName("propuesta");
            entity.Property(e => e.Regular)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::bpchar")
                .HasColumnName("regular");
            entity.Property(e => e.Ubicacion).HasColumnName("ubicacion");

            entity.HasOne(d => d.PersonaNavigation).WithMany(p => p.SgaAlumnos)
                .HasForeignKey(d => d.Persona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sga_alumnos_mdp_personas_fk");

            entity.HasOne(d => d.PlanVersionNavigation).WithMany(p => p.SgaAlumnos)
                .HasForeignKey(d => d.PlanVersion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sga_alumnos_sga_planes_versiones_fk");

            entity.HasOne(d => d.PropuestaNavigation).WithMany(p => p.SgaAlumnos)
                .HasForeignKey(d => d.Propuesta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sga_alumnos_sga_propuestas_fk");
        });

        modelBuilder.Entity<SgaAsignacione>(entity =>
        {
            entity.HasKey(e => e.Asignacion).HasName("pk_sga_asignaciones");

            entity.ToTable("sga_asignaciones", "negocio");

            entity.Property(e => e.Asignacion)
                .ValueGeneratedNever()
                .HasColumnName("asignacion");
            entity.Property(e => e.DiaSemana)
                .HasMaxLength(10)
                .HasColumnName("dia_semana");
            entity.Property(e => e.HoraFinalizacion).HasColumnName("hora_finalizacion");
            entity.Property(e => e.HoraInicio).HasColumnName("hora_inicio");
        });

        modelBuilder.Entity<SgaCertificado>(entity =>
        {
            entity.HasKey(e => e.Certificado).HasName("pk_sga_certificados");

            entity.ToTable("sga_certificados", "negocio");

            entity.Property(e => e.Certificado).HasColumnName("certificado");
            entity.Property(e => e.Codigo)
                .HasMaxLength(25)
                .HasColumnName("codigo");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .HasColumnName("estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreFemenino)
                .HasMaxLength(255)
                .HasColumnName("nombre_femenino");
            entity.Property(e => e.TituloNivel)
                .HasMaxLength(25)
                .HasColumnName("titulo_nivel");
        });

        modelBuilder.Entity<SgaComisione>(entity =>
        {
            entity.HasKey(e => e.Comision).HasName("pk_sga_comisiones");

            entity.ToTable("sga_comisiones", "negocio");

            entity.HasIndex(e => e.Elemento, "IX_sga_comisiones_elemento");

            entity.HasIndex(e => e.Turno, "IX_sga_comisiones_turno");

            entity.HasIndex(e => e.Ubicacion, "IX_sga_comisiones_ubicacion");

            entity.HasIndex(e => e.PeriodoLectivo, "ifk_sga_comisiones_sga_periodos_lectivos");

            entity.Property(e => e.Comision)
                .HasDefaultValueSql("nextval(('sga_comisiones_seq'::text)::regclass)")
                .HasColumnName("comision");
            entity.Property(e => e.Cobrable)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("cobrable");
            entity.Property(e => e.Cupo).HasColumnName("cupo");
            entity.Property(e => e.Elemento).HasColumnName("elemento");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'A'::bpchar")
                .HasColumnName("estado");
            entity.Property(e => e.InscripcionHabilitada)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::bpchar")
                .HasColumnName("inscripcion_habilitada");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(300)
                .HasColumnName("observaciones");
            entity.Property(e => e.PeriodoLectivo).HasColumnName("periodo_lectivo");
            entity.Property(e => e.Turno).HasColumnName("turno");
            entity.Property(e => e.Ubicacion)
                .HasDefaultValue(0)
                .HasColumnName("ubicacion");

            entity.HasOne(d => d.ElementoNavigation).WithMany(p => p.SgaComisiones)
                .HasForeignKey(d => d.Elemento)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_sga_comisiones_sga_elementos");

            entity.HasOne(d => d.PeriodoLectivoNavigation).WithMany(p => p.SgaComisiones)
                .HasForeignKey(d => d.PeriodoLectivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sga_comisiones_sga_periodos_lectivos_fk");

            entity.HasOne(d => d.TurnoNavigation).WithMany(p => p.SgaComisiones)
                .HasForeignKey(d => d.Turno)
                .HasConstraintName("sga_comisiones_sga_turnos_cursadas_fk");

            entity.HasOne(d => d.UbicacionNavigation).WithMany(p => p.SgaComisiones)
                .HasForeignKey(d => d.Ubicacion)
                .HasConstraintName("sga_comisiones_sga_ubicaciones_fk");

            entity.HasMany(d => d.Modalidads).WithMany(p => p.Comisions)
                .UsingEntity<Dictionary<string, object>>(
                    "SgaComisionesModalidad",
                    r => r.HasOne<SgaModalidadCursadum>().WithMany()
                        .HasForeignKey("Modalidad")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("fk_sga_comisiones_modalidad_sga_modalidad_cursada"),
                    l => l.HasOne<SgaComisione>().WithMany()
                        .HasForeignKey("Comision")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("fk_sga_comisiones_modalidad_sga_comisiones"),
                    j =>
                    {
                        j.HasKey("Comision", "Modalidad").HasName("pk_sga_comisiones_modalidad");
                        j.ToTable("sga_comisiones_modalidad", "negocio");
                        j.HasIndex(new[] { "Modalidad" }, "IX_sga_comisiones_modalidad_modalidad");
                        j.IndexerProperty<int>("Comision").HasColumnName("comision");
                        j.IndexerProperty<char>("Modalidad")
                            .HasMaxLength(1)
                            .HasColumnName("modalidad");
                    });
        });

        modelBuilder.Entity<SgaComisionesBh>(entity =>
        {
            entity.HasKey(e => e.BandaHoraria).HasName("pk_sga_comisiones_bh");

            entity.ToTable("sga_comisiones_bh", "negocio");

            entity.HasIndex(e => e.Asignacion, "IX_sga_comisiones_bh_asignacion");

            entity.HasIndex(e => e.Comision, "IX_sga_comisiones_bh_comision");

            entity.Property(e => e.BandaHoraria)
                .ValueGeneratedNever()
                .HasColumnName("banda_horaria");
            entity.Property(e => e.Asignacion).HasColumnName("asignacion");
            entity.Property(e => e.Comision).HasColumnName("comision");

            entity.HasOne(d => d.AsignacionNavigation).WithMany(p => p.SgaComisionesBhs)
                .HasForeignKey(d => d.Asignacion)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_sga_comisiones_bh_sga_asignaciones");

            entity.HasOne(d => d.ComisionNavigation).WithMany(p => p.SgaComisionesBhs)
                .HasForeignKey(d => d.Comision)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_sga_comisiones_bh_sga_comisiones");
        });

        modelBuilder.Entity<SgaComisionesPropuesta>(entity =>
        {
            entity.HasKey(e => new { e.Comision, e.Propuesta, e.Plan }).HasName("pk_sga_comisiones_propuestas");

            entity.ToTable("sga_comisiones_propuestas", "negocio");

            entity.HasIndex(e => e.Comision, "ifk_sga_comisiones_propuestas_sga_comisiones");

            entity.HasIndex(e => e.Plan, "ifk_sga_comisiones_propuestas_sga_planes");

            entity.HasIndex(e => e.Propuesta, "ifk_sga_comisiones_propuestas_sga_propuestas");

            entity.Property(e => e.Comision).HasColumnName("comision");
            entity.Property(e => e.Propuesta).HasColumnName("propuesta");
            entity.Property(e => e.Plan).HasColumnName("plan");

            entity.HasOne(d => d.ComisionNavigation).WithMany(p => p.SgaComisionesPropuesta)
                .HasForeignKey(d => d.Comision)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_sga_comisiones_propuestas_sga_comisiones");

            entity.HasOne(d => d.PlanNavigation).WithMany(p => p.SgaComisionesPropuesta)
                .HasForeignKey(d => d.Plan)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_sga_comisiones_propuestas_sga_planes");

            entity.HasOne(d => d.PropuestaNavigation).WithMany(p => p.SgaComisionesPropuesta)
                .HasForeignKey(d => d.Propuesta)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_sga_comisiones_propuestas_sga_propuestas");
        });

        modelBuilder.Entity<SgaConstancia>(entity =>
        {
            entity.HasKey(e => e.Constancia).HasName("pk_sga_constancias");

            entity.ToTable("sga_constancias", "negocio");

            entity.Property(e => e.Constancia)
                .ValueGeneratedNever()
                .HasColumnName("constancia");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .HasColumnName("descripcion");
            entity.Property(e => e.EstadoInicial).HasColumnName("estado_inicial");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<SgaElemento>(entity =>
        {
            entity.HasKey(e => e.Elemento).HasName("pk_sga_elementos");

            entity.ToTable("sga_elementos", "negocio");

            entity.HasIndex(e => e.Estado, "ifk_sga_elementos_sga_elementos_estados");

            entity.Property(e => e.Elemento)
                .HasDefaultValueSql("nextval(('sga_elementos_seq'::text)::regclass)")
                .HasColumnName("elemento");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("codigo");
            entity.Property(e => e.Compartible)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::bpchar")
                .HasColumnName("compartible");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .HasColumnName("estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreAbreviado)
                .HasMaxLength(50)
                .HasColumnName("nombre_abreviado");

            entity.HasOne(d => d.EstadoNavigation).WithMany(p => p.SgaElementos)
                .HasForeignKey(d => d.Estado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sga_elementos_sga_elementos_estados_fk");
        });

        modelBuilder.Entity<SgaElementosEstado>(entity =>
        {
            entity.HasKey(e => e.Estado).HasName("pk_sga_elementos_estados");

            entity.ToTable("sga_elementos_estados", "negocio");

            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .ValueGeneratedNever()
                .HasColumnName("estado");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<SgaElementosPlan>(entity =>
        {
            entity.HasKey(e => e.ElementoPlan).HasName("pk_sga_elementos_plan");

            entity.ToTable("sga_elementos_plan", "negocio");

            entity.HasIndex(e => e.ElementoRevision, "ifk_sga_elementos_plan_sga_elementos_revision");

            entity.HasIndex(e => e.PlanVersion, "ifk_sga_elementos_plan_sga_planes_versiones");

            entity.HasIndex(e => new { e.PlanVersion, e.ElementoRevision }, "iu_sga_elementos_plan_plan_version_elemento").IsUnique();

            entity.Property(e => e.ElementoPlan)
                .HasDefaultValueSql("nextval(('sga_elementos_plan_seq'::text)::regclass)")
                .HasColumnName("elemento_plan");
            entity.Property(e => e.Cobrable)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("cobrable");
            entity.Property(e => e.ElementoRevision).HasColumnName("elemento_revision");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");
            entity.Property(e => e.PlanVersion).HasColumnName("plan_version");

            entity.HasOne(d => d.ElementoRevisionNavigation).WithMany(p => p.SgaElementosPlans)
                .HasForeignKey(d => d.ElementoRevision)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_sga_elementos_plan_sga_elementos_revision");

            entity.HasOne(d => d.PlanVersionNavigation).WithMany(p => p.SgaElementosPlans)
                .HasForeignKey(d => d.PlanVersion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sga_elementos_plan_sga_planes_versiones_fk");
        });

        modelBuilder.Entity<SgaElementosRevision>(entity =>
        {
            entity.HasKey(e => e.ElementoRevision).HasName("pk_sga_elementos_revision");

            entity.ToTable("sga_elementos_revision", "negocio");

            entity.HasIndex(e => e.Elemento, "ifk_sga_elementos_revision_sga_elementos");

            entity.Property(e => e.ElementoRevision)
                .HasDefaultValueSql("nextval(('sga_elementos_revision_seq'::text)::regclass)")
                .HasColumnName("elemento_revision");
            entity.Property(e => e.Elemento).HasColumnName("elemento");

            entity.HasOne(d => d.ElementoNavigation).WithMany(p => p.SgaElementosRevisions)
                .HasForeignKey(d => d.Elemento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sga_elementos_revision_sga_elementos_fk");
        });

        modelBuilder.Entity<SgaInscCursada>(entity =>
        {
            entity.HasKey(e => e.Inscripcion).HasName("pk_sga_insc_cursada");

            entity.ToTable("sga_insc_cursadas", "negocio");

            entity.HasIndex(e => e.CuponPago, "IX_sga_insc_cursadas_cupon_pago").IsUnique();

            entity.HasIndex(e => e.ComisionAgrupada, "ifk_sga_insc_cursada_sai_comisiones_agrupadas");

            entity.HasIndex(e => e.Alumno, "ifk_sga_insc_cursada_sga_alumnos");

            entity.HasIndex(e => e.Estado, "ifk_sga_insc_cursada_sga_inscripciones_estados");

            entity.HasIndex(e => e.PlanVersion, "ifk_sga_insc_cursada_sga_planes_versiones");

            entity.HasIndex(e => e.NroTransaccion, "iu_sga_insc_cursada_nro_transaccion");

            entity.HasIndex(e => new { e.ComisionAgrupada, e.Alumno }, "iu_sga_insc_cursadas_comision_agrupada_alumno").IsUnique();

            entity.Property(e => e.Inscripcion)
                .HasDefaultValueSql("nextval(('negocio.sga_insc_cursada_seq'::text)::regclass)")
                .HasColumnName("inscripcion");
            entity.Property(e => e.Alumno).HasColumnName("alumno");
            entity.Property(e => e.ComisionAgrupada).HasColumnName("comision_agrupada");
            entity.Property(e => e.CuponPago).HasColumnName("cupon_pago");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .HasColumnName("estado");
            entity.Property(e => e.FechaInscripcion)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_inscripcion");
            entity.Property(e => e.NroTransaccion).HasColumnName("nro_transaccion");
            entity.Property(e => e.PlanVersion).HasColumnName("plan_version");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'I'::bpchar")
                .HasColumnName("tipo");

            entity.HasOne(d => d.AlumnoNavigation).WithMany(p => p.SgaInscCursada)
                .HasForeignKey(d => d.Alumno)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sga_insc_cursadas_sga_alumnos_fk");

            entity.HasOne(d => d.ComisionAgrupadaNavigation).WithMany(p => p.SgaInscCursada)
                .HasForeignKey(d => d.ComisionAgrupada)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sga_insc_cursadas_sai_comisiones_agrupadas_fk");

            entity.HasOne(d => d.CuponPagoNavigation).WithOne(p => p.SgaInscCursada)
                .HasForeignKey<SgaInscCursada>(d => d.CuponPago)
                .HasConstraintName("sga_insc_cursada_sai_cupon_pago_fk");

            entity.HasOne(d => d.EstadoNavigation).WithMany(p => p.SgaInscCursada)
                .HasForeignKey(d => d.Estado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sga_insc_cursadas_sga_inscripciones_estados_fk");

            entity.HasOne(d => d.PlanVersionNavigation).WithMany(p => p.SgaInscCursada)
                .HasForeignKey(d => d.PlanVersion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sga_insc_cursadas_sga_planes_versiones_fk");
        });

        modelBuilder.Entity<SgaInscExaman>(entity =>
        {
            entity.HasKey(e => e.Inscripcion).HasName("pk_sga_insc_examen");

            entity.ToTable("sga_insc_examen", "negocio");

            entity.HasIndex(e => e.CuponPago, "IX_sga_insc_examen_cupon_pago").IsUnique();

            entity.HasIndex(e => e.Alumno, "ifk_sga_insc_examen_sga_alumnos");

            entity.HasIndex(e => e.LlamadoMesa, "ifk_sga_insc_examen_sga_llamados_mesa");

            entity.HasIndex(e => new { e.Alumno, e.LlamadoMesa }, "iu_sga_insc_examen_alumno_llamado_mesa").IsUnique();

            entity.Property(e => e.Inscripcion)
                .HasDefaultValueSql("nextval(('sga_insc_examen_seq'::text)::regclass)")
                .HasColumnName("inscripcion");
            entity.Property(e => e.Alumno).HasColumnName("alumno");
            entity.Property(e => e.Condicion)
                .HasMaxLength(20)
                .HasColumnName("condicion");
            entity.Property(e => e.CuponPago).HasColumnName("cupon_pago");
            entity.Property(e => e.Estado)
                .HasMaxLength(5)
                .HasColumnName("estado");
            entity.Property(e => e.FechaInscripcion)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_inscripcion");
            entity.Property(e => e.LlamadoMesa).HasColumnName("llamado_mesa");
            entity.Property(e => e.Motivo)
                .HasMaxLength(255)
                .HasColumnName("motivo");

            entity.HasOne(d => d.AlumnoNavigation).WithMany(p => p.SgaInscExamen)
                .HasForeignKey(d => d.Alumno)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sga_insc_examen_sga_alumnos_fk");

            entity.HasOne(d => d.CuponPagoNavigation).WithOne(p => p.SgaInscExaman)
                .HasForeignKey<SgaInscExaman>(d => d.CuponPago)
                .HasConstraintName("sga_insc_examen_sai_cupon_pago_fk");

            entity.HasOne(d => d.LlamadoMesaNavigation).WithMany(p => p.SgaInscExamen)
                .HasForeignKey(d => d.LlamadoMesa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sga_insc_examen_sga_llamados_mesa_fk");
        });

        modelBuilder.Entity<SgaInscripcionesEstado>(entity =>
        {
            entity.HasKey(e => e.Estado).HasName("pk_sga_inscripciones_estados");

            entity.ToTable("sga_inscripciones_estados", "negocio");

            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .ValueGeneratedNever()
                .HasColumnName("estado");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<SgaLlamadosMesa>(entity =>
        {
            entity.HasKey(e => e.LlamadoMesa).HasName("pk_sga_llamados_mesa");

            entity.ToTable("sga_llamados_mesa", "negocio");

            entity.HasIndex(e => e.Llamado, "IX_sga_llamados_mesa_llamado");

            entity.HasIndex(e => e.Fecha, "id_sga_llamados_mesa_fecha");

            entity.HasIndex(e => e.MesaExamen, "ifk_sga_llamados_mesa_sga_mesas_examen");

            entity.HasIndex(e => e.MesaExamen, "sga_llamados_mesa_unique").IsUnique();

            entity.Property(e => e.LlamadoMesa)
                .HasDefaultValueSql("nextval(('sga_llamados_mesa_seq'::text)::regclass)")
                .HasColumnName("llamado_mesa");
            entity.Property(e => e.Cupo).HasColumnName("cupo");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'A'::bpchar")
                .HasColumnName("estado");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.HoraFinalizacion).HasColumnName("hora_finalizacion");
            entity.Property(e => e.HoraInicio).HasColumnName("hora_inicio");
            entity.Property(e => e.Instancia)
                .HasColumnType("character varying")
                .HasColumnName("instancia");
            entity.Property(e => e.Llamado).HasColumnName("llamado");
            entity.Property(e => e.MesaExamen).HasColumnName("mesa_examen");
            entity.Property(e => e.Motivo)
                .HasMaxLength(50)
                .HasColumnName("motivo");

            entity.HasOne(d => d.LlamadoNavigation).WithMany(p => p.SgaLlamadosMesas)
                .HasForeignKey(d => d.Llamado)
                .HasConstraintName("sga_llamados_mesa_sga_llamados_turno_fk");

            entity.HasOne(d => d.MesaExamenNavigation).WithOne(p => p.SgaLlamadosMesa)
                .HasForeignKey<SgaLlamadosMesa>(d => d.MesaExamen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sga_llamados_mesa_sga_mesas_examen_fk");
        });

        modelBuilder.Entity<SgaLlamadosTurno>(entity =>
        {
            entity.HasKey(e => e.Llamado).HasName("pk_sga_llamados_turno");

            entity.ToTable("sga_llamados_turno", "negocio");

            entity.HasIndex(e => e.Periodo, "ifk_sga_llamados_turno_sga_periodos");

            entity.Property(e => e.Llamado)
                .HasDefaultValueSql("nextval(('sga_llamados_turno_seq'::text)::regclass)")
                .HasColumnName("llamado");
            entity.Property(e => e.Periodo).HasColumnName("periodo");

            entity.HasOne(d => d.PeriodoNavigation).WithMany(p => p.SgaLlamadosTurnos)
                .HasForeignKey(d => d.Periodo)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_sga_llamados_turno_sga_periodos");
        });

        modelBuilder.Entity<SgaMesasExaman>(entity =>
        {
            entity.HasKey(e => e.MesaExamen).HasName("pk_sga_mesas_examen");

            entity.ToTable("sga_mesas_examen", "negocio");

            entity.HasIndex(e => e.AnioAcademico, "ifk_sga_mesas_examen_sga_anios_academicos");

            entity.HasIndex(e => e.Elemento, "ifk_sga_mesas_examen_sga_elementos");

            entity.HasIndex(e => e.Ubicacion, "ifk_sga_mesas_examen_sga_ubicaciones");

            entity.Property(e => e.MesaExamen)
                .HasDefaultValueSql("nextval(('sga_mesas_examen_seq'::text)::regclass)")
                .HasColumnName("mesa_examen");
            entity.Property(e => e.AnioAcademico).HasColumnName("anio_academico");
            entity.Property(e => e.Condicion)
                .HasMaxLength(30)
                .HasColumnName("condicion");
            entity.Property(e => e.Elemento).HasColumnName("elemento");
            entity.Property(e => e.MesaEnTurnoExamen)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::bpchar")
                .HasColumnName("mesa_en_turno_examen");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");
            entity.Property(e => e.Ubicacion).HasColumnName("ubicacion");

            entity.HasOne(d => d.ElementoNavigation).WithMany(p => p.SgaMesasExamen)
                .HasForeignKey(d => d.Elemento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sga_mesas_examen_sga_elementos_fk");
        });

        modelBuilder.Entity<SgaMesasExamenInstancia>(entity =>
        {
            entity.HasKey(e => new { e.MesaExamen, e.Instancia }).HasName("pk_sga_mesas_examen_instancias");

            entity.ToTable("sga_mesas_examen_instancias", "negocio");

            entity.Property(e => e.MesaExamen).HasColumnName("mesa_examen");
            entity.Property(e => e.Instancia).HasColumnName("instancia");

            entity.HasOne(d => d.MesaExamenNavigation).WithMany(p => p.SgaMesasExamenInstancia)
                .HasForeignKey(d => d.MesaExamen)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_sga_mesas_examen_instancias_sga_mesas_examen");
        });

        modelBuilder.Entity<SgaModalidadCursadum>(entity =>
        {
            entity.HasKey(e => e.Modalidad).HasName("pk_sga_modalidad_cursada");

            entity.ToTable("sga_modalidad_cursada", "negocio");

            entity.Property(e => e.Modalidad)
                .HasMaxLength(1)
                .ValueGeneratedNever()
                .HasColumnName("modalidad");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<SgaPeriodo>(entity =>
        {
            entity.HasKey(e => e.Periodo).HasName("pk_sga_periodos");

            entity.ToTable("sga_periodos", "negocio");

            entity.HasIndex(e => e.TipoPeriodo, "IX_sga_periodos_tipo_periodo");

            entity.HasIndex(e => e.FechaFin, "id_sga_periodos_fecha_fin");

            entity.HasIndex(e => new { e.FechaInicio, e.FechaFin }, "id_sga_periodos_fecha_inicio_fecha_fin");

            entity.HasIndex(e => e.AnioAcademico, "ifk_sga_periodos_sga_anios_academicos");

            entity.Property(e => e.Periodo)
                .HasDefaultValueSql("nextval(('sga_periodos_seq'::text)::regclass)")
                .HasColumnName("periodo");
            entity.Property(e => e.AnioAcademico).HasColumnName("anio_academico");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaFin).HasColumnName("fecha_fin");
            entity.Property(e => e.FechaInicio).HasColumnName("fecha_inicio");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.TipoPeriodo)
                .HasDefaultValue(1)
                .HasColumnName("tipo_periodo");

            entity.HasOne(d => d.TipoPeriodoNavigation).WithMany(p => p.SgaPeriodos)
                .HasForeignKey(d => d.TipoPeriodo)
                .HasConstraintName("sga_periodos_sai_periodos_tipos_fk");
        });

        modelBuilder.Entity<SgaPeriodosLectivo>(entity =>
        {
            entity.HasKey(e => e.PeriodoLectivo).HasName("pk_sga_periodos_lectivos");

            entity.ToTable("sga_periodos_lectivos", "negocio");

            entity.HasIndex(e => e.Periodo, "IX_sga_periodos_lectivos_periodo").IsUnique();

            entity.HasIndex(e => e.Periodo, "ifk_sga_periodos_lectivos_sga_periodos");

            entity.Property(e => e.PeriodoLectivo)
                .HasDefaultValueSql("nextval(('sga_periodos_lectivos_seq'::text)::regclass)")
                .HasColumnName("periodo_lectivo");
            entity.Property(e => e.Periodo).HasColumnName("periodo");

            entity.HasOne(d => d.PeriodoNavigation).WithOne(p => p.SgaPeriodosLectivo)
                .HasForeignKey<SgaPeriodosLectivo>(d => d.Periodo)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_sga_periodos_lectivos_sga_periodos");
        });

        modelBuilder.Entity<SgaPlane>(entity =>
        {
            entity.HasKey(e => e.Plan).HasName("pk_sga_planes");

            entity.ToTable("sga_planes", "negocio");

            entity.HasIndex(e => e.Estado, "ifk_sga_planes_sga_planes_estados");

            entity.HasIndex(e => e.VersionActual, "ifk_sga_planes_sga_planes_versiones");

            entity.HasIndex(e => e.Propuesta, "ifk_sga_planes_sga_propuestas");

            entity.HasIndex(e => new { e.Propuesta, e.Codigo }, "iu_sga_planes_propuesta_codigo");

            entity.HasIndex(e => e.Propuesta, "sga_planes_propuesta_idx");

            entity.Property(e => e.Plan)
                .HasDefaultValueSql("nextval(('sga_planes_seq'::text)::regclass)")
                .HasColumnName("plan");
            entity.Property(e => e.Cobrable)
                .HasDefaultValue(false)
                .HasColumnName("cobrable");
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .HasColumnName("codigo");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("estado");
            entity.Property(e => e.InscripcionHabilitada)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::bpchar")
                .HasColumnName("inscripcion_habilitada");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Propuesta).HasColumnName("propuesta");
            entity.Property(e => e.TipoPlan)
                .HasMaxLength(15)
                .HasDefaultValueSql("'Estructurado'::character varying")
                .HasColumnName("tipo_plan");
            entity.Property(e => e.VersionActual).HasColumnName("version_actual");

            entity.HasOne(d => d.EstadoNavigation).WithMany(p => p.SgaPlanes)
                .HasForeignKey(d => d.Estado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sga_planes_sga_planes_estados_fk");

            entity.HasOne(d => d.PropuestaNavigation).WithMany(p => p.SgaPlanes)
                .HasForeignKey(d => d.Propuesta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sga_planes_sga_propuestas_fk");
        });

        modelBuilder.Entity<SgaPlanesEstado>(entity =>
        {
            entity.HasKey(e => e.Estado).HasName("pk_sga_planes_estados");

            entity.ToTable("sga_planes_estados", "negocio");

            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .ValueGeneratedNever()
                .HasColumnName("estado");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<SgaPlanesVersione>(entity =>
        {
            entity.HasKey(e => e.PlanVersion).HasName("pk_sga_planes_versiones");

            entity.ToTable("sga_planes_versiones", "negocio");

            entity.HasIndex(e => e.Plan, "ifk_sga_planes_versiones_sga_planes");

            entity.HasIndex(e => e.Estado, "ifk_sga_planes_versiones_sga_planes_estados");

            entity.HasIndex(e => new { e.Plan, e.Version }, "iu_sga_planes_versiones_plan_version").IsUnique();

            entity.Property(e => e.PlanVersion)
                .HasDefaultValueSql("nextval(('sga_planes_versiones_seq'::text)::regclass)")
                .HasColumnName("plan_version");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Plan).HasColumnName("plan");
            entity.Property(e => e.Version)
                .HasMaxLength(10)
                .HasColumnName("version");

            entity.HasOne(d => d.PlanNavigation).WithMany(p => p.SgaPlanesVersiones)
                .HasForeignKey(d => d.Plan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sga_planes_versiones_sga_planes_fk");
        });

        modelBuilder.Entity<SgaPropuesta>(entity =>
        {
            entity.HasKey(e => e.Propuesta).HasName("pk_sga_propuestas");

            entity.ToTable("sga_propuestas", "negocio");

            entity.HasIndex(e => e.PropuestaTipo, "IX_sga_propuestas_propuesta_tipo");

            entity.Property(e => e.Propuesta)
                .HasDefaultValueSql("nextval(('sga_propuestas_seq'::text)::regclass)")
                .HasColumnName("propuesta");
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .HasColumnName("codigo");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .HasColumnName("estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreAbreviado)
                .HasMaxLength(50)
                .HasColumnName("nombre_abreviado");
            entity.Property(e => e.PropuestaTipo).HasColumnName("propuesta_tipo");
            entity.Property(e => e.Publica)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::bpchar")
                .HasColumnName("publica");

            entity.HasOne(d => d.PropuestaTipoNavigation).WithMany(p => p.SgaPropuesta)
                .HasForeignKey(d => d.PropuestaTipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sga_propuestas_sga_propuestas_tipos_fk");

            entity.HasMany(d => d.ResponsableAcademicas).WithMany(p => p.Propuesta)
                .UsingEntity<Dictionary<string, object>>(
                    "SgaPropuestasRa",
                    r => r.HasOne<SgaResponsablesAcademica>().WithMany()
                        .HasForeignKey("ResponsableAcademica")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("sga_propuestas_ra_sga_responsables_academicas_fk"),
                    l => l.HasOne<SgaPropuesta>().WithMany()
                        .HasForeignKey("Propuesta")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("sga_propuestas_ra_sga_propuestas_fk"),
                    j =>
                    {
                        j.HasKey("Propuesta", "ResponsableAcademica").HasName("pk_sga_propuestas_ra");
                        j.ToTable("sga_propuestas_ra", "negocio");
                        j.HasIndex(new[] { "Propuesta" }, "ifk_sga_propuestas_ra_sga_propuestas");
                        j.HasIndex(new[] { "ResponsableAcademica" }, "ifk_sga_propuestas_ra_sga_responsables_academicas");
                        j.IndexerProperty<int>("Propuesta").HasColumnName("propuesta");
                        j.IndexerProperty<int>("ResponsableAcademica").HasColumnName("responsable_academica");
                    });
        });

        modelBuilder.Entity<SgaPropuestasTipo>(entity =>
        {
            entity.HasKey(e => e.PropuestaTipo).HasName("sga_propuestas_tipos_pk");

            entity.ToTable("sga_propuestas_tipos", "negocio");

            entity.Property(e => e.PropuestaTipo)
                .ValueGeneratedNever()
                .HasColumnName("propuesta_tipo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<SgaResponsablesAcademica>(entity =>
        {
            entity.HasKey(e => e.ResponsableAcademica).HasName("pk_sga_responsables_academicas");

            entity.ToTable("sga_responsables_academicas", "negocio");

            entity.Property(e => e.ResponsableAcademica)
                .HasDefaultValueSql("nextval(('sga_responsables_academicas_seq'::text)::regclass)")
                .HasColumnName("responsable_academica");
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .HasColumnName("codigo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreAbreviado)
                .HasMaxLength(50)
                .HasColumnName("nombre_abreviado");
        });

        modelBuilder.Entity<SgaTurnosCursada>(entity =>
        {
            entity.HasKey(e => e.Turno).HasName("pk_sga_turnos_cursadas");

            entity.ToTable("sga_turnos_cursadas", "negocio");

            entity.Property(e => e.Turno)
                .HasDefaultValueSql("nextval(('sga_turnos_cursadas_seq'::text)::regclass)")
                .HasColumnName("turno");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<SgaUbicacione>(entity =>
        {
            entity.HasKey(e => e.Ubicacion).HasName("pk_sga_ubicaciones");

            entity.ToTable("sga_ubicaciones", "negocio");

            entity.HasIndex(e => e.UbicacionTipo, "ifk_sga_ubicaciones_sga_ubicaciones_tipos");

            entity.Property(e => e.Ubicacion)
                .HasDefaultValueSql("nextval(('sga_ubicaciones_seq'::text)::regclass)")
                .HasColumnName("ubicacion");
            entity.Property(e => e.Calle)
                .HasMaxLength(100)
                .HasColumnName("calle");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(15)
                .HasColumnName("codigo_postal");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .HasColumnName("fax");
            entity.Property(e => e.Latitud)
                .HasPrecision(9, 6)
                .HasColumnName("latitud");
            entity.Property(e => e.Localidad).HasColumnName("localidad");
            entity.Property(e => e.Longitud)
                .HasPrecision(9, 6)
                .HasColumnName("longitud");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Numero)
                .HasMaxLength(20)
                .HasColumnName("numero");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .HasColumnName("telefono");
            entity.Property(e => e.UbicacionTipo).HasColumnName("ubicacion_tipo");

            entity.HasOne(d => d.UbicacionTipoNavigation).WithMany(p => p.SgaUbicaciones)
                .HasForeignKey(d => d.UbicacionTipo)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_sga_ubicaciones_sga_ubicaciones_tipos");
        });

        modelBuilder.Entity<SgaUbicacionesTipo>(entity =>
        {
            entity.HasKey(e => e.UbicacionTipo).HasName("pk_sga_ubicaciones_tipos");

            entity.ToTable("sga_ubicaciones_tipos", "negocio");

            entity.Property(e => e.UbicacionTipo)
                .HasDefaultValueSql("nextval(('sga_ubicaciones_tipos_seq'::text)::regclass)")
                .HasColumnName("ubicacion_tipo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<U817SgaComisione>(entity =>
        {
            entity.HasKey(e => e.ComisionPk).HasName("u817_sga_comisiones_pkey");

            entity.ToTable("u817_sga_comisiones", "negocio");

            entity.HasIndex(e => e.ComisionSuperposicion, "IX_u817_sga_comisiones_comision_superposicion");

            entity.HasIndex(e => e.ComisionFk, "uk_u817_sga_comisiones").IsUnique();

            entity.Property(e => e.ComisionPk)
                .ValueGeneratedNever()
                .HasColumnName("comision_pk");
            entity.Property(e => e.ComisionFk).HasColumnName("comision_fk");
            entity.Property(e => e.ComisionSuperposicion).HasColumnName("comision_superposicion");
            entity.Property(e => e.Modalidad).HasColumnName("modalidad");

            entity.HasOne(d => d.ComisionFkNavigation).WithOne(p => p.U817SgaComisioneComisionFkNavigation)
                .HasForeignKey<U817SgaComisione>(d => d.ComisionFk)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_u817_sga_comisiones_sga_comisiones");

            entity.HasOne(d => d.ComisionSuperposicionNavigation).WithMany(p => p.U817SgaComisioneComisionSuperposicionNavigations)
                .HasForeignKey(d => d.ComisionSuperposicion)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_u817_sga_comisiones_sga_comisiones_superposicion");
        });

        modelBuilder.Entity<U817TramiteSolicitud>(entity =>
        {
            entity.HasKey(e => e.NroTransaccion).HasName("pk_u817_tramite_solicitud");

            entity.ToTable("u817_tramite_solicitud", "negocio");

            entity.HasIndex(e => e.Alumno, "IX_u817_tramite_solicitud_alumno");

            entity.HasIndex(e => e.Circuito, "IX_u817_tramite_solicitud_circuito");

            entity.Property(e => e.NroTransaccion)
                .ValueGeneratedNever()
                .HasColumnName("nro_transaccion");
            entity.Property(e => e.Alumno).HasColumnName("alumno");
            entity.Property(e => e.Circuito).HasColumnName("circuito");
            entity.Property(e => e.CodigoVerificacion)
                .HasMaxLength(20)
                .HasColumnName("codigo_verificacion");
            entity.Property(e => e.EntregadoPor).HasColumnName("entregado_por");
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.FechaEntrega)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_entrega");
            entity.Property(e => e.FechaFinVigencia).HasColumnName("fecha_fin_vigencia");
            entity.Property(e => e.FechaProceso)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_proceso");
            entity.Property(e => e.FechaSolicitud)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_solicitud");
            entity.Property(e => e.Interfaz)
                .HasDefaultValue((short)1)
                .HasColumnName("interfaz");
            entity.Property(e => e.Observaciones).HasColumnName("observaciones");
            entity.Property(e => e.ObservacionesInternas)
                .HasMaxLength(200)
                .HasColumnName("observaciones_internas");
            entity.Property(e => e.PresentarA)
                .HasMaxLength(200)
                .HasColumnName("presentar_a");
            entity.Property(e => e.ProcesadoPor).HasColumnName("procesado_por");
            entity.Property(e => e.Solicitud).HasColumnName("solicitud");

            entity.HasOne(d => d.AlumnoNavigation).WithMany(p => p.U817TramiteSolicituds)
                .HasForeignKey(d => d.Alumno)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("u817_tramite_solicitud_sga_alumnos_fk");

            entity.HasOne(d => d.CircuitoNavigation).WithMany(p => p.U817TramiteSolicituds)
                .HasForeignKey(d => d.Circuito)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("u817_tramite_solicitud_mce_circuitos_fk");

            entity.HasOne(d => d.NroTransaccionNavigation).WithOne(p => p.U817TramiteSolicitud)
                .HasForeignKey<U817TramiteSolicitud>(d => d.NroTransaccion)
                .HasConstraintName("u817_tramite_solicitud_sai_solicitud_tramite_fk");
        });

        modelBuilder.Entity<U817TramiteSolicitudDetalle>(entity =>
        {
            entity.HasKey(e => e.NroTransaccion).HasName("pk_tramite_solicitud_detalle");

            entity.ToTable("u817_tramite_solicitud_detalle", "negocio");

            entity.HasIndex(e => e.Certificado, "IX_u817_tramite_solicitud_detalle_certificado");

            entity.HasIndex(e => e.Plan, "IX_u817_tramite_solicitud_detalle_plan");

            entity.Property(e => e.NroTransaccion)
                .ValueGeneratedNever()
                .HasColumnName("nro_transaccion");
            entity.Property(e => e.Acta).HasColumnName("acta");
            entity.Property(e => e.Certificado).HasColumnName("certificado");
            entity.Property(e => e.CertificadoAnaliticoParcial)
                .HasDefaultValue(0)
                .HasColumnName("certificado_analitico_parcial");
            entity.Property(e => e.CertificadoBajaUniversidad)
                .HasDefaultValue(0)
                .HasColumnName("certificado_baja_universidad");
            entity.Property(e => e.CertificadoMateriasAprobadas)
                .HasDefaultValue(0)
                .HasColumnName("certificado_materias_aprobadas");
            entity.Property(e => e.CertificadoNoSancion)
                .HasDefaultValue(0)
                .HasColumnName("certificado_no_sancion");
            entity.Property(e => e.CertificadoPlanEstudios)
                .HasDefaultValue(0)
                .HasColumnName("certificado_plan_estudios");
            entity.Property(e => e.Colacion).HasColumnName("colacion");
            entity.Property(e => e.Diploma)
                .HasMaxLength(50)
                .HasColumnName("diploma");
            entity.Property(e => e.ElementoPlanOrientacion).HasColumnName("elemento_plan_orientacion");
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .HasColumnName("email");
            entity.Property(e => e.FojasAnaliticoParcial).HasColumnName("fojas_analitico_parcial");
            entity.Property(e => e.FojasCertificadoMateriasAprobadas).HasColumnName("fojas_certificado_materias_aprobadas");
            entity.Property(e => e.FojasMaterias).HasColumnName("fojas_materias");
            entity.Property(e => e.FojasPlanEstudio).HasColumnName("fojas_plan_estudio");
            entity.Property(e => e.HomologacionLibroTomoFolio)
                .HasMaxLength(200)
                .HasColumnName("homologacion_libro_tomo_folio");
            entity.Property(e => e.HomologacionMateriasAprobadas)
                .HasMaxLength(200)
                .HasColumnName("homologacion_materias_aprobadas");
            entity.Property(e => e.HomologacionMateriasOtorgadas)
                .HasMaxLength(200)
                .HasColumnName("homologacion_materias_otorgadas");
            entity.Property(e => e.Nota).HasColumnName("nota");
            entity.Property(e => e.Plan).HasColumnName("plan");
            entity.Property(e => e.Porcentaje).HasColumnName("porcentaje");
            entity.Property(e => e.Promedio).HasColumnName("promedio");
            entity.Property(e => e.Solicitud).HasColumnName("solicitud");
            entity.Property(e => e.TotalFojas)
                .HasDefaultValue(0)
                .HasColumnName("total_fojas");

            entity.HasOne(d => d.CertificadoNavigation).WithMany(p => p.U817TramiteSolicitudDetalles)
                .HasForeignKey(d => d.Certificado)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("u817_tramite_solicitud_detalle_sga_certificados_fk");

            entity.HasOne(d => d.NroTransaccionNavigation).WithOne(p => p.U817TramiteSolicitudDetalle)
                .HasForeignKey<U817TramiteSolicitudDetalle>(d => d.NroTransaccion)
                .HasConstraintName("tramite_solicitud_detalle_solicitud_fk");

            entity.HasOne(d => d.PlanNavigation).WithMany(p => p.U817TramiteSolicitudDetalles)
                .HasForeignKey(d => d.Plan)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("u817_tramite_solicitud_detalle_sga_planes_fk");
        });
        modelBuilder.HasSequence("mbe_intentos_seq", "negocio");
        modelBuilder.HasSequence("mbe_solicitudes_seq", "negocio");
        modelBuilder.HasSequence("mce_acciones_seq", "negocio");
        modelBuilder.HasSequence("mce_caminos_seq", "negocio");
        modelBuilder.HasSequence("mce_circuitos_seq", "negocio");
        modelBuilder.HasSequence("mce_estados_seq", "negocio");
        modelBuilder.HasSequence("mce_formularios_seq", "negocio");
        modelBuilder.HasSequence("mce_plantillas_seq", "negocio");
        modelBuilder.HasSequence("mdp_datos_estudios_seq", "negocio");
        modelBuilder.HasSequence("mdp_personas_contactos_seq", "negocio");
        modelBuilder.HasSequence("mdp_personas_documentos_seq", "negocio");
        modelBuilder.HasSequence("mdp_personas_foto_seq", "negocio");
        modelBuilder.HasSequence("mdp_personas_seq", "negocio");
        modelBuilder.HasSequence("sai_condiciones_seq", "negocio");
        modelBuilder.HasSequence<int>("seq_sai_comision_agrupada", "negocio");
        modelBuilder.HasSequence<int>("seq_sai_cota_responsable", "negocio");
        modelBuilder.HasSequence("sga_actas_seq", "negocio");
        modelBuilder.HasSequence("sga_actas_tipos_seq", "negocio");
        modelBuilder.HasSequence("sga_alumnos_seq", "negocio");
        modelBuilder.HasSequence("sga_certificados_seq", "negocio");
        modelBuilder.HasSequence("sga_certificados_tipos_seq", "negocio");
        modelBuilder.HasSequence("sga_comisiones_seq", "negocio");
        modelBuilder.HasSequence("sga_constancias_seq", "negocio");
        modelBuilder.HasSequence("sga_constancias_solicitud_seq", "negocio");
        modelBuilder.HasSequence("sga_elementos_plan_seq", "negocio");
        modelBuilder.HasSequence("sga_elementos_seq", "negocio");
        modelBuilder.HasSequence("sga_espacios_asignacion_seq", "negocio");
        modelBuilder.HasSequence("sga_espacios_seq", "negocio");
        modelBuilder.HasSequence("sga_espacios_tipos_seq", "negocio");
        modelBuilder.HasSequence("sga_insc_cursada_seq", "negocio");
        modelBuilder.HasSequence("sga_insc_examen_seq", "negocio");
        modelBuilder.HasSequence("sga_instituciones_seq", "negocio");
        modelBuilder.HasSequence("sga_instituciones_tipos_seq", "negocio");
        modelBuilder.HasSequence("sga_libros_actas_seq", "negocio");
        modelBuilder.HasSequence("sga_llamados_mesa_seq", "negocio");
        modelBuilder.HasSequence("sga_llamados_turno_seq", "negocio");
        modelBuilder.HasSequence("sga_mesas_examen_seq", "negocio");
        modelBuilder.HasSequence("sga_perdida_regularidad_causas_seq", "negocio");
        modelBuilder.HasSequence("sga_perdida_regularidad_seq", "negocio");
        modelBuilder.HasSequence("sga_periodos_genericos_seq", "negocio");
        modelBuilder.HasSequence("sga_periodos_inscripcion_aplanado_seq", "negocio");
        modelBuilder.HasSequence("sga_periodos_inscripcion_coeficiente_seq", "negocio");
        modelBuilder.HasSequence("sga_periodos_inscripcion_fechas_seq", "negocio");
        modelBuilder.HasSequence("sga_periodos_inscripcion_seq", "negocio");
        modelBuilder.HasSequence("sga_periodos_lectivos_seq", "negocio");
        modelBuilder.HasSequence("sga_periodos_lectivos_tramos_seq", "negocio");
        modelBuilder.HasSequence("sga_periodos_lectivos_turnos_seq", "negocio");
        modelBuilder.HasSequence("sga_periodos_seq", "negocio");
        modelBuilder.HasSequence("sga_planes_seq", "negocio");
        modelBuilder.HasSequence("sga_planes_versiones_seq", "negocio");
        modelBuilder.HasSequence("sga_propuestas_ext_seq", "negocio");
        modelBuilder.HasSequence("sga_propuestas_grupos_seq", "negocio");
        modelBuilder.HasSequence("sga_propuestas_relacion_grupo_seq", "negocio");
        modelBuilder.HasSequence("sga_propuestas_relacion_plan_seq", "negocio");
        modelBuilder.HasSequence("sga_propuestas_relacion_seq", "negocio");
        modelBuilder.HasSequence("sga_propuestas_seq", "negocio");
        modelBuilder.HasSequence("sga_readmisiones_seq", "negocio");
        modelBuilder.HasSequence("sga_readmisiones_solicitud_seq", "negocio");
        modelBuilder.HasSequence("sga_readmisiones_vencimiento_seq", "negocio");
        modelBuilder.HasSequence("sga_regularidades_venc_seq", "negocio");
        modelBuilder.HasSequence("sga_reinscripciones_seq", "negocio");
        modelBuilder.HasSequence("sga_responsables_academicas_seq", "negocio");
        modelBuilder.HasSequence("sga_responsables_academicas_tipos_seq", "negocio");
        modelBuilder.HasSequence("sga_sanciones_seq", "negocio");
        modelBuilder.HasSequence("sga_sanciones_tipos_seq", "negocio");
        modelBuilder.HasSequence("sga_tipos_ingreso_seq", "negocio");
        modelBuilder.HasSequence("sga_turnos_cursadas_seq", "negocio");
        modelBuilder.HasSequence("sga_turnos_examen_seq", "negocio");
        modelBuilder.HasSequence("sga_turnos_examen_tipos_seq", "negocio");
        modelBuilder.HasSequence("sga_ubicaciones_seq", "negocio");
        modelBuilder.HasSequence("sga_ubicaciones_tipos_seq", "negocio");
        modelBuilder.HasSequence("sga_unidades_gestion_seq", "negocio");
        modelBuilder.HasSequence("sga_usuarios_recordatorios_seq", "negocio");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
