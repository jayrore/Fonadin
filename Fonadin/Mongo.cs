using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Fonadin
{
    class Mongo
    {
        private MongoUrl urlCon = new MongoUrl("mongodb://jayroserver-pc");
        private MongoClient client;
        protected MongoServer server;
        protected MongoDatabase db;
        public Mongo()
        {
            client = new MongoClient(urlCon);
            server = client.GetServer();
            db = server.GetDatabase("fonadin");
        }
        protected MongoDatabase getDB(){
            return this.db;
        }
     
    }
}
