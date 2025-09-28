namespace DocumentationManager.WebAPI.Dtos;

public class DocumentationLinkDto
{
    public int Id { get; set; }
    public string TechnologyName { get; set; }
    public string Url { get; set; }
    public string? Category { get; set; }
}
