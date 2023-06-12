using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Frota : Base
    {
        [OpcoesBase(ChavePrimaria = true, UsaBD = true, UsaBusca = true)]
        public int Id { get; set; }

        [OpcoesBase(UsaBD = true)]
        public string IdCliente { get; set; }

        [OpcoesBase(UsaBD = true)]
        public string Destino { get; set; }

        public new List<Frota> Todos()
        {
            List<Frota> frota = new List<Frota>();
            foreach(var ibase in base.Todos())
            {
                frota.Add((Frota)ibase);
            }
            return frota;
        }
    }
}
