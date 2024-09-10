using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MuteMate.Server.Models;

namespace MuteMate.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = new ApplicationUser { UserName = model.Username, Email = model.Email };
            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);
                return Ok(new { Success = true, Message = "User registered successfully." });
            }

            return BadRequest(result.Errors);
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                return Ok(new { Success = true, Message = "Login successful." });
            }
            return BadRequest(new { Success = false, Message = "Invalid login attempt." });
        }

        [HttpPost]
        [Route("logout")]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Ok(new { success = true, message = "Logout Successful" });
        }

        [HttpGet]
        [Route("isAuthenticated")]
        public IActionResult IsAuthenticated()
        {


            if (User.Identity.IsAuthenticated)
            {
                return Ok(new { isLoggedIn = true });
            }
            return Ok(new { isLoggedIn = false });
        }

        [HttpGet]
        [Route("users/${userId}")]
        public async Task<IActionResult> GetUserById(string userId)
        {
            if (string.IsNullOrEmpty(userId))
                return BadRequest(new { Success = false, Message = "User ID is required." });

            // Hämta användardata från datalagret (t.ex. databas)
            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
                return NotFound(new { Success = false, Message = "User not found." });

            // Returnera användardata
            return Ok(new { Success = true, Username = user.UserName });
        }
    }


}