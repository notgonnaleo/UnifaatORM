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
            // TODO testar e ver se as querys funcionam corretamente
            Cliente requisicao = new Cliente();
            if (clienteId.Text != null) // Se o Id do cliente selecionado existir logo entao isso eh um update
            {
                requisicao.Id = int.Parse(clienteId.Text);
                requisicao.Nome = nomeCliente.Text;
                requisicao.Celular = clienteTelefone.Text;
                requisicao.Cpf = clienteCPF.Text;
            }
                requisicao.Id = 0; // Na realidade a gente nem precisa passar o parametro id pra criar algo no banco...
                requisicao.Nome = nomeCliente.Text;
                requisicao.Celular = clienteTelefone.Text;
                requisicao.Cpf = clienteCPF.Text;

            requisicao.Salvar(); // Salva o objeto com os dados da requisicao independente da acao que foi feita
            GetClientes(); // Lista retorno dos dados
        }
        

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // TODO Implementeder delete
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
            // Como setar cabecalho fixo: https://stackoverflow.com/questions/37458585/showing-empty-rows-in-datagridview-while-binding-with-datatable

            Cliente cliente = new Cliente();
            tableClientes.DataSource = cliente.Todos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // TODO: Implementar pesquisa por Id ou nome tanto faz
        }
    }
}
