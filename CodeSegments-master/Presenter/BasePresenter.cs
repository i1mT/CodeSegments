using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeSegments_master.Model.Model;
using CodeSegments_master.View;

namespace CodeSegments_master.Presenter
{
    public class BasePresenter
    {
        private BaseModel _model;

        public BaseView View;
        public BaseModel Model
        {
            // 绑定控件触发器
            get { return _model; }
            set
            {
                this._model = value;
                //if (this.View.control != null)
                //    this.View.BindModel(this.Model);
            }
        }

        public BasePresenter(BaseView v)
        {
            this.View = v;
            this.View.Presenter = this;
        }
    }
}
