using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using FrontEndAPI.Models;

namespace FrontEndAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElementsController : ControllerBase
    {
        public IWebHostEnvironment _environment;

        public ElementsController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        // Digital Gold Text ---------------
        IList<DigitalGold> digitalGolds = new List<DigitalGold>()
        {
            new DigitalGold()
            {
                DG_Name = "Digital Gold"
            }
        };

        [HttpGet("Gold")]
        public IList<DigitalGold> GetGolds() 
        {
            return digitalGolds;
        }
        

        // Digital Gold Image ----------------
        [HttpGet("Gold/{filename}")]
        public async Task<IActionResult> DigitalGoldImage([FromRoute] string filename)
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

        // Digital Silver --------------------
        IList<DigitalSilver> digitalSilvers = new List<DigitalSilver>()
        {
            new DigitalSilver() 
            {
                DS_Name = "Digital Silver"
            }
        };

        [HttpGet("Silver")]
        public IList<DigitalSilver> GetSilvers() 
        {
            return digitalSilvers;
        }

        // Digital Silver Image---------------
        [HttpGet("Silver/{filename}")]
        public async Task<ActionResult> DigitalSilverImage([FromRoute] string filename)
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

        // Mutual Fund ------------------
        IList<MutalFund> mutalFunds = new List<MutalFund>()
        { 
            new MutalFund()
            {
                MF_Name = "Mutal Fund"
            }
        };

        [HttpGet("MutalFund")]
        public IList<MutalFund> GetMutalFunds() 
        {
            return mutalFunds;
        }

        // Mutual Fund Image ----------------
        [HttpGet("MutalFund/{filename}")]
        public async Task<ActionResult> MutalFundImage([FromRoute] string filename)
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

        // Fixed Deposite --------------------
        IList<FixedDeposite> fixedDeposites = new List<FixedDeposite>()
        {
            new FixedDeposite()
            {
                FD_Name = "Fixed Deposit"
            }
        };

        [HttpGet("FixedDeposit")]
        public IList<FixedDeposite> GetFixedDeposit()
        {
            return fixedDeposites;
        }

        // Fixed Deposite Image ------------------
        [HttpGet("FixedDeposit/{filename}")]
        public async Task<ActionResult> FixedDepositImage([FromRoute] string filename)
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

        // Other ----------------
        IList<Other> others = new List<Other>() 
        {
            new Other() 
            {
                Othr_Name = "Extra Field"
            }
        };

        [HttpGet("Extra")]
        public IList<Other> GetOther() 
        {
            return others;
        }

        // Other Image --------------
        [HttpGet("Extra/{filename}")]
        public async Task<ActionResult> OtherImage([FromRoute] string filename)
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

        // Dream Banner -------------------
        [HttpGet("DreamBanner/{filename}")]
        public async Task<ActionResult> DreamImage([FromRoute] string filename)
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

        // Maya Tag Line -------------------
        IList<mayaTagLine> mayaTagLines = new List<mayaTagLine>()
        {
            new mayaTagLine() 
            {
                mayaTag = "Create financially smart families"
            }
        };

        [HttpGet("MyayTagLine")]
        public IList<mayaTagLine> GetMayaTag()
        {
            return mayaTagLines;
        }


    }
}
