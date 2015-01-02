using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Fonadin
{
    class Corredor
    {
        [BsonIgnoreIfNull]
        public ObjectId _id { get; set; }
        //Nombre de el nivel
        public String nombre { get; set; }
    }
}
