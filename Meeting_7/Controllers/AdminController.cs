using Meeting_7.DAL;
using Meeting_7.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Meeting_7.Controllers
{
    public class AdminController : Controller
    {
        private readonly IQuestList<Quest> repository;
        public AdminController(IQuestList<Quest> repository)
        {
            this.repository = repository;
        }

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            Quest quest = new Quest();
            return View(quest);
        }
        [HttpPost]
        public ActionResult Add(Quest quest, HttpPostedFileBase image)
        {
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    quest.ImagePath = SaveImage(image);
                }
                repository.Create(quest);
                return RedirectToAction("Index", "Home");
            }
            return View(quest);
        }

        private string SaveImage(HttpPostedFileBase image)
        {
            string relativePath = Path.Combine("Files", image.FileName);
            string absolutePath = Server.MapPath($"~/{relativePath}");
            image.SaveAs(absolutePath);
            return relativePath;
        }
    }
}



////DB Code
//CREATE TABLE[dbo].Quests
//(
//	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
//	[Title] nvarchar(100) NOT NULL,
//	[Description] nvarchar(255) NOT NULL,
//	ImagePath nvarchar(max) NOT NULL,
//	Difficulty int NOT NULL,
//	Size nvarchar(10) NOT NULL,
//	[Time] int NOT NULL,
//	LongDescriptionHeader nvarchar(max) NOT NULL,
//	LongDescription nvarchar(max) NOT NULL,
//)

//GO

//CREATE PROCEDURE[dbo].AddQuest
//	@title nvarchar(100),
//	@description nvarchar(255),
//	@imagePath nvarchar(max),
//	@difficulty int,
//	@size nvarchar(10),
//	@time int,
//	@longDescriptionHeader nvarchar(max),
//	@longDescription nvarchar(max),
//	@id int OUTPUT
//AS
//	INSERT INTO Quests
//	VALUES(@title, @description, @imagePath, @difficulty, @size, @time, @longDescriptionHeader, @longDescription);
//SET @id = @@IDENTITY