using System.ComponentModel.DataAnnotations;

namespace GeradorDeFolha.Models
{
    public class RecibosDePagModel
    {
        [Key]
        public int Id { get; set; }
        public int HExtras { get; set; }
        public decimal INSS { get; set; }
        public decimal IR { get; set; }
        public decimal Vencimentos { get; set; }
        public decimal Descontos { get; set; }
        public decimal Liquido { get; set; }
    }
}
