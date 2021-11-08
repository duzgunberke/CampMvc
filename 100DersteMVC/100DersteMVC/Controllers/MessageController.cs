using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _100DersteMVC.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        MessageManager messageManager = new MessageManager(new EFMessageDal());
        MessageValidator messageValidator = new MessageValidator();
        public ActionResult Inbox()
        {
            var messsageList = messageManager.GetListInbox();
            return View(messsageList);
        }

        public ActionResult SendBox()
        {
            var messageList = messageManager.GetListSendbox();
            return View(messageList);
        }

        public ActionResult GetInBoxMessageDetails(int id)
        {
            var Values = messageManager.GetByID(id);
            return View(Values);
        }

        public ActionResult GetSendBoxMessageDetails(int id)
        {
            var Values = messageManager.GetByID(id);
            return View(Values);
        }

        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(Message message)
        {
            ValidationResult result = messageValidator.Validate(message);
            if (result.IsValid)
            {
                message.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                messageManager.MessageAdd(message);
                return RedirectToAction("SendBox");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
            
        }
    }
}