using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ACMVT.SignlR.WebChatServer.Controllers
{
    public class ChatController : Controller
    {
        [Route("")]
        [Route("Chat")]
        [Route("Chat/Index")]
        public ActionResult Index()
        {
            return View();
        }
    }
}