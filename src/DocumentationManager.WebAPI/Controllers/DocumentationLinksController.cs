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
        var linkDto = await _context.DocumentationLinks
            .Select(link => new DocumentationLinkDto
            {
                Id = link.Id,
                Title = link.Title,
                Url = link.Url,
                Category = link.Category
            })
            .ToListAsync();

        return Ok(linkDto);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<DocumentationLinkDto>> GetDocumentationLinkById(int id)
    {
        var linkDto = await _context.DocumentationLinks
            .Where(link => link.Id == id)
            .Select(link => new DocumentationLinkDto
            {
                Id = link.Id,
                Title = link.Title,
                Url = link.Url,
                Category = link.Category
            })
            .FirstOrDefaultAsync();

        if (linkDto == null)
        {
            return NotFound();
        }

        return Ok(linkDto);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateLink(int id, UpdateLinkDto linkDto)
    {
        var documentationLink = await _context.DocumentationLinks.FindAsync(id);
        if (documentationLink == null)
        {
            return NotFound();
        }

        documentationLink.Title = linkDto.Title;
        documentationLink.Url = linkDto.Url;
        documentationLink.PersonalNotes = linkDto.PersonalNotes;

        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpPost]
    public async Task<ActionResult<DocumentationLinkDto>> PostDocumentationLink(CreateLinkDto linkDto)
    {
        var documentationLink = new DocumentationLink
        {
            Title = linkDto.Title,
            Url = linkDto.Url,
            Category = linkDto.Category,
            PersonalNotes = linkDto.PersonalNotes,
            DateAdded = DateTime.UtcNow
        };

        _context.DocumentationLinks.Add(documentationLink);
        await _context.SaveChangesAsync();

        var createdLinkDto = new DocumentationLinkDto
        {
            Id = documentationLink.Id,
            Title = documentationLink.Title,
            Url = documentationLink.Url,
            Category = documentationLink.Category
        };

        return CreatedAtAction(
            nameof(GetDocumentationLinkById),
            new { id = createdLinkDto.Id },
            createdLinkDto);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteDocumentationLink(int id)
    {
        var documentationLink = await _context.DocumentationLinks.FindAsync(id);
        if (documentationLink == null)
        {
            return NotFound();
        }

        _context.DocumentationLinks.Remove(documentationLink);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}