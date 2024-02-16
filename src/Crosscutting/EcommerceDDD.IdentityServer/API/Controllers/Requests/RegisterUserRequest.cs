namespace EcommerceDDD.IdentityServer.API.Controllers.Requests;

public record RegisterUserRequest
{
    [Required]
    public required string Email { get; set; }
    
    [Required]
    public required string Password { get; set; }
    
    [Required]
    public required string PasswordConfirm { get; set; }
}