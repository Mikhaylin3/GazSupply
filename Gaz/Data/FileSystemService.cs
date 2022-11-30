using Microsoft.AspNetCore.Components.Forms;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;

namespace Gaz.Data
{
    public class FileSystemService
    {
        public void UploadImageToDb(IBrowserFile file, string path)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Images");
            var gridFS = new GridFSBucket(database);

            using (FileStream fs = new FileStream($"{path}", FileMode.Open))
            {
                gridFS.UploadFromStream($"{file.Name}", fs);
            }
        }

        public void UploadImageToUserDb(IBrowserFile file, string path)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("UserImages");
            var gridFS = new GridFSBucket(database);

            using (FileStream fs = new FileStream($"{path}", FileMode.Open))
            {
                gridFS.UploadFromStream($"{file.Name}", fs);
            }
        }

    }
}
