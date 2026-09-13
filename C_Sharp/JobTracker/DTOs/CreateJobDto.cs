namespace JobTracker.DTOs;

public class CreateJobDto
{
    public string Company{get; set;} = string.Empty;
    public string Position{get; set;} = string.Empty;
    public string Status{get; set;}="Applied";
}