using Microsoft.AspNetCore.Mvc;
using SimpleApi.Models;

namespace SimpleApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SubmissionsController : ControllerBase
{
	// POST /api/submissions
	[HttpPost]
	public IActionResult Post([FromBody] SubmitRequest request)
	{
		if (string.IsNullOrWhiteSpace(request?.Name))
			return BadRequest(new { message = "Name is required." });

		// do something with request.Name (save to DB, etc.)
		return Ok(new
		{
			received = request.Name.Trim(),
			timestamp = DateTime.UtcNow
		});
	}
}
