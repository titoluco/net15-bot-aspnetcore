using MongoDB.Bson;
using MongoDB.Driver;
using System.Linq;

namespace SimpleBotCore.Logic
{
    public static class SimpleDB
    {
        public static string ConnectionString { get; set; }
        public static string Banco { get; set; }
        public static string Collection { get; set; }
        public static IMongoClient client { get; set; }
        public static IMongoDatabase db { get; set; }
        public static IMongoCollection<BsonDocument> col { get; set; }
        public static void Iniciar()
        {
            client = new MongoClient(ConnectionString);
            db = client.GetDatabase(Banco);
            col = db.GetCollection<BsonDocument>(Collection);
        }
        public static void createDoc(SimpleMessage message)
        {
            var doc = new BsonDocument() {
                { "Id", message.Id },
                { "User", message.User },
                { "Text", message.Text }
            };

            col.InsertOne(doc);
        }
        public static int getDoc(string Id)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Id", Id);
            var results = SimpleDB.col.Find(filter).ToList();
            return results.Count();
        }
    }
}
