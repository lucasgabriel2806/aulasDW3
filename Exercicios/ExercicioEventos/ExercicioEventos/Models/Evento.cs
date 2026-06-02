namespace ExercicioEventos.Models
{
    public class Evento
    {
        public int EventoId { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataEvento { get; set; }

        public int TipoId { get; set; }
        public Tipo Tipo { get; set; }

        public int PatrocinadorId { get; set; }
        public Patrocinador Patrocinador { get; set; }
    }
}
