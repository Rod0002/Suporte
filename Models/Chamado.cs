namespace SuporteAPI.Models
{
    public class Chamado
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; } 
        public Usuario Usuario { get; set; }
    }
}
