namespace ProjetoORM
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tableClientes = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clienteId = new System.Windows.Forms.TextBox();
            this.nomeCliente = new System.Windows.Forms.TextBox();
            this.clienteCPF = new System.Windows.Forms.TextBox();
            this.clienteTelefone = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnPgClientes = new System.Windows.Forms.Button();
            this.btnPgProdutos = new System.Windows.Forms.Button();
            this.btnPgPedidos = new System.Windows.Forms.Button();
            this.btnPgFrotas = new System.Windows.Forms.Button();
            this.btnPgEncomendas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableClientes
            // 
            this.tableClientes.BackgroundColor = System.Drawing.Color.White;
            this.tableClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Celular,
            this.Cpf});
            this.tableClientes.Location = new System.Drawing.Point(175, 155);
            this.tableClientes.Name = "tableClientes";
            this.tableClientes.Size = new System.Drawing.Size(443, 189);
            this.tableClientes.TabIndex = 1;
            this.tableClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableClientes_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "Celular";
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            // 
            // Cpf
            // 
            this.Cpf.DataPropertyName = "Cpf";
            this.Cpf.HeaderText = "Cpf";
            this.Cpf.Name = "Cpf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(55, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(242, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(242, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefone";
            // 
            // clienteId
            // 
            this.clienteId.Location = new System.Drawing.Point(119, 27);
            this.clienteId.Name = "clienteId";
            this.clienteId.Size = new System.Drawing.Size(100, 20);
            this.clienteId.TabIndex = 5;
            this.clienteId.TextChanged += new System.EventHandler(this.clienteId_TextChanged);
            // 
            // nomeCliente
            // 
            this.nomeCliente.Location = new System.Drawing.Point(119, 74);
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.Size = new System.Drawing.Size(100, 20);
            this.nomeCliente.TabIndex = 6;
            this.nomeCliente.TextChanged += new System.EventHandler(this.nomeCliente_TextChanged);
            // 
            // clienteCPF
            // 
            this.clienteCPF.Location = new System.Drawing.Point(291, 27);
            this.clienteCPF.Name = "clienteCPF";
            this.clienteCPF.Size = new System.Drawing.Size(100, 20);
            this.clienteCPF.TabIndex = 7;
            this.clienteCPF.TextChanged += new System.EventHandler(this.clienteCPF_TextChanged);
            // 
            // clienteTelefone
            // 
            this.clienteTelefone.Location = new System.Drawing.Point(323, 71);
            this.clienteTelefone.Name = "clienteTelefone";
            this.clienteTelefone.Size = new System.Drawing.Size(100, 20);
            this.clienteTelefone.TabIndex = 8;
            this.clienteTelefone.TextChanged += new System.EventHandler(this.clienteTelefone_TextChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(565, 87);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(68, 47);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(639, 88);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(68, 46);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(493, 88);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(66, 46);
            this.btnPesquisar.TabIndex = 11;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnPgClientes
            // 
            this.btnPgClientes.Location = new System.Drawing.Point(196, 368);
            this.btnPgClientes.Name = "btnPgClientes";
            this.btnPgClientes.Size = new System.Drawing.Size(75, 70);
            this.btnPgClientes.TabIndex = 12;
            this.btnPgClientes.Text = "Clientes";
            this.btnPgClientes.UseVisualStyleBackColor = true;
            this.btnPgClientes.Click += new System.EventHandler(this.btnPgClientes_Click);
            // 
            // btnPgProdutos
            // 
            this.btnPgProdutos.Location = new System.Drawing.Point(277, 368);
            this.btnPgProdutos.Name = "btnPgProdutos";
            this.btnPgProdutos.Size = new System.Drawing.Size(75, 70);
            this.btnPgProdutos.TabIndex = 13;
            this.btnPgProdutos.Text = "Produtos";
            this.btnPgProdutos.UseVisualStyleBackColor = true;
            this.btnPgProdutos.Click += new System.EventHandler(this.btnPgProdutos_Click);
            // 
            // btnPgPedidos
            // 
            this.btnPgPedidos.Location = new System.Drawing.Point(358, 368);
            this.btnPgPedidos.Name = "btnPgPedidos";
            this.btnPgPedidos.Size = new System.Drawing.Size(75, 70);
            this.btnPgPedidos.TabIndex = 14;
            this.btnPgPedidos.Text = "Pedidos";
            this.btnPgPedidos.UseVisualStyleBackColor = true;
            this.btnPgPedidos.Click += new System.EventHandler(this.btnPgPedidos_Click);
            // 
            // btnPgFrotas
            // 
            this.btnPgFrotas.Location = new System.Drawing.Point(439, 368);
            this.btnPgFrotas.Name = "btnPgFrotas";
            this.btnPgFrotas.Size = new System.Drawing.Size(75, 70);
            this.btnPgFrotas.TabIndex = 15;
            this.btnPgFrotas.Text = "Frotas";
            this.btnPgFrotas.UseVisualStyleBackColor = true;
            this.btnPgFrotas.Click += new System.EventHandler(this.btnPgFrotas_Click);
            // 
            // btnPgEncomendas
            // 
            this.btnPgEncomendas.Location = new System.Drawing.Point(520, 368);
            this.btnPgEncomendas.Name = "btnPgEncomendas";
            this.btnPgEncomendas.Size = new System.Drawing.Size(83, 70);
            this.btnPgEncomendas.TabIndex = 16;
            this.btnPgEncomendas.Text = "Encomendas";
            this.btnPgEncomendas.UseVisualStyleBackColor = true;
            this.btnPgEncomendas.Click += new System.EventHandler(this.btnPgEncomendas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPgEncomendas);
            this.Controls.Add(this.btnPgFrotas);
            this.Controls.Add(this.btnPgPedidos);
            this.Controls.Add(this.btnPgProdutos);
            this.Controls.Add(this.btnPgClientes);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.clienteTelefone);
            this.Controls.Add(this.clienteCPF);
            this.Controls.Add(this.nomeCliente);
            this.Controls.Add(this.clienteId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableClientes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tableClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox clienteId;
        private System.Windows.Forms.TextBox nomeCliente;
        private System.Windows.Forms.TextBox clienteCPF;
        private System.Windows.Forms.TextBox clienteTelefone;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnPgClientes;
        private System.Windows.Forms.Button btnPgProdutos;
        private System.Windows.Forms.Button btnPgPedidos;
        private System.Windows.Forms.Button btnPgFrotas;
        private System.Windows.Forms.Button btnPgEncomendas;
    }
}

