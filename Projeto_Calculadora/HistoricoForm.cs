using Dapper;
using Projeto_Calculadora.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Calculadora
{
    public partial class HistoricoForm : Form
    {
        public HistoricoForm(string connectionString)
        {
            InitializeComponent();
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; }

        private void HistoricoForm_Load(object sender, EventArgs e)
        {
           
            
                using var con = new SqlConnection(ConnectionString);
                var historico = con.Query<Product>("select * from Historico").ToList();
                HistoricoGridView.DataSource = historico;
            
        }
    }
}
