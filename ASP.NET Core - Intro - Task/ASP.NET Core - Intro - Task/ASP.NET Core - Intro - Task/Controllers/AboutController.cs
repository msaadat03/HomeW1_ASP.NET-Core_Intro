using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core___Intro___Task.Controllers
{
    public class AboutController : Controller
    {
        public string Index()
        {
            return "About page";
        }
    }
}
