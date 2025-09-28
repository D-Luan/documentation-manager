using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DocumentationManager.WebAPI.Model;
using DocumentationManager.WebAPI.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

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
    public async Task<IActionResult> GetDocumentationLinks()
    {
        try
        {
            var links = await _context.DocumentationLinks.ToListAsync();

            return Ok(links);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Ocorreu um erro interno no servidor: {ex.Message}");
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<DocumentationLink>> GetDocumentationLinkById(int id)
    {
        var documentationLink = await _context.DocumentationLinks.FindAsync(id);

        if(documentationLink == null)
        {
            return NotFound();
        }

        return Ok(documentationLink);
    }
}
