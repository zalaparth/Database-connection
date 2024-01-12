using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace studentinfo.models
{
    public class student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        public string name { get; set; } = string.Empty;
        public int age { get; set; }

    }
}
