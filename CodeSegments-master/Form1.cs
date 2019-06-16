using CodeSegments_master.DBA.Entity;
using CodeSegments_master.Helper;
using CodeSegments_master.Main;
using CodeSegments_master.Presenter;
using CodeSegments_master.View;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CodeSegments_master
{
    public partial class MainForm : Form
    {

        private bool isWindowsSizeMax = false; // false 正常, true 为最大化

        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            ///模拟关闭软件
            this.Close();
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minBtn_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maxBtn_Click(object sender, EventArgs e)
        {
            if (this.isWindowsSizeMax)
            {
                this.WindowState = FormWindowState.Normal;
            } else
            {
                this.WindowState = FormWindowState.Maximized;
            }

            this.isWindowsSizeMax = !this.isWindowsSizeMax;
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            // list.SelectedItem;
            Code code = (Code)list.SelectedItem;
            richText.Text = code.Content;
            searchInput.Text = code.Title;
            setComboBox.Text = code.Lan;
            Program.curCodeId = code._id;
        }

        private void richText_TextChanged(object sender, EventArgs e)
        {
            int start = Program.mainForm.richText.SelectionStart;
            HighLighter.RichHighlight(Program.mainForm.richText, start);
            /* if (!Program.isWriteMode)
            {
                // 取消语法高亮
                HighLighter.hideHighLight(start);
            } else
            {
                HighLighter.RichHighlight(Program.mainForm.richText, start);
            } */
        }

        private void searchInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                // enter 被按下
                string key = Program.mainForm.searchInput.Text;
                string lan = (string)Program.mainForm.searchComboBox.SelectedValue;
                if (lan == "") lan = null;
                MainFormPresenter.RefreshCodeList(lan, key);
            }
        }

        private void searchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object L = Program.mainForm.searchComboBox.SelectedValue;
            string lan = "";

            if (L.GetType() == typeof(String))
            {
                lan = (string)L;
            }
            
            if (lan == "")
                lan = null;

            MainFormPresenter.RefreshCodeList(lan);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            MainFormPresenter.SaveCode();        }

        private void deleteLabel_Click(object sender, EventArgs e)
        {
            MainFormPresenter.RemoveCode();
        }

        private void richText_Click(object sender, EventArgs e)
        {
            // 进入写作模式
            Program.isWriteMode = true;
            Program.mainForm.modeLabel.Text = "写作模式";
        }
    }
}
