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
    public partial class Form4 : Form
    {

        private const string FILE_APPLICATION = @"\WEB-INF\classes\application.properties";

        private string[] tenantArray = null;

        private List<FileInfo> copyFileList = new List<FileInfo>();

        /// <summary>
        /// 被排除的目录，这些目录下的文件不会被更新
        /// </summary>     
        private String[] forbidDirs = new string[] { };


        public Form4()
        {
            InitializeComponent();
            InitConfig();
            this.btn_update.Click += Btn_update_Click;
        }

       

        private void InitConfig()
        {
            this.txt_tomcatHome.Text = ConfigurationManager.AppSettings["tomcatHome"];
            this.txt_tenant.Text = ConfigurationManager.AppSettings["defaultTenant"];
            String forbidDirStr = ConfigurationManager.AppSettings["forbidDirs"];
            if (!string.IsNullOrWhiteSpace(forbidDirStr))
            {
                forbidDirs = forbidDirStr.Split(new char[] { ',' });
            }
        }


        void Btn_update_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定修改数据库密码吗？", "修改密码", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result != DialogResult.OK)
                return;

            try
            {
                DoUpdatePwd();
            }
            catch (Exception ex)
            {
                MessageBox.Show("程序出现了问题：" + ex.Message);
                return;
            }
            MessageBox.Show("成功");
        }



        private void DoUpdatePwd()
        {
            if (string.IsNullOrEmpty(txt_tomcatHome.Text))
            {
                throw new Exception("tomcat路径为空");
            }

            if (String.IsNullOrWhiteSpace(txt_db_pwd.Text))
            {
                throw new Exception("数据库密码为空");
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
                FileInfo fi_application = DoUpdatePwdForSub(subDic);
                if (fi_application != null)
                {
                    copyFileList.Add(fi_application);
                }
            }

            //记录成功日志
            StringBuilder builder = new StringBuilder("文件更新成功，更新文件如下:\r\n");
            foreach (FileInfo fi in copyFileList)
            {
                builder.Append(fi.FullName + "\r\n");
            }
            WriteLog(builder.ToString());


        }

        private FileInfo DoUpdatePwdForSub(DirectoryInfo subDic)
        {
            FileInfo fi_application = new FileInfo(subDic.FullName + FILE_APPLICATION);
            if (!fi_application.Exists)
            {
                WriteLog(string.Format("文件{0}不存在，跳过", fi_application.FullName), "WARN");
                return null;
            }

            FileStream fs =  fi_application.Open(FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("utf-8"));
            StringBuilder sb = new StringBuilder();
            string line =String.Empty;
            while ( (line =sr.ReadLine()) != null)
            {
                if(!String.IsNullOrWhiteSpace(line) && line.Trim().StartsWith("jdbc.password"))
                {
                    line = String.Format("jdbc.password={0}", txt_db_pwd.Text);
                }
                sb.Append(line + "\r\n");
            }
            sr.Close();
            fs.Close();

            FileStream fs1 = fi_application.Open(FileMode.Open, FileAccess.Write); 
            StreamWriter sw = new StreamWriter(fs1);
            sw.Write(sb.ToString());
            sw.Close();
            fs1.Close();

            return fi_application;
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
