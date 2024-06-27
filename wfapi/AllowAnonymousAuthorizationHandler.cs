using Microsoft.AspNetCore.Authorization;

namespace wfapi;

/// <summary>
/// This authorisation handler will bypass all requirements
/// </summary>
public class AllowAnonymousAuthorizationHandler : IAuthorizationHandler
{
    /// <summary>
    /// Simply pass all requirements
    /// </summary>
    /// <param name="context"></param>
    /// <returns></returns>
    public Task HandleAsync(AuthorizationHandlerContext context)
    {
        foreach (IAuthorizationRequirement requirement in context.PendingRequirements.ToList())
            context.Succeed(requirement); //Simply pass all requirements

        return Task.CompletedTask;
    }
}
