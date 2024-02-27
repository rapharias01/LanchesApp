using LanchesApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanchesApp.ViewModels
{
    public class PedidoLancheViewModel
    {
        public Pedido Pedido{ get; set; }
        public IEnumerable<PedidoDetalhe> PedidoDetalhes{ get; set; }
    }
}
