using FrontEndAPI.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEndAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaveInvestmentController : ControllerBase
    {
        public IWebHostEnvironment _environment;

        public SaveInvestmentController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        // Sale & investment ---------------------
        IList<SaveInvestment> saveInvestments = new List<SaveInvestment>()
        {
            new SaveInvestment()
            {
                SI_Name = "Save & Invest"
            }
        };

        [HttpGet]
        public IList<SaveInvestment> GetAll()
        {
            return saveInvestments;
        }

        // Sale Investment Tag -------------------
        IList<SaveInvestmentTag> saveInvestmentTags = new List<SaveInvestmentTag>()
        {
            new SaveInvestmentTag()
            {
                SI_Tagline = "Interactive savings & Investment options"
            }
        };


        [HttpGet("TagLine")]
        public IList<SaveInvestmentTag> GetTagLine()
        {
            return saveInvestmentTags;
        }

    }
}
