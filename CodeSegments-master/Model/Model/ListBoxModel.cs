using CodeSegments_master.DBA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSegments_master.Model.Model
{
    public class ListBoxModel : BaseModel
    {

        public ListBoxModel(List<Code> codeList)
        {
            CodeList = codeList;
        }
    }
}
