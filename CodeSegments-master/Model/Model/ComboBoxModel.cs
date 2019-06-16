using CodeSegments_master.DBA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSegments_master.Model.Model
{
    public class ComboBoxModel : BaseModel
    {
        public ComboBoxModel(List<Lang> langList, int type = 1)
        {
            if (type == 1)
                SrcLangList = langList;
            else
                SetLangList = langList;
        }
    }
}
