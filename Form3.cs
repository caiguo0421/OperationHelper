using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OperationHelper
{
    public partial class Form3 : Form
    {

        private DataTable dt_csv = null;

        private bool force = false;


        private const string REGEX_WEB_XML = ".root</param-value>";

        private const String REGEX_LOG_PROPERTIES = "{\\w.root}";

        private const string FILE_APPLICATION = @"\WEB-INF\classes\application.properties";
        private const string FILE_LOG4J_PROPERTIES = @"\WEB-INF\classes\log4j.properties";
        private const string FILE_WEB = @"\WEB-INF\web.xml";

        public Form3()
        {
            InitializeComponent();
            InitConfig();
            InitCbb();
            txt_cvs.TextChanged += Txt_cvs_TextChanged;
            btn_cvs.Click += Btn_cvs_Click;
            btn_deploy.Click += Btn_deploy_Click;
            btn_sql.Click += Btn_sql_Click;
        }



        private void InitConfig()
        {
            this.txt_tomcatHome.Text = ConfigurationManager.AppSettings["tomcatHome"];
            this.txt_template.Text = ConfigurationManager.AppSettings["templateHome"];
        }

        private void InitCbb()
        {
            string[] array = { "简版", "完整版" };
            this.cbb_sourceType.DataSource = array;
            this.cbb_sourceType.SelectedIndex = 0;

        }


        private void Btn_cvs_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_cvs.Text = openFileDialog1.FileName;
            }
        }

        private void Txt_cvs_TextChanged(object sender, EventArgs e)
        {

        }

        private void DoOpenCVS()
        {
            string cvsFilePath = txt_cvs.Text;
            if (String.IsNullOrEmpty(cvsFilePath))
            {
                throw new Exception("cvs路径为空");
            }
            dt_csv = CSVFileHelper.OpenCSV(cvsFilePath);
        }


        private void Btn_sql_Click(object sender, EventArgs e)
        {
            try
            {
                this.ClearLog();
                DoOpenCVS();
                DoGenSql();
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("程序出现问题：{0}\r\n{1}", ex.Message, ex.StackTrace));
                return;
            }
            MessageBox.Show("成功");
        }

        private const String SQL_TEMPLATE = @"IF NOT EXISTS ( SELECT  *
                FROM    dbo.Company_Url_Mapping
                WHERE   company_no = @company_no)
INSERT INTO dbo.Company_Url_Mapping (company_no, company_name, server_type, simplified, server_url, datasource_url, datasource_db_name, datasource_username, datasource_password, server_version)
VALUES (@company_no, @company_name, @server_type, @simplified, @server_url, @datasource_url, @datasource_db_name, @datasource_username, @datasource_password, @server_version)
GO

IF  EXISTS ( SELECT  *
                FROM    dbo.Company_Url_Mapping
                WHERE   company_no = @company_no)
UPDATE dbo.Company_Url_Mapping
SET company_name = @company_name,
	server_type = @server_type,
	simplified = @simplified,
	server_url = @server_url,
	datasource_url = @datasource_url,
	datasource_db_name = @datasource_db_name,
	datasource_username = @datasource_username,
	datasource_password = @datasource_password,
	server_version = @server_version
    WHERE company_no = @company_no
