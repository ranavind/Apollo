using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Apollo.Tiers.DataAccess.Models
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AttributeMaster> AttributeMasters { get; set; }
        public virtual DbSet<CompoundMaster> CompoundMasters { get; set; }
        public virtual DbSet<Config> Configs { get; set; }
        public virtual DbSet<CustomerMaster> CustomerMasters { get; set; }
        public virtual DbSet<DelayCodeMaster> DelayCodeMasters { get; set; }
        public virtual DbSet<DepartmentMaster> DepartmentMasters { get; set; }
        public virtual DbSet<Exception> Exceptions { get; set; }
        public virtual DbSet<LocationMaster> LocationMasters { get; set; }
        public virtual DbSet<MachineMaster> MachineMasters { get; set; }
        public virtual DbSet<MaterialCategoryMaster> MaterialCategoryMasters { get; set; }
        public virtual DbSet<MaterialMaster> MaterialMasters { get; set; }
        public virtual DbSet<OperatorMaster> OperatorMasters { get; set; }
        public virtual DbSet<PackingTypeMaster> PackingTypeMasters { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<PlantMaster> PlantMasters { get; set; }
        public virtual DbSet<ProcessMaster> ProcessMasters { get; set; }
        public virtual DbSet<ReasonMaster> ReasonMasters { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<ScrapTypeMaster> ScrapTypeMasters { get; set; }
        public virtual DbSet<ShiftMaster> ShiftMasters { get; set; }
        public virtual DbSet<StorageCreationMaster> StorageCreationMasters { get; set; }
        public virtual DbSet<StorageTypeMaster> StorageTypeMasters { get; set; }
        public virtual DbSet<TransporterMaster> TransporterMasters { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UsersPagesMapping> UsersPagesMappings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=AopolloDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AttributeMaster>(entity =>
            {
                entity.ToTable("AttributeMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AttributeName).HasMaxLength(50);

                entity.Property(e => e.UnitOfMeasure).HasMaxLength(50);
            });

            modelBuilder.Entity<CompoundMaster>(entity =>
            {
                entity.ToTable("CompoundMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AgingPeriod).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.BatchLimit).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.ExpiryPeriod).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.GreenLimit).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MaterialName).HasMaxLength(50);

                entity.Property(e => e.MinAgingPeriod).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MixingCycleTime).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PorcessCode).HasMaxLength(50);

                entity.Property(e => e.ProcessOrder).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RedLimit).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Sapcode)
                    .HasMaxLength(50)
                    .HasColumnName("SAPCode");

                entity.Property(e => e.YellowLimit).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Config>(entity =>
            {
                entity.ToTable("Config");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ConfigKey)
                    .HasMaxLength(50)
                    .HasColumnName("Config_Key");

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.Value).HasMaxLength(255);
            });

            modelBuilder.Entity<CustomerMaster>(entity =>
            {
                entity.ToTable("CustomerMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomerAddress).HasMaxLength(255);

                entity.Property(e => e.CustomerName).HasMaxLength(50);

                entity.Property(e => e.CustomerSapcode)
                    .HasMaxLength(50)
                    .HasColumnName("CustomerSAPCode");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Gstin)
                    .HasMaxLength(50)
                    .HasColumnName("GSTIN");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Pincode).HasMaxLength(50);
            });

            modelBuilder.Entity<DelayCodeMaster>(entity =>
            {
                entity.ToTable("DelayCodeMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DelayCode).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);
            });

            modelBuilder.Entity<DepartmentMaster>(entity =>
            {
                entity.ToTable("DepartmentMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DepartmentCode).HasMaxLength(50);

                entity.Property(e => e.DepartmentName).HasMaxLength(50);
            });

            modelBuilder.Entity<Exceptions>(entity =>
            {
                entity.HasIndex(e => new { e.ApplicationName, e.DeletionDate, e.CreationDate }, "IX_Exceptions_ApplicationName_DeletionDate_CreationDate_Filtered")
                    .HasFilter("([DeletionDate] IS NULL)");

                entity.HasIndex(e => e.CreationDate, "IX_Exceptions_CreationDate_Includes");

                entity.HasIndex(e => new { e.ErrorHash, e.ApplicationName, e.CreationDate, e.DeletionDate }, "IX_Exceptions_ErrorHash_ApplicationName_CreationDate_DeletionDate");

                entity.HasIndex(e => new { e.Guid, e.ApplicationName, e.DeletionDate, e.CreationDate }, "IX_Exceptions_GUID_ApplicationName_DeletionDate_CreationDate")
                    .IsUnique();

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Category).HasMaxLength(100);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DeletionDate).HasColumnType("datetime");

                entity.Property(e => e.DuplicateCount).HasDefaultValueSql("((1))");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Host).HasMaxLength(100);

                entity.Property(e => e.Httpmethod)
                    .HasMaxLength(10)
                    .HasColumnName("HTTPMethod");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.LastLogDate).HasColumnType("datetime");

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Message).HasMaxLength(1000);

                entity.Property(e => e.Source).HasMaxLength(100);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Url).HasMaxLength(500);
            });

            modelBuilder.Entity<LocationMaster>(entity =>
            {
                entity.ToTable("LocationMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Department).HasMaxLength(50);

                entity.Property(e => e.LocationCode).HasMaxLength(50);

                entity.Property(e => e.LocationName).HasMaxLength(50);
            });

            modelBuilder.Entity<MachineMaster>(entity =>
            {
                entity.ToTable("MachineMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.MachineCode).HasMaxLength(50);

                entity.Property(e => e.MachineGroup).HasMaxLength(50);

                entity.Property(e => e.MachineName).HasMaxLength(50);
            });

            modelBuilder.Entity<MaterialCategoryMaster>(entity =>
            {
                entity.ToTable("MaterialCategoryMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryCode).HasMaxLength(50);

                entity.Property(e => e.CategoryDescription).HasMaxLength(50);

                entity.Property(e => e.CategoryImage).HasMaxLength(50);

                entity.Property(e => e.CategoryName).HasMaxLength(50);
            });

            modelBuilder.Entity<MaterialMaster>(entity =>
            {
                entity.ToTable("MaterialMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AgingPeriod).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CompoundMaterial1).HasMaxLength(50);

                entity.Property(e => e.CompoundMaterial2).HasMaxLength(50);

                entity.Property(e => e.CompoundMaterial3).HasMaxLength(50);

                entity.Property(e => e.ExDescription).HasMaxLength(100);

                entity.Property(e => e.ExMaterialName).HasMaxLength(50);

                entity.Property(e => e.ExSapcode)
                    .HasMaxLength(50)
                    .HasColumnName("ExSAPCode");

                entity.Property(e => e.ExectedSackQuantity).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ExpectedBoxQty).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ExpectedBoxWeight).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ExpectedPouchQuantity).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ExpectedPouchWeight).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ExpectedSackWeight).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ExpiryPeriod).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FfDescription).HasMaxLength(100);

                entity.Property(e => e.FfMaterialName).HasMaxLength(50);

                entity.Property(e => e.FfMaterilaType).HasMaxLength(50);

                entity.Property(e => e.FfSapcode)
                    .HasMaxLength(50)
                    .HasColumnName("FfSAPCode");

                entity.Property(e => e.FgDescription).HasMaxLength(100);

                entity.Property(e => e.FgMaterialName).HasMaxLength(50);

                entity.Property(e => e.FgSapcode)
                    .HasMaxLength(50)
                    .HasColumnName("FgSAPCode");

                entity.Property(e => e.GreenLimit).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MinAgingPeriod).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NoOfMouldsRunning).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PerShiftOutput).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RedLimit).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RepassMaterial).HasMaxLength(50);

                entity.Property(e => e.SpAgingPeriod).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SpDescription).HasMaxLength(100);

                entity.Property(e => e.SpExpiryPeriod).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SpGreenLimit).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SpMaterialName).HasMaxLength(50);

                entity.Property(e => e.SpMinAgingPeriod).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SpNoOfMouldsRunning).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SpPerShiftOutput).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SpRedLimit).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SpSapcode)
                    .HasMaxLength(50)
                    .HasColumnName("SpSAPCode");

                entity.Property(e => e.SpYellowLimit).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Tolarance).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TubeWeight).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.YellowLimit).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<OperatorMaster>(entity =>
            {
                entity.ToTable("OperatorMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Department).HasMaxLength(50);

                entity.Property(e => e.OperatorCode).HasMaxLength(50);

                entity.Property(e => e.OperatorName).HasMaxLength(50);
            });

            modelBuilder.Entity<PackingTypeMaster>(entity =>
            {
                entity.ToTable("PackingTypeMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PackingCode).HasMaxLength(50);

                entity.Property(e => e.PackingType).HasMaxLength(50);
            });

            modelBuilder.Entity<Page>(entity =>
            {
                entity.Property(e => e.Page1)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("Page");

                entity.HasOne(d => d.ParentpageNavigation)
                    .WithMany(p => p.InverseParentpageNavigation)
                    .HasForeignKey(d => d.Parentpage)
                    .HasConstraintName("FK_Pages_Pages");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Pages)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Pages_Roles");
            });

            modelBuilder.Entity<PlantMaster>(entity =>
            {
                entity.ToTable("PlantMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Gstin)
                    .HasMaxLength(50)
                    .HasColumnName("GSTIN");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.PinCode).HasMaxLength(50);

                entity.Property(e => e.PlantAddr).HasMaxLength(255);

                entity.Property(e => e.PlantName).HasMaxLength(255);

                entity.Property(e => e.PlantSapcode)
                    .HasMaxLength(50)
                    .HasColumnName("PlantSAPCode");
            });

            modelBuilder.Entity<ProcessMaster>(entity =>
            {
                entity.ToTable("ProcessMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PorcessName).HasMaxLength(50);

                entity.Property(e => e.ProcessCode).HasMaxLength(50);
            });

            modelBuilder.Entity<ReasonMaster>(entity =>
            {
                entity.ToTable("ReasonMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DelayCode).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.ReasonCode).HasMaxLength(50);

                entity.Property(e => e.ReasonName).HasMaxLength(50);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Role1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Role");
            });

            modelBuilder.Entity<ScrapTypeMaster>(entity =>
            {
                entity.ToTable("ScrapTypeMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Sapcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SAPCode");

                entity.Property(e => e.ScrapType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShiftMaster>(entity =>
            {
                entity.ToTable("ShiftMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EndTime).HasMaxLength(50);

                entity.Property(e => e.ShiftCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ShiftIdCode).HasMaxLength(10);

                entity.Property(e => e.StratTime).HasMaxLength(50);
            });

            modelBuilder.Entity<StorageCreationMaster>(entity =>
            {
                entity.ToTable("StorageCreationMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.StorageCode).HasMaxLength(50);

                entity.Property(e => e.StorageNo).HasMaxLength(50);

                entity.Property(e => e.StorageType).HasMaxLength(50);
            });

            modelBuilder.Entity<StorageTypeMaster>(entity =>
            {
                entity.ToTable("StorageTypeMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.StorageName).HasMaxLength(50);
            });

            modelBuilder.Entity<TransporterMaster>(entity =>
            {
                entity.ToTable("TransporterMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Gstin)
                    .HasMaxLength(50)
                    .HasColumnName("GSTIN");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Pincode).HasMaxLength(50);

                entity.Property(e => e.TranspoterAddress).HasMaxLength(255);

                entity.Property(e => e.TranspoterName).HasMaxLength(50);

                entity.Property(e => e.TranspoterSapcode)
                    .HasMaxLength(50)
                    .HasColumnName("TranspoterSAPCode");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.RoleNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.Role)
                    .HasConstraintName("FK_Users_Roles");
            });

            modelBuilder.Entity<UsersPagesMapping>(entity =>
            {
                entity.ToTable("Users_Pages_Mapping");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.UsersPagesMappings)
                    .HasForeignKey(d => d.PageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Pages_Mapping_Pages");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersPagesMappings)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Pages_Mapping_Users");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
