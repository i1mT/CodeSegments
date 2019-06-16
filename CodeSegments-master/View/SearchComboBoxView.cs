using CodeSegments_master.DBA.Entity;
using CodeSegments_master.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeSegments_master.View
{
    public class SearchComboBoxView : BaseView, IBaseView
    {
        private new ComboBox control;
        public SearchComboBoxView (string id)
        {
            this.ID = id;
            // 获取实例
            if (Program.mainForm != null)
                this.control = (ComboBox)Program.mainForm.searchComboBox;
        }
        public override void BindModel(BaseModel bm)
        {
            this.Presenter.Model = (ComboBoxModel)bm;
            this.Presenter.Model.SrcLangList.Insert(0, new Lang { Name = "" });
            this.control.DataSource = this.Presenter.Model.SrcLangList;
            this.control.DisplayMember = "Name";
            this.control.ValueMember = "Name";//对应的值
        }
    }
}
