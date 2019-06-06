using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using MongoDB.Bson;

namespace SimpleBotCore.Logic
{
    public class SimpleBotUser
    {
        public string Reply(SimpleMessage message)
        {
            
            SimpleDB.Iniciar();
            int qtdMsg = 0;
            
            SimpleDB.createDoc2(message.Id, qtdMsg++);
            /*
            var filter = Builders<SimpleLog>.Filter.Eq("user", message.User);
            //var results = SimpleDB.col.Find(filter).ToList();


            SimpleDB.createDoc2(message.User, qtdMsg++);
            */

            return $"{message.User} disse '{message.Text}' ({qtdMsg-1})";
        }

    }
}