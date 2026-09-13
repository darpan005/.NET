using Microsoft.EntityFrameworkCore;
using JobTracker.DTOs;
using JobTracker.Services;
using Microsoft.AspNetCore.Mvc;

namespace JobTracker.Controllers;

[ApiController]
[Route("api/[controller]")]
public class JobController : ControllerBase
{
    private readonly IJobService _jobService;

    public JobController(IJobService jobService)
    {
        _jobService = jobService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var jobs = await _jobService.GetAllJobsAsync();
        return Ok(jobs);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateJobDto dto)
    {
        var createdJob = await _jobService.CreateJobAsync(dto);
        return Ok(createdJob);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var success = await _jobService.DeleteJobAsync(id);
        if(!success) return NotFound("Job Not Found");

        return NoContent();
    }
}