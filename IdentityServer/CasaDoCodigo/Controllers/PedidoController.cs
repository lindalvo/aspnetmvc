using CasaDoCodigo.Areas.Identity.Data;
using CasaDoCodigo.Models;
using CasaDoCodigo.Models.ViewModels;
using CasaDoCodigo.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IProdutoRepository produtoRepository;
        private readonly IPedidoRepository pedidoRepository;
        private readonly UserManager<AppIdentityUser> userManager;

        public PedidoController(IProdutoRepository produtoRepository,
            IPedidoRepository pedidoRepository,
            UserManager<AppIdentityUser> userManager)
        {
            this.produtoRepository = produtoRepository;
            this.pedidoRepository = pedidoRepository;
            this.userManager = userManager;
        }

        public async Task<IActionResult> Carrossel()
        {
            return View(await produtoRepository.GetProdutosAsync());
        }



    }
}
