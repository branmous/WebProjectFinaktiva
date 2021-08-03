using Infraestructure.Model.Constants;
using Infraestructure.Model.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace Web.Api.Helpers
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            User user = (User)context.HttpContext.Items[AdminConstant.User];
            var path = context.HttpContext.Request.Path.Value;
            if (user == null)
            {
                // not logged in
                context.Result = new JsonResult(new { message = "Unauthorized" }) { StatusCode = StatusCodes.Status401Unauthorized };
            }
            else if (!ValidatePath(path, user))
            {
                context.Result = new JsonResult(new { message = "Unauthorized" }) { StatusCode = StatusCodes.Status401Unauthorized };
            }
        }

        private bool ValidatePath(string path, User user)
        {
            bool isValid = true;
            if (user.RolId == 2 && !path.ToUpper().Contains(AdminConstant.GetAll.ToUpper()))
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
