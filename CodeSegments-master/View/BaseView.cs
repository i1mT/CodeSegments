using CodeSegments_master.Model.Model;
using CodeSegments_master.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeSegments_master.View
{
    public class BaseView : IBaseView
    {
        private string _id;
        private Control _control;
        public MainForm mainForm;

        public BasePresenter Presenter;


        public Control control
        {
            // 绑定控件触发器
            get { return _control; }
            set
            {
                this._control = value;
                if (this.Presenter != null)
                    this.BindModel(this.Presenter.Model);
            }
        }

        public string ID;

        public BaseView()
        {
        }

        public void getControl ()
        {
            // 获取实例
            if (Program.mainForm != null && this._id != null)
                this.control = Program.mainForm.Controls.Find(this.ID, false)[0];
            else
                this.control = null;
        }

        public virtual void BindModel(BaseModel bm)
        {
            // 虚方法，基类不绑定model
        }
    }
}
