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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            new Pedido().CriarTabela(); // Cria a tabela baseado no modelo escolhido assim que a tela carrega


            Cliente cliente = new Cliente();
            List<Cliente> todosClientes = cliente.Todos();
            cbClientes.DataSource = todosClientes;
            cbClientes.DisplayMember = "Nome";
            cbClientes.ValueMember = "Id";

            Produto produto = new Produto();
            List<Produto> todosProdutos = produto.Todos();
            cbProduto.DataSource = todosProdutos;
            cbProduto.DisplayMember = "Nome";
            cbProduto.ValueMember = "Id";

            LimpaCampos();
            GetPedidos();
        }

        private void GetPedidos()
        {
            tablePedidos.AutoGenerateColumns = false; // ja criei o cabecalho entao nao tem necessidade disso
            // Como setar cabecalho fixo: https://stackoverflow.com/questions/37458585/showing-empty-rows-in-datagridview-while-binding-with-datatable

            Pedido pedido = new Pedido();
            tablePedidos.DataSource = pedido.Todos();
        }

        private void tablePedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LimpaCampos()
        {
            // Limpa os campos (da pior forma possivel)
            cbClientes.SelectedItem = "";
            cbClientes.SelectedValue = "";

            cbProduto.SelectedItem = "";
            cbProduto.SelectedValue = "";

            pedidoId.Text = "";
            qtdeVal.Text = "";

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Pedido requisicao = new Pedido();

            // unico tipo de validacao que eu vo faze no sistema inteiro nao to nem ai
            if (cbClientes.SelectedItem == null || cbClientes.SelectedValue == null
                || cbProduto.SelectedItem == null || cbProduto.SelectedValue == null)
            {
                MessageBox.Show("Obrigatorio preencher campos.");
                return;
            }
            else
            {
                if (pedidoId.Text == null || pedidoId.Text == "") // Se o campo de id for null ou estiver vazio a gente vai modelar um objeto seguindo padrao de create
                {
                    Cliente clienteSelecionado = (Cliente)cbClientes.SelectedItem;
                    string nomeSelecionado = clienteSelecionado.Nome;
                    int idSelecionado = (int)cbClientes.SelectedValue;

                    Produto produtoSelecionado = (Produto)cbProduto.SelectedItem;
                    string nomeProdSelecionado = produtoSelecionado.Nome;
                    int idProdSelecionado = (int)cbProduto.SelectedValue;

                    requisicao.Id = 0; // Na realidade a gente nem precisa passar o parametro id pra criar algo no banco...
                    requisicao.IdCliente = idSelecionado;
                    requisicao.NomeCliente = nomeSelecionado;
                    requisicao.IdProduto = idProdSelecionado;
                    requisicao.NomeProdPedido = nomeProdSelecionado;
                    requisicao.Qtde = int.Parse(qtdeVal.Text);

                }
                else // Se o Id do cliente selecionado existir logo entao isso eh um update
                {
                    Cliente clienteSelecionado = (Cliente)cbClientes.SelectedItem;
                    string nomeSelecionado = clienteSelecionado.Nome;
                    int idSelecionado = (int)cbClientes.SelectedValue;

                    Produto produtoSelecionado = (Produto)cbProduto.SelectedItem;
                    string nomeProdSelecionado = produtoSelecionado.Nome;
                    int idProdSelecionado = (int)cbProduto.SelectedValue;

                    requisicao.Id = int.Parse(pedidoId.Text);
                    requisicao.IdCliente = idSelecionado;
                    requisicao.NomeCliente = nomeSelecionado;
                    requisicao.IdProduto = idProdSelecionado;
                    requisicao.NomeProdPedido = nomeProdSelecionado;
                    requisicao.Qtde = int.Parse(qtdeVal.Text);

                }
                requisicao.Salvar(); // Salva o objeto com os dados da requisicao independente da acao que foi feita
                LimpaCampos(); // Limpar os campos do form de cliente
                GetPedidos(); // Lista retorno dos dados
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            var id = int.Parse(pedidoId.Text);
            pedido.Excluir(id);
            GetPedidos(); // Lista retorno dos dados

        }

        private void GetPedido()
        {
            tablePedidos.AutoGenerateColumns = false; // ja criei o cabecalho entao nao tem necessidade disso
            // Como setar cabecalho fixo: https://stackoverflow.com/questions/37458585/showing-empty-rows-in-datagridview-while-binding-with-datatable

            Pedido pedido = new Pedido();

            var id = int.Parse(pedidoId.Text);

            var retorno = pedido.Buscar<Pedido>(id).FirstOrDefault(); // vou me matar

            if (retorno == null)
            {
                MessageBox.Show("Não encontrado");
                LimpaCampos();
                GetPedidos();
                return;
            }

            Cliente retornoCliente = new Cliente()
            {
                Id = retorno.IdCliente,
                Nome = retorno.NomeCliente
            };

            Produto retornoProduto = new Produto()
            {
                Id = retorno.IdProduto,
                Nome = retorno.NomeProdPedido
            };

            cbClientes.SelectedItem = retornoCliente.Nome;
            cbClientes.SelectedValue = retornoCliente.Id;

            cbProduto.SelectedItem = retornoProduto.Nome;
            cbProduto.SelectedValue = retornoProduto.Id;

            pedido.Id = id;
            qtdeVal.Text = retorno.Qtde.ToString();

            tablePedidos.DataSource = new List<Pedido>() { retorno };
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            GetPedido();
        }
    }
}
