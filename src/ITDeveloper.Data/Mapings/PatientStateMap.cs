using ITDeveloper.Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITDeveloper.Data.Mapings {
    public class PatientStateMap : IEntityTypeConfiguration<PatientState> {
        public void Configure(EntityTypeBuilder<PatientState> builder) {
            builder.ToTable("TBL_PATIENT_STATE");

            builder.HasKey(pk => pk.Id);
            builder.Property(p => p.Description)
                .HasColumnType("varchar(30)")
                .HasColumnName("Description");

            builder.HasMany(s => s.Patients);
        }
    }
}