﻿using Microsoft.AspNetCore.Mvc;
using Qinshift.NotesAppAndTags.Db;
using Qinshift.NotesAppAndTags.Models;

namespace Qinshift.NotesAppAndTags.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok(StaticDb.Users);

        }

        #region Path variables or Route parameters

        [HttpGet("byId/{id:int}")]
        public ActionResult<string> GetById(int id)
        {
            if (id != 0 && id > 0)            
                return Ok(StaticDb.Users[id - 1]);
            return BadRequest("Id must have positive value different than zero");
        }
        [HttpGet("byName/{name:alpha}")]
        public ActionResult<string> GetByName(string name)
        {
            if (!string.IsNullOrEmpty(name))
                return Ok(StaticDb.Users.FirstOrDefault(x => x.ToLower() == name.ToLower()));
            return BadRequest("Name must have value!");
        }

        #endregion

        #region Query string parameters
        [HttpGet("QueryString")]
        public ActionResult<string> GetByIdFromQuery(int index)
        {
            if (index != 0 && index > 0)
                return Ok(StaticDb.Users[index -1]);
            return BadRequest("Id must have positive value zero!");
        }


        #endregion

        #region Handling body parameters
        [HttpPost("fromBody")]
        public IActionResult AddUserFromBody([FromBody] User user)
        {
            //the code to handle add of a user
            return Ok();
        }

        [HttpPost("fromQuery")]
        public IActionResult AddUserFromQuery([FromQuery] User user)
        {
            //the code to handle add of a user
            return Ok();
        }

        [HttpPost("header-info")]
        public IActionResult HeaderInfo([FromHeader(Name = "Accept-language")] string language, [FromHeader(Name = "Custom-Name")]string name)
        {
            //the code to handle add of a user
            return Ok($" language header: { language}, Name header: {name} ");
        }

        #endregion

    }
}
