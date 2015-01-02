using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;


namespace Fonadin
{
    class Presupuesto
    {
        [BsonIgnoreIfNull]
        public ObjectId _id { get; set; }
        //Nombre de la autopista
        public String nombre { get; set; }

        public String corredor { get; set; }
        
        public String programa { get; set; }

        public Double obra { get; set; }
        [System.ComponentModel.DefaultValue(0.0)]
        public Double supervision { get; set; }
        [System.ComponentModel.DefaultValue(0.0)]
        public Double inversion { get; set; }
    }
}
