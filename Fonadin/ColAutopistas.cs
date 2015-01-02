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
    class ColAutopistas : Mongo
    {
        MongoCollection collection;
        public ColAutopistas() : base()
        {
         collection = this.db.GetCollection("autopistas");
        }

        public WriteConcernResult save(Autopista autopista) 
        {
            WriteConcernResult result;
            try
            {
                autopista.nombre = autopista.nombre.ToLower();
                result = collection.Save<Autopista>(autopista, WriteConcern.W1);
                Console.WriteLine("Result de insert");
                Console.Write(result.Response.ToJson());
                return result;
            }
            catch (WriteConcernException wcEx)
            {
                Console.WriteLine(wcEx.Message);
                return wcEx.WriteConcernResult;
            }
           
        }
        public MongoCursor<Autopista> getAll()
        {
            MongoCursor<Autopista> cursor;
      
                cursor = collection.FindAllAs<Autopista>();
            return cursor;
        }

        public bool delete(String autopistaName)
        {
            WriteConcernResult result;

            result = collection.Remove(Query.EQ("nombre", autopistaName));
            return result.Ok;
        }

    }

}
