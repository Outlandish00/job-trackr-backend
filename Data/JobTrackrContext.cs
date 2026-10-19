using job_trackr_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace job_trackr_backend.Data;

public class JobTrackerContext : DbContext
{
    public JobTrackerContext(DbContextOptions<JobTrackerContext> options)
        : base(options) { }

    public DbSet<JobApplication> JobApplications => Set<JobApplication>();
    public DbSet<Status> Statuses => Set<Status>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Status>()
            .HasData(
                new Status { Id = 1, StatusName = "Applied" },
                new Status { Id = 2, StatusName = "Interviewing" },
                new Status { Id = 3, StatusName = "Offer" },
                new Status { Id = 4, StatusName = "Rejected" },
                new Status { Id = 5, StatusName = "Withdrawn" }
            );
    }
}
