using LanchesApp.Areas.Admin.Servicos;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace LanchesApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminGraficoController : Controller
    {
        private readonly GraficoVendasServicos _graficoVendas;

        public AdminGraficoController(GraficoVendasServicos graficoVendas)
        {
            _graficoVendas = graficoVendas ?? throw new ArgumentNullException(nameof(graficoVendas));
        }

        public JsonResult VendasLanches(int dias)
        {
            var lanchesVendasTotais = _graficoVendas.GetVendasLanche(dias);
            return Json(lanchesVendasTotais);
        }
        [HttpGet]
        public IActionResult Index(int dias)
        {
            return View();
        }
        [HttpGet]
        public IActionResult VendasMensal(int dias)
        {
            return View();
        }
        [HttpGet]
        public IActionResult VendasSemanal(int dias)
        {
            return View();
        }
    }
}
