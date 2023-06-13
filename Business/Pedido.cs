using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Pedido : Base
    {
        [OpcoesBase(ChavePrimaria = true, UsaBD = true, UsaBusca = true)]
        public int Id { get; set; }
        [OpcoesBase(UsaBD = true)]
        public int IdCliente { get; set; }
        [OpcoesBase(UsaBD = true)]
        public string NomeCliente { get; set; }
        [OpcoesBase(UsaBD = true)]
        public int IdProduto { get; set; }
        [OpcoesBase(UsaBD = true)]
        public string NomeProdPedido { get; set; }
        [OpcoesBase(UsaBD = true)]
        public int Qtde { get; set; }
        [OpcoesBase(UsaBD = true)]
        public string Cidade { get; set; }
        [OpcoesBase(UsaBD = true)]
        public DateTime DataPedido { get; set; }

        public new List<Pedido> Todos()
        {
            List<Pedido> pedidos = new List<Pedido>();
            foreach(var ibase in base.Todos())
            {
                pedidos.Add((Pedido)ibase);
            }
            return pedidos;
        }
    }
}
