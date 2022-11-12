using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace validaThorAPI.Models
{
	public class User
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string Id { get; set; }

		[BsonElement("Name")]
		[Required(ErrorMessage = "Este campo é obrigatório")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Este campo é obrigatório")]
    [EmailAddress(ErrorMessage = "O campo {0} esta em formato inválido.")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Este campo é obrigatório")]
    [StringLength(100, 
    ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", 
    MinimumLength = 6)]
    public string Password { get; set; }
	}
}