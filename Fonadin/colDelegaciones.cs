using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Driver.Operations;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization.Attributes;

namespace Fonadin
{
    class colDelegaciones : Mongo
    {
        public MongoCollection collection;
        public colDelegaciones(): base()
        {
            collection = this.db.GetCollection("delegaciones");
        }

        public List<Delegacion> getAll()
        {
            MongoCursor<Delegacion> cursor;
            try
            {
            cursor = collection.FindAllAs<Delegacion>();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message.ToString());
                throw;
            }
            
            
            return cursor.ToList();
        }

        public Delegacion getByNombre(string nombre){

            var query = new QueryDocument("nombre", nombre);
            var cursor = collection.FindOneAs<Delegacion>(query);
            return cursor;
        }
        public BsonDocument save(Delegacion nivel)
        {
            WriteConcernResult result = collection.Save<Delegacion>(nivel);
            Console.WriteLine("Result de insert");
            Console.Write(result.Response.ToJson());
            return result.Response;
        }
    }
}
