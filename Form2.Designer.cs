namespace OperationHelper
{
    partial class Form2
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
            this.btn_search = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_rename = new System.Windows.Forms.Button();
            this.gpb_crm = new System.Windows.Forms.GroupBox();
            this.tbpnl_main = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_tomcat = new System.Windows.Forms.Label();
            this.txt_response = new System.Windows.Forms.TextBox();
            this.txt_tmp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_recive = new System.Windows.Forms.TextBox();
            this.btn_response = new System.Windows.Forms.Button();
            this.btn_recive = new System.Windows.Forms.Button();
            this.btn_tmp = new System.Windows.Forms.Button();
            this.gbp_dfs = new System.Windows.Forms.GroupBox();
            this.btn_search_dfs = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_response_dfs = new System.Windows.Forms.Button();
            this.btn_tmp_dfs = new System.Windows.Forms.Button();
            this.txt_response_dfs = new System.Windows.Forms.TextBox();
            this.txt_tmp_dfs = new System.Windows.Forms.TextBox();
            this.dt_begin = new System.Windows.Forms.DateTimePicker();
            this.dt_end = new System.Windows.Forms.DateTimePicker();
            this.gpb_crm.SuspendLayout();
            this.tbpnl_main.SuspendLayout();
            this.gbp_dfs.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Location = new System.Drawing.Point(789, 152);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "开始查找";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // btn_rename
            // 
            this.btn_rename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_rename.Location = new System.Drawing.Point(868, 152);
            this.btn_rename.Name = "btn_rename";
            this.btn_rename.Size = new System.Drawing.Size(75, 23);
            this.btn_rename.TabIndex = 11;
            this.btn_rename.Text = "改名";
            this.btn_rename.UseVisualStyleBackColor = true;
            // 
            // gpb_crm
            // 
            this.gpb_crm.Controls.Add(this.tbpnl_main);
            this.gpb_crm.Controls.Add(this.btn_search);
            this.gpb_crm.Controls.Add(this.btn_rename);
            this.gpb_crm.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpb_crm.Location = new System.Drawing.Point(0, 0);
            this.gpb_crm.Name = "gpb_crm";
            this.gpb_crm.Size = new System.Drawing.Size(954, 182);
            this.gpb_crm.TabIndex = 12;
            this.gpb_crm.TabStop = false;
            this.gpb_crm.Text = "CRM";
            // 
            // tbpnl_main
            // 
            this.tbpnl_main.ColumnCount = 5;
            this.tbpnl_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tbpnl_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tbpnl_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbpnl_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tbpnl_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tbpnl_main.Controls.Add(this.lbl_tomcat, 1, 0);
            this.tbpnl_main.Controls.Add(this.txt_response, 2, 0);
            this.tbpnl_main.Controls.Add(this.txt_tmp, 2, 2);
            this.tbpnl_main.Controls.Add(this.label1, 1, 1);
            this.tbpnl_main.Controls.Add(this.label2, 1, 2);
            this.tbpnl_main.Controls.Add(this.txt_recive, 2, 1);
            this.tbpnl_main.Controls.Add(this.btn_response, 3, 0);
            this.tbpnl_main.Controls.Add(this.btn_recive, 3, 1);
            this.tbpnl_main.Controls.Add(this.btn_tmp, 3, 2);
            this.tbpnl_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbpnl_main.Location = new System.Drawing.Point(3, 17);
            this.tbpnl_main.Margin = new System.Windows.Forms.Padding(2);
            this.tbpnl_main.Name = "tbpnl_main";
            this.tbpnl_main.RowCount = 4;
            this.tbpnl_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tbpnl_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tbpnl_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tbpnl_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tbpnl_main.Size = new System.Drawing.Size(948, 91);
            this.tbpnl_main.TabIndex = 10;
            // 
            // lbl_tomcat
            // 
            this.lbl_tomcat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_tomcat.AutoSize = true;
            this.lbl_tomcat.Location = new System.Drawing.Point(51, 5);
            this.lbl_tomcat.Name = "lbl_tomcat";
            this.lbl_tomcat.Size = new System.Drawing.Size(65, 12);
            this.lbl_tomcat.TabIndex = 2;
            this.lbl_tomcat.Text = "err_文件夹";
            // 
            // txt_response
            // 
            this.txt_response.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_response.Location = new System.Drawing.Point(122, 3);
            this.txt_response.Name = "txt_response";
            this.txt_response.Size = new System.Drawing.Size(763, 21);
            this.txt_response.TabIndex = 1;
            // 
            // txt_tmp
            // 
            this.txt_tmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tmp.Location = new System.Drawing.Point(122, 47);
            this.txt_tmp.Name = "txt_tmp";
            this.txt_tmp.Size = new System.Drawing.Size(763, 21);
            this.txt_tmp.TabIndex = 6;
            this.txt_tmp.Text = "C:\\tmp\\CRM";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "对应源文件夹";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "查找文件存放地";
            // 
            // txt_recive
            // 
            this.txt_recive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_recive.Location = new System.Drawing.Point(122, 25);
            this.txt_recive.Name = "txt_recive";
            this.txt_recive.Size = new System.Drawing.Size(763, 21);
            this.txt_recive.TabIndex = 4;
            this.txt_recive.Text = "C:\\MCS_DATA\\CRM_MESSAGE\\201802\\Receive";
            // 
            // btn_response
            // 
            this.btn_response.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_response.Location = new System.Drawing.Point(888, 0);
            this.btn_response.Margin = new System.Windows.Forms.Padding(0);
            this.btn_response.Name = "btn_response";
            this.btn_response.Size = new System.Drawing.Size(52, 22);
            this.btn_response.TabIndex = 10;
            this.btn_response.Text = "打开";
            this.btn_response.UseVisualStyleBackColor = true;
            // 
            // btn_recive
            // 
            this.btn_recive.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_recive.Location = new System.Drawing.Point(888, 22);
            this.btn_recive.Margin = new System.Windows.Forms.Padding(0);
            this.btn_recive.Name = "btn_recive";
            this.btn_recive.Size = new System.Drawing.Size(52, 22);
            this.btn_recive.TabIndex = 9;
            this.btn_recive.Text = "打开";
            this.btn_recive.UseVisualStyleBackColor = true;
            // 
            // btn_tmp
            // 
            this.btn_tmp.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_tmp.Location = new System.Drawing.Point(888, 44);
            this.btn_tmp.Margin = new System.Windows.Forms.Padding(0);
            this.btn_tmp.Name = "btn_tmp";
            this.btn_tmp.Size = new System.Drawing.Size(52, 22);
            this.btn_tmp.TabIndex = 11;
            this.btn_tmp.Text = "打开";
            this.btn_tmp.UseVisualStyleBackColor = true;
            // 
            // gbp_dfs
            // 
            this.gbp_dfs.Controls.Add(this.btn_search_dfs);
            this.gbp_dfs.Controls.Add(this.tableLayoutPanel1);
            this.gbp_dfs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbp_dfs.Location = new System.Drawing.Point(0, 182);
            this.gbp_dfs.Name = "gbp_dfs";
            this.gbp_dfs.Size = new System.Drawing.Size(954, 224);
            this.gbp_dfs.TabIndex = 13;
            this.gbp_dfs.TabStop = false;
            this.gbp_dfs.Text = "DFS";
            // 
            // btn_search_dfs
            // 
            this.btn_search_dfs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search_dfs.Location = new System.Drawing.Point(787, 195);
            this.btn_search_dfs.Name = "btn_search_dfs";
            this.btn_search_dfs.Size = new System.Drawing.Size(75, 23);
            this.btn_search_dfs.TabIndex = 12;
            this.btn_search_dfs.Text = "开始查找";
            this.btn_search_dfs.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 181F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_response_dfs, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_tmp_dfs, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_response_dfs, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_tmp_dfs, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.dt_begin, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dt_end, 4, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(948, 91);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "response文件夹";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "文件创建时间";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "查找文件存放地";
            // 
            // btn_response_dfs
            // 
            this.btn_response_dfs.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_response_dfs.Location = new System.Drawing.Point(888, 0);
            this.btn_response_dfs.Margin = new System.Windows.Forms.Padding(0);
            this.btn_response_dfs.Name = "btn_response_dfs";
            this.btn_response_dfs.Size = new System.Drawing.Size(52, 22);
            this.btn_response_dfs.TabIndex = 10;
            this.btn_response_dfs.Text = "打开";
            this.btn_response_dfs.UseVisualStyleBackColor = true;
            // 
            // btn_tmp_dfs
            // 
            this.btn_tmp_dfs.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_tmp_dfs.Location = new System.Drawing.Point(888, 44);
            this.btn_tmp_dfs.Margin = new System.Windows.Forms.Padding(0);
            this.btn_tmp_dfs.Name = "btn_tmp_dfs";
            this.btn_tmp_dfs.Size = new System.Drawing.Size(52, 22);
            this.btn_tmp_dfs.TabIndex = 11;
            this.btn_tmp_dfs.Text = "打开";
            this.btn_tmp_dfs.UseVisualStyleBackColor = true;
            // 
            // txt_response_dfs
            // 
            this.txt_response_dfs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txt_response_dfs, 4);
            this.txt_response_dfs.Location = new System.Drawing.Point(122, 3);
            this.txt_response_dfs.Name = "txt_response_dfs";
            this.txt_response_dfs.Size = new System.Drawing.Size(763, 21);
            this.txt_response_dfs.TabIndex = 1;
            // 
            // txt_tmp_dfs
            // 
            this.txt_tmp_dfs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txt_tmp_dfs, 4);
            this.txt_tmp_dfs.Location = new System.Drawing.Point(122, 47);
            this.txt_tmp_dfs.Name = "txt_tmp_dfs";
            this.txt_tmp_dfs.Size = new System.Drawing.Size(763, 21);
            this.txt_tmp_dfs.TabIndex = 6;
            this.txt_tmp_dfs.Text = "C:\\tmp\\DFS";
            // 
            // dt_begin
            // 
            this.dt_begin.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dt_begin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_begin.Location = new System.Drawing.Point(122, 25);
            this.dt_begin.Name = "dt_begin";
            this.dt_begin.Size = new System.Drawing.Size(149, 21);
            this.dt_begin.TabIndex = 12;
            // 
            // dt_end
            // 
            this.dt_end.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dt_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_end.Location = new System.Drawing.Point(310, 25);
            this.dt_end.Name = "dt_end";
            this.dt_end.Size = new System.Drawing.Size(175, 21);
            this.dt_end.TabIndex = 13;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 406);
            this.Controls.Add(this.gbp_dfs);
            this.Controls.Add(this.gpb_crm);
            this.Name = "Form2";
            this.Text = "CRM文件查找";
            this.gpb_crm.ResumeLayout(false);
            this.tbpnl_main.ResumeLayout(false);
            this.tbpnl_main.PerformLayout();
            this.gbp_dfs.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_rename;
        private System.Windows.Forms.GroupBox gpb_crm;
        private System.Windows.Forms.TableLayoutPanel tbpnl_main;
        private System.Windows.Forms.Label lbl_tomcat;
        private System.Windows.Forms.TextBox txt_response;
        private System.Windows.Forms.TextBox txt_tmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_recive;
        private System.Windows.Forms.Button btn_response;
        private System.Windows.Forms.Button btn_recive;
        private System.Windows.Forms.Button btn_tmp;
        private System.Windows.Forms.GroupBox gbp_dfs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_response_dfs;
        private System.Windows.Forms.TextBox txt_tmp_dfs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_response_dfs;
        private System.Windows.Forms.Button btn_tmp_dfs;
        private System.Windows.Forms.Button btn_search_dfs;
        private System.Windows.Forms.DateTimePicker dt_begin;
        private System.Windows.Forms.DateTimePicker dt_end;
    }
}