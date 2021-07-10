using Meeting_7.DAL;
using Meeting_7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Meeting_7.Controllers
{
    public class HomeController : Controller
    {
        private readonly IQuestList<Quest> questList;
        public HomeController(IQuestList<Quest> questList)
        {
            this.questList = questList;
        }

        // GET: Home
        public ActionResult Index()
        {
            return View(questList.GetAll());
        }

        public ActionResult Quest(int id)
        {
            Quest buf = questList.GetItem(id);
            if(buf != null)
            {
                return View(buf);
            }
            return HttpNotFound("Quest was not found");
        }
    }
}