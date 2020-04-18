using ITDeveloper.Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITDeveloper.Data.Mapings {
    public class PatientMap : IEntityTypeConfiguration<Patient> {
        public void Configure(EntityTypeBuilder<Patient> builder) {
            builder.ToTable("TBL_PATIENT");
            builder.HasKey(pk => pk.Id);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasColumnType("varchar(80)")
                .HasColumnName("Name");

            builder.Property(p => p.Email)
                .IsRequired()
                .HasColumnType("varchar(150)")
                .HasColumnName("Email");

            builder.Property(p => p.Cpf)
                .IsRequired()
                .HasColumnType("varchar(11)")
                .HasColumnName("Cpf")
                .HasMaxLength(11)
                .IsFixedLength(true);

            builder.Property(p => p.Rg)
                .HasColumnType("varchar(15)")
                .HasColumnName("RG")
                .HasMaxLength(15);

            builder.Property(p => p.RgEmitterOrgan)
                .HasColumnType("varchar(10)")
                .HasColumnName("RgEmitterOrgan");

            builder.HasOne(p => p.State)
                .WithMany(s => s.Patients)
                .HasForeignKey(p => p.StateId)
                .HasPrincipalKey(p => p.Id);
        }
    }
}