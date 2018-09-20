namespace OperationHelper
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_copy = new System.Windows.Forms.Button();
            this.pnl_buttom = new System.Windows.Forms.Panel();
            this.tbpnl_main = new System.Windows.Forms.TableLayoutPanel();
            this.txt_tenant = new System.Windows.Forms.TextBox();
            this.lbl_tomcat = new System.Windows.Forms.Label();
            this.txt_tomcatHome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sourceFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_subPath = new System.Windows.Forms.TextBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chb_except = new System.Windows.Forms.CheckBox();
            this.gpb_log = new System.Windows.Forms.GroupBox();
            this.txt_log = new System.Windows.Forms.TextBox();
            this.chb_force = new System.Windows.Forms.CheckBox();
            this.pnl_buttom.SuspendLayout();
            this.tbpnl_main.SuspendLayout();
            this.gpb_log.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_copy
            // 
            this.btn_copy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_copy.Location = new System.Drawing.Point(946, 5);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(75, 23);
            this.btn_copy.TabIndex = 0;
            this.btn_copy.Text = "更新";
            this.btn_copy.UseVisualStyleBackColor = true;
            // 
            // pnl_buttom
            // 
            this.pnl_buttom.Controls.Add(this.chb_force);
            this.pnl_buttom.Controls.Add(this.btn_copy);
            this.pnl_buttom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_buttom.Location = new System.Drawing.Point(0, 449);
            this.pnl_buttom.Name = "pnl_buttom";
            this.pnl_buttom.Size = new System.Drawing.Size(1035, 34);
            this.pnl_buttom.TabIndex = 9;
            // 
            // tbpnl_main
            // 
            this.tbpnl_main.ColumnCount = 5;
            this.tbpnl_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tbpnl_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tbpnl_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbpnl_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tbpnl_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tbpnl_main.Controls.Add(this.txt_tenant, 2, 1);
            this.tbpnl_main.Controls.Add(this.lbl_tomcat, 1, 0);
            this.tbpnl_main.Controls.Add(this.txt_tomcatHome, 2, 0);
            this.tbpnl_main.Controls.Add(this.label2, 1, 3);
            this.tbpnl_main.Controls.Add(this.txt_sourceFile, 2, 3);
            this.tbpnl_main.Controls.Add(this.label1, 1, 2);
            this.tbpnl_main.Controls.Add(this.txt_subPath, 2, 2);
            this.tbpnl_main.Controls.Add(this.btn_open, 3, 3);
            this.tbpnl_main.Controls.Add(this.label3, 1, 1);
            this.tbpnl_main.Controls.Add(this.gpb_log, 1, 4);
            this.tbpnl_main.Controls.Add(this.chb_except, 3, 1);
            this.tbpnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpnl_main.Location = new System.Drawing.Point(0, 0);
            this.tbpnl_main.Margin = new System.Windows.Forms.Padding(2);
            this.tbpnl_main.Name = "tbpnl_main";
            this.tbpnl_main.RowCount = 5;
            this.tbpnl_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tbpnl_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tbpnl_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tbpnl_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tbpnl_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbpnl_main.Size = new System.Drawing.Size(1035, 449);
            this.tbpnl_main.TabIndex = 10;
            // 
            // txt_tenant
            // 
            this.txt_tenant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tenant.Location = new System.Drawing.Point(158, 33);
            this.txt_tenant.Name = "txt_tenant";
            this.txt_tenant.Size = new System.Drawing.Size(786, 21);
            this.txt_tenant.TabIndex = 9;
            this.txt_tenant.Text = "DMJT";
            // 
            // lbl_tomcat
            // 
            this.lbl_tomcat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_tomcat.AutoSize = true;
            this.lbl_tomcat.Location = new System.Drawing.Point(87, 5);
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
            this.txt_tomcatHome.Size = new System.Drawing.Size(786, 21);
            this.txt_tomcatHome.TabIndex = 1;
            this.txt_tomcatHome.Text = "D:\\Apache Software Foundation\\apache-tomcat-7.0.82";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "源文件";
            // 
            // txt_sourceFile
            // 
            this.txt_sourceFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_sourceFile.Location = new System.Drawing.Point(158, 91);
            this.txt_sourceFile.Name = "txt_sourceFile";
            this.txt_sourceFile.Size = new System.Drawing.Size(786, 21);
            this.txt_sourceFile.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "子文件夹路径";
            // 
            // txt_subPath
            // 
            this.txt_subPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_subPath.Location = new System.Drawing.Point(158, 69);
            this.txt_subPath.Name = "txt_subPath";
            this.txt_subPath.Size = new System.Drawing.Size(786, 21);
            this.txt_subPath.TabIndex = 4;
            this.txt_subPath.Text = "\\WEB-INF\\lib\\";
            // 
            // btn_open
            // 
            this.btn_open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_open.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_open.Location = new System.Drawing.Point(947, 88);
            this.btn_open.Margin = new System.Windows.Forms.Padding(0);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(80, 22);
            this.btn_open.TabIndex = 9;
            this.btn_open.Text = "打开";
            this.btn_open.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "待更新经销商（多个经销商用“,”隔开）";
            // 
            // chb_except
            // 
            this.chb_except.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chb_except.AutoSize = true;
            this.chb_except.Checked = true;
            this.chb_except.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_except.Location = new System.Drawing.Point(950, 36);
            this.chb_except.Name = "chb_except";
            this.chb_except.Size = new System.Drawing.Size(48, 16);
            this.chb_except.TabIndex = 11;
            this.chb_except.Text = "除外";
            this.chb_except.UseVisualStyleBackColor = true;
            // 
            // gpb_log
            // 
            this.tbpnl_main.SetColumnSpan(this.gpb_log, 3);
            this.gpb_log.Controls.Add(this.txt_log);
            this.gpb_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpb_log.Location = new System.Drawing.Point(8, 113);
            this.gpb_log.Name = "gpb_log";
            this.gpb_log.Size = new System.Drawing.Size(1016, 333);
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
            this.txt_log.Size = new System.Drawing.Size(1010, 313);
            this.txt_log.TabIndex = 0;
            // 
            // chb_force
            // 
            this.chb_force.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chb_force.AutoSize = true;
            this.chb_force.Location = new System.Drawing.Point(868, 9);
            this.chb_force.Name = "chb_force";
            this.chb_force.Size = new System.Drawing.Size(72, 16);
            this.chb_force.TabIndex = 12;
            this.chb_force.Text = "强制更新";
            this.chb_force.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 483);
            this.Controls.Add(this.tbpnl_main);
            this.Controls.Add(this.pnl_buttom);
            this.Name = "Form1";
            this.Text = "Tomcat文件替换";
            this.pnl_buttom.ResumeLayout(false);
            this.pnl_buttom.PerformLayout();
            this.tbpnl_main.ResumeLayout(false);
            this.tbpnl_main.PerformLayout();
            this.gpb_log.ResumeLayout(false);
            this.gpb_log.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Panel pnl_buttom;
        private System.Windows.Forms.TableLayoutPanel tbpnl_main;
        private System.Windows.Forms.TextBox txt_tenant;
        private System.Windows.Forms.Label lbl_tomcat;
        private System.Windows.Forms.TextBox txt_tomcatHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sourceFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_subPath;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chb_except;
        private System.Windows.Forms.GroupBox gpb_log;
        private System.Windows.Forms.TextBox txt_log;
        private System.Windows.Forms.CheckBox chb_force;
    }
}

