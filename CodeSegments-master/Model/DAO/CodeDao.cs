using CodeSegments_master.DBA;
using CodeSegments_master.DBA.Entity;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeSegments_master.Model.DAO
{
    class CodeDao:BaseDao
{
        public IMongoCollection<BsonDocument> collection;
        public static IQueryable<Code> query;

        public CodeDao() {
            collection = BaseDao.getCollection("code");
            query = IQueryableInit<Code>("code");
        }

        public static IQueryable<Code> GetQueryable()
        {
            return query;
        }

        /// <summary>
        /// 通过collection获取
        /// </summary>
        /// <returns></returns>
        public List<Code> Find(string lang = null, string key = null, int page = 1)
        {
            var FilterDef = Builders<BsonDocument>.Filter;
            int capacity = 7;
            int skipNum = (page - 1) * capacity;

            // 查询条件
            var filter = "{ ";
            if (lang != null)
            {
                filter = filter + "lan: '" + lang + "',";
            }

            if (key != null)
            {
                filter = filter + "$or:[" +
                                            "{ title: {$regex: '" + key + "'} }," +
                                            "{ content: {$regex: '" + key + "'} }" +
                                          "]";
            }

            // 排序
            SortDefinitionBuilder<BsonDocument> sortBuilder = Builders<BsonDocument>.Sort;
            SortDefinition<BsonDocument> sortRule = sortBuilder.Descending("_id");
                                    
                                    
            filter = filter + "}";
            // TODO: 
            // .Skip(skipNum).Limit(capacity) 暂不skip
            var res = collection.Find(filter).Sort(sortRule).As<Code>().ToList();
            return res;
        }

        /// <summary>
        /// 新增一个
        /// </summary>
        /// <param name="l"></param> Code 实体
        public void Insert(Code l)
        {
            collection.InsertOne(l.ToBsonDocument());
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="_id"></param> id
        public void Delete (string _id)
        {
            var filter = "{ _id: ObjectId('" + _id + "') }";

            collection.DeleteOne(filter);
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="_id"></param> id
        /// <param name="l"></param> Code实体
        public void Update (string _id, Code l)
        {
            var filter = "{ _id: ObjectId('" + _id + "') }";

            collection.InsertOne(l.ToBsonDocument());

            Delete(_id);
        }
     
    }
}
