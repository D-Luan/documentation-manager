using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DocumentationManager.WebAPI.Model;
using DocumentationManager.WebAPI.Data;

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
}
