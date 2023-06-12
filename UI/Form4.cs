using Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoORM
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void GetFrotas()
        {
            tableFrotas.AutoGenerateColumns = false; // ja criei o cabecalho entao nao tem necessidade disso
            // Como setar cabecalho fixo: https://stackoverflow.com/questions/37458585/showing-empty-rows-in-datagridview-while-binding-with-datatable

            Frota frota = new Frota();
            tableFrotas.DataSource = frota.Todos();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            new Frota().CriarTabela(); // Cria a tabela baseado no modelo escolhido assim que a tela carrega

            Cliente cliente = new Cliente();
            List<Cliente> todosClientes = cliente.Todos();
            cbClientes.DataSource = todosClientes;
            cbClientes.DisplayMember = "Nome";
            cbClientes.ValueMember = "Id";

            GetFrotas();
        }

        private void tableFrotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
