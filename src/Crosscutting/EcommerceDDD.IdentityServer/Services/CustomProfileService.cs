using Duende.IdentityServer.Extensions;
using Duende.IdentityServer.Models;
using Duende.IdentityServer.Services;
using EcommerceDDD.IdentityServer.Models;
using IdentityModel;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace EcommerceDDD.IdentityServer.Services;

public class CustomProfileService(
    UserManager<ApplicationUser> userMgr,
    RoleManager<IdentityRole> roleMgr,
    IUserClaimsPrincipalFactory<ApplicationUser> userClaimsPrincipalFactory)
    : IProfileService
{
    public async Task GetProfileDataAsync(ProfileDataRequestContext context)
    {
        var sub = context.Subject.GetSubjectId();
        var user = await userMgr.FindByIdAsync(sub);
        var userClaims = await userClaimsPrincipalFactory.CreateAsync(user);

        var claims = userClaims.Claims.ToList();
        claims = claims.Where(claim => context.RequestedClaimTypes.Contains(claim.Type)).ToList();
        claims.Add(new Claim(JwtClaimTypes.Email, user.Email));

        if (userMgr.SupportsUserRole)
        {
            var roles = await userMgr.GetRolesAsync(user);
            foreach (var rolename in roles)
            {
                claims.Add(new Claim(JwtClaimTypes.Role, rolename));
                if (!roleMgr.SupportsRoleClaims) continue;
                var role = await roleMgr.FindByNameAsync(rolename);
                if (role != null)
                {
                    claims.AddRange(await roleMgr.GetClaimsAsync(role));
                }
            }
        }

        context.IssuedClaims = claims;
    }

    public async Task IsActiveAsync(IsActiveContext context)
    {
        var sub = context.Subject.GetSubjectId();
        var user = await userMgr.FindByIdAsync(sub);
        context.IsActive = user != null;
    }
}

