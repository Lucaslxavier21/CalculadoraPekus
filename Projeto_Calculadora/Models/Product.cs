namespace Projeto_Calculadora.Models
{
    public class Product
    {
        public int Id { get; init; }
        public decimal ValorA { get; set; }
        public decimal ValorB { get; set; }
        public string Operacao { get; set; }
        public decimal Resultado { get; set; }
        public DateTime DataHora { get; init; }    
    }

}
