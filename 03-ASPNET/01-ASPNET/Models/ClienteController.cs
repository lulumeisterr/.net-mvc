using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_ASPNET.Models
{
    // 1 - Herdar de Controller
    // 2 - Actions
    // 3 - Acessa url e acessa o metodo da devida classe

    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            
            return View();
        }
    }
}