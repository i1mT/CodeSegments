using CodeSegments_master.Model.Model;
using CodeSegments_master.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSegments_master.Presenter
{
    public class SearchInputPresenter : BasePresenter
    {
        public SearchInputPresenter(BaseView v) : base(v)
        {
            this.View.ID = "searchInput";
        }
        
    }
}
