using Microsoft.AspNetCore.Mvc;

namespace Qinshift.NotesApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<string>> Get()
        {
            return Ok(StaticDb.SimpleNotes);
        }

        [HttpGet("{id:int}")]// with :int, if the value is not int, the request doesn't hit the ednpoint
        public ActionResult<string> GetById(int id)
        {
            try
            {
                if (id < 0)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, "The id has negative value! Try again with positive!");
                }
                if (id > StaticDb.SimpleNotes.Count)
                {
                    return StatusCode(StatusCodes.Status404NotFound, $"Note with {id} not exist!");
                }

                return StaticDb.SimpleNotes[id - 1];
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occured. Contact the administrator!");
            }
        }

        [HttpGet("{noteId}/user/{userId}")]
        public ActionResult<string> GetNoteByIdAndUserId(int noteId, int userId)
        {
            if (noteId < 0 || userId < 0)
            {
                return BadRequest("The id's cannot be negative");
            }

            return Ok($"Returning note with id: {noteId} for user with id: {userId}.");
            //return StatusCode(StatusCodes.Status200OK, $"Returning note with id: {noteId} for user with id: {userId}."); same with the line above
        }

        [HttpPost]
        public IActionResult Post()
        {
            try
            {
                using (StreamReader reader = new StreamReader(Request.Body))
                {
                    string newNote = reader.ReadToEnd();

                    if (string.IsNullOrEmpty(newNote))
                    {
                        return BadRequest("The body of the reqeuest cannot be empty!");
                    }
                    StaticDb.SimpleNotes.Add(newNote);
                    return Ok("The note was added successfully");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occured1");
            }
        }
    }
}
