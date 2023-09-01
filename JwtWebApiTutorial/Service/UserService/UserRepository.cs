using System.Security.Claims;

namespace JwtWebApiTutorial.Service.UserService
{
    public class UserRepository : IUserService
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public UserRepository(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }
        public string GetMyName()
        {
            var result = string.Empty;
            if(_contextAccessor.HttpContext != null)
            {
                result = _contextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
            }
            return result;
        }
    }
}
