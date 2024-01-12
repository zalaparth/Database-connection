using MongoDB.Driver;

namespace studentinfo.models
{
    public class Contextdb
    {
        private readonly IMongoDatabase db;

        public Contextdb(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetConnectionString("MongoDB"));
            db = client.GetDatabase(configuration["ConnectionStrings:DatabaseName"]);

            student = db.GetCollection<student>("student");
        }

        public readonly IMongoCollection<student> student;
    }
}
