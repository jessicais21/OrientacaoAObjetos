namespace WindowsFormsApp1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.click_cancelar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.corCarroCadastrarVenda = new System.Windows.Forms.TextBox();
            this.click_cadastrar = new System.Windows.Forms.Button();
            this.valorCarroCadastrarVenda = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.anoCarroCadastrarVenda = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.modeloCarroCadastrarVenda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.marcaCarroCadastrarVenda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chassiCarroCadastrarVenda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nomeClienteCadastrarVenda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clienteRgCadastrarVenda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vendedorNomeCadastrarVenda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gridViewCarros = new System.Windows.Forms.DataGridView();
            this.MarcaPesquisar = new System.Windows.Forms.TextBox();
            this.click_MostrarMarcas = new System.Windows.Forms.Button();
            this.click_QuantidadeMarcaMostrar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.click_todosOsCarros = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.modelo_Pesquisar = new System.Windows.Forms.TextBox();
            this.Click_Mostrar_Modelos = new System.Windows.Forms.Button();
            this.click_QuantidadeModelos = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cor_Pesquisar = new System.Windows.Forms.TextBox();
            this.click_MostrarDeAcordoComACor = new System.Windows.Forms.Button();
            this.click_quantidade_carro_corres = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.ano_carro_pesquisar = new System.Windows.Forms.TextBox();
            this.click_quantidade_cor = new System.Windows.Forms.Button();
            this.click_ano_mostrar_carros = new System.Windows.Forms.Button();
            this.dataGridVendas = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.click_todasAsVendas = new System.Windows.Forms.Button();
            this.pesquisarPorDataOuHora = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.click_mostrar = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCarros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.click_cancelar);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.corCarroCadastrarVenda);
            this.panel1.Controls.Add(this.click_cadastrar);
            this.panel1.Controls.Add(this.valorCarroCadastrarVenda);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.anoCarroCadastrarVenda);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.modeloCarroCadastrarVenda);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.marcaCarroCadastrarVenda);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.chassiCarroCadastrarVenda);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.nomeClienteCadastrarVenda);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.clienteRgCadastrarVenda);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.vendedorNomeCadastrarVenda);
            this.panel1.Location = new System.Drawing.Point(2, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 378);
            this.panel1.TabIndex = 0;
            // 
            // click_cancelar
            // 
            this.click_cancelar.Location = new System.Drawing.Point(10, 339);
            this.click_cancelar.Name = "click_cancelar";
            this.click_cancelar.Size = new System.Drawing.Size(75, 23);
            this.click_cancelar.TabIndex = 19;
            this.click_cancelar.Text = "cancelar";
            this.click_cancelar.UseVisualStyleBackColor = true;
            this.click_cancelar.Click += new System.EventHandler(this.click_cancelar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "cor do carro";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // corCarroCadastrarVenda
            // 
            this.corCarroCadastrarVenda.Location = new System.Drawing.Point(108, 223);
            this.corCarroCadastrarVenda.Name = "corCarroCadastrarVenda";
            this.corCarroCadastrarVenda.Size = new System.Drawing.Size(100, 20);
            this.corCarroCadastrarVenda.TabIndex = 17;
            // 
            // click_cadastrar
            // 
            this.click_cadastrar.Location = new System.Drawing.Point(108, 339);
            this.click_cadastrar.Name = "click_cadastrar";
            this.click_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.click_cadastrar.TabIndex = 16;
            this.click_cadastrar.Text = "cadastrar venda";
            this.click_cadastrar.UseVisualStyleBackColor = true;
            this.click_cadastrar.Click += new System.EventHandler(this.click_cadastrar_Click);
            // 
            // valorCarroCadastrarVenda
            // 
            this.valorCarroCadastrarVenda.Location = new System.Drawing.Point(108, 290);
            this.valorCarroCadastrarVenda.Name = "valorCarroCadastrarVenda";
            this.valorCarroCadastrarVenda.Size = new System.Drawing.Size(100, 20);
            this.valorCarroCadastrarVenda.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "valor do carro";
            // 
            // anoCarroCadastrarVenda
            // 
            this.anoCarroCadastrarVenda.Location = new System.Drawing.Point(108, 258);
            this.anoCarroCadastrarVenda.Name = "anoCarroCadastrarVenda";
            this.anoCarroCadastrarVenda.Size = new System.Drawing.Size(100, 20);
            this.anoCarroCadastrarVenda.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "ano do carro";
            // 
            // modeloCarroCadastrarVenda
            // 
            this.modeloCarroCadastrarVenda.Location = new System.Drawing.Point(108, 197);
            this.modeloCarroCadastrarVenda.Name = "modeloCarroCadastrarVenda";
            this.modeloCarroCadastrarVenda.Size = new System.Drawing.Size(100, 20);
            this.modeloCarroCadastrarVenda.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "modelo do carro";
            // 
            // marcaCarroCadastrarVenda
            // 
            this.marcaCarroCadastrarVenda.Location = new System.Drawing.Point(108, 163);
            this.marcaCarroCadastrarVenda.Name = "marcaCarroCadastrarVenda";
            this.marcaCarroCadastrarVenda.Size = new System.Drawing.Size(100, 20);
            this.marcaCarroCadastrarVenda.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "marca do carro";
            // 
            // chassiCarroCadastrarVenda
            // 
            this.chassiCarroCadastrarVenda.Location = new System.Drawing.Point(106, 134);
            this.chassiCarroCadastrarVenda.Name = "chassiCarroCadastrarVenda";
            this.chassiCarroCadastrarVenda.Size = new System.Drawing.Size(100, 20);
            this.chassiCarroCadastrarVenda.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "chassi do carro";
            // 
            // nomeClienteCadastrarVenda
            // 
            this.nomeClienteCadastrarVenda.Location = new System.Drawing.Point(108, 96);
            this.nomeClienteCadastrarVenda.Name = "nomeClienteCadastrarVenda";
            this.nomeClienteCadastrarVenda.Size = new System.Drawing.Size(100, 20);
            this.nomeClienteCadastrarVenda.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "nome do cliente";
            // 
            // clienteRgCadastrarVenda
            // 
            this.clienteRgCadastrarVenda.Location = new System.Drawing.Point(106, 65);
            this.clienteRgCadastrarVenda.Name = "clienteRgCadastrarVenda";
            this.clienteRgCadastrarVenda.Size = new System.Drawing.Size(100, 20);
            this.clienteRgCadastrarVenda.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "rg do cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "nome do vendedor";
            // 
            // vendedorNomeCadastrarVenda
            // 
            this.vendedorNomeCadastrarVenda.Location = new System.Drawing.Point(106, 24);
            this.vendedorNomeCadastrarVenda.Name = "vendedorNomeCadastrarVenda";
            this.vendedorNomeCadastrarVenda.Size = new System.Drawing.Size(100, 20);
            this.vendedorNomeCadastrarVenda.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vendas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(268, 467);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "mostrar carros";
            // 
            // gridViewCarros
            // 
            this.gridViewCarros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewCarros.Cursor = System.Windows.Forms.Cursors.No;
            this.gridViewCarros.Location = new System.Drawing.Point(248, 579);
            this.gridViewCarros.Name = "gridViewCarros";
            this.gridViewCarros.Size = new System.Drawing.Size(683, 150);
            this.gridViewCarros.TabIndex = 3;
            // 
            // MarcaPesquisar
            // 
            this.MarcaPesquisar.Location = new System.Drawing.Point(369, 483);
            this.MarcaPesquisar.Name = "MarcaPesquisar";
            this.MarcaPesquisar.Size = new System.Drawing.Size(100, 20);
            this.MarcaPesquisar.TabIndex = 5;
            // 
            // click_MostrarMarcas
            // 
            this.click_MostrarMarcas.Location = new System.Drawing.Point(475, 483);
            this.click_MostrarMarcas.Name = "click_MostrarMarcas";
            this.click_MostrarMarcas.Size = new System.Drawing.Size(75, 23);
            this.click_MostrarMarcas.TabIndex = 6;
            this.click_MostrarMarcas.Text = "pesquisar";
            this.click_MostrarMarcas.UseVisualStyleBackColor = true;
            this.click_MostrarMarcas.Click += new System.EventHandler(this.click_MostrarMarcas_Click);
            // 
            // click_QuantidadeMarcaMostrar
            // 
            this.click_QuantidadeMarcaMostrar.Location = new System.Drawing.Point(556, 483);
            this.click_QuantidadeMarcaMostrar.Name = "click_QuantidadeMarcaMostrar";
            this.click_QuantidadeMarcaMostrar.Size = new System.Drawing.Size(75, 23);
            this.click_QuantidadeMarcaMostrar.TabIndex = 7;
            this.click_QuantidadeMarcaMostrar.Text = "quantidade";
            this.click_QuantidadeMarcaMostrar.UseVisualStyleBackColor = true;
            this.click_QuantidadeMarcaMostrar.Click += new System.EventHandler(this.click_QuantidadeMarcaMostrar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(366, 470);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "marca";
            // 
            // click_todosOsCarros
            // 
            this.click_todosOsCarros.Location = new System.Drawing.Point(271, 483);
            this.click_todosOsCarros.Name = "click_todosOsCarros";
            this.click_todosOsCarros.Size = new System.Drawing.Size(75, 49);
            this.click_todosOsCarros.TabIndex = 9;
            this.click_todosOsCarros.Text = "Todos os carros";
            this.click_todosOsCarros.UseVisualStyleBackColor = true;
            this.click_todosOsCarros.Click += new System.EventHandler(this.click_todosOsCarros_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(366, 519);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "modelo";
            // 
            // modelo_Pesquisar
            // 
            this.modelo_Pesquisar.Location = new System.Drawing.Point(369, 535);
            this.modelo_Pesquisar.Name = "modelo_Pesquisar";
            this.modelo_Pesquisar.Size = new System.Drawing.Size(100, 20);
            this.modelo_Pesquisar.TabIndex = 11;
            // 
            // Click_Mostrar_Modelos
            // 
            this.Click_Mostrar_Modelos.Location = new System.Drawing.Point(475, 532);
            this.Click_Mostrar_Modelos.Name = "Click_Mostrar_Modelos";
            this.Click_Mostrar_Modelos.Size = new System.Drawing.Size(75, 23);
            this.Click_Mostrar_Modelos.TabIndex = 12;
            this.Click_Mostrar_Modelos.Text = "pesquisar";
            this.Click_Mostrar_Modelos.UseVisualStyleBackColor = true;
            this.Click_Mostrar_Modelos.Click += new System.EventHandler(this.Click_Mostrar_Modelos_Click);
            // 
            // click_QuantidadeModelos
            // 
            this.click_QuantidadeModelos.Location = new System.Drawing.Point(556, 533);
            this.click_QuantidadeModelos.Name = "click_QuantidadeModelos";
            this.click_QuantidadeModelos.Size = new System.Drawing.Size(75, 23);
            this.click_QuantidadeModelos.TabIndex = 13;
            this.click_QuantidadeModelos.Text = "quantidade";
            this.click_QuantidadeModelos.UseVisualStyleBackColor = true;
            this.click_QuantidadeModelos.Click += new System.EventHandler(this.click_QuantidadeModelos_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(666, 470);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "cor";
            // 
            // cor_Pesquisar
            // 
            this.cor_Pesquisar.Location = new System.Drawing.Point(669, 483);
            this.cor_Pesquisar.Name = "cor_Pesquisar";
            this.cor_Pesquisar.Size = new System.Drawing.Size(100, 20);
            this.cor_Pesquisar.TabIndex = 15;
            // 
            // click_MostrarDeAcordoComACor
            // 
            this.click_MostrarDeAcordoComACor.Location = new System.Drawing.Point(775, 480);
            this.click_MostrarDeAcordoComACor.Name = "click_MostrarDeAcordoComACor";
            this.click_MostrarDeAcordoComACor.Size = new System.Drawing.Size(75, 23);
            this.click_MostrarDeAcordoComACor.TabIndex = 16;
            this.click_MostrarDeAcordoComACor.Text = "pesquisar";
            this.click_MostrarDeAcordoComACor.UseVisualStyleBackColor = true;
            this.click_MostrarDeAcordoComACor.Click += new System.EventHandler(this.click_MostrarDeAcordoComACor_Click);
            // 
            // click_quantidade_carro_corres
            // 
            this.click_quantidade_carro_corres.Location = new System.Drawing.Point(856, 480);
            this.click_quantidade_carro_corres.Name = "click_quantidade_carro_corres";
            this.click_quantidade_carro_corres.Size = new System.Drawing.Size(75, 23);
            this.click_quantidade_carro_corres.TabIndex = 17;
            this.click_quantidade_carro_corres.Text = "quantidade";
            this.click_quantidade_carro_corres.UseVisualStyleBackColor = true;
            this.click_quantidade_carro_corres.Click += new System.EventHandler(this.click_quantidade_carro_corres_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(666, 519);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "ano";
            // 
            // ano_carro_pesquisar
            // 
            this.ano_carro_pesquisar.Location = new System.Drawing.Point(669, 536);
            this.ano_carro_pesquisar.Name = "ano_carro_pesquisar";
            this.ano_carro_pesquisar.Size = new System.Drawing.Size(100, 20);
            this.ano_carro_pesquisar.TabIndex = 19;
            // 
            // click_quantidade_cor
            // 
            this.click_quantidade_cor.Location = new System.Drawing.Point(856, 532);
            this.click_quantidade_cor.Name = "click_quantidade_cor";
            this.click_quantidade_cor.Size = new System.Drawing.Size(75, 23);
            this.click_quantidade_cor.TabIndex = 21;
            this.click_quantidade_cor.Text = "quantidade";
            this.click_quantidade_cor.UseVisualStyleBackColor = true;
            this.click_quantidade_cor.Click += new System.EventHandler(this.click_quantidade_cor_Click);
            // 
            // click_ano_mostrar_carros
            // 
            this.click_ano_mostrar_carros.Location = new System.Drawing.Point(775, 532);
            this.click_ano_mostrar_carros.Name = "click_ano_mostrar_carros";
            this.click_ano_mostrar_carros.Size = new System.Drawing.Size(75, 23);
            this.click_ano_mostrar_carros.TabIndex = 22;
            this.click_ano_mostrar_carros.Text = "pesquisar";
            this.click_ano_mostrar_carros.UseVisualStyleBackColor = true;
            this.click_ano_mostrar_carros.Click += new System.EventHandler(this.click_ano_mostrar_carros_Click);
            // 
            // dataGridVendas
            // 
            this.dataGridVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVendas.Location = new System.Drawing.Point(225, 111);
            this.dataGridVendas.Name = "dataGridVendas";
            this.dataGridVendas.Size = new System.Drawing.Size(1167, 284);
            this.dataGridVendas.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(346, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 24;
            this.label16.Text = "Vendas";
            // 
            // click_todasAsVendas
            // 
            this.click_todasAsVendas.Location = new System.Drawing.Point(332, 58);
            this.click_todasAsVendas.Name = "click_todasAsVendas";
            this.click_todasAsVendas.Size = new System.Drawing.Size(75, 47);
            this.click_todasAsVendas.TabIndex = 25;
            this.click_todasAsVendas.Text = "Todas as vendas";
            this.click_todasAsVendas.UseVisualStyleBackColor = true;
            this.click_todasAsVendas.Click += new System.EventHandler(this.click_todasAsVendas_Click);
            // 
            // pesquisarPorDataOuHora
            // 
            this.pesquisarPorDataOuHora.Location = new System.Drawing.Point(475, 80);
            this.pesquisarPorDataOuHora.Name = "pesquisarPorDataOuHora";
            this.pesquisarPorDataOuHora.Size = new System.Drawing.Size(100, 20);
            this.pesquisarPorDataOuHora.TabIndex = 26;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(472, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 13);
            this.label17.TabIndex = 27;
            this.label17.Text = "data ou hora";
            // 
            // click_mostrar
            // 
            this.click_mostrar.Location = new System.Drawing.Point(581, 78);
            this.click_mostrar.Name = "click_mostrar";
            this.click_mostrar.Size = new System.Drawing.Size(75, 23);
            this.click_mostrar.TabIndex = 28;
            this.click_mostrar.Text = "pesquisar";
            this.click_mostrar.UseVisualStyleBackColor = true;
            this.click_mostrar.Click += new System.EventHandler(this.click_mostrar_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(472, 59);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 13);
            this.label18.TabIndex = 29;
            this.label18.Text = "../../../  ..:..:..";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(0, 59);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(210, 13);
            this.label19.TabIndex = 30;
            this.label19.Text = "Cancelamento: dados do cliente e do carro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 741);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.click_mostrar);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.pesquisarPorDataOuHora);
            this.Controls.Add(this.click_todasAsVendas);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dataGridVendas);
            this.Controls.Add(this.click_ano_mostrar_carros);
            this.Controls.Add(this.click_quantidade_cor);
            this.Controls.Add(this.ano_carro_pesquisar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.click_quantidade_carro_corres);
            this.Controls.Add(this.click_MostrarDeAcordoComACor);
            this.Controls.Add(this.cor_Pesquisar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.click_QuantidadeModelos);
            this.Controls.Add(this.Click_Mostrar_Modelos);
            this.Controls.Add(this.modelo_Pesquisar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.click_todosOsCarros);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.click_QuantidadeMarcaMostrar);
            this.Controls.Add(this.click_MostrarMarcas);
            this.Controls.Add(this.MarcaPesquisar);
            this.Controls.Add(this.gridViewCarros);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Formulario do vendedor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCarros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox chassiCarroCadastrarVenda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nomeClienteCadastrarVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox clienteRgCadastrarVenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vendedorNomeCadastrarVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button click_cadastrar;
        private System.Windows.Forms.TextBox valorCarroCadastrarVenda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox anoCarroCadastrarVenda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox modeloCarroCadastrarVenda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox marcaCarroCadastrarVenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox corCarroCadastrarVenda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView gridViewCarros;
        private System.Windows.Forms.TextBox MarcaPesquisar;
        private System.Windows.Forms.Button click_MostrarMarcas;
        private System.Windows.Forms.Button click_QuantidadeMarcaMostrar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button click_todosOsCarros;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox modelo_Pesquisar;
        private System.Windows.Forms.Button Click_Mostrar_Modelos;
        private System.Windows.Forms.Button click_QuantidadeModelos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox cor_Pesquisar;
        private System.Windows.Forms.Button click_MostrarDeAcordoComACor;
        private System.Windows.Forms.Button click_quantidade_carro_corres;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ano_carro_pesquisar;
        private System.Windows.Forms.Button click_quantidade_cor;
        private System.Windows.Forms.Button click_ano_mostrar_carros;
        private System.Windows.Forms.DataGridView dataGridVendas;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button click_todasAsVendas;
        private System.Windows.Forms.TextBox pesquisarPorDataOuHora;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button click_mostrar;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button click_cancelar;
        private System.Windows.Forms.Label label19;
    }
}

