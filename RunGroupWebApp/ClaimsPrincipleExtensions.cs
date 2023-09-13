using System.Runtime.CompilerServices;
using System.Security.Claims;

namespace RunGroupWebApp
{
    public static class ClaimsPrincipleExtensions
    {
        public static string GetUserId(this ClaimsPrincipal user)
        {
            return user.FindFirst(ClaimTypes.NameIdentifier).Value;
       }
    }
}
