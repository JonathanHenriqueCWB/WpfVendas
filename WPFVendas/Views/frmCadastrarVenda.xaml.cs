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
    /// Interaction logic for frmCadastrarVenda.xaml
    /// </summary>
    public partial class frmCadastrarVenda : Window
    {
        private List<dynamic> produtos = new List<dynamic>();
        double total = 0;
        public frmCadastrarVenda()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //dtaProdutos.ItemsSource = ProdutoDAO.ListarProdutos();
            cboProdutos.ItemsSource =
                ProdutoDAO.ListarProdutos();
            cboProdutos.DisplayMemberPath = "Nome";
            cboProdutos.SelectedValuePath = "ProdutoId";
        }

        private void BtnAdicionar_Click(object sender, RoutedEventArgs e)
        {
            if (!txtQuantidade.Text.Equals(""))
            {
                int idProduto =
                    Convert.ToInt32(cboProdutos.SelectedValue);
                Produto p = ProdutoDAO.BuscarProdutoPorId(idProduto);
                dynamic d = new
                {
                    Produto = p.Nome,
                    Quantidade = txtQuantidade.Text,
                    Preco = p.Preco,
                    Subtotal = 
                        Convert.ToInt32(txtQuantidade.Text) * p.Preco
                };
                produtos.Add(d);
                dtaProdutos.ItemsSource = produtos;
                dtaProdutos.Items.Refresh();
                total += 
                    p.Preco * Convert.ToInt32(txtQuantidade.Text);
                lblTotal.Content = "Total: " + total.ToString("C2");

            }
            else
            {
                MessageBox.Show("Favor preencher a quantidade!");
            }
        }

        private void CboProdutos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dynamic d = dtaProdutos.SelectedItem;
            MessageBox.Show(d.Produto);
        }

        private void DtaProdutos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dynamic d = dtaProdutos.SelectedItem;
            MessageBox.Show(d.Produto);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DateTime? data = dteData.SelectedDate;
            string mensagem = "Data: " + data.ToString();
            ComboBoxItem item = 
                (ComboBoxItem) cboHora.SelectedItem;
            mensagem += "\nHora: " + item.Content;
            MessageBox.Show(mensagem);

        }
    }
}
