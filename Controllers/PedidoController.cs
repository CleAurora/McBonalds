using McBonalds.Models;
using McBonalds.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hamburgueria.Controllers
{
    public class PedidoController : Controller
    {
        private PedidoRepositorio Repositorio = new PedidoRepositorio();
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistrarPedido(IFormCollection form)
        {
            System.Console.WriteLine(form["nome"]);
            System.Console.WriteLine(form["endereco"]);
            System.Console.WriteLine(form["telefone"]);
            System.Console.WriteLine(form["email"]);
            System.Console.WriteLine(form["hamburguer"]);
            System.Console.WriteLine(form["shake"]);

            Pedido pedido = new Pedido();

            Cliente cliente = new Cliente();
            cliente.Nome = form["nome"];
            cliente.Endereco = form["endereco"];
            cliente.Telefone = form["telefone"];
            cliente.Email = form["email"];

            pedido.Cliente = cliente;//linkando o pedido ao cliente

            //Forma 2 - Usa parâmetros nos contrutores
            Hamburguer hamburguer = new Hamburguer(
                Nome: form["hamburguer"]
            );

            pedido.Hamburguer = hamburguer;

            // Forma 3 Resumo da forma 1
            Shake shake = new Shake(){
                Nome = form["Shake"]
            };

            pedido.Shake = shake;

            Repositorio.Inserir(pedido);
            
            return RedirectToAction("Index", "Home");
        }
    }
}