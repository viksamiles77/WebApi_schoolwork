using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Qinshift.EShop.DTOs.User;
using Qinshift.EShop.Services.Implementation;
using Qinshift.EShop.Services.Interface;

namespace Qinshift.EShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpPost("register")]
        public IActionResult RegisterUser([FromBody] RegisterUserDto registerUserDto)
        {
            try
            {
                var result = _userService.RegisterUser(registerUserDto);
                if (result < 0) return BadRequest("An error occured!");

                return StatusCode(StatusCodes.Status201Created, "User created successfully!");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        [HttpPost("login")]
        public IActionResult LoginUser([FromBody] UserDto userDto)
        {
            try
            {
                string token = _userService.LoginUser(userDto.UserName, userDto.Password);
                return Ok(token);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
