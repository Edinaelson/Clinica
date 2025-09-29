namespace Clinica.Models
{
    public class Procedimento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Double Preco { get; set; }
        public string? UrlImage { get; set; }  // nullable
    }
}
