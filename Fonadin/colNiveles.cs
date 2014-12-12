using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
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
            var mayores = new Nivel("Mayores");        
            var menores = new Nivel("Menores");
            menores.subNiveles = new List<Subnivel>();
            menores.subNiveles.Add(new Subnivel("Construccion"));
            menores.subNiveles.Add(new Subnivel("Revicion"));
            var lista = new List<Nivel>();
            lista.Add(mayores);
            lista.Add(menores);
            Console.Write(lista.ToJson());
            return lista;
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
