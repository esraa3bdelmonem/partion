using Partion.DataAccess;
using Partion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Partion.Controllers
{
    public class FolderController : Controller
    {
        // GET: Folder
        FolderContext Context;
        public FolderController()
        {
            Context = new FolderContext();
        }
        public ActionResult Index()
        {
            return View();
        }
     
        public JsonResult Display(int? ParentId= null)
        {
            var Folders= Context.Folders.Where(c=>c.ParentId == ParentId).ToList().Select(c=>new FolderModel(c)).ToList();
            return Json(Folders, JsonRequestBehavior.AllowGet);
        }
        

    }
}