GO";

        private void DoGenSql()
        {
            String serverType = "prod";
            String simplified = "simplified";
            if (this.cbb_sourceType.Text == "完整版")
            {
                simplified = "complete";
            }
            foreach (DataRow dr in dt_csv.Rows)
            {
                string sql = SQL_TEMPLATE.Replace("@company_no", string.Format("'{0}'", dr["company_no"]))
                    .Replace("@company_name", string.Format("'{0}'", dr["company_name"]))
                    .Replace("@server_type", string.Format("'{0}'", serverType))
                    .Replace("@simplified", string.Format("'{0}'", simplified))
                    .Replace("@server_url", string.Format("'{0}'", dr["server_url"]))
                    .Replace("@datasource_url", string.Format("'{0}'", dr["datasource_url"]))
                    .Replace("@datasource_db_name", string.Format("'{0}'", dr["datasource_db_name"]))
                    .Replace("@datasource_username", string.Format("'{0}'", dr["datasource_username"]))
                    .Replace("@datasource_password", string.Format("'{0}'", dr["datasource_password"]))
                    .Replace("@server_version", string.Format("'{0}'", dr["server_version"]));
                this.WriteSql(sql);
            }
        }

        private void Btn_deploy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("替换文件前请做好备份，确定替换文件吗？", "部署", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result != DialogResult.OK)
                return;

            try
            {
                this.ClearLog();
                DoOpenCVS();
                DoDeploy();
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("程序出现问题：{0}\r\n{1}", ex.Message, ex.StackTrace));
                return;
            }
            MessageBox.Show("成功");
        }

        /// <summary>
        /// 部署
        /// </summary>
        private void DoDeploy()
        {
            if (String.IsNullOrEmpty(txt_tomcatHome.Text))
            {
                throw new Exception("tomcat路径为空");
            }

            if (string.IsNullOrEmpty(txt_template.Text))
            {
                throw new Exception("模板路径为空");
            }

            if (string.IsNullOrEmpty(txt_cvs.Text))
            {
                throw new Exception("cvs路径为空");
            }

            if (dt_csv == null || dt_csv.Rows.Count == 0)
            {
                throw new Exception("cvs内容为空");
            }


            if (!Directory.Exists(txt_tomcatHome.Text))//判断是否存在
            {
                throw new Exception("tomcat路径不存在");
            }

            DirectoryInfo dicWebapp = new DirectoryInfo(txt_tomcatHome.Text + "\\webapps");
            if (!dicWebapp.Exists)
            {
                throw new Exception(dicWebapp.FullName + "不存在");
            }

            DirectoryInfo dicTemplate = new DirectoryInfo(txt_template.Text);
            if (!dicTemplate.Exists)
            {
                throw new Exception("项目模板不存在");
            }

            force = chb_force.Checked;
            DoCopy(dicWebapp, dicTemplate);
        }

        /// <summary>
        /// 复制项目
        /// </summary>
        /// <param name="dicWebapp"></param>
        /// <param name="dicTemplate"></param>
        private void DoCopy(DirectoryInfo dicWebapp, DirectoryInfo dicTemplate)
        {
            foreach (DataRow dr in dt_csv.Rows)
            {
                string companyNo = dr["company_no"] + "";
                if (string.IsNullOrEmpty(companyNo))
                {
                    continue;
                }
                DirectoryInfo dic_target = new DirectoryInfo(dicWebapp.FullName + "\\" + companyNo);

                if (!force && dic_target.Exists)
                {
                    //如果项目已经存在而且不是强制更新，跳过
                    this.WriteLog(string.Format("项目：{0} 已存在,跳过", companyNo));
                    continue;
                }

                if (dic_target.Exists)
                {
                    //备份
                    String backTraget = txt_tomcatHome.Text + "\\web-bak\\" + companyNo + "-" + DateTime.Now.ToString("yyyyMMddhhmmss.fff");
                    CopyDirectoryForBackup(dic_target.FullName, backTraget, true);
                    dic_target.Delete(true);//删除原来已有的
                    this.WriteLog(string.Format("项目：{0} 备份到{1}中", companyNo, backTraget));
                }


                CopyDirectory(dicTemplate.FullName, dic_target.FullName, dr);

                this.WriteLog(string.Format("项目：{0} 部署完毕，路径{1}", companyNo, dic_target.FullName));
            }
        }

        private void CopyDirectory(String templateStr, String targetStr, DataRow dr_csv)
        {
            DirectoryInfo dicTemplate = new DirectoryInfo(templateStr);
            if (!dicTemplate.Exists)
            {
                throw new Exception(string.Format("{0}不存在", templateStr));
            }

            DirectoryInfo dic_target = new DirectoryInfo(targetStr);
            if (!dic_target.Exists)
            {
                dic_target.Create();
            }

            foreach (FileInfo fi in dicTemplate.GetFiles())
            {

                if (fi.FullName.EndsWith(FILE_APPLICATION) || fi.FullName.EndsWith(FILE_LOG4J_PROPERTIES) || fi.FullName.EndsWith(FILE_WEB))
                {
                    CopyFile(fi, dic_target, dr_csv);
                }
                else
                {
                    //直接复制
                    fi.CopyTo(dic_target.FullName + "\\" + fi.Name, true);
                }

            }

            foreach (DirectoryInfo di in dicTemplate.GetDirectories())
            {
                CopyDirectory(di.FullName, dic_target.FullName + "\\" + di.Name, dr_csv);
            }

        }



        private static void CopyFile(FileInfo fiTemplate, DirectoryInfo dic_target, DataRow dr_csv)
        {
            String file_target = dic_target.FullName + "\\" + fiTemplate.Name;
            Console.WriteLine(String.Format("fiTemplate:{0}，file_target:{0}", fiTemplate.FullName, file_target));
            String[] lines = File.ReadAllLines(fiTemplate.FullName);
            if (lines == null)
            {
                return;
            }

            for (int i = 0; i < lines.Length; i++)
            {
                String replaceText = lines[i];
                if (file_target.EndsWith(FILE_APPLICATION))
                {
                    if (replaceText.Contains("jdbc.url"))
                    {
                        replaceText = string.Format("jdbc.url={0}", dr_csv["datasource_url"] + "DatabaseName=" + dr_csv["datasource_db_name"]);
                    }
                    else if (replaceText.Contains("jdbc.username"))
                    {
                        replaceText = string.Format("jdbc.username={0}", dr_csv["datasource_username"]);
                    }
                    else if (replaceText.Contains("jdbc.password"))
                    {
                        replaceText = string.Format("jdbc.password={0}", dr_csv["datasource_password"]);
                    }
                    else if (replaceText.Contains("ftp.hostname"))
                    {
                        replaceText = string.Format("ftp.hostname={0}", dr_csv["ftp_hostname"]);
                    }
                    else if (replaceText.Contains("ftp.port"))
                    {
                        replaceText = string.Format("ftp.port={0}", dr_csv["ftp_port"]);
                    }
                    else if (replaceText.Contains("ftp.username"))
                    {
                        replaceText = string.Format("ftp.username={0}", dr_csv["ftp_username"]);
                    }
                    else if (replaceText.Contains("ftp.password"))
                    {
                        replaceText = string.Format("ftp.password={0}", dr_csv["ftp_password"]);
                    }
                    else if (replaceText.Contains("ftp.attachment.path"))
                    {
                        replaceText = string.Format("ftp.attachment.path={0}", dr_csv["ftp_attachment_path"]);
                    }
                }
                else if (file_target.EndsWith(FILE_LOG4J_PROPERTIES))
                {
                    if (Regex.IsMatch(replaceText, REGEX_LOG_PROPERTIES))
                    {
                        replaceText = Regex.Replace(replaceText, REGEX_LOG_PROPERTIES, string.Format("{0}.root", dr_csv["company_no"]));
                    }
                }
                else if (file_target.EndsWith(FILE_WEB))
                {
                    if (replaceText.Contains(REGEX_WEB_XML))
                    {
                        replaceText = string.Format("<param-value>{0}.root</param-value>", dr_csv["company_no"]);
                    }
                    //if (Regex.IsMatch(replaceText, REGEX_WEB_XML))
                    //{
                    //    replaceText = string.Format("<param-value>{0}.root</param-value>", dr_csv["company_no"]);
                    //}
                }

                lines[i] = replaceText;
            }

            File.WriteAllLines(file_target, lines);
        }


        private static bool CopyDirectoryForBackup(string SourcePath, string DestinationPath, bool overwriteexisting)
        {
            bool ret = false;
            try
            {
                SourcePath = SourcePath.EndsWith(@"\") ? SourcePath : SourcePath + @"\";
                DestinationPath = DestinationPath.EndsWith(@"\") ? DestinationPath : DestinationPath + @"\";

                if (Directory.Exists(SourcePath))
                {
                    if (Directory.Exists(DestinationPath) == false)
                    {
                        Directory.CreateDirectory(DestinationPath);
                    }

                    foreach (string fls in Directory.GetFiles(SourcePath))
                    {
                        FileInfo flinfo = new FileInfo(fls);
                        flinfo.CopyTo(DestinationPath + flinfo.Name, overwriteexisting);
                    }
                    foreach (string drs in Directory.GetDirectories(SourcePath))
                    {
                        DirectoryInfo drinfo = new DirectoryInfo(drs);
                        if (CopyDirectoryForBackup(drs, DestinationPath + drinfo.Name, overwriteexisting) == false)
                            ret = false;
                    }
                }
                ret = true;
            }
            catch (Exception ex)
            {
                ret = false;
            }
            return ret;
        }



        private void ClearLog()
        {
            this.txt_log.Text = string.Empty;
        }

        private void WriteLog(string msg, string logType = "DEBUG")
        {
            if (string.IsNullOrEmpty(msg))
                return;


            this.txt_log.Text += string.Format("{0}-{1}:{2}\r\n", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), logType, msg);
        }


        private void WriteSql(string sql)
        {
            this.txt_log.Text += string.Format("{0}\r\n", sql);
        }
    }
}
