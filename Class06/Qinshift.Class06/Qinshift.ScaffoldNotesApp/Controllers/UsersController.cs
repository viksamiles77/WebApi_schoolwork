﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Qinshift.DataAccess.Domain;

namespace Qinshift.ScaffoldNotesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly NotesScaffoldDbContext _context;
        public UsersController(NotesScaffoldDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var users = _context.Users.FirstOrDefault(x => x.Id == 1);
            return Ok(users);
        }


    }
}