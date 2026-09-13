using Microsoft.EntityFrameworkCore;
using JobTracker.DTOs;
using JobTracker.Models;
using JobTracker.Data;

namespace JobTracker.Services;

public class JobService : IJobService
{
    private readonly AppDbContext _context;

    public JobService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Job>> GetAllJobsAsync()
    {
        return await _context.Jobs.ToListAsync();
    }


    public async Task<Job> CreateJobAsync(CreateJobDto dto)
    {
        var job = new Job
        {
            Company=dto.Company,
            Position=dto.Position,
            Status=dto.Status,
            AppliedDate=DateTime.UtcNow
        };

        _context.Jobs.Add(job);
        await _context.SaveChangesAsync();
        return job;
    }

    public async Task<bool> DeleteJobAsync(int id)
    {
        var job = await _context.Jobs.FindAsync(id);
        if(job == null) return false;

        _context.Jobs.Remove(job);
        await _context.SaveChangesAsync();
        return true;
    }
}