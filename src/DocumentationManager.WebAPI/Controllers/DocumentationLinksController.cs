using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DocumentationManager.WebAPI.Model;
using DocumentationManager.WebAPI.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using DocumentationManager.WebAPI.Dtos;

namespace DocumentationManager.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DocumentationLinksController : ControllerBase
{
    private readonly DocumentationContext _context;

    public DocumentationLinksController(DocumentationContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<DocumentationLinkDto>>> GetDocumentationLinks()
    {
        var linksDto = await _context.DocumentationLinks
            .Select(link => new DocumentationLinkDto 
            {
                Id = link.Id,
                TechnologyName = link.TechnologyName,
                Url = link.Url,
                Category = link.Category
            })
            .ToListAsync();

        return Ok(linksDto);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<DocumentationLinkDto>> GetDocumentationLinkById(int id)
    {
        var linksDto = await _context.DocumentationLinks
            .Where(link => link.Id == id)
            .Select(link => new DocumentationLinkDto
            {
                Id = link.Id,
                TechnologyName = link.TechnologyName,
                Url = link.Url,
                Category = link.Category
            })
            .FirstOrDefaultAsync();

        if (linksDto == null)
        {
            return NotFound();
        }

        return Ok(linksDto);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateLink(int id, UpdateLinkDto linkDto)
    {
        var linksDto = await _context.DocumentationLinks.FindAsync(id);
        if (linksDto == null)
        {
            return NotFound();
        }

        linksDto.TechnologyName = linkDto.TechnologyName;
        linksDto.Url = linkDto.Url;
        linksDto.PersonalNotes = linkDto.PersonalNotes;

        await _context.SaveChangesAsync();

        return NoContent();
    }
}
