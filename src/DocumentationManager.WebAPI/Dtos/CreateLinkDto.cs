namespace DocumentationManager.WebAPI.Dtos;

public class CreateLinkDto
{
    public string TechnologyName { get; set; }
    public string Url { get; set; }
    public string? Category { get; set; }
    public string? PersonalNotes { get; set; }
}
