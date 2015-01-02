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
    class ColCorredores : Mongo
    {
        public MongoCollection collection;
        public ColCorredores(): base()
        {
            collection = this.db.GetCollection("corredores");
        }

        public List<Corredor> getAll()
        {
            MongoCursor<Corredor> cursor;
            try
            {
            cursor = collection.FindAllAs<Corredor>();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message.ToString());
                throw;
            }
            
            
            return cursor.ToList();
        }

        public Corredor getByNombre(string nombre){

            var query = new QueryDocument("nombre", nombre);
            var cursor = collection.FindOneAs<Corredor>(query);
            return cursor;
        }
        public BsonDocument save(Corredor nivel)
        {
            WriteConcernResult result = collection.Save<Corredor>(nivel);
            Console.WriteLine("Result de insert");
            Console.Write(result.Response.ToJson());
            return result.Response;
        }

        public bool delete(String corredorName)
        {
            WriteConcernResult result;

            result = collection.Remove(Query.EQ("nombre", corredorName));
            return result.Ok;
        }
    }
}
