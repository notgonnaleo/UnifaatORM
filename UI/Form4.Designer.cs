namespace ProjetoORM
{
    partial class Form4
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
            this.btnPgEncomendas = new System.Windows.Forms.Button();
            this.btnPgFrotas = new System.Windows.Forms.Button();
            this.btnPgPedidos = new System.Windows.Forms.Button();
            this.btnPgProdutos = new System.Windows.Forms.Button();
            this.btnPgClientes = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tableFrotas = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.produtoId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableFrotas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPgEncomendas
            // 
            this.btnPgEncomendas.Location = new System.Drawing.Point(533, 359);
            this.btnPgEncomendas.Name = "btnPgEncomendas";
            this.btnPgEncomendas.Size = new System.Drawing.Size(83, 70);
            this.btnPgEncomendas.TabIndex = 34;
            this.btnPgEncomendas.Text = "Encomendas";
            this.btnPgEncomendas.UseVisualStyleBackColor = true;
            // 
            // btnPgFrotas
            // 
            this.btnPgFrotas.Location = new System.Drawing.Point(452, 359);
            this.btnPgFrotas.Name = "btnPgFrotas";
            this.btnPgFrotas.Size = new System.Drawing.Size(75, 70);
            this.btnPgFrotas.TabIndex = 33;
            this.btnPgFrotas.Text = "Frotas";
            this.btnPgFrotas.UseVisualStyleBackColor = true;
            // 
            // btnPgPedidos
            // 
            this.btnPgPedidos.Location = new System.Drawing.Point(371, 359);
            this.btnPgPedidos.Name = "btnPgPedidos";
            this.btnPgPedidos.Size = new System.Drawing.Size(75, 70);
            this.btnPgPedidos.TabIndex = 32;
            this.btnPgPedidos.Text = "Pedidos";
            this.btnPgPedidos.UseVisualStyleBackColor = true;
            // 
            // btnPgProdutos
            // 
            this.btnPgProdutos.Location = new System.Drawing.Point(290, 359);
            this.btnPgProdutos.Name = "btnPgProdutos";
            this.btnPgProdutos.Size = new System.Drawing.Size(75, 70);
            this.btnPgProdutos.TabIndex = 31;
            this.btnPgProdutos.Text = "Produtos";
            this.btnPgProdutos.UseVisualStyleBackColor = true;
            // 
            // btnPgClientes
            // 
            this.btnPgClientes.Location = new System.Drawing.Point(209, 359);
            this.btnPgClientes.Name = "btnPgClientes";
            this.btnPgClientes.Size = new System.Drawing.Size(75, 70);
            this.btnPgClientes.TabIndex = 30;
            this.btnPgClientes.Text = "Clientes";
            this.btnPgClientes.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(575, 53);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 29;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(656, 24);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 28;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(575, 24);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 27;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // tableFrotas
            // 
            this.tableFrotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableFrotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Destino,
            this.dataGridViewTextBoxColumn1});
            this.tableFrotas.Location = new System.Drawing.Point(187, 160);
            this.tableFrotas.Name = "tableFrotas";
            this.tableFrotas.Size = new System.Drawing.Size(442, 189);
            this.tableFrotas.TabIndex = 26;
            this.tableFrotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableFrotas_CellContentClick);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Nome.Location = new System.Drawing.Point(232, 22);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(62, 23);
            this.Nome.TabIndex = 25;
            this.Nome.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(70, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Id";
            // 
            // produtoId
            // 
            this.produtoId.Location = new System.Drawing.Point(111, 24);
            this.produtoId.Name = "produtoId";
            this.produtoId.Size = new System.Drawing.Size(100, 20);
            this.produtoId.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(43, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 36;
            this.label2.Text = "Destino";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 35;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Destino
            // 
            this.Destino.DataPropertyName = "Destino";
            this.Destino.HeaderText = "Destino";
            this.Destino.Name = "Destino";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NomeCliente";
            this.dataGridViewTextBoxColumn1.HeaderText = "NomeCliente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(300, 27);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(121, 21);
            this.cbClientes.TabIndex = 37;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnPgEncomendas);
            this.Controls.Add(this.btnPgFrotas);
            this.Controls.Add(this.btnPgPedidos);
            this.Controls.Add(this.btnPgProdutos);
            this.Controls.Add(this.btnPgClientes);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tableFrotas);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.produtoId);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableFrotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPgEncomendas;
        private System.Windows.Forms.Button btnPgFrotas;
        private System.Windows.Forms.Button btnPgPedidos;
        private System.Windows.Forms.Button btnPgProdutos;
        private System.Windows.Forms.Button btnPgClientes;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView tableFrotas;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox produtoId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.ComboBox cbClientes;
    }
}