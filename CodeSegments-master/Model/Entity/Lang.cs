using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeSegments_master.Model.Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CodeSegments_master.DBA.Entity
{
    public class Lang
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        public BsonDocument ToBsonDocument()
        {
            LangBson lb = new LangBson();
            lb.Name = this.Name;
            return lb.ToBsonDocument();
        }
    }

    class LangBson
    {
        [BsonElement("name")]
        public string Name { get; set; }
    }
}
