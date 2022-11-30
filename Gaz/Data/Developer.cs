using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Gaz.Data
{
    [BsonKnownTypes(typeof(Developer))]
    //заказчик
    [BsonDiscriminator("Developer")]
    public class Developer : IUserData
    {
        [BsonId]
        [BsonIgnoreIfNull]
        public Object id { get; set; }
        public string? Name { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Info { get; set; }
        
    }
}
