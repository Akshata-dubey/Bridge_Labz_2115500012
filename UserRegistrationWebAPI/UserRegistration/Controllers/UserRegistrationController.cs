using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Services;
using ModelLayer.DTO;
using NLog;

namespace UserRegistration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserRegistrationController : ControllerBase
    {
        private readonly UserRegistrationBL _userRegistrationBL;
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public UserRegistrationController(UserRegistrationBL userRegistrationBL)
        {
            _userRegistrationBL = userRegistrationBL;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("User Registration API is Working!");
        }

        [HttpPost]
        public IActionResult Registration([FromBody] UserDTO user)
        {
            try
            {
                var result = _userRegistrationBL.RegistrationBL(user);
                return Ok(new { message = "User registered successfully", data = result });
            }
            catch (Exception ex)
            {
                _logger.Error($"Error in Registration: {ex.Message}");
                return StatusCode(500, new { message = "Internal Server Error", error = ex.Message });
            }
        }
    }
}
