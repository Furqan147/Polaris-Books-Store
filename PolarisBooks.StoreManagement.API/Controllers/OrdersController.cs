using Microsoft.AspNetCore.Mvc;

namespace PolarisBooks.StoreManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {

        #region Properties


        #endregion

        #region Constructor

        public OrdersController()
        {

        }

        #endregion

        #region Public Actions

        public async Task<string> Ping()
        {
            try
            {
                return "Orders controller is working.......";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        #endregion

    }
}
