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
    class ColProgramas : Mongo
    {
        public MongoCollection collection;
        public ColProgramas() : base() {

            collection = this.db.GetCollection("programas");
        }

        public List<Programas> getNiveles()
        {
            MongoCursor<Programas> cursor;
            try
            {
            cursor = collection.FindAllAs<Programas>();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message.ToString());
                throw;
            }
            
            
            return cursor.ToList();
        }
        public WriteConcernResult save(Programas nivel)
        {
            WriteConcernResult result;
            try
            {
            result = collection.Save<Programas>(nivel, WriteConcern.W1);
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

        public bool delete(String prgmName)
        {
            WriteConcernResult result;

            result = collection.Remove(Query.EQ("nombre", prgmName));
            return result.Ok;
        }
    }
}
