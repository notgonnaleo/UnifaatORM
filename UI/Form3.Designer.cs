﻿namespace ProjetoORM
{
    partial class Form3
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
            this.tablePedidos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pedidoId = new System.Windows.Forms.TextBox();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.qtdeVal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.dateTimePedido = new System.Windows.Forms.DateTimePicker();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProdPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablePedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPgEncomendas
            // 
            this.btnPgEncomendas.Location = new System.Drawing.Point(533, 358);
            this.btnPgEncomendas.Name = "btnPgEncomendas";
            this.btnPgEncomendas.Size = new System.Drawing.Size(83, 70);
            this.btnPgEncomendas.TabIndex = 34;
            this.btnPgEncomendas.Text = "Encomendas";
            this.btnPgEncomendas.UseVisualStyleBackColor = true;
            // 
            // btnPgFrotas
            // 
            this.btnPgFrotas.Location = new System.Drawing.Point(452, 358);
            this.btnPgFrotas.Name = "btnPgFrotas";
            this.btnPgFrotas.Size = new System.Drawing.Size(75, 70);
            this.btnPgFrotas.TabIndex = 33;
            this.btnPgFrotas.Text = "Frotas";
            this.btnPgFrotas.UseVisualStyleBackColor = true;
            // 
            // btnPgPedidos
            // 
            this.btnPgPedidos.Location = new System.Drawing.Point(371, 358);
            this.btnPgPedidos.Name = "btnPgPedidos";
            this.btnPgPedidos.Size = new System.Drawing.Size(75, 70);
            this.btnPgPedidos.TabIndex = 32;
            this.btnPgPedidos.Text = "Pedidos";
            this.btnPgPedidos.UseVisualStyleBackColor = true;
            // 
            // btnPgProdutos
            // 
            this.btnPgProdutos.Location = new System.Drawing.Point(290, 358);
            this.btnPgProdutos.Name = "btnPgProdutos";
            this.btnPgProdutos.Size = new System.Drawing.Size(75, 70);
            this.btnPgProdutos.TabIndex = 31;
            this.btnPgProdutos.Text = "Produtos";
            this.btnPgProdutos.UseVisualStyleBackColor = true;
            this.btnPgProdutos.Click += new System.EventHandler(this.btnPgProdutos_Click);
            // 
            // btnPgClientes
            // 
            this.btnPgClientes.Location = new System.Drawing.Point(209, 358);
            this.btnPgClientes.Name = "btnPgClientes";
            this.btnPgClientes.Size = new System.Drawing.Size(75, 70);
            this.btnPgClientes.TabIndex = 30;
            this.btnPgClientes.Text = "Clientes";
            this.btnPgClientes.UseVisualStyleBackColor = true;
            this.btnPgClientes.Click += new System.EventHandler(this.btnPgClientes_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(575, 52);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 29;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(656, 23);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 28;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(575, 23);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 27;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tablePedidos
            // 
            this.tablePedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablePedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dataGridViewTextBoxColumn1,
            this.NomeProdPedido,
            this.Qtde,
            this.Destino,
            this.Data});
            this.tablePedidos.Location = new System.Drawing.Point(81, 163);
            this.tablePedidos.Name = "tablePedidos";
            this.tablePedidos.Size = new System.Drawing.Size(642, 189);
            this.tablePedidos.TabIndex = 26;
            this.tablePedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablePedidos_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(77, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Id";
            // 
            // pedidoId
            // 
            this.pedidoId.Location = new System.Drawing.Point(111, 23);
            this.pedidoId.Name = "pedidoId";
            this.pedidoId.Size = new System.Drawing.Size(100, 20);
            this.pedidoId.TabIndex = 22;
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(111, 73);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(121, 21);
            this.cbClientes.TabIndex = 35;
            this.cbClientes.SelectedIndexChanged += new System.EventHandler(this.cbClientes_SelectedIndexChanged);
            // 
            // cbProduto
            // 
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(325, 73);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(121, 21);
            this.cbProduto.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(43, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 37;
            this.label2.Text = "Cliente";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(251, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 38;
            this.label3.Text = "Produto";
            // 
            // qtdeVal
            // 
            this.qtdeVal.Location = new System.Drawing.Point(325, 25);
            this.qtdeVal.Name = "qtdeVal";
            this.qtdeVal.Size = new System.Drawing.Size(100, 20);
            this.qtdeVal.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(269, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 23);
            this.label4.TabIndex = 40;
            this.label4.Text = "Qtde";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(43, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 23);
            this.label6.TabIndex = 42;
            this.label6.Text = "Cidade";
            // 
            // cbCidade
            // 
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Location = new System.Drawing.Point(111, 115);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(121, 21);
            this.cbCidade.TabIndex = 41;
            // 
            // dateTimePedido
            // 
            this.dateTimePedido.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dateTimePedido.Location = new System.Drawing.Point(533, 118);
            this.dateTimePedido.Name = "dateTimePedido";
            this.dateTimePedido.Size = new System.Drawing.Size(190, 20);
            this.dateTimePedido.TabIndex = 43;
            this.dateTimePedido.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NomeCliente";
            this.dataGridViewTextBoxColumn1.HeaderText = "NomeCliente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // NomeProdPedido
            // 
            this.NomeProdPedido.DataPropertyName = "NomeProdPedido";
            this.NomeProdPedido.HeaderText = "NomeProdPedido";
            this.NomeProdPedido.Name = "NomeProdPedido";
            // 
            // Qtde
            // 
            this.Qtde.DataPropertyName = "Qtde";
            this.Qtde.HeaderText = "Qtde";
            this.Qtde.Name = "Qtde";
            // 
            // Destino
            // 
            this.Destino.DataPropertyName = "Cidade";
            this.Destino.HeaderText = "Destino";
            this.Destino.Name = "Destino";
            // 
            // Data
            // 
            this.Data.DataPropertyName = "DataPedido";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(575, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "Pesquisar por data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(28, 382);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(118, 23);
            this.btnPdf.TabIndex = 45;
            this.btnPdf.Text = "Gerar relatorio";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePedido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbCidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.qtdeVal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbProduto);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.btnPgEncomendas);
            this.Controls.Add(this.btnPgFrotas);
            this.Controls.Add(this.btnPgPedidos);
            this.Controls.Add(this.btnPgProdutos);
            this.Controls.Add(this.btnPgClientes);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tablePedidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pedidoId);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePedidos)).EndInit();
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
        private System.Windows.Forms.DataGridView tablePedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pedidoId;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox qtdeVal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.DateTimePicker dateTimePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProdPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPdf;
    }
}