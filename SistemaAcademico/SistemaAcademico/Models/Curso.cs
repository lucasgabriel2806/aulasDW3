namespace SistemaAcademico.Models
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string? Nome { get; set; }
        public int Vagas { get; set; }
        public ICollection<Disciplina>? Disciplinas { get; set; }
    }
}
