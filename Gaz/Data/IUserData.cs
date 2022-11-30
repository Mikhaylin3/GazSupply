using Microsoft.AspNetCore.Components.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Gaz.Data
{
    
    public interface IUserData
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
        public string? Phone { get; set; }
    }
}
