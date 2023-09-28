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
        public JsonResult Display()
        {
            var Folders= Context.Folders.Where(c=>!c.ParentId.HasValue).ToList().Select(c=>new FolderModel(c)).ToList();
            return Json(Folders, JsonRequestBehavior.AllowGet);
        }
        //[HttpPost]
        //public JsonResult ToggleIsOpen(int folderId, bool isOpen)
        //{
        //    try
        //    {
        //        var folder = Context.Folders.Find(folderId);

        //        if (folder != null)
        //        {
        //            folder.IsOpen = isOpen;
        //            Context.SaveChanges(); 
        //            return Json(new { success = true });
        //        }
        //        else
        //        {
        //            return Json(new { success = false, message = "Folder not found." });
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(new { success = false, message = ex.Message });
        //    }
        //}

    }
}