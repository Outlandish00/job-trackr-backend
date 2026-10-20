using job_trackr_backend.Data;
using job_trackr_backend.Models;
using job_trackr_backend.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class JobApplicationController : ControllerBase
{
    private JobTrackrContext _dbContext;

    public JobApplicationController(JobTrackrContext context)
    {
        _dbContext = context;
    }

    [HttpGet]
    public IActionResult GetJobApplications()
    {
        List<JobApplicationDTO> foundJobApplications = _dbContext
            .JobApplications.Select(ja => new JobApplicationDTO
            {
                Id = ja.Id,
                Company = ja.Company,
                JobTitle = ja.JobTitle,
                StatusId = ja.StatusId,
                Status = new StatusDTO { Id = ja.Status.Id, StatusName = ja.Status.StatusName },
                DateApplied = ja.DateApplied,
                Notes = ja.Notes,
            })
            .ToList();
        if (foundJobApplications == null)
        {
            return BadRequest();
        }
        return Ok(foundJobApplications);
    }

    [HttpPost]
    public IActionResult PostJobApplication(JobApplication newJobApplication)
    {
        _dbContext.JobApplications.Add(newJobApplication);
        _dbContext.SaveChanges();
        return NoContent();
    }
}
