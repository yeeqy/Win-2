using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win实验2
{
    public partial class Form1 : Form
    {
        string filename;
        string fileplace;
        string sn;

        public Form1()
        {
            InitializeComponent();
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            fileplace = null;
            filename = "无标题";

        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.Text = openFileDialog1.SafeFileName;
                fileplace = openFileDialog1.FileName;
                StreamReader Reader1 = new StreamReader(fileplace, System.Text.Encoding.Default);
                String sLine = "";
                while (sLine != null)
                {
                    sLine = Reader1.ReadLine();
                    if (sLine != null && !sLine.Equals(""))
                        richTextBox1.Text = richTextBox1.Text + sLine;
                }
                Reader1.Close();
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileplace != null)
            {
                sn = richTextBox1.Text;
                StreamWriter writer1 = new StreamWriter(fileplace);
                writer1.WriteLine(sn);
                writer1.Close();
            }
            else
            {
                sn = richTextBox1.Text;
                saveFileDialog1.Filter = "txt files(*.txt)|*.*";
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName != null)
                {
                    string aa = saveFileDialog1.FileName;
                    StreamWriter writer1 = new StreamWriter(aa, true, System.Text.Encoding.Default);
                    for (int i = 0; i < richTextBox1.Lines.Length; i++)
                    {
                        writer1.WriteLine(sn);
                    }
                    filename = aa;
                    writer1.Close();
                }
            }
            this.Text = filename;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("18219110218\n18计算机一班\n叶清逸\n");
        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog.Color;
                richTextBox1.SelectionColor = color;
            }
        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog.Font;
            }
        }

        private void 自动换行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "*无标题-记事本";
            if (自动换行ToolStripMenuItem.Checked)
            {
                richTextBox1.WordWrap = true;
            }
            else
            {
                richTextBox1.WordWrap = false;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            fileplace = null;
            filename = "无标题";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.Text = openFileDialog1.SafeFileName;
                fileplace = openFileDialog1.FileName;
                StreamReader Reader1 = new StreamReader(fileplace, System.Text.Encoding.Default);
                String sLine = "";
                while (sLine != null)
                {
                    sLine = Reader1.ReadLine();
                    if (sLine != null && !sLine.Equals(""))
                        richTextBox1.Text = richTextBox1.Text + sLine;
                }
                Reader1.Close();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (fileplace != null)
            {
                sn = richTextBox1.Text;
                StreamWriter writer1 = new StreamWriter(fileplace);
                writer1.WriteLine(sn);
                writer1.Close();
            }
            else
            {
                sn = richTextBox1.Text;
                saveFileDialog1.Filter = "txt files(*.txt)|*.*";
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName != null)
                {
                    string aa = saveFileDialog1.FileName;
                    StreamWriter writer1 = new StreamWriter(aa, true, System.Text.Encoding.Default);
                    for (int i = 0; i < richTextBox1.Lines.Length; i++)
                    {
                        writer1.WriteLine(sn);
                    }
                    filename = aa;
                    writer1.Close();
                }
            }
            this.Text = filename;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog.Color;
                richTextBox1.SelectionColor = color;
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog.Font;
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("18219110218\n18计算机一班\n叶清逸\n");
        }


   
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
       
       
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            this.toolStripStatusLabel2.Text ="字数："+ richTextBox1.Text.Length.ToString();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
