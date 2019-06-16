using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Configuration;
using CodeSegments_master.DBA.Entity;

namespace CodeSegments_master.DBA
{
    class MongoHelper <BsonDocument>
    {

        public static string conn = "mongodb://iimt:123456@www.iimt.me:27017/codeseg";
        public static string dbName = "codeseg";
        public static string collectionName = "lan";

        IMongoCollection<BsonDocument> collection;
        

        /// <summary>
        /// 获取集合
        /// </summary>
        public static IMongoCollection<BsonDocument> getCollection(string collectionName)
        {
            MongoClient client = new MongoClient(conn);
            var database = client.GetDatabase(dbName);

            return database.GetCollection<BsonDocument>(collectionName);
        }

        /// <summary>
        /// MongoDb查询
        /// </summary>
        /// <typeparam name="T">对象名称</typeparam>
        /// <param name="collectionName">表名</param>
        /// <returns></returns>
        protected static IQueryable<T> IQueryableInit<T>(string collectionName) where T : new()
        {
            var colls = new MongoClient(conn).GetDatabase(dbName).GetCollection<T>(collectionName);
            var query = from n in colls.AsQueryable() select n;
            return query;
        }

    }
}
