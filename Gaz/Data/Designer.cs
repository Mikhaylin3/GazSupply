using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;

namespace Gaz.Data
{
    [BsonKnownTypes(typeof(Designer))]
    [BsonDiscriminator("Designer")]
    public class Designer : IUserData, IGazDocument
    {
        //застройщик
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
        public string? OGPN { get; set; }
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string? Supervisor { get; set; }
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public byte[] Data { get ; set ; }

    }
    
}
