using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeSegments_master.DBA;
using CodeSegments_master.DBA.Entity;
using CodeSegments_master.DBA.DAO;
using MongoDB.Driver;
using MongoDB.Bson;

namespace CodeSegments_master.Main
{
    class Init
    {

        public static void initData(MainForm mainForm)
        {
            Init init = new Init();
            init.insertLang();
            // init.getLang();
        }

        public void getLang () {
            var langQuery = LangDao.GetQueryable();
            Lang lang = new Lang { Name = "C++" };
            var res = langQuery.First();
            
        }

        public void insertLang ()
        {

            var collection = BaseDao.getCollection("lang");

            Lang lang = new Lang
            {
                Name = "C++"
            };

            var langBson = lang.ToBsonDocument();
            

            collection.InsertOne(langBson);
        }

    }
}
