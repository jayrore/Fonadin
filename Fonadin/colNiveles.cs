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
            var lista = new List<Nivel>();
            lista.Add(mayores);
            lista.Add(menores);
            return lista;
        }
    }
}
