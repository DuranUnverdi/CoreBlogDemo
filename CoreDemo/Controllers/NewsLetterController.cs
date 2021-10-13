using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class NewsLetterController : Controller
    {
        [HttpGet]
        public IActionResult IndexSubscribeMail()
        {
            return PartialView();
        }
        [HttpPost] 
        public IActionResult IndexSubscribeMail(NewsLetter p)
        {
            
            return PartialView();
        }
    }
}
