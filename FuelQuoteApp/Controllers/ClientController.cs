using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FuelQuoteApp.Models.Client;
using Microsoft.AspNetCore.Mvc;

namespace FuelQuoteApp.Controllers
{
    public class ClientController : Controller
    {
        [HttpGet]
        public IActionResult ClientDashBoard()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ClientProfile()
        {
            return View();
        }


        [HttpPost]
        public ActionResult ClientProfile(ClientProfileViewModel clientProfile)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("GetQuote", "Quote");
            }
            else
            {
                return View();
            }
       
        }

        public bool ClientProfileDataValidation(ClientProfileViewModel data)
        {
            bool flag = false;
            if ((data.FullName.Length <= 50) && (data.FullName != String.Empty))
            {
                if (((data.Address1.Length <= 100) && (data.Address1 != String.Empty)) && (data.Address2.Length <= 100))
                {
                    if ((data.City.Length <= 100) && (data.City != String.Empty))
                    {
                        if (data.ZipCode.Length <= 9 && data.ZipCode.Length >= 5)
                        {
                            flag = true;
                        }
                    }
                }
            }
            else
            {
                flag = false;
            }

            return flag;
        }
    }
}