using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;

namespace LeoKayProject.Controllers
{
    [Route("api/logincontroller")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpGet]
        public IHttpActionResult GetData()
        {
            // Xử lý logic để lấy dữ liệu từ nguồn nào đó
            var data = GetDataFromSource();

            // Trả về dữ liệu dưới dạng JSON
            return Json(data);
        }

        private object GetDataFromSource()
        {
            // Xử lý logic để lấy dữ liệu từ nguồn nào đó
            // Ví dụ: truy vấn cơ sở dữ liệu, gọi API bên ngoài, vv.
            // Trả về dữ liệu dưới dạng object
            return new { Name = "John Doe", Age = 30 };
        }

    }
}
