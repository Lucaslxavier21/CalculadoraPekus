using Dapper;
using Projeto_Calculadora.Models;
using System.Data.SqlClient;
using System.Globalization;


namespace Projeto_Calculadora;

public partial class MainForm : Form
{
    decimal ValorA = 0, ValorB = 0;
    string Operacao = "";

    public string ConnectionString { get; }

    private void adicao_Click(object sender, EventArgs e)
    {
        var operacao = ((Button)sender).Tag.ToString();
        var resultado = operacao switch
        {
            "+" => valorA.Value + valorB.Value,
            "-" => valorA.Value - valorB.Value,
            "*" => valorA.Value * valorB.Value,
            "/" => valorA.Value / valorB.Value,
        };

        var product = new Product
        {
            ValorA = valorA.Value,
            ValorB = valorB.Value,
            Resultado = resultado,
            Operacao = operacao,
        };

        using var con = new SqlConnection(ConnectionString);
        con.Execute("insert Historico (ValorA, ValorB, Operacao, Resultado)" +
            "values(@ValorA, @ValorB, @Operacao, @Resultado)", product); 
        
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var form = new HistoricoForm(ConnectionString);
        form.ShowDialog();
    }

    public MainForm(string connectionString)
    {
        InitializeComponent();
        ConnectionString = connectionString;
    } 

}

