using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSegments_master.DBA
{
    public class BaseDao
    {

        public static string conn = "mongodb://iimt:ATyangguang@www.iimt.me:27017/codeseg";
        public static string dbName = "codeseg";
        public static string collectionName = "lan";


        protected static IMongoDatabase MogoDatabase
        {
            get
            {
                return new MongoClient(conn).GetDatabase(dbName);
            }
        }

        /// <summary>
        /// MongoDb查询
        /// </summary>
        /// <typeparam name="T">对象名称</typeparam>
        /// <param name="collectionName">表名</param>
        /// <returns></returns>
        public static IQueryable<T> IQueryableInit<T>(string collectionName) where T : new()
        {
            var colls = MogoDatabase.GetCollection<T>(collectionName);
            var query = from n in colls.AsQueryable() select n;

            return query;
        }

        public static IMongoCollection<BsonDocument> getCollection(string collectionName)
        {
            MongoClient client = new MongoClient(conn);
            var database = client.GetDatabase(dbName);

            return database.GetCollection<BsonDocument>(collectionName);
        }
    }
}
