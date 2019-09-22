using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPFVendas.DAL;
using WPFVendas.Models;

namespace WPFVendas.Views
{
    /// <summary>
    /// Interaction logic for frmCadastrarProduto.xaml
    /// </summary>
    public partial class frmCadastrarProduto : Window
    {
        private string msg;
        public frmCadastrarProduto(string msg)
        {
            InitializeComponent();
            this.msg = msg;
            MessageBox.Show(msg);
        }
        public frmCadastrarProduto()
        {
            InitializeComponent();
            txtCriadoEm.Text = DateTime.Now.ToString();
        }
        private void LimparFormulario()
        {
            txtNome.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();
            txtCriadoEm.Text = DateTime.Now.ToString();
            txtNome.Focus();
        }

        private void BtnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            Produto p = new Produto
            {
                Nome = txtNome.Text,
                Quantidade = Convert.ToInt32(txtQuantidade.Text),
                Preco = Convert.ToDouble(txtPreco.Text)
            };
            if (ProdutoDAO.CadastrarProduto(p))
            {
                MessageBox.Show("Produto cadastrado!");
                LimparFormulario();
            }
            else
            {
                MessageBox.Show("Esse produto já existe!");
            }
        }

        private void BtnBuscar_Click(object sender, RoutedEventArgs e)
        {
            Produto p = new Produto
            {
                Nome = txtNome.Text
            };
            p = ProdutoDAO.BuscarProdutoPorNome(p);
            if(p != null)
            {
                txtNome.Text = p.Nome;
                txtPreco.Text = p.Preco.ToString("C2");
                txtQuantidade.Text = p.Quantidade.ToString();
                txtCriadoEm.Text = p.CriadoEm.ToString();
            }
            else
            {
                MessageBox.Show("Esse produto não existe!");
            }
        }
    }
}
