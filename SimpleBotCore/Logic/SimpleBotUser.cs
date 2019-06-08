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
            
            //SimpleDB.Iniciar();

            int a = SimpleDB.getDoc(message.Id);
            SimpleDB.createDoc2(message);

            return $"{message.User} disse '{message.Text}' ({a+1})";
        }

    }
}