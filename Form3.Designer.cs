namespace OperationHelper
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab_main = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbpnl_main = new System.Windows.Forms.TableLayoutPanel();
            this.txt_template = new System.Windows.Forms.TextBox();
            this.lbl_tomcat = new System.Windows.Forms.Label();
            this.txt_tomcatHome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cvs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gpb_log = new System.Windows.Forms.GroupBox();
            this.txt_log = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_cvs = new System.Windows.Forms.Button();
            this.cbb_sourceType = new System.Windows.Forms.ComboBox();
            this.pnl_buttom = new System.Windows.Forms.Panel();
            this.chb_force = new System.Windows.Forms.CheckBox();
            this.btn_deploy = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_sql = new System.Windows.Forms.Button();
            this.tab_main.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tbpnl_main.SuspendLayout();
            this.gpb_log.SuspendLayout();
            this.pnl_buttom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_main
            // 
            this.tab_main.Controls.Add(this.tabPage1);
            this.tab_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_main.Location = new System.Drawing.Point(0, 0);
            this.tab_main.Name = "tab_main";
            this.tab_main.SelectedIndex = 0;
            this.tab_main.Size = new System.Drawing.Size(994, 446);
            this.tab_main.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbpnl_main);
            this.tabPage1.Controls.Add(this.pnl_buttom);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(986, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "文件替换";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbpnl_main
            // 
            this.tbpnl_main.ColumnCount = 6;
            this.tbpnl_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tbpnl_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tbpnl_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbpnl_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tbpnl_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tbpnl_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tbpnl_main.Controls.Add(this.txt_template, 2, 1);
            this.tbpnl_main.Controls.Add(this.lbl_tomcat, 1, 0);
            this.tbpnl_main.Controls.Add(this.txt_tomcatHome, 2, 0);
            this.tbpnl_main.Controls.Add(this.label1, 1, 2);
            this.tbpnl_main.Controls.Add(this.txt_cvs, 2, 2);
            this.tbpnl_main.Controls.Add(this.label3, 1, 1);
            this.tbpnl_main.Controls.Add(this.gpb_log, 1, 4);
            this.tbpnl_main.Controls.Add(this.button1, 4, 1);
            this.tbpnl_main.Controls.Add(this.btn_cvs, 4, 2);
            this.tbpnl_main.Controls.Add(this.cbb_sourceType, 1, 3);
            this.tbpnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpnl_main.Location = new System.Drawing.Point(3, 3);
            this.tbpnl_main.Margin = new System.Windows.Forms.Padding(2);
            this.tbpnl_main.Name = "tbpnl_main";
            this.tbpnl_main.RowCount = 5;
            this.tbpnl_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tbpnl_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tbpnl_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tbpnl_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tbpnl_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbpnl_main.Size = new System.Drawing.Size(980, 380);
            this.tbpnl_main.TabIndex = 12;
            // 
            // txt_template
            // 
            this.txt_template.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_template.Location = new System.Drawing.Point(158, 28);
            this.txt_template.Name = "txt_template";
            this.txt_template.Size = new System.Drawing.Size(674, 21);
            this.txt_template.TabIndex = 9;
            // 
            // lbl_tomcat
            // 
            this.lbl_tomcat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_tomcat.AutoSize = true;
            this.lbl_tomcat.Location = new System.Drawing.Point(87, 6);
            this.lbl_tomcat.Name = "lbl_tomcat";
            this.lbl_tomcat.Size = new System.Drawing.Size(65, 12);
            this.lbl_tomcat.TabIndex = 2;
            this.lbl_tomcat.Text = "tomcat路径";
            // 
            // txt_tomcatHome
            // 
            this.txt_tomcatHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tomcatHome.Location = new System.Drawing.Point(158, 3);
            this.txt_tomcatHome.Name = "txt_tomcatHome";
            this.txt_tomcatHome.Size = new System.Drawing.Size(674, 21);
            this.txt_tomcatHome.TabIndex = 1;
            this.txt_tomcatHome.Text = "D:\\Apache Software Foundation\\apache-tomcat-7.0.82";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "csv路径";
            // 
            // txt_cvs
            // 
            this.txt_cvs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cvs.Location = new System.Drawing.Point(158, 53);
            this.txt_cvs.Name = "txt_cvs";
            this.txt_cvs.Size = new System.Drawing.Size(674, 21);
            this.txt_cvs.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "项目模板路径";
            // 
            // gpb_log
            // 
            this.tbpnl_main.SetColumnSpan(this.gpb_log, 4);
            this.gpb_log.Controls.Add(this.txt_log);
            this.gpb_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpb_log.Location = new System.Drawing.Point(8, 103);
            this.gpb_log.Name = "gpb_log";
            this.gpb_log.Size = new System.Drawing.Size(964, 274);
            this.gpb_log.TabIndex = 12;
            this.gpb_log.TabStop = false;
            this.gpb_log.Text = "日志";
            // 
            // txt_log
            // 
            this.txt_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_log.Location = new System.Drawing.Point(3, 17);
            this.txt_log.Multiline = true;
            this.txt_log.Name = "txt_log";
            this.txt_log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_log.Size = new System.Drawing.Size(958, 254);
            this.txt_log.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(895, 26);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 22);
            this.button1.TabIndex = 15;
            this.button1.Text = "打开";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_cvs
            // 
            this.btn_cvs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cvs.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_cvs.Location = new System.Drawing.Point(895, 51);
            this.btn_cvs.Margin = new System.Windows.Forms.Padding(0);
            this.btn_cvs.Name = "btn_cvs";
            this.btn_cvs.Size = new System.Drawing.Size(80, 22);
            this.btn_cvs.TabIndex = 16;
            this.btn_cvs.Text = "打开";
            this.btn_cvs.UseVisualStyleBackColor = true;
            // 
            // cbb_sourceType
            // 
            this.cbb_sourceType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_sourceType.FormattingEnabled = true;
            this.cbb_sourceType.Location = new System.Drawing.Point(31, 78);
            this.cbb_sourceType.Name = "cbb_sourceType";
            this.cbb_sourceType.Size = new System.Drawing.Size(121, 20);
            this.cbb_sourceType.TabIndex = 14;
            // 
            // pnl_buttom
            // 
            this.pnl_buttom.Controls.Add(this.btn_sql);
            this.pnl_buttom.Controls.Add(this.chb_force);
            this.pnl_buttom.Controls.Add(this.btn_deploy);
            this.pnl_buttom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_buttom.Location = new System.Drawing.Point(3, 383);
            this.pnl_buttom.Name = "pnl_buttom";
            this.pnl_buttom.Size = new System.Drawing.Size(980, 34);
            this.pnl_buttom.TabIndex = 11;
            // 
            // chb_force
            // 
            this.chb_force.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chb_force.AutoSize = true;
            this.chb_force.Location = new System.Drawing.Point(747, 10);
            this.chb_force.Name = "chb_force";
            this.chb_force.Size = new System.Drawing.Size(72, 16);
            this.chb_force.TabIndex = 12;
            this.chb_force.Text = "强制部署";
            this.chb_force.UseVisualStyleBackColor = true;
            // 
            // btn_deploy
            // 
            this.btn_deploy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deploy.Location = new System.Drawing.Point(825, 6);
            this.btn_deploy.Name = "btn_deploy";
            this.btn_deploy.Size = new System.Drawing.Size(75, 23);
            this.btn_deploy.TabIndex = 0;
            this.btn_deploy.Text = "部署";
            this.btn_deploy.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_sql
            // 
            this.btn_sql.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sql.Location = new System.Drawing.Point(902, 5);
            this.btn_sql.Name = "btn_sql";
            this.btn_sql.Size = new System.Drawing.Size(75, 23);
            this.btn_sql.TabIndex = 13;
            this.btn_sql.Text = "生成脚本";
            this.btn_sql.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 446);
            this.Controls.Add(this.tab_main);
            this.Name = "Form3";
            this.Text = "服务端批量部署工具";
            this.tab_main.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tbpnl_main.ResumeLayout(false);
            this.tbpnl_main.PerformLayout();
            this.gpb_log.ResumeLayout(false);
            this.gpb_log.PerformLayout();
            this.pnl_buttom.ResumeLayout(false);
            this.pnl_buttom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_main;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tbpnl_main;
        private System.Windows.Forms.TextBox txt_template;
        private System.Windows.Forms.Label lbl_tomcat;
        private System.Windows.Forms.TextBox txt_tomcatHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cvs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpb_log;
        private System.Windows.Forms.TextBox txt_log;
        private System.Windows.Forms.ComboBox cbb_sourceType;
        private System.Windows.Forms.Panel pnl_buttom;
        private System.Windows.Forms.CheckBox chb_force;
        private System.Windows.Forms.Button btn_deploy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_cvs;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_sql;
    }
}