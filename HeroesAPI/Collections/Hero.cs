using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace HeroesAPI.Collections;


[Table("heroes")]
[BsonIgnoreExtraElements]
public class Hero
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("nome")]
    [JsonPropertyName("Nome")]
    public string Nome { get; set; }

    [BsonElement("time")]
    [JsonPropertyName("Time")]
    public string Time { get; set; }

    [BsonElement("idade")]
    [JsonPropertyName("Idade")]
    public int Idade { get; set; }

    [BsonElement("genero")]
    public decimal Genero { get; set; }

    [BsonElement("habilidades")]
    public List<string> Habilidaes { get; set; }

    [BsonElement("tags")]
    public List<string> Tags { get; set; }

    [BsonElement("usaCa")]
    public bool UsaCapa { get; set; }

    [BsonElement("universo")]
    public string Universo { get; set; }


}
