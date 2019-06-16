using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeSegments_master.Helper
{
    public static class HighLighter
    {

        private static Hashtable keywords = new Hashtable();
        public static string fontName = "Consolas";
        public static int fontSize = 15;

        public static void KeywordsInitialize()
        {
            keywords.Add("using", "1");
            keywords.Add("public", "1");
            keywords.Add("private", "1");
            keywords.Add("namespace", "1");
            keywords.Add("class", "1");
            keywords.Add("set", "1");
            keywords.Add("get", "1");
            keywords.Add("void", "1");
            keywords.Add("int", "1");
            keywords.Add("string", "1");
            keywords.Add("float", "1");
            keywords.Add("double", "1");
            keywords.Add("for", "1");
            keywords.Add("foreach", "1");
            keywords.Add("in", "1");
            keywords.Add("object", "1");
            keywords.Add("if", "1");
            keywords.Add("else", "1");
            keywords.Add("while", "1");
            keywords.Add("do", "1");
            keywords.Add("partial", "1");
            keywords.Add("switch", "1");
            keywords.Add("case", "1");
            keywords.Add("default", "1");
            keywords.Add("continue", "1");
            keywords.Add("break", "1");
            keywords.Add("return", "1");
            keywords.Add("new", "1");
            keywords.Add("bool", "1");
            keywords.Add("null", "1");
            keywords.Add("false", "1");
            keywords.Add("true", "1");
            keywords.Add("catch", "1");
            keywords.Add("finally", "1");
            keywords.Add("try", "1");
            keywords.Add("enum", "1");
            keywords.Add("extern", "1");
            keywords.Add("inline", "1");
            keywords.Add("char", "1");
            keywords.Add("byte", "1");
            keywords.Add("const", "1");
            keywords.Add("long", "1");
            keywords.Add("protected", "1");
            keywords.Add("short", "1");
            keywords.Add("signed", "1");
            keywords.Add("unsigned", "1");
            keywords.Add("struct", "1");
            keywords.Add("static", "1");
            keywords.Add("this", "1");
            keywords.Add("throw", "1");
            keywords.Add("union", "1");
            keywords.Add("virtual", "1");
            keywords.Add("abstract", "1");
            keywords.Add("event", "1");
            keywords.Add("as", "1");
            keywords.Add("explicit", "1");
            keywords.Add("base", "1");
            keywords.Add("operator", "1");
            keywords.Add("out", "1");
            keywords.Add("params", "1");
            keywords.Add("typeof", "1");
            keywords.Add("uint", "1");
            keywords.Add("ulong", "1");
            keywords.Add("checked", "1");
            keywords.Add("goto", "1");
            keywords.Add("unchecked", "1");
            keywords.Add("readonly", "1");
            keywords.Add("unsafe", "1");
            keywords.Add("implicit", "1");
            keywords.Add("ref", "1");
            keywords.Add("ushort", "1");
            keywords.Add("decimal", "1");
            keywords.Add("sbyte", "1");
            keywords.Add("interface", "1");
            keywords.Add("sealed", "1");
            keywords.Add("volatile", "1");
            keywords.Add("delegate", "1");
            keywords.Add("internal", "1");
            keywords.Add("is", "1");
            keywords.Add("sizeof", "1");
            keywords.Add("lock", "1");
            keywords.Add("stackalloc", "1");
            keywords.Add("var", "1");
            keywords.Add("value", "1");
            keywords.Add("yield", "1");
        }

        /// <summary>
        /// C#语法高亮着色器
        /// </summary>
        /// <param name="start">起始行号</param>
        public static void RichHighlight(RichTextBox rich, int selectionStart, int start = 0)
        {
            
            // 真实RichText
            RichTextBox realRichText = rich;
            
            // 跳板RichText
            RichTextBox richText = Program.mainForm.cloneRichText;
            richText.Text = realRichText.Text;

            // 获取所有行
            string[] ln = richText.Text.Split('\n');

            // 先初始化所有的
            richText.Select(0, richText.Text.Length);
            richText.SelectionFont = new Font(fontName, fontSize, (FontStyle.Regular));
            richText.SelectionColor = Color.Black;

            int pos = 0;
            int lnum = 0;
            foreach (string lv in ln)
            {
                if (lnum >= start)
                {
                    string ts = lv.Replace("(", " ").Replace(")", " ");
                    ts = ts.Replace("[", " ").Replace("]", " ");
                    ts = ts.Replace("{", " ").Replace("}", " ");
                    ts = ts.Replace(".", " ").Replace("=", " ").Replace(";", " ");

                    if (lv.Trim().StartsWith("//"))
                    {
                        richText.Select(pos, lv.Length);
                        richText.SelectionFont = new Font(fontName, fontSize, (FontStyle.Regular));
                        richText.SelectionColor = Color.Gray;
                        pos += lv.Length + 1;
                        continue;
                    }

                    if (lv.Trim().StartsWith("#"))
                    {
                        richText.Select(pos, lv.Length);
                        richText.SelectionFont = new Font(fontName, fontSize, (FontStyle.Regular));
                        richText.SelectionColor = Color.Green;
                        pos += lv.Length + 1;
                        continue;
                    }

                    ArrayList marks = new ArrayList();
                    string smark = "";
                    string last = "";
                    bool inmark = false;
                    for (int i = 0; i < ts.Length; i++)
                    {
                        if (ts.Substring(i, 1) == "\"" && last != "\\")
                        {
                            if (inmark)
                            {
                                marks.Add(smark + "," + i);
                                smark = "";
                                inmark = false;
                            }
                            else
                            {
                                smark += i;
                                inmark = true;
                            }
                        }
                        last = ts.Substring(i, 1);
                    }
                    if (inmark)
                    {
                        marks.Add(smark + "," + ts.Length);
                    }

                    string[] ta = ts.Split(' ');
                    int x = 0;
                    foreach (string tv in ta)
                    {
                        if (tv.Length < 2)
                        {
                            x += tv.Length + 1;
                            continue;
                        }
                        else
                        {
                            bool find = false;
                            foreach (string px in marks)
                            {
                                string[] pa = px.Split(',');
                                if (x >= Int32.Parse(pa[0]) && x < Int32.Parse(pa[1]))
                                {
                                    find = true;
                                    break;
                                }
                            }
                            if (!find)
                            {
                                if (keywords[tv] != null)
                                {
                                    richText.Select(pos + x, tv.Length);
                                    richText.SelectionFont = new Font(fontName, fontSize, (FontStyle.Regular));
                                    richText.SelectionColor = Color.Blue;
                                }
                            }
                            x += tv.Length + 1;
                        }
                    }

                    foreach (string px in marks)
                    {
                        string[] pa = px.Split(',');
                        richText.Select(pos + Int32.Parse(pa[0]), Int32.Parse(pa[1]) - Int32.Parse(pa[0]) + 1);
                        richText.SelectionFont = new Font(fontName, fontSize, (FontStyle.Regular));
                        richText.SelectionColor = Color.DarkRed;
                    }
                }
                pos += lv.Length + 1;
                lnum++;
            }

            realRichText.Text = richText.Text;
            realRichText.SelectedRtf = richText.Rtf;
            

            // 返回光标，重置画笔
            realRichText.Select(selectionStart, 0);
            realRichText.SelectionFont = new Font(fontName, fontSize, (FontStyle.Regular));
            realRichText.SelectionColor = Color.Black;
        }

        public static void hideHighLight (int start)
        {
            RichTextBox richText = Program.mainForm.richText;

            richText.Text = richText.Text;

            richText.Select(start, 0);
        }
    }
}