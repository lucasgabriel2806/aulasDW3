using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ExercicioClinica.Models
{
    public class Clinica
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Alarme { get; set; } // "Ligado" ou "Desligado"
    }
}
