namespace Sistema_PDV
{
    partial class FrmPrincipal
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
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovimentacao = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.img02 = new System.Windows.Forms.PictureBox();
            this.img04 = new System.Windows.Forms.PictureBox();
            this.img03 = new System.Windows.Forms.PictureBox();
            this.img01 = new System.Windows.Forms.PictureBox();
            this.MenuFucionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCargos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEntradaSaida = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFluxoDeCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLancaVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDespesasRel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDespesas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVendasRel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovimentosRel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEntradaSaindaRel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutosRel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img01)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastro,
            this.MenuProduto,
            this.MenuMovimentacao,
            this.MenuRelatorio,
            this.MenuSair});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.MenuPrincipal.Size = new System.Drawing.Size(933, 24);
            this.MenuPrincipal.TabIndex = 0;
            this.MenuPrincipal.Text = "menuStrip1";
            // 
            // MenuCadastro
            // 
            this.MenuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCargos,
            this.MenuClientes,
            this.MenuFornecedores,
            this.MenuFucionarios,
            this.MenuUsuarios});
            this.MenuCadastro.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuCadastro.Name = "MenuCadastro";
            this.MenuCadastro.Size = new System.Drawing.Size(77, 20);
            this.MenuCadastro.Text = "Cadastro";
            // 
            // MenuProduto
            // 
            this.MenuProduto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuEstoque,
            this.MenuProdutos});
            this.MenuProduto.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuProduto.Name = "MenuProduto";
            this.MenuProduto.Size = new System.Drawing.Size(76, 20);
            this.MenuProduto.Text = "Produtos";
            // 
            // MenuMovimentacao
            // 
            this.MenuMovimentacao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuDespesas,
            this.MenuEntradaSaida,
            this.MenuFluxoDeCaixa,
            this.MenuLancaVenda});
            this.MenuMovimentacao.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuMovimentacao.Name = "MenuMovimentacao";
            this.MenuMovimentacao.Size = new System.Drawing.Size(109, 20);
            this.MenuMovimentacao.Text = "Movimentação";
            // 
            // MenuRelatorio
            // 
            this.MenuRelatorio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuDespesasRel,
            this.MenuEntradaSaindaRel,
            this.MenuMovimentosRel,
            this.MenuProdutosRel,
            this.MenuVendasRel});
            this.MenuRelatorio.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuRelatorio.Name = "MenuRelatorio";
            this.MenuRelatorio.Size = new System.Drawing.Size(75, 20);
            this.MenuRelatorio.Text = "Relatório";
            // 
            // MenuSair
            // 
            this.MenuSair.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(43, 20);
            this.MenuSair.Text = "Sair";
            this.MenuSair.Click += new System.EventHandler(this.MenuSair_Click);
            // 
            // img02
            // 
            this.img02.Image = global::Sistema_PDV.Properties.Resources.basket;
            this.img02.Location = new System.Drawing.Point(477, 29);
            this.img02.Name = "img02";
            this.img02.Size = new System.Drawing.Size(200, 200);
            this.img02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img02.TabIndex = 5;
            this.img02.TabStop = false;
            // 
            // img04
            // 
            this.img04.Image = global::Sistema_PDV.Properties.Resources.report;
            this.img04.Location = new System.Drawing.Point(477, 240);
            this.img04.Name = "img04";
            this.img04.Size = new System.Drawing.Size(200, 200);
            this.img04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img04.TabIndex = 4;
            this.img04.TabStop = false;
            // 
            // img03
            // 
            this.img03.Image = global::Sistema_PDV.Properties.Resources.money;
            this.img03.Location = new System.Drawing.Point(256, 240);
            this.img03.Name = "img03";
            this.img03.Size = new System.Drawing.Size(200, 200);
            this.img03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img03.TabIndex = 3;
            this.img03.TabStop = false;
            // 
            // img01
            // 
            this.img01.Image = global::Sistema_PDV.Properties.Resources.trolley;
            this.img01.Location = new System.Drawing.Point(256, 29);
            this.img01.Name = "img01";
            this.img01.Size = new System.Drawing.Size(200, 200);
            this.img01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img01.TabIndex = 1;
            this.img01.TabStop = false;
            // 
            // MenuFucionarios
            // 
            this.MenuFucionarios.Name = "MenuFucionarios";
            this.MenuFucionarios.Size = new System.Drawing.Size(180, 22);
            this.MenuFucionarios.Text = "Funcionários";
            // 
            // MenuClientes
            // 
            this.MenuClientes.Name = "MenuClientes";
            this.MenuClientes.Size = new System.Drawing.Size(180, 22);
            this.MenuClientes.Text = "Clientes";
            // 
            // MenuUsuarios
            // 
            this.MenuUsuarios.Name = "MenuUsuarios";
            this.MenuUsuarios.Size = new System.Drawing.Size(180, 22);
            this.MenuUsuarios.Text = "Usuários";
            // 
            // MenuCargos
            // 
            this.MenuCargos.Name = "MenuCargos";
            this.MenuCargos.Size = new System.Drawing.Size(180, 22);
            this.MenuCargos.Text = "Cargos";
            // 
            // MenuFornecedores
            // 
            this.MenuFornecedores.Name = "MenuFornecedores";
            this.MenuFornecedores.Size = new System.Drawing.Size(180, 22);
            this.MenuFornecedores.Text = "Fornecedores";
            // 
            // MenuEstoque
            // 
            this.MenuEstoque.Name = "MenuEstoque";
            this.MenuEstoque.Size = new System.Drawing.Size(180, 22);
            this.MenuEstoque.Text = "Estoque";
            // 
            // MenuProdutos
            // 
            this.MenuProdutos.Name = "MenuProdutos";
            this.MenuProdutos.Size = new System.Drawing.Size(180, 22);
            this.MenuProdutos.Text = "Produtos";
            // 
            // MenuEntradaSaida
            // 
            this.MenuEntradaSaida.Name = "MenuEntradaSaida";
            this.MenuEntradaSaida.Size = new System.Drawing.Size(180, 22);
            this.MenuEntradaSaida.Text = "Entrada/Saida";
            // 
            // MenuFluxoDeCaixa
            // 
            this.MenuFluxoDeCaixa.Name = "MenuFluxoDeCaixa";
            this.MenuFluxoDeCaixa.Size = new System.Drawing.Size(180, 22);
            this.MenuFluxoDeCaixa.Text = "Fluxo de caixa";
            // 
            // MenuLancaVenda
            // 
            this.MenuLancaVenda.Name = "MenuLancaVenda";
            this.MenuLancaVenda.Size = new System.Drawing.Size(180, 22);
            this.MenuLancaVenda.Text = "Lançar venda";
            // 
            // MenuDespesasRel
            // 
            this.MenuDespesasRel.Name = "MenuDespesasRel";
            this.MenuDespesasRel.Size = new System.Drawing.Size(180, 22);
            this.MenuDespesasRel.Text = "Despesas";
            // 
            // MenuDespesas
            // 
            this.MenuDespesas.Name = "MenuDespesas";
            this.MenuDespesas.Size = new System.Drawing.Size(180, 22);
            this.MenuDespesas.Text = "Despesas";
            // 
            // MenuVendasRel
            // 
            this.MenuVendasRel.Name = "MenuVendasRel";
            this.MenuVendasRel.Size = new System.Drawing.Size(180, 22);
            this.MenuVendasRel.Text = "Vendas";
            // 
            // MenuMovimentosRel
            // 
            this.MenuMovimentosRel.Name = "MenuMovimentosRel";
            this.MenuMovimentosRel.Size = new System.Drawing.Size(180, 22);
            this.MenuMovimentosRel.Text = "Movimentos";
            // 
            // MenuEntradaSaindaRel
            // 
            this.MenuEntradaSaindaRel.Name = "MenuEntradaSaindaRel";
            this.MenuEntradaSaindaRel.Size = new System.Drawing.Size(180, 22);
            this.MenuEntradaSaindaRel.Text = "Entrada/Sainda";
            // 
            // MenuProdutosRel
            // 
            this.MenuProdutosRel.Name = "MenuProdutosRel";
            this.MenuProdutosRel.Size = new System.Drawing.Size(180, 22);
            this.MenuProdutosRel.Text = "Produtos";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.img02);
            this.Controls.Add(this.img04);
            this.Controls.Add(this.img03);
            this.Controls.Add(this.img01);
            this.Controls.Add(this.MenuPrincipal);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.MenuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastro;
        private System.Windows.Forms.ToolStripMenuItem MenuProduto;
        private System.Windows.Forms.ToolStripMenuItem MenuMovimentacao;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatorio;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.PictureBox img01;
        private System.Windows.Forms.PictureBox img03;
        private System.Windows.Forms.PictureBox img04;
        private System.Windows.Forms.PictureBox img02;
        private System.Windows.Forms.ToolStripMenuItem MenuCargos;
        private System.Windows.Forms.ToolStripMenuItem MenuClientes;
        private System.Windows.Forms.ToolStripMenuItem MenuFornecedores;
        private System.Windows.Forms.ToolStripMenuItem MenuFucionarios;
        private System.Windows.Forms.ToolStripMenuItem MenuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem MenuEstoque;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutos;
        private System.Windows.Forms.ToolStripMenuItem MenuEntradaSaida;
        private System.Windows.Forms.ToolStripMenuItem MenuFluxoDeCaixa;
        private System.Windows.Forms.ToolStripMenuItem MenuLancaVenda;
        private System.Windows.Forms.ToolStripMenuItem MenuDespesas;
        private System.Windows.Forms.ToolStripMenuItem MenuDespesasRel;
        private System.Windows.Forms.ToolStripMenuItem MenuEntradaSaindaRel;
        private System.Windows.Forms.ToolStripMenuItem MenuMovimentosRel;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutosRel;
        private System.Windows.Forms.ToolStripMenuItem MenuVendasRel;
    }
}

