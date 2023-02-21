using System.Security.Claims;

namespace PolarisBooks.StoreManagement.API.Services
{
    public class LoggedInUserService
    {

        #region Properties

        public string UserId { get; }

        #endregion

        #region Constructor

        public LoggedInUserService(HttpContextAccessor httpContextAccessor)
        {
            UserId = httpContextAccessor?.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier) ?? string.Empty;
        }

        #endregion

    }
}
