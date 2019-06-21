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
            int qtd = SimpleDB.getDoc(message.Id);
            SimpleDB.createDoc(message);
            string retorno = $"{message.User} disse '{message.Text}' ({qtd + 1} {(qtd == 0 ? " mensagem enviada" : " mensagens enviadas")})";

            return retorno;
        }

    }
}