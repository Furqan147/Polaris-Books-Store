﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PolarisBooks.StoreManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        #region Properties


        #endregion

        #region Constructor

        public BooksController()
        {

        }

        #endregion


        #region Public Actions

        public async Task<string> Ping()
        {
            try
            {
                return "Books controller is working......";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        #endregion

    }
}
