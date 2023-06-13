using Database;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            Cliente requisicao = new Cliente();

                if (clienteId.Text == null || clienteId.Text == "") // Se o campo de id for null ou estiver vazio a gente vai modelar um objeto seguindo padrao de create
                {
                    requisicao.Id = 0; // Na realidade a gente nem precisa passar o parametro id pra criar algo no banco...
                    requisicao.Nome = nomeCliente.Text;
                    requisicao.Celular = clienteTelefone.Text;
                    requisicao.Cpf = clienteCPF.Text;
                }
                else // Se o Id do cliente selecionado existir logo entao isso eh um update
                {
                    requisicao.Id = int.Parse(clienteId.Text);
                    requisicao.Nome = nomeCliente.Text;
                    requisicao.Celular = clienteTelefone.Text;
                    requisicao.Cpf = clienteCPF.Text;
                }
                requisicao.Salvar(); // Salva o objeto com os dados da requisicao independente da acao que foi feita


                LimpaCampos(); // Limpar os campos do form de cliente
                GetClientes(); // Lista retorno dos dados                    
        }
        private void LimpaCampos()
        {
            // Limpa os campos (da pior forma possivel)
            clienteId.Text = "";
            nomeCliente.Text = "";
            clienteTelefone.Text = "";
            clienteCPF.Text = "";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            var id = int.Parse(clienteId.Text);
            cliente.Excluir(id);
            GetClientes();
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

        private void GetCliente()
        {
            tableClientes.AutoGenerateColumns = false; // ja criei o cabecalho entao nao tem necessidade disso
            // Como setar cabecalho fixo: https://stackoverflow.com/questions/37458585/showing-empty-rows-in-datagridview-while-binding-with-datatable

            Cliente cliente = new Cliente();

            var id = int.Parse(clienteId.Text);

            var retorno = cliente.Buscar<Cliente>(id).FirstOrDefault(); // pega o primeiro que vier 

            if (retorno == null)
            {
                MessageBox.Show("Não encontrado");
                LimpaCampos();
                GetClientes();
                return;
            }

            cliente.Id = id;
            nomeCliente.Text = retorno.Nome;
            clienteCPF.Text = retorno.Cpf;
            clienteTelefone.Text = retorno.Celular;

            tableClientes.DataSource = new List<Cliente>() { retorno };
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            GetCliente();
        }

        private void btnPgClientes_Click(object sender, EventArgs e)
        {

        }

        private void btnPgProdutos_Click(object sender, EventArgs e)
        {
            Form2 produtos = new Form2();

            produtos.Show();
            this.Hide();
        }

        private void btnPgPedidos_Click(object sender, EventArgs e)
        {
            Form3 pedido = new Form3();

            pedido.Show();
            this.Hide();
        }

        private void btnPgFrotas_Click(object sender, EventArgs e)
        {
        }

        private void btnPgEncomendas_Click(object sender, EventArgs e)
        {

        }

        private void cbCidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
