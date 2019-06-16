using CodeSegments_master.DBA.DAO;
using CodeSegments_master.DBA.Entity;
using CodeSegments_master.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSegments_master.Model.Model
{
    public class BaseModel
    {
        public string Text { get; internal set; }
        public object CodeList { get; internal set; }
        public List<Lang> SrcLangList { get; internal set; }
        public List<Lang> SetLangList { get; internal set; }
    }

    
}
