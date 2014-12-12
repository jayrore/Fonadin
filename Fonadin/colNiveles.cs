using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Driver.Operations;
using MongoDB.Bson;

namespace Fonadin
{
    class colNiveles : Mongo
    {
        public MongoCollection collection;
        public colNiveles() : base() {

            collection = this.db.GetCollection("niveles");
        }

        public List<Nivel> getNiveles()
        {
            MongoCursor<Nivel> cursor;
            try
            {
            cursor = collection.FindAllAs<Nivel>();
            Console.Write(cursor.ToJson());
            Console.WriteLine("Result de getNiveles");
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message.ToString());
                throw;
            }
            
            
            return cursor.ToList<Nivel>();
        }
        public BsonDocument save(Nivel nivel)
        {
            WriteConcernResult result = collection.Save<Nivel>(nivel);
            Console.WriteLine("Result de insert");
            Console.Write(result.Response.ToJson());
            return result.Response;
        }
    }
}
