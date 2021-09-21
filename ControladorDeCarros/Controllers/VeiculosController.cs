//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using WebMvcRazorCshap.Models;

//namespace WebMvcRazorCshap.Controllers
//{
//    public class VeiculosController : Controller
//    {
//        // GET: Veiculos
//        public ActionResult Adicionar()
//        {
//            ViewBag.Title = "Veiculos";
//            ViewBag.mensage = "Adicionar Veiculos";
//            return View();
//        }


//        [HttpPost]
//        public void Salvar()
//        {
//            var veiculo = new Adicionar();
//            veiculo.Id = Convert.ToInt32("0" + Request["id"]);
//            veiculo.Nome = Request["nome"];
//            veiculo.Modelo = Request["modelo"];
//            veiculo.Ano = Convert.ToInt16(Request["fabricacao"]);
//            veiculo.Fabricacao = Convert.ToInt16(Request["fabricacao"]);
//            veiculo.Cor = Request["cor"];
//            try
//            {
//                veiculo.Combustivel = Convert.ToByte(Request["combustivel"]);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Falha: " + ex.Message);
//            }
//            veiculo.Automatico = false;
//            veiculo.Valor = Convert.ToDecimal(Request["valor"]);
//            veiculo.Ativo = true;

//            veiculo.Salvar();

//            Response.Redirect("/Home/Veiculos");

//        }
//        public ActionResult Alterar(int id)
//        {
//            ViewBag.Title = "Veiculos";
//            ViewBag.mensage = "Alterar veiculos";

//            var veiculo = new Alterar();
//            veiculo.GetVeiculo(id);
//            ViewBag.veiculo = veiculo;

//            return View();
//        }
//        public ActionResult Excluir(int id)
//        {
//            ViewBag.Title = "Veiculos";
//            ViewBag.mensage = "Excluir veiculos";

//            var veiculo = new Alterar();
//            veiculo.GetVeiculo(id);
//            ViewBag.veiculo = veiculo;


//            return View();
//        }


//        [HttpPost]
//        public void Excluir()
//        {
//            var veiculo = new Remover();
//            veiculo.Id = Convert.ToInt32("0" + Request["id"]);


//            veiculo.Excluir();


//            Response.Redirect("/Home/Veiculos");

//        }
//    }
//}