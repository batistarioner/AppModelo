using DevIO.UI.Site.Data;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.UI.Site.Controllers
{
  public class HomeController : Controller
  {
    public IPedidoRepository _pedidoRepository;

    public HomeController(IPedidoRepository pedidoRepository)
    {
      _pedidoRepository = pedidoRepository;
    }

    public IActionResult Index()
    {
      var pedido = _pedidoRepository.ObterPedido();

      return View();
    }
  }
}