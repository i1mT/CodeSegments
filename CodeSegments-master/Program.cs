using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeSegments_master.Main;
using CodeSegments_master.Presenter;
using CodeSegments_master.View;

namespace CodeSegments_master
{
    static class Program
    {

        public static MainForm mainForm; // 全局form对象
        public static bool isWriteMode = false;
        public static string curCodeId = "";
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 挂载到MVP模式中
            MainFormPresenter presenter = new MainFormPresenter(new MainView());
            mainForm = presenter.View.mainForm;
            presenter.Init();

            Application.Run(mainForm);
        }
    }
}
