using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyAPI.Database;
using Dapper;
namespace PharmacyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUser _userService;
        public UsersController(IUser userService)
        {
            _userService = userService;
        }

        //[HttpGet]
        //public async Task<IActionResult> Users()
        //{
        //    var employeeList = await _userService.GetAllUsers();
        //    return Ok(employeeList);
        //}

        [HttpGet]
        public async Task<IActionResult> Users(string PharmacyCode, string UserId)
        {
            var employeeList = await _userService.GetAllUsers(PharmacyCode, UserId);
            return Ok(employeeList);
        }
    }
}
