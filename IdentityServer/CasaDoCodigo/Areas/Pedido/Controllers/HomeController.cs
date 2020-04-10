using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasaDoCodigo.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CasaDoCodigo.MVC.Areas.Pedido.Controllers
{
    [Area("Pedido")]
    public class HomeController : Controller
    {
        private readonly IPedidoRepository pedidoRepository;

        public HomeController(IPedidoRepository pedidoRepository)
        {
            this.pedidoRepository = pedidoRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Resumo(CasaDoCodigo.Models.Cadastro cadastro)
        {
            if (ModelState.IsValid)
            {
                /*var usuario = await userManager.GetUserAsync(this.User);

                usuario.Email       = cadastro.Email;
                usuario.Telefone    = cadastro.Telefone;
                usuario.Nome        = cadastro.Nome;
                usuario.Endereco    = cadastro.Endereco;
                usuario.Complemento = cadastro.Complemento;
                usuario.Bairro      = cadastro.Bairro;
                usuario.Municipio   = cadastro.Municipio;
                usuario.UF          = cadastro.UF;
                usuario.CEP         = cadastro.CEP;

                await userManager.UpdateAsync(usuario);*/

                return View(await pedidoRepository.UpdateCadastroAsync(cadastro));
            }
            return Redirect("/Cadastro");
        }



    }
}