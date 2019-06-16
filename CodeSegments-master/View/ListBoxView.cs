using CodeSegments_master.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeSegments_master.View
{
    public class ListBoxView : BaseView, IBaseView
    {
        private new ListBox control;

        public ListBoxView(string id)
        {
            this.ID = id;
            // 获取实例
            if (Program.mainForm != null)
                this.control = Program.mainForm.list;
        }

        public override void BindModel(BaseModel bm)
        {
            this.Presenter.Model = bm;
            this.control.DataSource = this.Presenter.Model.CodeList;
            this.control.DisplayMember = "Title";
            this.control.ValueMember = "_id";
        }
    }
}
