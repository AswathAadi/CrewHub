using CrewHub.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CrewHub.Data.DBContext
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
        : base(options)
        {
            try
            {
                // Attempt to open the database connection
                Database.OpenConnection();
                Database.CloseConnection();
            }
            catch (Exception ex)
            {
                // Handle the exception or log the error
                Console.WriteLine($"Error connecting to the database: {ex.Message}");
                throw;
            }
        }

        public DbSet<TblTitanEmployee> Employee { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblTitanEmployee>(entity =>
            {
                entity.ToTable("tbl_titan_employee");

                entity.HasIndex(e => e.Id)
                .HasDatabaseName("UQ_tbl_titan_employee");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(55)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(55);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.IsActive)
                    .HasColumnName("is_active")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnName("updated_date");

                entity.Property(e => e.DateOfBirth).HasColumnName("date_of_birth");

                entity.Property(e => e.DateOfJoining).HasColumnName("date_of_joining");

                entity.Property(e => e.EmpRefCode)
                    .HasColumnName("emp_ref_code")
                    .HasMaxLength(45);

                entity.Property(e => e.ReportsTo)
                    .HasColumnName("reports_to")
                    .HasMaxLength(55);
            });

        }
    }
}
