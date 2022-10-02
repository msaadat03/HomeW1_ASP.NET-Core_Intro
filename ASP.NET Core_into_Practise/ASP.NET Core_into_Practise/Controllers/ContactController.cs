using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_into_Practise.Controllers
{
    public class ContactController : Controller
    {
        public string Index()
        {
            return "Contact page";
        }
    }
}
