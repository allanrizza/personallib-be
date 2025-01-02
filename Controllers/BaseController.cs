using Microsoft.AspNetCore.Mvc;
using personallib_be.Data;

namespace personallib_be.Controllers
{
    public class BaseController : Controller
    {
        protected DatabaseContext DbContext => (DatabaseContext)HttpContext.RequestServices.GetService(typeof(DatabaseContext));
    }
}
