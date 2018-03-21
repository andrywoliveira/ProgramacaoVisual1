namespace WebMvc.Models
{
    public class Pessoa
    {
        public int Id {get; set;}
        [Required]
        public string Nome {get; set;}
    }
}