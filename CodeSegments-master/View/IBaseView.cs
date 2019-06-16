using CodeSegments_master.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSegments_master.View
{
    interface IBaseView
    {
        void BindModel(BaseModel bm);
    }
}
