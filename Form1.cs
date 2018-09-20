using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OperationHelper
{
    public partial class Form1 : Form
    {

        private string[] tenantArray = null;

        private List<FileInfo> copyFileList = new List<FileInfo>();

  

        /// <summary>
        /// 被排除的目录，这些目录下的文件不会被更新
        /// </summary>     
        private String[] forbidDirs = new string[] { };

        public Form1()
        {
            InitializeComponent();
            InitConfig();
            this.btn_copy.Click += btn_copy_Click;
            this.btn_open.Click += btn_open_Click;
        }

        private void InitConfig()
        {
            this.txt_tomcatHome.Text = ConfigurationManager.AppSettings["tomcatHome"];
            this.txt_tenant.Text = ConfigurationManager.AppSettings["defaultTenant"];
            this.txt_subPath.Text = ConfigurationManager.AppSettings["subPath"];
            String forbidDirStr = ConfigurationManager.AppSettings["forbidDirs"];
            if (!string.IsNullOrWhiteSpace(forbidDirStr))
            {
                forbidDirs = forbidDirStr.Split(new char[] { ',' });
            }
        }

        void btn_open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_sourceFile.Text = openFileDialog1.FileName;
            }

        }


        void btn_copy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("替换文件前请做好备份，确定替换文件吗？", "备份", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result != DialogResult.OK)
                return;

            try
            {
                DoCopy();
            }
            catch (Exception ex)
            {
                MessageBox.Show("程序出现了问题：" + ex.Message);
                return;
            }
            MessageBox.Show("成功");
        }


        private void DoCopy()
        {
            if (string.IsNullOrEmpty(txt_tomcatHome.Text))
            {
                throw new Exception("tomcat路径为空");
            }
            if (string.IsNullOrEmpty(txt_subPath.Text))
            {
                throw new Exception("子文件夹路径为空");
            }
            if (string.IsNullOrEmpty(txt_sourceFile.Text))
            {
                throw new Exception("源文件为空");
            }

            FileInfo sourceFile = new FileInfo(txt_sourceFile.Text);
            if (!sourceFile.Exists)
            {
                throw new Exception("源文件不存在");
            }

            if (!Directory.Exists(txt_tomcatHome.Text))//判断是否存在{
            {
                throw new Exception("tomcat路径不存在");
            }

            DirectoryInfo dic = new DirectoryInfo(txt_tomcatHome.Text + "\\webapps");
            if (!dic.Exists)
            {
                throw new Exception(dic.FullName + "不存在");
            }


            tenantArray = txt_tenant.Text.Split(new char[] { ',', '，' }, StringSplitOptions.RemoveEmptyEntries);

            copyFileList.Clear();//清空copyFileList
            ClearLog();//清空日志
            foreach (DirectoryInfo subDic in dic.GetDirectories())
            {
                if (forbidDirs.Contains(subDic.Name))
                {
                    WriteLog(string.Format("目录：{0}禁止更新，跳过", subDic.Name), "WARN");
                    continue;
                }

                if (tenantArray != null && tenantArray.Length > 0)
                {
                    //除外
                    if (chb_except.Checked)
                    {
                        if (tenantArray.Contains(subDic.Name))
                        {
                            WriteLog(string.Format("跳过经销商：{0}", subDic.Name), "WARN");
                            continue;
                        }
                    }
                    else
                    {
                        if (!tenantArray.Contains(subDic.Name))
                        {
                            WriteLog(string.Format("跳过目录：{0}", subDic.FullName), "WARN");
                            continue;
                        }
                    }
                }
                CopyForSub(subDic, sourceFile);
            }

            //记录成功日志
            StringBuilder builder = new StringBuilder("文件更新成功，更新文件如下:\r\n");
            foreach(FileInfo fi in copyFileList)
            {
                builder.Append(fi.FullName + "\r\n");
            }
            WriteLog(builder.ToString());
        }

        private void CopyForSub(DirectoryInfo subDic, FileInfo sourceFile)
        {
            FileInfo targetFile = new FileInfo(subDic.FullName + "\\" + txt_subPath.Text + "\\" + sourceFile.Name);
            if (!targetFile.Exists)
            {
                if (!chb_force.Checked)
                {
                    WriteLog(string.Format("待更新的源文件：{0}不存在，跳过", targetFile.FullName), "WARN");
                    return;
                }
            }

            if (!targetFile.Directory.Exists)
            {
                targetFile.Directory.Create();
            }

            File.Copy(sourceFile.FullName, targetFile.FullName, true);
            copyFileList.Add(targetFile);
        }

        private void ClearLog()
        {
            this.txt_log.Text = string.Empty;
        }

        private void WriteLog(string msg, string logType = "DEBUG")
        {
            if (string.IsNullOrEmpty(msg))
                return;
            logType = string.IsNullOrEmpty(logType) ? "DEBUG" : logType;

            this.txt_log.Text += string.Format("{0}-{1}:{2}\r\n", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), logType, msg);
        }

    }
}
