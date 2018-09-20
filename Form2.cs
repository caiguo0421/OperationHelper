using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OperationHelper
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Load += Form2_Load;
        }

        void Form2_Load(object sender, EventArgs e)
        {
            RegEvents();
        }

        private void RegEvents()
        {
            btn_response.Click += BtnClick;
            btn_recive.Click += BtnClick;
            btn_tmp.Click += BtnClick;
            btn_search.Click += BtnClick;
            btn_rename.Click += BtnClick;
        }

        
        void BtnClick(object sender, EventArgs e)
        {
            if (sender == btn_response)
            {
                DoBtnResponse();
            }
            else if (sender == btn_recive)
            {
                DoBtnRecive();
            }
            else if (sender == btn_tmp)
            {
                DoBtnTmp();
            }
            else if (sender == btn_search)
            {
                try
                {
                    DoSearch();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("程序出现了问题：" + ex.Message);
                    return;
                }

                MessageBox.Show("处理成功");
            }
            else if (sender == btn_rename)
            {
                try
                {
                    DoRename();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("程序出现了问题：" + ex.Message);
                    return;
                }
                MessageBox.Show("处理成功");
            }

        }

        private void DoRename()
        {
            DirectoryInfo tmp_dict = new DirectoryInfo(txt_tmp.Text);
            if (!tmp_dict.Exists)
            {
                throw new Exception(txt_tmp.Text+"不存在");
            }
            DirectoryInfo rename_dict = new DirectoryInfo(tmp_dict.FullName + "\\rename\\");
            if (!rename_dict.Exists)
            {
                rename_dict.Create();
            }

            DialogResult rs = MessageBox.Show(this, "将修改 “查找文件存放地”下的文件，改名后的文件将放入此文件夹下的rename文件夹", "提示", MessageBoxButtons.OKCancel);
           if (rs == System.Windows.Forms.DialogResult.OK)
           {
               foreach (FileInfo fi_tmp in tmp_dict.GetFiles())
               {
                   string fileName_tmp = fi_tmp.Name;
                   string rename_tmp = fileName_tmp.Substring(0, fileName_tmp.IndexOf(".XML.") + 4);//先变成 1_2018020600004386_MaintenanceApproved.XML
                   Char[] chs = rename_tmp.ToCharArray();
                   Char[] new_chs = new Char[chs.Length];
                   for (int i = 0; i < chs.Length; i++)
                   {
                       if (i == 10)
                       {
                           //int tmp = 0;
                           //int.TryParse(chs[i].ToString(),out tmp);

                           new_chs[i] = Convert.ToChar(Convert.ToInt32(chs[i]) + 1);
                       }
                       else
                       {
                           new_chs[i] = chs[i];
                       }
                   }

                   FileInfo fi_rename = new FileInfo(rename_dict.FullName + "\\" + new string(new_chs));
                   File.Copy(fi_tmp.FullName, fi_rename.FullName, true);
               }
           }
        }

        

        private void DoBtnTmp()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_tmp.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void DoBtnRecive()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_recive.Text = folderBrowserDialog1.SelectedPath;
            } 
        }

        private void DoBtnResponse()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_response.Text = folderBrowserDialog1.SelectedPath;
            }
        }


        private void DoSearch()
        {
            DirectoryInfo dic_response = new DirectoryInfo(txt_response.Text);//_err文件
            DirectoryInfo dic_recive = new DirectoryInfo(txt_recive.Text);
            DirectoryInfo tmp_dict = new DirectoryInfo(txt_tmp.Text);

            

            if (!dic_response.Exists)
            {
                throw new Exception("err_文件夹不存在");
            }
            if (!dic_recive.Exists)
            {
                throw new Exception("对应源文件夹不存在");
            }
            if (string.IsNullOrEmpty(txt_tmp.Text))
            {
                //查找文件存放地
                throw new Exception("查找文件存放地不能为空");
            }

            if (!tmp_dict.Exists)
            {
                tmp_dict.Create();//创建
            }



            foreach (FileInfo fi_response in dic_response.GetFiles())
            {
                if (!fi_response.Name.EndsWith("_err.xml"))
                    continue;
                String fileName = fi_response.Name;
                FileInfo[] fis_revice = dic_recive.GetFiles(fileName.Substring(0, fileName.Length - "_err.xml".Length) + "*", SearchOption.TopDirectoryOnly);
                if (fis_revice != null && fis_revice.Count() > 0)
                {
                    CopyForSub(txt_tmp.Text, fis_revice[0]);
                }

            }
        }


        private void CopyForSub(string dic_tmpName, FileInfo sourceFile)
        {
            FileInfo targetFile = new FileInfo(dic_tmpName + "\\" + sourceFile.Name);
            File.Copy(sourceFile.FullName, targetFile.FullName, true);
        }
    }
}
