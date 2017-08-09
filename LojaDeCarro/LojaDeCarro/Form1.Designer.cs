namespace LojaDeCarro
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.anoQuantidade = new System.Windows.Forms.TextBox();
            this.modeloQuantidade = new System.Windows.Forms.TextBox();
            this.marcaQuantidade = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mostrarCarros = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.marca_item = new System.Windows.Forms.TextBox();
            this.modelo_item = new System.Windows.Forms.TextBox();
            this.cor_item = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pesquisar_por_item = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "pesquisar quantidade";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.anoQuantidade);
            this.panel1.Controls.Add(this.modeloQuantidade);
            this.panel1.Controls.Add(this.marcaQuantidade);
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 170);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ano";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "marca";
            // 
            // anoQuantidade
            // 
            this.anoQuantidade.Location = new System.Drawing.Point(18, 104);
            this.anoQuantidade.Name = "anoQuantidade";
            this.anoQuantidade.Size = new System.Drawing.Size(100, 20);
            this.anoQuantidade.TabIndex = 2;
            // 
            // modeloQuantidade
            // 
            this.modeloQuantidade.Location = new System.Drawing.Point(18, 64);
            this.modeloQuantidade.Name = "modeloQuantidade";
            this.modeloQuantidade.Size = new System.Drawing.Size(100, 20);
            this.modeloQuantidade.TabIndex = 1;
            // 
            // marcaQuantidade
            // 
            this.marcaQuantidade.Location = new System.Drawing.Point(18, 22);
            this.marcaQuantidade.Name = "marcaQuantidade";
            this.marcaQuantidade.Size = new System.Drawing.Size(100, 20);
            this.marcaQuantidade.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mostrarCarros
            // 
            this.mostrarCarros.Location = new System.Drawing.Point(3, 6);
            this.mostrarCarros.Multiline = true;
            this.mostrarCarros.Name = "mostrarCarros";
            this.mostrarCarros.Size = new System.Drawing.Size(242, 304);
            this.mostrarCarros.TabIndex = 2;
            this.mostrarCarros.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.mostrarCarros);
            this.panel2.Location = new System.Drawing.Point(171, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 367);
            this.panel2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "mostrar carros";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(104, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "visualizar Carros";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pesquisar_por_item);
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.cor_item);
            this.panel3.Controls.Add(this.modelo_item);
            this.panel3.Controls.Add(this.marca_item);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(450, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(273, 367);
            this.panel3.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "pesquisar carros por item";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "marca";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "modelo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "cor";
            // 
            // marca_item
            // 
            this.marca_item.Location = new System.Drawing.Point(59, 6);
            this.marca_item.Name = "marca_item";
            this.marca_item.Size = new System.Drawing.Size(177, 20);
            this.marca_item.TabIndex = 3;
            // 
            // modelo_item
            // 
            this.modelo_item.Location = new System.Drawing.Point(59, 29);
            this.modelo_item.Name = "modelo_item";
            this.modelo_item.Size = new System.Drawing.Size(177, 20);
            this.modelo_item.TabIndex = 4;
            // 
            // cor_item
            // 
            this.cor_item.Location = new System.Drawing.Point(59, 56);
            this.cor_item.Name = "cor_item";
            this.cor_item.Size = new System.Drawing.Size(177, 20);
            this.cor_item.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(7, 104);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(254, 206);
            this.textBox4.TabIndex = 6;
            // 
            // pesquisar_por_item
            // 
            this.pesquisar_por_item.Location = new System.Drawing.Point(186, 327);
            this.pesquisar_por_item.Name = "pesquisar_por_item";
            this.pesquisar_por_item.Size = new System.Drawing.Size(75, 23);
            this.pesquisar_por_item.TabIndex = 7;
            this.pesquisar_por_item.Text = "pesquisar";
            this.pesquisar_por_item.UseVisualStyleBackColor = true;
            this.pesquisar_por_item.Click += new System.EventHandler(this.pesquisar_por_item_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 460);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sistema de vendas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox anoQuantidade;
        private System.Windows.Forms.TextBox modeloQuantidade;
        private System.Windows.Forms.TextBox marcaQuantidade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox mostrarCarros;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button pesquisar_por_item;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox cor_item;
        private System.Windows.Forms.TextBox modelo_item;
        private System.Windows.Forms.TextBox marca_item;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

