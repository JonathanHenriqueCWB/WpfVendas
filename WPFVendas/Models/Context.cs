using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFVendas.Models
{
    class Context : DbContext
    {
        public Context() : base("DbVendasWPF") { }
        public DbSet<Produto> Produtos { get; set; }
    }
}
