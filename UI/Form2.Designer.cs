namespace ProjetoORM
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.produtoId = new System.Windows.Forms.TextBox();
            this.nomeProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tableProdutos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPgEncomendas = new System.Windows.Forms.Button();
            this.btnPgFrotas = new System.Windows.Forms.Button();
            this.btnPgPedidos = new System.Windows.Forms.Button();
            this.btnPgProdutos = new System.Windows.Forms.Button();
            this.btnPgClientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // produtoId
            // 
            this.produtoId.Location = new System.Drawing.Point(112, 33);
            this.produtoId.Name = "produtoId";
            this.produtoId.Size = new System.Drawing.Size(100, 20);
            this.produtoId.TabIndex = 0;
            this.produtoId.TextChanged += new System.EventHandler(this.produtoId_TextChanged);
            // 
            // nomeProduto
            // 
            this.nomeProduto.Location = new System.Drawing.Point(291, 33);
            this.nomeProduto.Name = "nomeProduto";
            this.nomeProduto.Size = new System.Drawing.Size(100, 20);
            this.nomeProduto.TabIndex = 1;
            this.nomeProduto.TextChanged += new System.EventHandler(this.nomeProduto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(250, 36);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 3;
            this.Nome.Text = "Nome";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(576, 62);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 15;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(657, 33);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(576, 33);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tableProdutos
            // 
            this.tableProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dataGridViewTextBoxColumn1});
            this.tableProdutos.Location = new System.Drawing.Point(188, 169);
            this.tableProdutos.Name = "tableProdutos";
            this.tableProdutos.Size = new System.Drawing.Size(442, 189);
            this.tableProdutos.TabIndex = 12;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // btnPgEncomendas
            // 
            this.btnPgEncomendas.Location = new System.Drawing.Point(534, 368);
            this.btnPgEncomendas.Name = "btnPgEncomendas";
            this.btnPgEncomendas.Size = new System.Drawing.Size(83, 70);
            this.btnPgEncomendas.TabIndex = 21;
            this.btnPgEncomendas.Text = "Encomendas";
            this.btnPgEncomendas.UseVisualStyleBackColor = true;
            // 
            // btnPgFrotas
            // 
            this.btnPgFrotas.Location = new System.Drawing.Point(453, 368);
            this.btnPgFrotas.Name = "btnPgFrotas";
            this.btnPgFrotas.Size = new System.Drawing.Size(75, 70);
            this.btnPgFrotas.TabIndex = 20;
            this.btnPgFrotas.Text = "Frotas";
            this.btnPgFrotas.UseVisualStyleBackColor = true;
            // 
            // btnPgPedidos
            // 
            this.btnPgPedidos.Location = new System.Drawing.Point(372, 368);
            this.btnPgPedidos.Name = "btnPgPedidos";
            this.btnPgPedidos.Size = new System.Drawing.Size(75, 70);
            this.btnPgPedidos.TabIndex = 19;
            this.btnPgPedidos.Text = "Pedidos";
            this.btnPgPedidos.UseVisualStyleBackColor = true;
            // 
            // btnPgProdutos
            // 
            this.btnPgProdutos.Location = new System.Drawing.Point(291, 368);
            this.btnPgProdutos.Name = "btnPgProdutos";
            this.btnPgProdutos.Size = new System.Drawing.Size(75, 70);
            this.btnPgProdutos.TabIndex = 18;
            this.btnPgProdutos.Text = "Produtos";
            this.btnPgProdutos.UseVisualStyleBackColor = true;
            this.btnPgProdutos.Click += new System.EventHandler(this.btnPgProdutos_Click);
            // 
            // btnPgClientes
            // 
            this.btnPgClientes.Location = new System.Drawing.Point(210, 368);
            this.btnPgClientes.Name = "btnPgClientes";
            this.btnPgClientes.Size = new System.Drawing.Size(75, 70);
            this.btnPgClientes.TabIndex = 17;
            this.btnPgClientes.Text = "Clientes";
            this.btnPgClientes.UseVisualStyleBackColor = true;
            this.btnPgClientes.Click += new System.EventHandler(this.btnPgClientes_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPgEncomendas);
            this.Controls.Add(this.btnPgFrotas);
            this.Controls.Add(this.btnPgPedidos);
            this.Controls.Add(this.btnPgProdutos);
            this.Controls.Add(this.btnPgClientes);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tableProdutos);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomeProduto);
            this.Controls.Add(this.produtoId);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox produtoId;
        private System.Windows.Forms.TextBox nomeProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView tableProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnPgEncomendas;
        private System.Windows.Forms.Button btnPgFrotas;
        private System.Windows.Forms.Button btnPgPedidos;
        private System.Windows.Forms.Button btnPgProdutos;
        private System.Windows.Forms.Button btnPgClientes;
    }
}