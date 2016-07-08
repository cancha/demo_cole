using Colegio_Jean.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Colegio_Jean.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(PersonalModel objPersonalModel)
        {
            Boolean logueado = string.IsNullOrEmpty((string)Session["usuario"]) ? objPersonalModel.autenticar() : false;
            
            if (logueado)
            {
                Session["usuario"] = objPersonalModel;
                return Index();
            }
            ViewBag.mensajeError = "Usuario o Contraseña Incorrectos";
            return Login();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
    }
}