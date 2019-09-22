﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFVendas.Models;

namespace WPFVendas.DAL
{
    class ProdutoDAO
    {
        private static Context ctx = new Context();
        public static bool CadastrarProduto(Produto p)
        {
            if (BuscarProdutoPorNome(p) == null)
            {
                ctx.Produtos.Add(p);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }
        public static Produto BuscarProdutoPorNome
            (Produto p)
        {
            return ctx.Produtos.FirstOrDefault
                (x => x.Nome.Equals(p.Nome));
        }
    }
}