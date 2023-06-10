using Business;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clienteId_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void clienteCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void clienteTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void tableClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new Cliente().CriarTabela(); // Cria a tabela baseado no modelo escolhido assim que a tela carrega
            GetClientes(); // Executa o fetch de dados da tabela da tela escolhida
        }

        private void GetClientes()
        {
            tableClientes.AutoGenerateColumns = false; // ja criei o cabecalho entao nao tem necessidade disso

            Cliente cliente = new Cliente();
            tableClientes.DataSource = cliente.Todos();
        }
    }
}
