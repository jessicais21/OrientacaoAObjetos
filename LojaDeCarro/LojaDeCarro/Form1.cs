using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaDeCarro
{
    public partial class Form1 : Form
    {
         ControleDeEstoque controleDeEstoque = new ControleDeEstoque();
       ControleDeVendas controleDeVendas = new ControleDeVendas();

        public Form1()
        {
            InitializeComponent();
        }

       // private void button1_Click(object sender, EventArgs e)
      //  {
          //  int ano = Convert.ToInt32(anoQuantidade.Text);
          //  int retornar = controleDeEstoque.QuantidadeDeCarro(marcaQuantidade.Text, modeloQuantidade.Text, ano);
           // MessageBox.Show(retornar.ToString());
      //  }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ano = Convert.ToInt32(anoQuantidade.Text);
           int retornar = controleDeEstoque.QuantidadeDeCarro(marcaQuantidade.Text, modeloQuantidade.Text, ano);
            MessageBox.Show(retornar.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mostrarCarros.Text = "";
     
            mostrarCarros.Text = controleDeEstoque.MostrarElementosDeUmaLista();
        //    MessageBox.Show("ola");
        }

        private void pesquisar_por_item_Click(object sender, EventArgs e)
        {

            if (marca_item.Text != null)
            {
                
                string nome = controleDeEstoque.PesquisarPelaMarca(marca_item.Text);
                MessageBox.Show(nome);

            }

            marca_item.Text = "";
        }
    }
}
