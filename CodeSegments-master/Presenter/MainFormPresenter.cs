using CodeSegments_master.DBA.DAO;
using CodeSegments_master.DBA.Entity;
using CodeSegments_master.Helper;
using CodeSegments_master.Model.DAO;
using CodeSegments_master.Model.Model;
using CodeSegments_master.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeSegments_master.Presenter
{
    public class MainFormPresenter : BasePresenter
    {
        public static SearchInputPresenter searchInputPresenter;
        public static SearchComboBoxPresenter searchComboBoxPresenter;
        public static SelectComboBoxPresenter selectComboBoxPresenter;
        public static ListBoxPresenter listBoxPresenter;

        /// <summary>
        /// 主窗口presenter构造函数
        /// </summary>
        /// <param name="v"></param>
        public MainFormPresenter(BaseView v):base(v)
        {
            this.View = v;
            this.View.ID = "MainForm";
        }

        /// <summary>
        /// 初始化主窗口
        /// </summary>
        public void Init ()
        {
            
            InitSearchInput();
            InitComboBox();
            RefreshCodeList();

            //  初始化高亮器的关键字
            HighLighter.KeywordsInitialize();
            HighLighter.RichHighlight(Program.mainForm.richText, Program.mainForm.richText.Text.Length);

        }

        /// <summary>
        /// 初始化搜索框
        /// </summary>
        public void InitSearchInput ()
        {
            searchInputPresenter = new SearchInputPresenter(new SearchInputView());
            SearchInputModel sim = new SearchInputModel();
            searchInputPresenter.View.BindModel(sim);
        }

        /// <summary>
        /// 初始化下拉列表，左上方和右下方的
        /// </summary>
        public void InitComboBox ()
        {
            LangDao langDao = new LangDao();

            // 获取所有语言
            List<Lang> allLang = langDao.GetAll();
            // 由于使用同一个List会造成两个combobox串数据的情况，故这里做一个副本
            List<Lang> allLang_clone = langDao.GetAll();


            // 视图
            SearchComboBoxView searchComboView = new SearchComboBoxView("searchComboBox");
            SelectComboBoxView selectComboBoxView = new SelectComboBoxView("setComboBox");

            // 表现器
            searchComboBoxPresenter = new SearchComboBoxPresenter(searchComboView);
            selectComboBoxPresenter = new SelectComboBoxPresenter(selectComboBoxView);

            
            ComboBoxModel cbm = new ComboBoxModel(allLang);
            ComboBoxModel set_cbm = new ComboBoxModel(allLang_clone, 2);

            // 绑定数据
            searchComboBoxPresenter.View.BindModel(cbm);
            // 注意：使用副本绑定
            selectComboBoxPresenter.View.BindModel(set_cbm);
        }

        /// <summary>
        /// 刷新代码列表
        /// </summary>
        /// <param name="lan"></param>  语言
        /// <param name="key"></param>  搜索关键字
        /// <param name="page"></param> 页数
        public static void RefreshCodeList(string lan = null, string key = null, int page = 1)
        {
            CodeDao codeDao = new CodeDao();
            // 获取一页代码段
            List<Code> codes = codeDao.Find(lan, key);
            if (codes.Count == 0)
            {
                // 如果没有找到，提示是否发布新文章
                ShowDialog();
            }
            // 视图
            ListBoxView listBoxView = new ListBoxView("list");

            // 表现器
            listBoxPresenter = new ListBoxPresenter(listBoxView);

            // 设置model
            ListBoxModel lbm = new ListBoxModel(codes);

            // 绑定
            listBoxPresenter.View.BindModel(lbm);



        }

        /// <summary>
        /// 弹出询问是否进入写作模式
        /// 
        /// </summary>
        public static void ShowDialog ()
        {
            DialogResult dr = MessageBox.Show("没有找到内容，是否进入写作模式？", "提示", MessageBoxButtons.OKCancel);

            if (dr == DialogResult.OK)
            {
                // 进入写作模式
                Program.curCodeId = null;
                Program.isWriteMode = true;
                Program.mainForm.modeLabel.Text = "写作模式";
            }
            Program.mainForm.richText.Text = "没有找到内容...";
        }


        /// <summary>
        /// 保存代码
        /// </summary>
        public static void SaveCode ()
        {
            string content = Program.mainForm.richText.Text;
            string title = Program.mainForm.searchInput.Text;
            string lan = (string)Program.mainForm.setComboBox.SelectedValue;

            Code code = new Code {
                Title = title,
                Lan = lan,
                Content = content,
                _id = Program.curCodeId
            };

            CodeDao codeDao = new CodeDao();

            if (Program.curCodeId != null)
            {
                // 阅读模式
                codeDao.Update(Program.curCodeId, code);

                DialogResult dr = MessageBox.Show("修改成功!", "提示", MessageBoxButtons.OK);

               
            } else {
                // 写作模式
                codeDao.Insert(code);

                DialogResult dr = MessageBox.Show("保存成功!", "提示", MessageBoxButtons.OK);

                // 返回阅读模式
                Program.isWriteMode = false;
                Program.mainForm.modeLabel.Text = "阅读模式";
                Program.mainForm.searchInput.Text = "";
            }


            RefreshCodeList();
        }

        /// <summary>
        /// 删除代码段
        /// </summary>
        public static void RemoveCode ()
        {
            string id = Program.curCodeId;

            CodeDao codeDao = new CodeDao();

            codeDao.Delete(id);

            DialogResult dr = MessageBox.Show("删除成功!", "提示", MessageBoxButtons.OK);

            RefreshCodeList();
        }
    }
}
