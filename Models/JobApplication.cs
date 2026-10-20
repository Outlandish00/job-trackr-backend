namespace job_trackr_backend.Models;

public class JobApplication
{
    public int Id { get; set; }
    public string Company { get; set; } = string.Empty;
    public string JobTitle { get; set; } = string.Empty;
    public int StatusId { get; set; }
    public Status? Status { get; set; } = null!;
    public DateTime DateApplied { get; set; } = DateTime.UtcNow;
    public string? Notes { get; set; }
}
