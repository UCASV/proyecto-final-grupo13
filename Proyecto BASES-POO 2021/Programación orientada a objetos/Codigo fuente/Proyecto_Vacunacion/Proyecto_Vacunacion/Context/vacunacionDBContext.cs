using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Proyecto_Vacunacion
{
    public partial class vacunacionDBContext : DbContext
    {
        public vacunacionDBContext()
        {
        }

        public vacunacionDBContext(DbContextOptions<vacunacionDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cabina> Cabinas { get; set; }
        public virtual DbSet<Citum> Cita { get; set; }
        public virtual DbSet<Ciudadano> Ciudadanos { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Enfermedade> Enfermedades { get; set; }
        public virtual DbSet<Enfermedadesxciudadano> Enfermedadesxciudadanos { get; set; }
        public virtual DbSet<Institucion> Institucions { get; set; }
        public virtual DbSet<ProcesoVacunacion> ProcesoVacunacions { get; set; }
        public virtual DbSet<RegistroEmpleado> RegistroEmpleados { get; set; }
        public virtual DbSet<Sintoma> Sintomas { get; set; }
        public virtual DbSet<Sintomasxciudadano> Sintomasxciudadanos { get; set; }
        public virtual DbSet<TipoEmpleado> TipoEmpleados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=vacunacionDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Cabina>(entity =>
            {
                entity.HasKey(e => e.IdCabina)
                    .HasName("PK__CABINA__FAD33CFDC5C8D168");

                entity.ToTable("CABINA");

                entity.HasIndex(e => e.Telefono, "UQ__CABINA__2A16D945BE9FF68D")
                    .IsUnique();

                entity.Property(e => e.IdCabina).HasColumnName("id_cabina");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.IdEmpleado).HasColumnName("id_empleado");

                entity.Property(e => e.Telefono).HasColumnName("telefono");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.Cabinas)
                    .HasForeignKey(d => d.IdEmpleado)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__CABINA__id_emple__3D5E1FD2");
            });

            modelBuilder.Entity<Citum>(entity =>
            {
                entity.HasKey(e => e.IdCita)
                    .HasName("PK__CITA__6AEC3C09E1C950D9");

                entity.ToTable("CITA");

                entity.Property(e => e.IdCita).HasColumnName("id_cita");

                entity.Property(e => e.DuiCiudadano).HasColumnName("dui_ciudadano");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.IdEmpleado).HasColumnName("id_empleado");

                entity.Property(e => e.TipoVacuna).HasColumnName("tipo_vacuna");

                entity.HasOne(d => d.DuiCiudadanoNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.DuiCiudadano)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__CITA__dui_ciudad__412EB0B6");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.IdEmpleado)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__CITA__id_emplead__403A8C7D");
            });

            modelBuilder.Entity<Ciudadano>(entity =>
            {
                entity.HasKey(e => e.Dui)
                    .HasName("PK__CIUDADAN__D876F1BEA3BFC9E6");

                entity.ToTable("CIUDADANO");

                entity.HasIndex(e => e.Telefono, "UQ__CIUDADAN__2A16D9451CDD53BE")
                    .IsUnique();

                entity.Property(e => e.Dui)
                    .ValueGeneratedNever()
                    .HasColumnName("dui");

                entity.Property(e => e.CorreoElectronico)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("correo_electronico");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Edad).HasColumnName("edad");

                entity.Property(e => e.IdInstitucion).HasColumnName("id_institucion");

                entity.Property(e => e.Telefono).HasColumnName("telefono");

                entity.HasOne(d => d.IdInstitucionNavigation)
                    .WithMany(p => p.Ciudadanos)
                    .HasForeignKey(d => d.IdInstitucion)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__CIUDADANO__id_in__3F466844");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado)
                    .HasName("PK__EMPLEADO__88B5139460F61BB8");

                entity.ToTable("EMPLEADO");

                entity.Property(e => e.IdEmpleado).HasColumnName("id_empleado");

                entity.Property(e => e.Contrasenia)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("contrasenia");

                entity.Property(e => e.CorreoInstitucional)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("correo_institucional");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.IdTipoEmpleado).HasColumnName("id_tipo_empleado");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.IdTipoEmpleadoNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.IdTipoEmpleado)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__EMPLEADO__id_tip__3B75D760");
            });

            modelBuilder.Entity<Enfermedade>(entity =>
            {
                entity.HasKey(e => e.IdEnfermedades)
                    .HasName("PK__ENFERMED__715AAA6BA71D5383");

                entity.ToTable("ENFERMEDADES");

                entity.Property(e => e.IdEnfermedades).HasColumnName("id_enfermedades");

                entity.Property(e => e.EnfermedadesCronicas)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("enfermedades_cronicas");
            });

            modelBuilder.Entity<Enfermedadesxciudadano>(entity =>
            {
                entity.HasKey(e => new { e.IdEnfermedades, e.DuiCiudadano })
                    .HasName("pk_ENFERMEDADESXCIUDADANO");

                entity.ToTable("ENFERMEDADESXCIUDADANO");

                entity.Property(e => e.IdEnfermedades).HasColumnName("id_enfermedades");

                entity.Property(e => e.DuiCiudadano).HasColumnName("dui_ciudadano");

                entity.HasOne(d => d.DuiCiudadanoNavigation)
                    .WithMany(p => p.Enfermedadesxciudadanos)
                    .HasForeignKey(d => d.DuiCiudadano)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ENFERMEDA__dui_c__440B1D61");

                entity.HasOne(d => d.IdEnfermedadesNavigation)
                    .WithMany(p => p.Enfermedadesxciudadanos)
                    .HasForeignKey(d => d.IdEnfermedades)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ENFERMEDA__id_en__44FF419A");
            });

            modelBuilder.Entity<Institucion>(entity =>
            {
                entity.HasKey(e => e.IdInstitucion)
                    .HasName("PK__INSTITUC__680718D3BEAA5F33");

                entity.ToTable("INSTITUCION");

                entity.Property(e => e.IdInstitucion).HasColumnName("id_institucion");

                entity.Property(e => e.Institucion1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("institucion");
            });

            modelBuilder.Entity<ProcesoVacunacion>(entity =>
            {
                entity.HasKey(e => e.IdProceso)
                    .HasName("PK__PROCESO___4D1766E4908B70E5");

                entity.ToTable("PROCESO_VACUNACION");

                entity.Property(e => e.IdProceso).HasColumnName("id_proceso");

                entity.Property(e => e.DuiCiudadano).HasColumnName("dui_ciudadano");

                entity.Property(e => e.FechaHora)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_hora");

                entity.Property(e => e.IdEmpleado).HasColumnName("id_empleado");

                entity.HasOne(d => d.DuiCiudadanoNavigation)
                    .WithMany(p => p.ProcesoVacunacions)
                    .HasForeignKey(d => d.DuiCiudadano)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__PROCESO_V__dui_c__4316F928");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.ProcesoVacunacions)
                    .HasForeignKey(d => d.IdEmpleado)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__PROCESO_V__id_em__4222D4EF");
            });

            modelBuilder.Entity<RegistroEmpleado>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PK__REGISTRO__48155C1F29865DCD");

                entity.ToTable("REGISTRO_EMPLEADO");

                entity.Property(e => e.IdRegistro).HasColumnName("id_registro");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.IdCabina).HasColumnName("id_cabina");

                entity.Property(e => e.IdEmpleado).HasColumnName("id_empleado");

                entity.HasOne(d => d.IdCabinaNavigation)
                    .WithMany(p => p.RegistroEmpleados)
                    .HasForeignKey(d => d.IdCabina)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__REGISTRO___id_ca__3E52440B");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.RegistroEmpleados)
                    .HasForeignKey(d => d.IdEmpleado)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__REGISTRO___id_em__3C69FB99");
            });

            modelBuilder.Entity<Sintoma>(entity =>
            {
                entity.HasKey(e => e.IdSintoma)
                    .HasName("PK__SINTOMAS__F76CD03833AC4360");

                entity.ToTable("SINTOMAS");

                entity.Property(e => e.IdSintoma).HasColumnName("id_sintoma");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Sintoma1)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("sintoma");
            });

            modelBuilder.Entity<Sintomasxciudadano>(entity =>
            {
                entity.HasKey(e => new { e.IdSintoma, e.DuiCiudadano })
                    .HasName("pk_SINTOMASXCIUDADANO");

                entity.ToTable("SINTOMASXCIUDADANO");

                entity.Property(e => e.IdSintoma).HasColumnName("id_sintoma");

                entity.Property(e => e.DuiCiudadano).HasColumnName("dui_ciudadano");

                entity.HasOne(d => d.DuiCiudadanoNavigation)
                    .WithMany(p => p.Sintomasxciudadanos)
                    .HasForeignKey(d => d.DuiCiudadano)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SINTOMASX__dui_c__45F365D3");

                entity.HasOne(d => d.IdSintomaNavigation)
                    .WithMany(p => p.Sintomasxciudadanos)
                    .HasForeignKey(d => d.IdSintoma)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SINTOMASX__id_si__46E78A0C");
            });

            modelBuilder.Entity<TipoEmpleado>(entity =>
            {
                entity.HasKey(e => e.IdTipoEmpleado)
                    .HasName("PK__TIPO_EMP__F614CD33A31D1A29");

                entity.ToTable("TIPO_EMPLEADO");

                entity.Property(e => e.IdTipoEmpleado).HasColumnName("id_tipo_empleado");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("tipo");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
