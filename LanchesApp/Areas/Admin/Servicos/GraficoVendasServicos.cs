using LanchesApp.Context;
using LanchesApp.Models;
using Microsoft.VisualBasic;
using NuGet.DependencyResolver;

namespace LanchesApp.Areas.Admin.Servicos
{
    public class GraficoVendasServicos
    {
        private readonly AppDbContext _context;

        public GraficoVendasServicos(AppDbContext context)
        {
            _context = context;
        }

        public List<LanchesGrafico> GetVendasLanche(int dias = 360)
        {
            var data = DateTime.Now.AddDays(-360);
            var lanches = (from pd in _context.PedidosDetalhe
                           join l in _context.Lanches on pd.LancheId equals l.LancheId
                           where pd.Pedido.PedidoEnviado >= data
                           group pd by new {pd.LancheId, l.Nome, pd.Quantidade}
                           into g
                           select new
                           {
                               LancheNome = g.Key.Nome,
                               LanchesQuantidade = g.Sum(q => q.Quantidade),
                               LanchesValorTotal = g.Sum(a => a.Quantidade * a.Preco)
                           });
            var lista = new List<LanchesGrafico>();

            foreach (var item in lanches) 
            {
                var lanche = new LanchesGrafico();
                lanche.LancheNome = item.LancheNome;
                lanche.LanchesQuantidade = item.LanchesQuantidade;
                lanche.LanchesValorTotal = item.LanchesValorTotal;
                lista.Add(lanche);
            }
            return lista;

        }
    }
}
