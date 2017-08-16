namespace WindowsFormsApp2
{
    partial class Form1
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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pesquisarVenda = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dataOuHoraPesquisa = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RegistrarVenda = new System.Windows.Forms.Button();
            this.valorCarroVenda = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.anoCarroVenda = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.corCarroVenda = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.modeloCarroVenda = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.marcaCarroVenda = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chassiCarroVenda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nomeClienteVenda = new System.Windows.Forms.TextBox();
            this.rgClienteVenda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.vendedorNomeVenda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CadastrarVenda = new System.Windows.Forms.TabControl();
            this.PesquisarCarro = new System.Windows.Forms.TabPage();
            this.dataGridVendas = new System.Windows.Forms.DataGridView();
            this.relatorioDeVendas = new System.Windows.Forms.Button();
            this.click_relatorioDeCarros = new System.Windows.Forms.Button();
            this.gridViewCarros = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.marcaPesquisar = new System.Windows.Forms.TextBox();
            this.modeloPesquisar = new System.Windows.Forms.TextBox();
            this.corPesquisar = new System.Windows.Forms.TextBox();
            this.anoPesquisar = new System.Windows.Forms.TextBox();
            this.marcaVisualizar = new System.Windows.Forms.Button();
            this.visualizarModelo = new System.Windows.Forms.Button();
            this.visualizarAno = new System.Windows.Forms.Button();
            this.visualizarCor = new System.Windows.Forms.Button();
            this.quantidadeMarca = new System.Windows.Forms.Button();
            this.quantidadeModelo = new System.Windows.Forms.Button();
            this.quantidadeAno = new System.Windows.Forms.Button();
            this.corQuantidade = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.CadastrarVenda.SuspendLayout();
            this.PesquisarCarro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCarros)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(986, 485);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "cancelar venda";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.relatorioDeVendas);
            this.tabPage3.Controls.Add(this.dataGridVendas);
            this.tabPage3.Controls.Add(this.pesquisarVenda);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.dataOuHoraPesquisa);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(986, 485);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "pesquisar venda";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pesquisarVenda
            // 
            this.pesquisarVenda.Location = new System.Drawing.Point(492, 83);
            this.pesquisarVenda.Name = "pesquisarVenda";
            this.pesquisarVenda.Size = new System.Drawing.Size(75, 23);
            this.pesquisarVenda.TabIndex = 4;
            this.pesquisarVenda.Text = "pesquisar";
            this.pesquisarVenda.UseVisualStyleBackColor = true;
            this.pesquisarVenda.Click += new System.EventHandler(this.pesquisarVenda_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(353, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "../../..  OU  ..:..:..";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(351, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "DATA OU HORA";
            // 
            // dataOuHoraPesquisa
            // 
            this.dataOuHoraPesquisa.Location = new System.Drawing.Point(356, 86);
            this.dataOuHoraPesquisa.Name = "dataOuHoraPesquisa";
            this.dataOuHoraPesquisa.Size = new System.Drawing.Size(100, 20);
            this.dataOuHoraPesquisa.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RegistrarVenda);
            this.tabPage1.Controls.Add(this.valorCarroVenda);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.anoCarroVenda);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.corCarroVenda);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.modeloCarroVenda);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.marcaCarroVenda);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.chassiCarroVenda);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.nomeClienteVenda);
            this.tabPage1.Controls.Add(this.rgClienteVenda);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.vendedorNomeVenda);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(986, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastrar venda";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // RegistrarVenda
            // 
            this.RegistrarVenda.Location = new System.Drawing.Point(825, 396);
            this.RegistrarVenda.Name = "RegistrarVenda";
            this.RegistrarVenda.Size = new System.Drawing.Size(75, 32);
            this.RegistrarVenda.TabIndex = 22;
            this.RegistrarVenda.Text = "Cadastrar";
            this.RegistrarVenda.UseVisualStyleBackColor = true;
            this.RegistrarVenda.Click += new System.EventHandler(this.RegistrarVenda_Click);
            // 
            // valorCarroVenda
            // 
            this.valorCarroVenda.Location = new System.Drawing.Point(608, 403);
            this.valorCarroVenda.Name = "valorCarroVenda";
            this.valorCarroVenda.Size = new System.Drawing.Size(111, 20);
            this.valorCarroVenda.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(605, 387);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "VALOR";
            // 
            // anoCarroVenda
            // 
            this.anoCarroVenda.Location = new System.Drawing.Point(606, 339);
            this.anoCarroVenda.Name = "anoCarroVenda";
            this.anoCarroVenda.Size = new System.Drawing.Size(113, 20);
            this.anoCarroVenda.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(603, 323);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "ANO";
            // 
            // corCarroVenda
            // 
            this.corCarroVenda.Location = new System.Drawing.Point(607, 277);
            this.corCarroVenda.Name = "corCarroVenda";
            this.corCarroVenda.Size = new System.Drawing.Size(116, 20);
            this.corCarroVenda.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(607, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "COR";
            // 
            // modeloCarroVenda
            // 
            this.modeloCarroVenda.Location = new System.Drawing.Point(610, 219);
            this.modeloCarroVenda.Name = "modeloCarroVenda";
            this.modeloCarroVenda.Size = new System.Drawing.Size(116, 20);
            this.modeloCarroVenda.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(606, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "MODELO";
            // 
            // marcaCarroVenda
            // 
            this.marcaCarroVenda.Location = new System.Drawing.Point(607, 155);
            this.marcaCarroVenda.Name = "marcaCarroVenda";
            this.marcaCarroVenda.Size = new System.Drawing.Size(115, 20);
            this.marcaCarroVenda.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(603, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "MARCA";
            // 
            // chassiCarroVenda
            // 
            this.chassiCarroVenda.Location = new System.Drawing.Point(606, 94);
            this.chassiCarroVenda.Name = "chassiCarroVenda";
            this.chassiCarroVenda.Size = new System.Drawing.Size(116, 20);
            this.chassiCarroVenda.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(604, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "CARRO";
            // 
            // nomeClienteVenda
            // 
            this.nomeClienteVenda.Location = new System.Drawing.Point(316, 155);
            this.nomeClienteVenda.Name = "nomeClienteVenda";
            this.nomeClienteVenda.Size = new System.Drawing.Size(100, 20);
            this.nomeClienteVenda.TabIndex = 9;
            // 
            // rgClienteVenda
            // 
            this.rgClienteVenda.Location = new System.Drawing.Point(316, 94);
            this.rgClienteVenda.Name = "rgClienteVenda";
            this.rgClienteVenda.Size = new System.Drawing.Size(100, 20);
            this.rgClienteVenda.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "CLIENTE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "NOME";
            // 
            // vendedorNomeVenda
            // 
            this.vendedorNomeVenda.Location = new System.Drawing.Point(26, 103);
            this.vendedorNomeVenda.Name = "vendedorNomeVenda";
            this.vendedorNomeVenda.Size = new System.Drawing.Size(100, 20);
            this.vendedorNomeVenda.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(603, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "CHASSI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "RG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "VENDEDOR";
            // 
            // CadastrarVenda
            // 
            this.CadastrarVenda.AccessibleName = "CadastrarVenda";
            this.CadastrarVenda.Controls.Add(this.tabPage1);
            this.CadastrarVenda.Controls.Add(this.tabPage3);
            this.CadastrarVenda.Controls.Add(this.PesquisarCarro);
            this.CadastrarVenda.Controls.Add(this.tabPage4);
            this.CadastrarVenda.Location = new System.Drawing.Point(12, 5);
            this.CadastrarVenda.Name = "CadastrarVenda";
            this.CadastrarVenda.SelectedIndex = 0;
            this.CadastrarVenda.Size = new System.Drawing.Size(994, 511);
            this.CadastrarVenda.TabIndex = 0;
            // 
            // PesquisarCarro
            // 
            this.PesquisarCarro.Controls.Add(this.corQuantidade);
            this.PesquisarCarro.Controls.Add(this.quantidadeAno);
            this.PesquisarCarro.Controls.Add(this.quantidadeModelo);
            this.PesquisarCarro.Controls.Add(this.quantidadeMarca);
            this.PesquisarCarro.Controls.Add(this.visualizarCor);
            this.PesquisarCarro.Controls.Add(this.visualizarAno);
            this.PesquisarCarro.Controls.Add(this.visualizarModelo);
            this.PesquisarCarro.Controls.Add(this.marcaVisualizar);
            this.PesquisarCarro.Controls.Add(this.anoPesquisar);
            this.PesquisarCarro.Controls.Add(this.corPesquisar);
            this.PesquisarCarro.Controls.Add(this.modeloPesquisar);
            this.PesquisarCarro.Controls.Add(this.marcaPesquisar);
            this.PesquisarCarro.Controls.Add(this.label18);
            this.PesquisarCarro.Controls.Add(this.label17);
            this.PesquisarCarro.Controls.Add(this.label16);
            this.PesquisarCarro.Controls.Add(this.label15);
            this.PesquisarCarro.Controls.Add(this.gridViewCarros);
            this.PesquisarCarro.Controls.Add(this.click_relatorioDeCarros);
            this.PesquisarCarro.Location = new System.Drawing.Point(4, 22);
            this.PesquisarCarro.Name = "PesquisarCarro";
            this.PesquisarCarro.Size = new System.Drawing.Size(986, 485);
            this.PesquisarCarro.TabIndex = 4;
            this.PesquisarCarro.Text = "Pesquisar carro";
            this.PesquisarCarro.UseVisualStyleBackColor = true;
            // 
            // dataGridVendas
            // 
            this.dataGridVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVendas.Location = new System.Drawing.Point(6, 127);
            this.dataGridVendas.Name = "dataGridVendas";
            this.dataGridVendas.Size = new System.Drawing.Size(974, 343);
            this.dataGridVendas.TabIndex = 5;
            // 
            // relatorioDeVendas
            // 
            this.relatorioDeVendas.Location = new System.Drawing.Point(847, 98);
            this.relatorioDeVendas.Name = "relatorioDeVendas";
            this.relatorioDeVendas.Size = new System.Drawing.Size(133, 23);
            this.relatorioDeVendas.TabIndex = 6;
            this.relatorioDeVendas.Text = "relatorio de vendas";
            this.relatorioDeVendas.UseVisualStyleBackColor = true;
            this.relatorioDeVendas.Click += new System.EventHandler(this.relatorioDeVendas_Click);
            // 
            // click_relatorioDeCarros
            // 
            this.click_relatorioDeCarros.Location = new System.Drawing.Point(685, 180);
            this.click_relatorioDeCarros.Name = "click_relatorioDeCarros";
            this.click_relatorioDeCarros.Size = new System.Drawing.Size(132, 23);
            this.click_relatorioDeCarros.TabIndex = 0;
            this.click_relatorioDeCarros.Text = "relatorio de carros";
            this.click_relatorioDeCarros.UseVisualStyleBackColor = true;
            this.click_relatorioDeCarros.Click += new System.EventHandler(this.click_relatorioDeCarros_Click);
            // 
            // gridViewCarros
            // 
            this.gridViewCarros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewCarros.Location = new System.Drawing.Point(179, 209);
            this.gridViewCarros.Name = "gridViewCarros";
            this.gridViewCarros.Size = new System.Drawing.Size(638, 194);
            this.gridViewCarros.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(280, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "MARCA";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(270, 71);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "MODELO";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(280, 169);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "ANO";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(280, 122);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "COR";
            // 
            // marcaPesquisar
            // 
            this.marcaPesquisar.Location = new System.Drawing.Point(349, 22);
            this.marcaPesquisar.Name = "marcaPesquisar";
            this.marcaPesquisar.Size = new System.Drawing.Size(100, 20);
            this.marcaPesquisar.TabIndex = 6;
            // 
            // modeloPesquisar
            // 
            this.modeloPesquisar.Location = new System.Drawing.Point(349, 71);
            this.modeloPesquisar.Name = "modeloPesquisar";
            this.modeloPesquisar.Size = new System.Drawing.Size(100, 20);
            this.modeloPesquisar.TabIndex = 7;
            // 
            // corPesquisar
            // 
            this.corPesquisar.Location = new System.Drawing.Point(349, 125);
            this.corPesquisar.Name = "corPesquisar";
            this.corPesquisar.Size = new System.Drawing.Size(100, 20);
            this.corPesquisar.TabIndex = 8;
            // 
            // anoPesquisar
            // 
            this.anoPesquisar.Location = new System.Drawing.Point(349, 169);
            this.anoPesquisar.Name = "anoPesquisar";
            this.anoPesquisar.Size = new System.Drawing.Size(100, 20);
            this.anoPesquisar.TabIndex = 9;
            // 
            // marcaVisualizar
            // 
            this.marcaVisualizar.Location = new System.Drawing.Point(474, 22);
            this.marcaVisualizar.Name = "marcaVisualizar";
            this.marcaVisualizar.Size = new System.Drawing.Size(75, 23);
            this.marcaVisualizar.TabIndex = 10;
            this.marcaVisualizar.Text = "visualizar";
            this.marcaVisualizar.UseVisualStyleBackColor = true;
            this.marcaVisualizar.Click += new System.EventHandler(this.marcaVisualizar_Click);
            // 
            // visualizarModelo
            // 
            this.visualizarModelo.Location = new System.Drawing.Point(474, 74);
            this.visualizarModelo.Name = "visualizarModelo";
            this.visualizarModelo.Size = new System.Drawing.Size(75, 23);
            this.visualizarModelo.TabIndex = 11;
            this.visualizarModelo.Text = "visualizar";
            this.visualizarModelo.UseVisualStyleBackColor = true;
            this.visualizarModelo.Click += new System.EventHandler(this.visualizarModelo_Click);
            // 
            // visualizarAno
            // 
            this.visualizarAno.Location = new System.Drawing.Point(474, 167);
            this.visualizarAno.Name = "visualizarAno";
            this.visualizarAno.Size = new System.Drawing.Size(75, 23);
            this.visualizarAno.TabIndex = 12;
            this.visualizarAno.Text = "visualizar";
            this.visualizarAno.UseVisualStyleBackColor = true;
            this.visualizarAno.Click += new System.EventHandler(this.visualizarAno_Click);
            // 
            // visualizarCor
            // 
            this.visualizarCor.Location = new System.Drawing.Point(474, 125);
            this.visualizarCor.Name = "visualizarCor";
            this.visualizarCor.Size = new System.Drawing.Size(75, 23);
            this.visualizarCor.TabIndex = 13;
            this.visualizarCor.Text = "visualizar";
            this.visualizarCor.UseVisualStyleBackColor = true;
            this.visualizarCor.Click += new System.EventHandler(this.visualizarCor_Click);
            // 
            // quantidadeMarca
            // 
            this.quantidadeMarca.Location = new System.Drawing.Point(567, 22);
            this.quantidadeMarca.Name = "quantidadeMarca";
            this.quantidadeMarca.Size = new System.Drawing.Size(75, 23);
            this.quantidadeMarca.TabIndex = 14;
            this.quantidadeMarca.Text = "quantidade";
            this.quantidadeMarca.UseVisualStyleBackColor = true;
            this.quantidadeMarca.Click += new System.EventHandler(this.quantidadeMarca_Click);
            // 
            // quantidadeModelo
            // 
            this.quantidadeModelo.Location = new System.Drawing.Point(567, 71);
            this.quantidadeModelo.Name = "quantidadeModelo";
            this.quantidadeModelo.Size = new System.Drawing.Size(75, 23);
            this.quantidadeModelo.TabIndex = 15;
            this.quantidadeModelo.Text = "quantidade";
            this.quantidadeModelo.UseVisualStyleBackColor = true;
            this.quantidadeModelo.Click += new System.EventHandler(this.quantidadeModelo_Click);
            // 
            // quantidadeAno
            // 
            this.quantidadeAno.Location = new System.Drawing.Point(567, 167);
            this.quantidadeAno.Name = "quantidadeAno";
            this.quantidadeAno.Size = new System.Drawing.Size(75, 23);
            this.quantidadeAno.TabIndex = 16;
            this.quantidadeAno.Text = "quantidade";
            this.quantidadeAno.UseVisualStyleBackColor = true;
            this.quantidadeAno.Click += new System.EventHandler(this.quantidadeAno_Click);
            // 
            // corQuantidade
            // 
            this.corQuantidade.Location = new System.Drawing.Point(567, 125);
            this.corQuantidade.Name = "corQuantidade";
            this.corQuantidade.Size = new System.Drawing.Size(75, 23);
            this.corQuantidade.TabIndex = 17;
            this.corQuantidade.Text = "quantidade";
            this.corQuantidade.UseVisualStyleBackColor = true;
            this.corQuantidade.Click += new System.EventHandler(this.corQuantidade_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(410, 192);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(78, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "FALTA FAZER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 544);
            this.Controls.Add(this.CadastrarVenda);
            this.Name = "Form1";
            this.Text = "Venda e consulta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.CadastrarVenda.ResumeLayout(false);
            this.PesquisarCarro.ResumeLayout(false);
            this.PesquisarCarro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCarros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl CadastrarVenda;
        private System.Windows.Forms.TabPage PesquisarCarro;
        private System.Windows.Forms.TextBox valorCarroVenda;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox anoCarroVenda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox corCarroVenda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox modeloCarroVenda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox marcaCarroVenda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox chassiCarroVenda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nomeClienteVenda;
        private System.Windows.Forms.TextBox rgClienteVenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox vendedorNomeVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox dataOuHoraPesquisa;
        private System.Windows.Forms.Button pesquisarVenda;
        private System.Windows.Forms.Button RegistrarVenda;
        private System.Windows.Forms.DataGridView dataGridVendas;
        private System.Windows.Forms.Button relatorioDeVendas;
        private System.Windows.Forms.Button click_relatorioDeCarros;
        private System.Windows.Forms.DataGridView gridViewCarros;
        private System.Windows.Forms.Button corQuantidade;
        private System.Windows.Forms.Button quantidadeAno;
        private System.Windows.Forms.Button quantidadeModelo;
        private System.Windows.Forms.Button quantidadeMarca;
        private System.Windows.Forms.Button visualizarCor;
        private System.Windows.Forms.Button visualizarAno;
        private System.Windows.Forms.Button visualizarModelo;
        private System.Windows.Forms.Button marcaVisualizar;
        private System.Windows.Forms.TextBox anoPesquisar;
        private System.Windows.Forms.TextBox corPesquisar;
        private System.Windows.Forms.TextBox modeloPesquisar;
        private System.Windows.Forms.TextBox marcaPesquisar;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
    }
}

