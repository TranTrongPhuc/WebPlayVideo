using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebASPNETCore.Models;
using WebASPNETCore.Services;

namespace WebASPNETCore.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdmin _Admin;
        public AdminController(IAdmin _IAdmin)
        {
            _Admin = _IAdmin;
        }
        public IActionResult Index()
        {
            return View(_Admin.GetAdminsAll);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Admin model)
        {
            if(ModelState.IsValid)
            {
                _Admin.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                //error
                return NotFound();
            }
            else
            {
                Admin model = _Admin.GetAdminByID(Id);
                return View(model);
            }
        }
        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirm(int? Id)
        {
            _Admin.Remove(Id);
            return RedirectToAction("Index");
        }

    }
}