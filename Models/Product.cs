using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace validaThorAPI.Models
{
  public class Product
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string Id { get; set; }

		[BsonElement("ProductName")]
		public string ProductName { get; set; }

		public string ProductDescription { get; set; }

		public string ProductNote { get; set; }
	}
}
