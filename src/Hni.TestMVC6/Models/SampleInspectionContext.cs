using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Hni.TestMVC6.Models
{
    public partial class SampleInspectionContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auditor>(entity =>
            {
                entity.HasIndex(e => e.AuditorName).HasName("UX_AuditorName").IsUnique();

                entity.Property(e => e.AuditorName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnType("varchar");
            });

            modelBuilder.Entity<InspectionType>(entity =>
            {
                entity.HasIndex(e => e.InspectionTypeDesc).HasName("UX_InspectionTypeDesc").IsUnique();

                entity.Property(e => e.InspectionTypeDesc)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnType("varchar");
            });

            modelBuilder.Entity<Part>(entity =>
            {
                entity.HasIndex(e => e.PartCategoryId).HasName("IX_Part_PartCategoryId");

                entity.HasIndex(e => new { e.PartNumber, e.PartCategoryId }).HasName("UX_PartNumberCatergoryId").IsUnique();

                entity.Property(e => e.PartNumber)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnType("varchar");

                entity.HasOne(d => d.PartCategory).WithMany(p => p.Part).HasForeignKey(d => d.PartCategoryId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<PartCategory>(entity =>
            {
                entity.HasIndex(e => e.PartCategoryDesc).HasName("UX_PartCategoryDesc").IsUnique();

                entity.Property(e => e.PartCategoryDesc)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnType("varchar");
            });

            modelBuilder.Entity<PartReceived>(entity =>
            {
                entity.HasIndex(e => e.AuditorId).HasName("IX_PartReceived_Auditor");

                entity.HasIndex(e => e.InspectionTypeId).HasName("IX_PartReceived_InspectionType");

                entity.HasIndex(e => e.PartId).HasName("IX_PartReceived_Part");

                entity.HasIndex(e => e.SerialNumber).HasName("IX_PartReceived_SerialNumber");

                entity.HasIndex(e => e.VendorId).HasName("IX_PartReceived_Vendor");

                entity.HasIndex(e => e.WhereFoundId).HasName("IX_PartReceived_WhereFound");

                entity.Property(e => e.DateCode).HasColumnType("numeric");

                entity.Property(e => e.IncomingDate).HasColumnType("datetime");

                entity.Property(e => e.IndividualPartComments)
                    .HasMaxLength(255)
                    .HasColumnType("varchar");

                entity.Property(e => e.InspectorNum).HasColumnType("numeric");

                entity.Property(e => e.InspectorNum2).HasColumnType("numeric");

                entity.Property(e => e.RedTagNum)
                    .HasMaxLength(255)
                    .HasColumnType("varchar");

                entity.Property(e => e.SampleInspectionEntryDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.SerialNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnType("varchar");

                entity.Property(e => e.WasTestedId).HasDefaultValue(1);

                entity.HasOne(d => d.Auditor).WithMany(p => p.PartReceived).HasForeignKey(d => d.AuditorId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.InspectionType).WithMany(p => p.PartReceived).HasForeignKey(d => d.InspectionTypeId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Part).WithMany(p => p.PartReceived).HasForeignKey(d => d.PartId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Vendor).WithMany(p => p.PartReceived).HasForeignKey(d => d.VendorId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.WasTested).WithMany(p => p.PartReceived).HasForeignKey(d => d.WasTestedId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.WhereFound).WithMany(p => p.PartReceived).HasForeignKey(d => d.WhereFoundId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<PassFail03>(entity =>
            {
                entity.Property(e => e.PassFail03Id).ValueGeneratedNever();

                entity.Property(e => e.PassFail03Desc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("varchar");
            });

            modelBuilder.Entity<PassFail08>(entity =>
            {
                entity.Property(e => e.PassFail08Id).ValueGeneratedNever();

                entity.Property(e => e.PassFail08Desc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("varchar");
            });

            modelBuilder.Entity<PassFail11>(entity =>
            {
                entity.Property(e => e.PassFail11Id).ValueGeneratedNever();

                entity.Property(e => e.PassFail11Desc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("varchar");
            });

            modelBuilder.Entity<PassFail13>(entity =>
            {
                entity.Property(e => e.PassFail13Id).ValueGeneratedNever();

                entity.Property(e => e.PassFail13Desc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("varchar");
            });

            modelBuilder.Entity<Valve>(entity =>
            {
                entity.HasKey(e => e.PartId);

                entity.HasIndex(e => e.ValveControlTypeId).HasName("IX_Valve_ValveEngine");

                entity.HasIndex(e => e.ValveFuelTypeId).HasName("IX_Valve_ValveTechnology");

                entity.Property(e => e.PartId).ValueGeneratedNever();

                entity.Property(e => e.Step10HighMax).HasColumnType("numeric");

                entity.Property(e => e.Step10HighMin).HasColumnType("numeric");

                entity.Property(e => e.Step10LowMax).HasColumnType("numeric");

                entity.Property(e => e.Step10LowMin).HasColumnType("numeric");

                entity.Property(e => e.Step5mHMax).HasColumnType("numeric");

                entity.Property(e => e.Step5mHMin).HasColumnType("numeric");

                entity.Property(e => e.Step5OhmsMax)
                    .HasColumnType("numeric")
                    .HasDefaultValue(0m);

                entity.Property(e => e.Step5OhmsMin)
                    .HasColumnType("numeric")
                    .HasDefaultValue(0m);

                entity.Property(e => e.Step6mHMax).HasColumnType("numeric");

                entity.Property(e => e.Step6mHMin).HasColumnType("numeric");

                entity.Property(e => e.Step6OhmsMax)
                    .HasColumnType("numeric")
                    .HasDefaultValue(0m);

                entity.Property(e => e.Step6OhmsMin)
                    .HasColumnType("numeric")
                    .HasDefaultValue(0m);

                entity.HasOne(d => d.Part).WithOne(p => p.Valve).HasForeignKey<Valve>(d => d.PartId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.ValveControlType).WithMany(p => p.Valve).HasForeignKey(d => d.ValveControlTypeId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.ValveFuelType).WithMany(p => p.Valve).HasForeignKey(d => d.ValveFuelTypeId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<ValveControlType>(entity =>
            {
                entity.HasIndex(e => e.ValveControlTypeDesc).HasName("UX_ValveControlTypeDesc").IsUnique();

                entity.Property(e => e.ValveControlTypeDesc)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnType("varchar");
            });

            modelBuilder.Entity<ValveFuelType>(entity =>
            {
                entity.HasIndex(e => e.ValveFuelTypeDesc).HasName("UX_ValveFuelTypeDesc").IsUnique();

                entity.Property(e => e.ValveFuelTypeDesc)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnType("varchar");
            });

            modelBuilder.Entity<ValveTestResults>(entity =>
            {
                entity.HasKey(e => e.PartReceivedId);

                entity.Property(e => e.PartReceivedId).ValueGeneratedNever();

                entity.Property(e => e.Step05mH).HasColumnType("numeric");

                entity.Property(e => e.Step05Ohms).HasColumnType("numeric");

                entity.Property(e => e.Step06mH).HasColumnType("numeric");

                entity.Property(e => e.Step06Ohms).HasColumnType("numeric");

                entity.Property(e => e.Step10High).HasColumnType("numeric");

                entity.Property(e => e.Step10Low).HasColumnType("numeric");

                entity.HasOne(d => d.PartReceived).WithOne(p => p.ValveTestResults).HasForeignKey<ValveTestResults>(d => d.PartReceivedId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Step03TestResult).WithMany(p => p.ValveTestResults).HasForeignKey(d => d.Step03TestResultId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Step08TestResult).WithMany(p => p.ValveTestResults).HasForeignKey(d => d.Step08TestResultId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Step11TestResult).WithMany(p => p.ValveTestResults).HasForeignKey(d => d.Step11TestResultId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Step13TestResult).WithMany(p => p.ValveTestResults).HasForeignKey(d => d.Step13TestResultId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.HasIndex(e => e.VendorDesc).HasName("UX_VendorDesc").IsUnique();

                entity.Property(e => e.VendorDesc)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnType("varchar");
            });

            modelBuilder.Entity<WasTested>(entity =>
            {
                entity.HasIndex(e => e.WasTestedDesc).HasName("UX_WasTested_WasTestedDesc").IsUnique();

                entity.Property(e => e.WasTestedId).ValueGeneratedNever();

                entity.Property(e => e.WasTestedDesc)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnType("char");
            });

            modelBuilder.Entity<WhereFound>(entity =>
            {
                entity.HasIndex(e => e.WhereFoundDesc).HasName("UX_WhereFoundDesc").IsUnique();

                entity.Property(e => e.WhereFoundDesc)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnType("varchar");
            });
        }

        public virtual DbSet<Auditor> Auditor { get; set; }
        public virtual DbSet<InspectionType> InspectionType { get; set; }
        public virtual DbSet<Part> Part { get; set; }
        public virtual DbSet<PartCategory> PartCategory { get; set; }
        public virtual DbSet<PartReceived> PartReceived { get; set; }
        public virtual DbSet<PassFail03> PassFail03 { get; set; }
        public virtual DbSet<PassFail08> PassFail08 { get; set; }
        public virtual DbSet<PassFail11> PassFail11 { get; set; }
        public virtual DbSet<PassFail13> PassFail13 { get; set; }
        public virtual DbSet<Valve> Valve { get; set; }
        public virtual DbSet<ValveControlType> ValveControlType { get; set; }
        public virtual DbSet<ValveFuelType> ValveFuelType { get; set; }
        public virtual DbSet<ValveTestResults> ValveTestResults { get; set; }
        public virtual DbSet<Vendor> Vendor { get; set; }
        public virtual DbSet<WasTested> WasTested { get; set; }
        public virtual DbSet<WhereFound> WhereFound { get; set; }
    }
}