using Microsoft.EntityFrameworkCore;

namespace job_trackr_backend.Data;

public class JobTrackerContext : DbContext
{
    public JobTrackerContext(DbContextOptions<JobTrackerContext> options)
        : base(options) { }
}
