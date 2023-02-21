using Microsoft.AspNetCore.Mvc;

namespace PolarisBooks.StoreManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {

        #region Properties


        #endregion

        #region Constructor


        #endregion

        #region Public Actions

        public async Task<string> Ping()
        {
            try
            {
                return "Accounts controller is working........";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        #endregion

    }
}
