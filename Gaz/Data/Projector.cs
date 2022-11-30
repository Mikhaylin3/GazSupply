using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Net;

namespace Gaz.Data
{
    [BsonDiscriminator("Projector")]
    public class Projector : IUserData
    {
        [BsonId]
        [BsonIgnoreIfNull]
        public Object id { get; set; }
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string? Name { get; set; }
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string? Login { get; set; }
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string? Password { get; set; }
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string? Email { get; set; }
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string? Adress { get; set; }
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string? Phone { get; set; }
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string? INN { get; set; }
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string? KPP { get; set; }
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string? OGNP { get; set; }
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string? Director { get; set;}
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string? Engineer { get; set; }
    }
}
