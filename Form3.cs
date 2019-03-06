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


        private const string REGEX_WEB_XML = "<param-value>\\w.root</param-value>";

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
        }

        private void InitConfig()
        {
            this.txt_tomcatHome.Text = ConfigurationManager.AppSettings["tomcatHome"];
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
            string cvsFilePath = txt_cvs.Text;
            if (String.IsNullOrEmpty(cvsFilePath))
            {
                return;
            }

            dt_csv = CSVFileHelper.OpenCSV(cvsFilePath);
        }

        private void Btn_deploy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("替换文件前请做好备份，确定替换文件吗？", "部署", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result != DialogResult.OK)
                return;

            try
            {
                DoDeploy();
            }
            catch (Exception ex)
            {
                MessageBox.Show("程序出现了问题：" + ex.Message);
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
                    continue;
                }

                if (dic_target.Exists)
                {
                    //备份
                    //TODO
                    dic_target.Delete(true);//删除原来已有的
                }
            }
        }

        private static void CopyDirectory(DirectoryInfo dicTemplate, DirectoryInfo dic_target, DataRow dr_csv)
        {
            if (!dicTemplate.Exists)
            {
                throw new Exception(string.Format("{0}不存在", dicTemplate.FullName));
            }

            if (!dic_target.Exists)
            {
                dic_target.Create();
            }

            foreach (FileInfo fi in dicTemplate.GetFiles())
            {
                fi.CopyTo(dic_target.FullName + fi.Name, true);
            }

            foreach (DirectoryInfo di in dicTemplate.GetDirectories())
            {
                CopyDirectory(di, new DirectoryInfo(dic_target.FullName + di.Name), dr_csv);
            }
        }

       

        private static void CopyFile(FileInfo fiTemplate, DirectoryInfo dic_target, DataRow dr_csv)
        {
            String file_target = dic_target.FullName + fiTemplate.Name;
            fiTemplate.CopyTo(file_target, true);
            string text = string.Empty;
            using (FileStream fs = new FileStream(fiTemplate.FullName, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    text = sr.ReadToEnd();
                }
            }

            using (FileStream fs = new FileStream(file_target, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    if (file_target.EndsWith(FILE_APPLICATION))
                    {
                        if (text.Contains("jdbc.url"))
                        {
                            text = string.Format("jdbc.url={0}", dr_csv["datasource_url"] + "DatabaseName=" + dr_csv["datasource_db_name"]);
                        }
                        else if (text.Contains("jdbc.username"))
                        {
                            text = string.Format("jdbc.username={0}", dr_csv["datasource_username"]);
                        }
                        else if (text.Contains("jdbc.password"))
                        {
                            text = string.Format("jdbc.password={0}", dr_csv["datasource_password"]);
                        }
                        else if (text.Contains("ftp.hostname"))
                        {
                            text = string.Format("ftp.hostname={0}", dr_csv["ftp_hostname"]);
                        }
                        else if (text.Contains("ftp.port"))
                        {
                            text = string.Format("ftp.port={0}", dr_csv["ftp_port"]);
                        }
                        else if (text.Contains("ftp.username"))
                        {
                            text = string.Format("ftp.username={0}", dr_csv["ftp_username"]);
                        }
                        else if (text.Contains("ftp.password"))
                        {
                            text = string.Format("ftp.password={0}", dr_csv["ftp_password"]);
                        }
                        else if (text.Contains("ftp.attachment.path"))
                        {
                            text = string.Format("ftp.attachment.path={0}", dr_csv["ftp_attachment_path"]);
                        }
                    }
                    else if (file_target.EndsWith(FILE_LOG4J_PROPERTIES))
                    {
                        if(Regex.IsMatch(text, REGEX_LOG_PROPERTIES))
                        {
                            text = Regex.Replace(text, REGEX_LOG_PROPERTIES, string.Format("{0}.root", dr_csv["company_no"]));
                        }
                    }
                    else if (file_target.EndsWith(FILE_WEB))
                    {
                        if(Regex.IsMatch(text, REGEX_WEB_XML))
                        {
                            text = string.Format("<param-value>{0}.root</param-value>", dr_csv["company_no"]);
                        }
                       
                    }

                    sw.Write(text);
                }
            }
        }


        private static bool CopyDirectory(string SourcePath, string DestinationPath, bool overwriteexisting)
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
                        if (CopyDirectory(drs, DestinationPath + drinfo.Name, overwriteexisting) == false)
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
    }
}
