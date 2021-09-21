//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using WebMvcRazorCshap.Models;

//namespace WebMvcRazorCshap.Controllers
//{
//    public class Login : Controller
//    {
//        // GET: Login
//        public ActionResult Index()
//        {

//            if (Session["Erro"] != null)
//            {
//                ViewBag.Erro = Session["Erro"].ToString();
//            }
//            return View();
//        }

//        [HttpPost]
//        public void ChecarLogin()
//        {
//            var usuario = new Usuario();
//            usuario.Email = Request["Email"];
//            usuario.Senha = Request["PassWord"];


//            if (usuario.Login())
//            {
//                Session["Autorizado"] = "ok";
//                Response.Redirect("/Home/Index");
//            }
//            else
//            {
//                Session["erros"] = "senha ou usuario invalido";
//                Response.Redirect("/Login/Index");
//            }
//        }

//        public ActionResult Registrar()
//        {
//            return View();
//        }

//        /* public ActionResult Aderir()
//         {
//             var Criar = new Pessoa(); 
//             Criar.Id = Convert.ToInt32("0" + Request["id"]);
//             Criar.Email = Request["email"];
//             Criar.Nome = Request["nome"];
//             Criar.Senha = Request["senha"];

//             return View();
//         }*/

//    }
//}