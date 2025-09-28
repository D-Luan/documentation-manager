namespace DocumentationManager.WebAPI.Model;

public class DocumentationLink
{
    public int Id { get; set; }
    public string TechnologyName { get; set; }
    public string? Category { get; set; }
    public string Url { get; set; }
    public string? PersonalNotes { get; set; }
    public DateTime DateAdded { get; set; }
}