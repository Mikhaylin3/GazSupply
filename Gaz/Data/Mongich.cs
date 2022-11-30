using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Reflection;
using static MongoDB.Bson.Serialization.Serializers.SerializerHelper;

namespace Gaz.Data
{
    public class Mongich
    {
        public IUserData user1;
        public static void ReplaceByName(IUserData member, string login)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("Davletka");
            var collection = database.GetCollection<IUserData>("GazWater");
            collection.ReplaceOne(x => x.Login == member.Login, member);
        }
        public static List <IUserData> FindAll()
        {
            BsonClassMap.RegisterClassMap<Designer>();
            BsonClassMap.RegisterClassMap<Developer>();
            BsonClassMap.RegisterClassMap<Projector>();
            var client = new MongoClient();
            var database = client.GetDatabase("Gaz");
            var col = database.GetCollection<IUserData>("User");
            var t = col.Find(x => true).ToList();
            List<IUserData> result = new List<IUserData>();
            foreach( var i in t)
            {
                result.Add(i);
            }
            return result;
        }

        public static void AddToDb(IUserData  use)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("Gaz");
            var col = database.GetCollection<IUserData>("User");
            col.InsertOne(use);

        }
        public IUserData GetUser()
        {
            return user1;
        }

        public void SetUser(IUserData user)
        {
            this.user1 = user;
        }
    }
}
