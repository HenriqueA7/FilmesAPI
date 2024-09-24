using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DTO
{
    public class ReadFilmeDto
    {
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public int Duracao { get; set; }
        public DateTime HoraConsulta { get; set; } = DateTime.Now;
    }
}
