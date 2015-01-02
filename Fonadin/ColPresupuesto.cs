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
    class ColPresupuesto:Mongo
    {
        MongoCollection collection;
        public ColPresupuesto(): base()
        {
         collection = this.db.GetCollection("presupuestos");
        }

        public void save(Presupuesto autopista) 
        {
            collection.Save(autopista);
        }
        public List<Presupuesto> getAll()
        {
            MongoCursor<Presupuesto> cursor;
            try
            {
                cursor = collection.FindAllAs<Presupuesto>();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message.ToString());
                throw;
            }

            return cursor.ToList();
        }

    }
}
