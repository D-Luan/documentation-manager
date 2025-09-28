namespace DocumentationManager.WebAPI.Dtos;

public class UpdateLinkDto
{
    public string TechnologyName { get; set; }
    public string Url { get; set; }
    public string? PersonalNotes { get; set; }
}
