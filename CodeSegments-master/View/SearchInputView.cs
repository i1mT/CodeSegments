using CodeSegments_master.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeSegments_master.View
{
    class SearchInputView : BaseView, IBaseView
    {
        private new TextBox control;
        public SearchInputView ()
        {
            this.ID = "searchInput";
            // 获取实例
            if (Program.mainForm != null)
            {
                control = Program.mainForm.searchInput;
            }
        }
        public override void BindModel (BaseModel bm)
        {
            this.Presenter.Model = bm;
            this.control.DataBindings.Add("Text", this.Presenter.Model, "Text");
        }
    }
}
