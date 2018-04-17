using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AraoAuth.Extensions
{
    public static class OwinContextExtensions
    {
        public static string GetUserId(this IOwinContext ctx)
        {
            var result = "-1";
            var claim = ctx.Authentication.User.Claims.FirstOrDefault(c => c.Type.Equals("sub"));
            if (claim != null)
            {
                result = claim.Value;
            }
            return result;
        }
    }
}