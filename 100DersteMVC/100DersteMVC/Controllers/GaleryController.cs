using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _100DersteMVC.Controllers
{
    public class GaleryController : Controller
    {
        // GET: Galery
        ImageManager ımageManager = new ImageManager(new EFImageDal());
        public ActionResult Index()
        {
            var files = ımageManager.GetList();
            return View(files);
        }
    }
}