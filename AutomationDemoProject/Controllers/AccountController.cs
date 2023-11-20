using AutomationDemoProject.Util;
using Microsoft.AspNetCore.Mvc;

namespace AutomationDemoProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost("create")]
        public IActionResult CreateAccount([FromBody] AccountRequest request)
        {
            // Assuming AccountService is a class responsible for account creation logic
            var result = AccountService.CreateAccount(request);

            // Assuming ApiResponse is a class representing the response structure
            return Ok(result);
        }

        [HttpPut("deposit")]
        public IActionResult Deposit([FromBody] DepositRequest request)
        {
            // Assuming AccountService is a class responsible for account deposit logic
            var result = AccountService.Deposit(request);

            // Assuming ApiResponse is a class representing the response structure
            return Ok(result);
        }

        [HttpPut("withdraw")]
        public IActionResult Withdraw([FromBody] WithdrawRequest request)
        {
            // Assuming AccountService is a class responsible for account withdrawal logic
            var result = AccountService.Withdraw(request);

            // Assuming ApiResponse is a class representing the response structure
            return Ok(result);
        }

        [HttpDelete("delete/{accountID}")]
        public IActionResult DeleteAccount(string accountID)
        {
            // Assuming AccountService is a class responsible for account deletion logic
            var result = AccountService.DeleteAccount(accountID);

            // Assuming ApiResponse is a class representing the response structure
            return Ok(result);
        }
    }
}
