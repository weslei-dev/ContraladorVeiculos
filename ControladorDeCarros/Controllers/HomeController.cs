using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMvcRazorCshap.Models;

namespace WebMvcRazorCshap.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //if (Session["Autorizado"] != null)
            //{
                return View();
            //}
            //else
            //{
            //    //Response.Redirect("/Login/Index");
            //    return RedirectToAction("Index", "Login");
            //}
        }


        //public ActionResult Veiculos()
        //{
        //    ViewBag.Title = "Vende-se";
        //    ViewBag.Mensagem = "Relação de Carros";

        //    if (Session["Autorizado"] != null)
        //    {

        //        List<Veiculo> lista = Veiculo.GetCarros();
        //        return View(lista);
        //    }
        //    else
        //    {
        //        //Response.Redirect("/Login/Index");
        //        return RedirectToAction("Index", "Login");

        //    }
        //}

        //public ActionResult Contact()
        //{
        //    if (Session["Autorizado"] != null)
        //    {
        //        ViewBag.Message = "Your contact page.";
        //        return View();
        //    }
        //    else
        //    {
        //        //Response.Redirect("/Login/Index");
        //        return RedirectToAction("Index", "Login");

        //    }
        //}
        //public ActionResult Integração()
        //{
        //    return View();
        //}
    }
}