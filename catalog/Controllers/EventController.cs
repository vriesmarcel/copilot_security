using Microsoft.AspNetCore.Mvc;
using GloboTicket.Catalog.Repositories;
using GloboTicket.Catalog.Model;
using System.ComponentModel.DataAnnotations;

namespace GloboTicket.Catalog.Controllers;

[ApiController]
[Route("[controller]")]
public class EventController : ControllerBase
{
    private readonly IEventRepository _eventRepository;
    private readonly ILogger<EventController> _logger;

    public EventController(IEventRepository eventRepository, ILogger<EventController> logger)
    {
        _eventRepository = eventRepository;
        _logger = logger;
    }

    [HttpGet(Name = "GetEvents")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _eventRepository.GetEvents());
    }

    [HttpGet("{id}", Name = "GetById")]
    public async Task<Event> GetById(Guid id)
    {
        return await _eventRepository.GetEventById(id);
    }

    [HttpPost(Name = "CreateEvent")]
    public async Task<IActionResult> CreateEvent([FromBody] Event newEvent)
    {
        if (newEvent == null)
        {
            return BadRequest("Event data is required.");
        }

        // Validate the event data
        if (string.IsNullOrWhiteSpace(newEvent.Name) || newEvent.Date == default || newEvent.Price <= 0)
        {
            return BadRequest("Invalid event data. Ensure all required fields are provided and valid.");
        }

        try
        {
            await _eventRepository.AddEvent(newEvent);
            return CreatedAtRoute("GetById", new { id = newEvent.EventId }, newEvent);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error creating event");
            return StatusCode(500, "An error occurred while creating the event.");
        }
    }
}
