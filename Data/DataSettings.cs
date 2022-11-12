namespace validaThorAPI.Data
{
	public class MongoDatabaseSettings : IDatabaseSettings
	{
		public string UsersCollectionName { get; set; }
		public string ProductsCollectionName { get; set; }
		public string ConnectionString { get; set; }
		public string DatabaseName { get; set; }
	}

	public interface IDatabaseSettings
	{
		string UsersCollectionName { get; set; }
		string ProductsCollectionName { get; set; }
		string ConnectionString { get; set; }
		string DatabaseName { get; set; }
	}
}
