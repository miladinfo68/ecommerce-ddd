namespace EcommerceDDD.IdentityServer.Controllers;

[AllowAnonymous]
[ApiController]
[Route("api/accounts")]
public class AccountsController(IIdentityManager identityManager) : CustomControllerBase
{
    [HttpPost, Route("login")]
    public async Task<IActionResult> UserLogin(LoginRequest request)
    {
        try
        {
            var response = await identityManager
                .AuthUserByCredentials(request);

            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequestActionResult(e.Message);
        }
    }

    [HttpPost, Route("register")]
    public async Task<IActionResult> Register(RegisterUserRequest request)
    {
        try
        {
            var result = await identityManager
                .RegisterNewUser(request);

            return Ok(new
            {
                data = result,
                success = result.Succeeded
            });
        }
        catch (Exception e)
        {
            return BadRequestActionResult(e.Message);            
        }
    }
}
