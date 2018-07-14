namespace SqlConvert.Win.App
{
    partial class FormMainForm
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
            SqlConvert.Domain.Connections.ConnectionParam connectionParam1 = new SqlConvert.Domain.Connections.ConnectionParam();
            SqlConvert.Domain.Connections.ConnectionParam connectionParam2 = new SqlConvert.Domain.Connections.ConnectionParam();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSource = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonNext = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageDestination = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonPrev1 = new System.Windows.Forms.Button();
            this.buttonNext1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageSqlServer = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonPrev2 = new System.Windows.Forms.Button();
            this.buttonNext2 = new System.Windows.Forms.Button();
            this.tabPagePostgres = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonPrev3 = new System.Windows.Forms.Button();
            this.buttonNext3 = new System.Windows.Forms.Button();
            this.tabPageSummary = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonPrev4 = new System.Windows.Forms.Button();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewTables = new System.Windows.Forms.DataGridView();
            this.dataGridViewColumns = new System.Windows.Forms.DataGridView();
            this.connectionParamControlMsSql = new SqlConvert.Win.App.ConnectionParamControl();
            this.connectionParamControlPostgre = new SqlConvert.Win.App.ConnectionParamControl();
            this.tabControl1.SuspendLayout();
            this.tabPageSource.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPageDestination.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPageSqlServer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPagePostgres.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPageSummary.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewColumns)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageSource);
            this.tabControl1.Controls.Add(this.tabPageDestination);
            this.tabControl1.Controls.Add(this.tabPageSqlServer);
            this.tabControl1.Controls.Add(this.tabPagePostgres);
            this.tabControl1.Controls.Add(this.tabPageSummary);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(562, 302);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageSource
            // 
            this.tabPageSource.Controls.Add(this.panel1);
            this.tabPageSource.Controls.Add(this.tableLayoutPanel1);
            this.tabPageSource.Location = new System.Drawing.Point(4, 22);
            this.tabPageSource.Name = "tabPageSource";
            this.tabPageSource.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSource.Size = new System.Drawing.Size(554, 276);
            this.tabPageSource.TabIndex = 0;
            this.tabPageSource.Text = "State 1";
            this.tabPageSource.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 30);
            this.panel1.TabIndex = 3;
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNext.Location = new System.Drawing.Point(470, 4);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 0;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 489F));
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(548, 270);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(62, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source";
            // 
            // tabPageDestination
            // 
            this.tabPageDestination.Controls.Add(this.panel2);
            this.tabPageDestination.Controls.Add(this.tableLayoutPanel2);
            this.tabPageDestination.Location = new System.Drawing.Point(4, 22);
            this.tabPageDestination.Name = "tabPageDestination";
            this.tabPageDestination.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDestination.Size = new System.Drawing.Size(554, 276);
            this.tabPageDestination.TabIndex = 1;
            this.tabPageDestination.Text = "State 2";
            this.tabPageDestination.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonPrev1);
            this.panel2.Controls.Add(this.buttonNext1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 243);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 30);
            this.panel2.TabIndex = 5;
            // 
            // buttonPrev1
            // 
            this.buttonPrev1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrev1.Location = new System.Drawing.Point(389, 3);
            this.buttonPrev1.Name = "buttonPrev1";
            this.buttonPrev1.Size = new System.Drawing.Size(75, 23);
            this.buttonPrev1.TabIndex = 2;
            this.buttonPrev1.Text = "Previous";
            this.buttonPrev1.UseVisualStyleBackColor = true;
            this.buttonPrev1.Click += new System.EventHandler(this.buttonPrev1_Click);
            // 
            // buttonNext1
            // 
            this.buttonNext1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNext1.Location = new System.Drawing.Point(470, 3);
            this.buttonNext1.Name = "buttonNext1";
            this.buttonNext1.Size = new System.Drawing.Size(75, 23);
            this.buttonNext1.TabIndex = 1;
            this.buttonNext1.Text = "Next";
            this.buttonNext1.UseVisualStyleBackColor = true;
            this.buttonNext1.Click += new System.EventHandler(this.buttonNext1_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 489F));
            this.tableLayoutPanel2.Controls.Add(this.comboBox2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(548, 270);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(62, 92);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destino";
            // 
            // tabPageSqlServer
            // 
            this.tabPageSqlServer.Controls.Add(this.panel3);
            this.tabPageSqlServer.Controls.Add(this.connectionParamControlMsSql);
            this.tabPageSqlServer.Location = new System.Drawing.Point(4, 22);
            this.tabPageSqlServer.Name = "tabPageSqlServer";
            this.tabPageSqlServer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSqlServer.Size = new System.Drawing.Size(554, 276);
            this.tabPageSqlServer.TabIndex = 2;
            this.tabPageSqlServer.Text = "Sql Server ";
            this.tabPageSqlServer.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonPrev2);
            this.panel3.Controls.Add(this.buttonNext2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 243);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(548, 30);
            this.panel3.TabIndex = 6;
            // 
            // buttonPrev2
            // 
            this.buttonPrev2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrev2.Location = new System.Drawing.Point(389, 3);
            this.buttonPrev2.Name = "buttonPrev2";
            this.buttonPrev2.Size = new System.Drawing.Size(75, 23);
            this.buttonPrev2.TabIndex = 2;
            this.buttonPrev2.Text = "Previous";
            this.buttonPrev2.UseVisualStyleBackColor = true;
            this.buttonPrev2.Click += new System.EventHandler(this.buttonPrev2_Click);
            // 
            // buttonNext2
            // 
            this.buttonNext2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNext2.Location = new System.Drawing.Point(470, 3);
            this.buttonNext2.Name = "buttonNext2";
            this.buttonNext2.Size = new System.Drawing.Size(75, 23);
            this.buttonNext2.TabIndex = 1;
            this.buttonNext2.Text = "Next";
            this.buttonNext2.UseVisualStyleBackColor = true;
            this.buttonNext2.Click += new System.EventHandler(this.buttonNext2_Click);
            // 
            // tabPagePostgres
            // 
            this.tabPagePostgres.Controls.Add(this.panel4);
            this.tabPagePostgres.Controls.Add(this.connectionParamControlPostgre);
            this.tabPagePostgres.Location = new System.Drawing.Point(4, 22);
            this.tabPagePostgres.Name = "tabPagePostgres";
            this.tabPagePostgres.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePostgres.Size = new System.Drawing.Size(554, 276);
            this.tabPagePostgres.TabIndex = 3;
            this.tabPagePostgres.Text = "Postgres";
            this.tabPagePostgres.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonPrev3);
            this.panel4.Controls.Add(this.buttonNext3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 243);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(548, 30);
            this.panel4.TabIndex = 6;
            // 
            // buttonPrev3
            // 
            this.buttonPrev3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrev3.Location = new System.Drawing.Point(389, 3);
            this.buttonPrev3.Name = "buttonPrev3";
            this.buttonPrev3.Size = new System.Drawing.Size(75, 23);
            this.buttonPrev3.TabIndex = 2;
            this.buttonPrev3.Text = "Previous";
            this.buttonPrev3.UseVisualStyleBackColor = true;
            this.buttonPrev3.Click += new System.EventHandler(this.buttonPrev3_Click);
            // 
            // buttonNext3
            // 
            this.buttonNext3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNext3.Location = new System.Drawing.Point(470, 3);
            this.buttonNext3.Name = "buttonNext3";
            this.buttonNext3.Size = new System.Drawing.Size(75, 23);
            this.buttonNext3.TabIndex = 1;
            this.buttonNext3.Text = "Next";
            this.buttonNext3.UseVisualStyleBackColor = true;
            this.buttonNext3.Click += new System.EventHandler(this.buttonNext3_Click);
            // 
            // tabPageSummary
            // 
            this.tabPageSummary.Controls.Add(this.splitContainer1);
            this.tabPageSummary.Controls.Add(this.panel5);
            this.tabPageSummary.Location = new System.Drawing.Point(4, 22);
            this.tabPageSummary.Name = "tabPageSummary";
            this.tabPageSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSummary.Size = new System.Drawing.Size(554, 276);
            this.tabPageSummary.TabIndex = 4;
            this.tabPageSummary.Text = "Summary";
            this.tabPageSummary.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonPrev4);
            this.panel5.Controls.Add(this.buttonFinish);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 243);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(548, 30);
            this.panel5.TabIndex = 7;
            // 
            // buttonPrev4
            // 
            this.buttonPrev4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrev4.Location = new System.Drawing.Point(389, 3);
            this.buttonPrev4.Name = "buttonPrev4";
            this.buttonPrev4.Size = new System.Drawing.Size(75, 23);
            this.buttonPrev4.TabIndex = 2;
            this.buttonPrev4.Text = "Previous";
            this.buttonPrev4.UseVisualStyleBackColor = true;
            this.buttonPrev4.Click += new System.EventHandler(this.buttonPrev4_Click);
            // 
            // buttonFinish
            // 
            this.buttonFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFinish.Location = new System.Drawing.Point(470, 3);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(75, 23);
            this.buttonFinish.TabIndex = 1;
            this.buttonFinish.Text = "Next";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClose.Location = new System.Drawing.Point(15, 320);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "button1";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 9);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewTables);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewColumns);
            this.splitContainer1.Size = new System.Drawing.Size(545, 228);
            this.splitContainer1.SplitterDistance = 269;
            this.splitContainer1.TabIndex = 10;
            // 
            // dataGridViewTables
            // 
            this.dataGridViewTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTables.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTables.Name = "dataGridViewTables";
            this.dataGridViewTables.Size = new System.Drawing.Size(269, 228);
            this.dataGridViewTables.TabIndex = 0;
            // 
            // dataGridViewColumns
            // 
            this.dataGridViewColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewColumns.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewColumns.Name = "dataGridViewColumns";
            this.dataGridViewColumns.Size = new System.Drawing.Size(272, 228);
            this.dataGridViewColumns.TabIndex = 1;
            // 
            // connectionParamControlMsSql
            // 
            connectionParam1.Database = "";
            connectionParam1.Password = "";
            connectionParam1.Port = 1453;
            connectionParam1.Server = "localhost";
            connectionParam1.ServerType = SqlConvert.Domain.ServerType.MSSqlServer;
            connectionParam1.User = "";
            this.connectionParamControlMsSql.ConnectionParam = connectionParam1;
            this.connectionParamControlMsSql.Database = "";
            this.connectionParamControlMsSql.Location = new System.Drawing.Point(6, 70);
            this.connectionParamControlMsSql.Name = "connectionParamControlMsSql";
            this.connectionParamControlMsSql.Password = "";
            this.connectionParamControlMsSql.Port = 1453;
            this.connectionParamControlMsSql.Server = "";
            this.connectionParamControlMsSql.ServerType = SqlConvert.Domain.ServerType.MSSqlServer;
            this.connectionParamControlMsSql.Size = new System.Drawing.Size(307, 118);
            this.connectionParamControlMsSql.TabIndex = 0;
            this.connectionParamControlMsSql.User = "";
            // 
            // connectionParamControlPostgre
            // 
            connectionParam2.Database = "";
            connectionParam2.Password = "";
            connectionParam2.Port = 5432;
            connectionParam2.Server = "localhost";
            connectionParam2.ServerType = SqlConvert.Domain.ServerType.PostGres;
            connectionParam2.User = "";
            this.connectionParamControlPostgre.ConnectionParam = connectionParam2;
            this.connectionParamControlPostgre.Database = "";
            this.connectionParamControlPostgre.Location = new System.Drawing.Point(6, 70);
            this.connectionParamControlPostgre.Name = "connectionParamControlPostgre";
            this.connectionParamControlPostgre.Password = "";
            this.connectionParamControlPostgre.Port = 5432;
            this.connectionParamControlPostgre.Server = "";
            this.connectionParamControlPostgre.ServerType = SqlConvert.Domain.ServerType.PostGres;
            this.connectionParamControlPostgre.Size = new System.Drawing.Size(307, 118);
            this.connectionParamControlPostgre.TabIndex = 1;
            this.connectionParamControlPostgre.User = "";
            // 
            // FormMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 355);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonClose);
            this.Name = "FormMainForm";
            this.ShowIcon = false;
            this.Text = "Convert Database";
            this.tabControl1.ResumeLayout(false);
            this.tabPageSource.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPageDestination.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPageSqlServer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabPagePostgres.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tabPageSummary.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewColumns)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSource;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageDestination;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonNext1;
        private System.Windows.Forms.Button buttonPrev1;
        private System.Windows.Forms.TabPage tabPageSqlServer;
        private System.Windows.Forms.TabPage tabPagePostgres;
        private ConnectionParamControl connectionParamControlMsSql;
        private ConnectionParamControl connectionParamControlPostgre;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonPrev2;
        private System.Windows.Forms.Button buttonNext2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonPrev3;
        private System.Windows.Forms.Button buttonNext3;
        private System.Windows.Forms.TabPage tabPageSummary;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonPrev4;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewTables;
        private System.Windows.Forms.DataGridView dataGridViewColumns;
    }
}

