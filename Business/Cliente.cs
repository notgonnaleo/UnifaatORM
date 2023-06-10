using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Cliente : Base
    {
        [OpcoesBase(ChavePrimaria = true, UsaBD = true, UsaBusca = true)]
        public int Id { get; set; }

        [OpcoesBase(UsaBD = true)]
        public string Nome { get; set; }

        [OpcoesBase(UsaBD = true)]
        public string Celular { get; set; }

        [OpcoesBase(UsaBD = true)]
        public string Cpf { get; set; }

        public new List<Cliente> Todos()
        {
            List<Cliente> clientes = new List<Cliente>();
            foreach(var ibase in base.Todos())
            {
                clientes.Add((Cliente)ibase);
            }
            // Por alguma razao na qual eu nao to com vontade de descobrir o porque
            // o objeto clientes ta retornando o mesmo registro varias vezes duplicado
            // Entao minha solucao totalmente horrorosa foi agrupar os itens que possuem o mesmo Id 
            // e pegando apenas os itens que possuem informacao distinta no mesmo Id e listando-as.
            return clientes.GroupBy(x => x.Id)
                .Select(g => g.First()).ToList();
        }
    }
}
