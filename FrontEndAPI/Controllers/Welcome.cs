using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
using System;
using FrontEndAPI.Models;
using System.Collections.Generic;

namespace FrontEndAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Welcome : ControllerBase
    {
        public static IWebHostEnvironment _environment;

        public Welcome(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        // Welcome -------------------
        IList<UserInterface> welcome = new List<UserInterface>()
        {
            new UserInterface()
            {
               WelText = "Welcome"
            }
        };

        [HttpGet]
        public IList<UserInterface> GetAll()
        {
            //Return list of all employees
            return welcome;
        }

        // Welcome Banner -----------------
        [HttpGet("{filename}")]
        public async Task<IActionResult> BigContainer([FromRoute] string filename)
        {
            string path = _environment.WebRootPath + "\\uploads\\";
            var filePath = path + filename + ".jpg";
            if (System.IO.File.Exists(filePath))
            {
                byte[] b = System.IO.File.ReadAllBytes(filePath);
                return File(b, "image/jpg");
            }
            return null;
        }
    }
}
