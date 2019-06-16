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
    public class Code
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        [BsonElement("title")]
        public string Title { get; set; }

        [BsonElement("content")]
        public string Content { get; set; }

        [BsonElement("tagName")]
        public string Tag { get; set; }

        [BsonElement("lan")]
        public string Lan { get; set; }

        public BsonDocument ToBsonDocument()
        {
            CodeBson cd = new CodeBson();
            cd.Title = this.Title;
            cd.Lan = this.Lan;
            cd.Content = this.Content;
            cd.Tag = this.Tag;
            return cd.ToBsonDocument();
        }
    }

    class CodeBson
    {
        [BsonElement("title")]
        public string Title { get; set; }

        [BsonElement("content")]
        public string Content { get; set; }

        [BsonElement("tagName")]
        public string Tag { get; set; }

        [BsonElement("lan")]
        public string Lan { get; set; }
    }
}
