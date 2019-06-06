using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Driver;
using SimpleBotCore.Logic;

namespace SimpleBotCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            var client = new MongoClient("mongodb://localhost:27017");

            var db = client.GetDatabase("15NET");
            var col = db.GetCollection<BsonDocument>("col1");

            var doc = new BsonDocument();
            col.InsertOne(doc);

            var docArray = from i in Enumerable.Range(1, 10)
                           select new BsonDocument
                           {
                               { "num", i }
                           };
            col.InsertMany(docArray);
            */            

            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
