using JobTracker.Models;
using JobTracker.DTOs;

namespace JobTracker.Services;

public interface IJobService
{
    Task<List<Job>> GetAllJobsAsync();
    Task<Job> CreateJobAsync(CreateJobDto dto);
    Task<bool> DeleteJobAsync(int id);
}