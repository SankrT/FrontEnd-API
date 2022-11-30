using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEndAPI.Models
{
    public class UserInterface
    {
        public string WelText { get; set; }
    }

    public class BigContainer
    {
        public IFormFile ConImg { get; set; }
    }

    public class SaveInvestment
    {
        public string SI_Name { get; set; }
    }

    public class SaveInvestmentTag
    {
        public string SI_Tagline { get; set; }
    }

    public class DigitalGold
    {
        public string DG_Name { get; set; }
    }

    public class DigitalGoldImg
    {
        public IFormFile DG_Img { get; set; }
    }

    public class DigitalSilver
    {
        public string DS_Name { get; set; }
    }

    public class DigitalSilverImg
    {
        public IFormFile DS_Img { get; set; }
    }

    public class MutalFund
    {
        public string MF_Name { get; set; }
    }

    public class MutalFundImg
    {
        public IFormFile MF_Img { get; set; }
    }

    public class FixedDeposite
    {
        public string FD_Name { get; set; }
    }

    public class FixedDepositeImg
    {
        public IFormFile FD_Img { get; set; }
    }

    public class Other
    {
        public string Othr_Name { get; set; }
    }

    public class OtherImg
    {
        public IFormFile Oth_Img { get; set; }
    }

    public class mayaTagLine
    {
        public string mayaTag { get; set; }
    }

}
