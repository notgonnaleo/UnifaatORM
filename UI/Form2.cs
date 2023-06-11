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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto requisicao = new Produto();

            if (produtoId.Text == null || produtoId.Text == "") // Se o campo de id for null ou estiver vazio a gente vai modelar um objeto seguindo padrao de create
            {
                requisicao.Id = 0; // Na realidade a gente nem precisa passar o parametro id pra criar algo no banco...
                requisicao.Nome = nomeProduto.Text;

            }
            else // Se o Id do cliente selecionado existir logo entao isso eh um update
            {
                requisicao.Id = int.Parse(produtoId.Text);
                requisicao.Nome = nomeProduto.Text;
            }
            requisicao.Salvar(); // Salva o objeto com os dados da requisicao independente da acao que foi feita


            LimpaCampos(); // Limpar os campos do form de cliente
            GetProdutos(); // Lista retorno dos dados
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            GetProduto();
        }
        private void LimpaCampos()
        {
            // Limpa os campos (da pior forma possivel)
            produtoId.Text = "";
            nomeProduto.Text = "";

        }
        private void GetProduto()
        {
            tableProdutos.AutoGenerateColumns = false; // ja criei o cabecalho entao nao tem necessidade disso
            // Como setar cabecalho fixo: https://stackoverflow.com/questions/37458585/showing-empty-rows-in-datagridview-while-binding-with-datatable

            Produto produto = new Produto();

            var id = int.Parse(produtoId.Text);

            var retorno = produto.Buscar<Produto>(id).FirstOrDefault(); // vou me matar

            if (retorno == null)
            {
                MessageBox.Show("Não encontrado");
                LimpaCampos();
                GetProdutos();
                return;
            }

            produto.Id = id;
            nomeProduto.Text = retorno.Nome;

            tableProdutos.DataSource = new List<Produto>() { retorno };
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            var id = int.Parse(produtoId.Text);
            produto.Excluir(id);
        }

        private void nomeProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void produtoId_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            new Produto().CriarTabela(); // Cria a tabela baseado no modelo escolhido assim que a tela carrega
            GetProdutos(); // Executa o fetch de dados da tabela da tela escolhida
        }

        private void GetProdutos()
        {
            tableProdutos.AutoGenerateColumns = false; // ja criei o cabecalho entao nao tem necessidade disso
            // Como setar cabecalho fixo: https://stackoverflow.com/questions/37458585/showing-empty-rows-in-datagridview-while-binding-with-datatable

            Produto produto = new Produto();
            tableProdutos.DataSource = produto.Todos();
        }

        private void btnPgClientes_Click(object sender, EventArgs e)
        {

        }

        private void btnPgProdutos_Click(object sender, EventArgs e)
        {
            Form1 clientes = new Form1();

            clientes.Show();
            this.Hide();
        }
    }
}
