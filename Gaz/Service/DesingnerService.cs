using Gaz.Data;
using Gaz.IInvoiceService;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System.ComponentModel.Design;

namespace Gaz.Service
{
    public class DesingnerService : IdownloadService
    {
        private MongoClient _mongoClient = null;
        private IMongoDatabase _database = null;
        private IMongoCollection<IUserData> _designer = null;
        public DesingnerService()
        {
            _mongoClient = new MongoClient("mongodb://localhost:27017");
            _database = _mongoClient.GetDatabase("Gaz");
            _designer = _database.GetCollection<IUserData>("User");
        }
        public void DeletePdf(string id)
        {
            BsonClassMap.RegisterClassMap<Designer>();
            var des = _designer.Find(x => x.id == id);
            foreach (var item in _designer)
            {
                foreach (var t in des)
                {
                    t.Data = null;
                    _designer.ReplaceOne(x => x.id == (Object)id, t);
                }
            }
            var fd = _designer.Find(x => x.id == id).FirstOrDefault();


        }
        
        public List<IUserData> GetInvoices()
        {
            var mongoClient = new MongoClient("mongodb://localhost:27017");
            var database = mongoClient.GetDatabase("Gaz");
            var _designer = database.GetCollection<IUserData>("User");
            return _designer.Find(FilterDefinition<IUserData>.Empty).ToList();
        }

        public IUserData Save(Designer designer)
        {
            var mongoClient = new MongoClient("mongodb://localhost:27017");
            var database = mongoClient.GetDatabase("Gaz");
            var _designer = database.GetCollection<IUserData>("User");
            var des = _designer.AsQueryable<IUserData>().OfType<Designer>();
            foreach(var t in des) 
            {
                
            }
            return designer;
        }

        /*public IUserData UploadPdf(string id, byte[] bytes)
        {
            var fd = _designer.Find(x => x.id == id).FirstOrDefault();
            fd.Data = bytes;
            _designer.ReplaceOne(x => x.id == id, fd);
            return fd;
        }*/
    }
}
