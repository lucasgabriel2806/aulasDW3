using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace SistemaAcademico.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        // DataNotation
        [Display(Name = "RA")]
        [Required(ErrorMessage = "O RA é obrigatório.")]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "O RA deve ter entre 4 e 10 caracteres.")]
        public string? Ra { get; set; }
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
    }
}
