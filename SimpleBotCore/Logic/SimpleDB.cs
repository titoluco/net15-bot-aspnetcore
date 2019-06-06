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
        public static IMongoCollection<BsonDocument> col { get; set; }
        public static void Iniciar()
        {
            client = new MongoClient("mongodb://localhost:27017");
            db = client.GetDatabase("15NET");
            col = db.GetCollection<BsonDocument>("col33");
        }
        public static void createDoc()
        {
            var doc = new BsonDocument();
            //col.InsertOne(doc);

        }

        public static void createDoc2(string idUsuario, int qtdMsg)
        {
            //var doc = new BsonDocument()
            //{
            //    Usuario = idUsuario,
            //    qtdMensagens = qtdMsg
            //};


            var doc = new BsonDocument() {
                { "campo1", 1 },
                { "campo2", 2 }};
            col.InsertOne(doc);
        }
    }
}
