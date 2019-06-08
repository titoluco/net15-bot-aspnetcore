using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBotCore.Logic
{
    public static class SimpleDB
    {
        public static IMongoClient client { get; set; }
        public static IMongoDatabase db { get; set; }
        public static IMongoCollection<SimpleMessage> col { get; set; }
        public static void Iniciar()
        {
            client = new MongoClient("mongodb://localhost:27017");
            db = client.GetDatabase("15NET");
            col = db.GetCollection<SimpleMessage>("novo");
        }
        public static void createDoc()
        {
            var doc = new BsonDocument();
            //col.InsertOne(doc);

        }

        public static void createDoc2(SimpleMessage message)
        {
            //var doc = new BsonDocument()
            //{
            //    Usuario = idUsuario,
            //    qtdMensagens = qtdMsg
            //};

            /*
            var doc = new BsonDocument() {
                { "campo1", 1 },
                { "campo2", 2 }};
            */
            col.InsertOne(message);
        }
        public static int getDoc(string Id)
        {
            var filter = Builders<SimpleMessage>.Filter.Eq("Id", Id);
            var results = SimpleDB.col.Find(filter).ToList();
            return results.Count();
        }
    }
}
