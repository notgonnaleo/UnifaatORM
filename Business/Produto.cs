using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Produto : Base
    {
        [OpcoesBase(ChavePrimaria = true, UsaBD = true, UsaBusca = true)]
        public int Id { get; set; }
        [OpcoesBase(UsaBD = true)]
        public string Nome { get; set; }

        public new List<Produto> Todos()
        {
            List<Produto> produtos = new List<Produto>();
            foreach(var ibase in base.Todos())
            {
                produtos.Add((Produto)ibase);
            }
            return produtos;
        }
    }
}
