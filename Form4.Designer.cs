namespace OperationHelper
{
    partial class Form4
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
            this.tbpnl_main = new System.Windows.Forms.TableLayoutPanel();
            this.txt_tenant = new System.Windows.Forms.TextBox();
            this.lbl_tomcat = new System.Windows.Forms.Label();
            this.txt_tomcatHome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_db_pwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gpb_log = new System.Windows.Forms.GroupBox();
            this.txt_log = new System.Windows.Forms.TextBox();
            this.chb_except = new System.Windows.Forms.CheckBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.tbpnl_main.SuspendLayout();
            this.gpb_log.SuspendLayout();
            this.SuspendLayout();
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
            this.tbpnl_main.Controls.Add(this.txt_tenant, 2, 1);
            this.tbpnl_main.Controls.Add(this.lbl_tomcat, 1, 0);
            this.tbpnl_main.Controls.Add(this.txt_tomcatHome, 2, 0);
            this.tbpnl_main.Controls.Add(this.label1, 1, 2);
            this.tbpnl_main.Controls.Add(this.txt_db_pwd, 2, 2);
            this.tbpnl_main.Controls.Add(this.label3, 1, 1);
            this.tbpnl_main.Controls.Add(this.gpb_log, 1, 4);
            this.tbpnl_main.Controls.Add(this.chb_except, 3, 1);
            this.tbpnl_main.Controls.Add(this.btn_update, 4, 2);
            this.tbpnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpnl_main.Location = new System.Drawing.Point(0, 0);
            this.tbpnl_main.Margin = new System.Windows.Forms.Padding(2);
            this.tbpnl_main.Name = "tbpnl_main";
            this.tbpnl_main.RowCount = 5;
            this.tbpnl_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tbpnl_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tbpnl_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tbpnl_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tbpnl_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbpnl_main.Size = new System.Drawing.Size(876, 433);
            this.tbpnl_main.TabIndex = 13;
            // 
            // txt_tenant
            // 
            this.txt_tenant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tenant.Location = new System.Drawing.Point(158, 32);
            this.txt_tenant.Name = "txt_tenant";
            this.txt_tenant.Size = new System.Drawing.Size(570, 21);
            this.txt_tenant.TabIndex = 9;
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
            this.txt_tomcatHome.Size = new System.Drawing.Size(570, 21);
            this.txt_tomcatHome.TabIndex = 1;
            this.txt_tomcatHome.Text = "D:\\Apache Software Foundation\\apache-tomcat-7.0.82";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "数据库密码";
            // 
            // txt_db_pwd
            // 
            this.txt_db_pwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_db_pwd.Location = new System.Drawing.Point(158, 66);
            this.txt_db_pwd.Name = "txt_db_pwd";
            this.txt_db_pwd.Size = new System.Drawing.Size(570, 21);
            this.txt_db_pwd.TabIndex = 4;
            this.txt_db_pwd.Text = "Tysoft2019";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "待更新经销商（多个经销商用“,”隔开）";
            // 
            // gpb_log
            // 
            this.tbpnl_main.SetColumnSpan(this.gpb_log, 4);
            this.gpb_log.Controls.Add(this.txt_log);
            this.gpb_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpb_log.Location = new System.Drawing.Point(8, 116);
            this.gpb_log.Name = "gpb_log";
            this.gpb_log.Size = new System.Drawing.Size(860, 314);
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
            this.txt_log.Size = new System.Drawing.Size(854, 294);
            this.txt_log.TabIndex = 0;
            // 
            // chb_except
            // 
            this.chb_except.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chb_except.AutoSize = true;
            this.chb_except.Checked = true;
            this.chb_except.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_except.Location = new System.Drawing.Point(734, 34);
            this.chb_except.Name = "chb_except";
            this.chb_except.Size = new System.Drawing.Size(48, 16);
            this.chb_except.TabIndex = 11;
            this.chb_except.Text = "除外";
            this.chb_except.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_update.Location = new System.Drawing.Point(791, 64);
            this.btn_update.Margin = new System.Windows.Forms.Padding(0);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(80, 22);
            this.btn_update.TabIndex = 13;
            this.btn_update.Text = "修改";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 433);
            this.Controls.Add(this.tbpnl_main);
            this.Name = "Form4";
            this.Text = "批量修改数据库密码";
            this.tbpnl_main.ResumeLayout(false);
            this.tbpnl_main.PerformLayout();
            this.gpb_log.ResumeLayout(false);
            this.gpb_log.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbpnl_main;
        private System.Windows.Forms.TextBox txt_tenant;
        private System.Windows.Forms.Label lbl_tomcat;
        private System.Windows.Forms.TextBox txt_tomcatHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_db_pwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpb_log;
        private System.Windows.Forms.TextBox txt_log;
        private System.Windows.Forms.CheckBox chb_except;
        private System.Windows.Forms.Button btn_update;
    }
}