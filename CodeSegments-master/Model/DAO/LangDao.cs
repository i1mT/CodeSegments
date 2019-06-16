using CodeSegments_master.DBA.Entity;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace CodeSegments_master.DBA.DAO
{
    class LangDao : BaseDao
    {
        public static IQueryable<Entity.Lang> GetQueryable ()
        {
            var query = IQueryableInit<Entity.Lang>("lang");

            return query;
        }
        
        /// <summary>
        /// 通过collection获取
        /// </summary>
        /// <returns></returns>
        public List<Lang> GetAll ()
        {
            var collection = BaseDao.getCollection("lang");

            var FilterDef = new FilterDefinitionBuilder<Lang>();
            var filter = FilterDef.Empty;

            var emList = collection.Find(Builders<BsonDocument>.Filter.Empty);

            return emList.As<Lang>().ToList();
        }

        public void Insert(Lang l)
        {
            var collection = BaseDao.getCollection("lang");

            collection.InsertOne(l.ToBsonDocument());
        }
    }
}
