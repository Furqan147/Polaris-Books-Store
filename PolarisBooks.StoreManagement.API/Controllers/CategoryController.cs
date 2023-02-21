using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PolarisBooks.StoreManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        #region Properties



        #endregion

        #region Constructor

        public CategoryController()
        {

        }

        #endregion

        #region Public Actions

        public async Task<string> Ping()
        {
            try
            {
                return "Category Controller is working.....";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        #endregion

    }
}
