using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace Fonadin
{
    class Subnivel
    {
        public String nombre {get; set; }
        
        [BsonIgnoreIfNull]
        //Arreglo de sub niveles
        public List<Subnivel> subNiveles {get; set; }

        public Subnivel(String nombre)
        {
            this.nombre = nombre;
        }
    }
}
