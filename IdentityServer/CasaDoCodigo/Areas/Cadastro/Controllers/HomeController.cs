using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasaDoCodigo.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CasaDoCodigo.MVC.Areas.Cadastro.Controllers
{
    [Area("Cadastro")]
    public class HomeController : Controller
    {

        private readonly IPedidoRepository pedidoRepository;

        public HomeController(IPedidoRepository pedidoRepository)
        {
            this.pedidoRepository = pedidoRepository;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var pedido = await pedidoRepository.GetPedidoAsync();

            if (pedido == null)
            {
                return RedirectToAction("/");
            }

            /*var usuario = await userManager.GetUserAsync(this.User);

            pedido.Cadastro.Email = usuario.Email;
            pedido.Cadastro.Telefone = usuario.Telefone;
            pedido.Cadastro.Nome = usuario.Nome;
            pedido.Cadastro.Endereco = usuario.Endereco;
            pedido.Cadastro.Complemento = usuario.Complemento;
            pedido.Cadastro.Bairro = usuario.Bairro;
            pedido.Cadastro.Municipio = usuario.Municipio;
            pedido.Cadastro.UF = usuario.UF;
            pedido.Cadastro.CEP = usuario.CEP; */

            pedido.Cadastro.Nome = User.FindFirst("name")?.Value;
            pedido.Cadastro.Email = User.FindFirst("email")?.Value;

            return View(pedido.Cadastro);
        }

    }
}