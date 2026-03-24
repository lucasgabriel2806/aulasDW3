using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace VasosInteligentes.Models
{
    public class Vaso
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id { get; set; }
        public string? Nome { get; set; }
        public double PlantaId { get; set; }
        [Display(Name = "Localização")]
        public string? Localizacao { get; set; }
        public List<Planta> PlantaRelacionada { get; set; } = new List<Planta>();
    }
}
