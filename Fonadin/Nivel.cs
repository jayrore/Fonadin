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
    class Nivel
    {
        public ObjectId id {get; set; }
        //Nombre de el nivel
        public String nombre {get; set; }
        
        [BsonIgnoreIfNull]
        //Arreglo de sub niveles
        public List<Nivel> subNiveles {get; set; }
        
        public Nivel(String nombre){
            this.nombre = nombre;
        }
    }
}
