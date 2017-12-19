using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;
using MyMediaBox.Models;

namespace MyMediaBox.Controllers
{
    public class ProjectsController : Controller
    {
        // GET: Projects
        public ActionResult AllProjects()
        {
            AllProjects proj;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(AllProjects));
            using (FileStream fileStream = new FileStream(Server.MapPath("/App_Data/Project.xml"), FileMode.Open))
            {
                proj = (AllProjects)xmlSerializer.Deserialize(fileStream);
            }
            return View("Projects", proj);
        }
    }
}