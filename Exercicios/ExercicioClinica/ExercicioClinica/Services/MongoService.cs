using MongoDB.Driver;

using ExercicioClinica.Models;

public class MongoService
{
    private readonly IMongoCollection<Clinica> _clinicas;

    public MongoService(IConfiguration config)
    {
        var client = new MongoClient(config["MongoDB:ConnectionString"]);
        var database = client.GetDatabase(config["MongoDB:DatabaseName"]);
        _clinicas = database.GetCollection<Clinica>(config["MongoDB:CollectionName"]);
    }

    public List<Clinica> Get() => _clinicas.Find(c => true).ToList();

    public void Create(Clinica c) => _clinicas.InsertOne(c);

    public void ToggleAlarme(string id)
    {
        var clinica = _clinicas.Find(c => c.Id == id).FirstOrDefault();
        clinica.Alarme = clinica.Alarme == "Ligado" ? "Desligado" : "Ligado";

        _clinicas.ReplaceOne(c => c.Id == id, clinica);
    }
}