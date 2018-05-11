namespace MTPsys
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Mix = new System.Windows.Forms.Button();
            this.Max = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Profile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.New = new System.Windows.Forms.Button();
            this.Fresh = new System.Windows.Forms.Button();
            this.Print = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cOMPANYIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPANYNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tESTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMLEVELIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMLEVELNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTYTOTALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTYJOINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTYRATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tESTPASSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tESTFAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tESTRATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCOREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bASEPASSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bASEFAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bASERATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAJORPASSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAJORFAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAJORRATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pARENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aTENDDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.kMLEVELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLASSIFYIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEMARKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCOMPANYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mTPDataSet = new MTPsys.MTPDataSet();
            this.arreaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new MTPsys.DatabaseDataSet();
            this.arreaTableAdapter = new MTPsys.DatabaseDataSetTableAdapters.ArreaTableAdapter();
            this.t_COMPANYTableAdapter = new MTPsys.MTPDataSetTableAdapters.T_COMPANYTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCOMPANYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arreaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Mix);
            this.panel1.Controls.Add(this.Max);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.Profile);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 106);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 64);
            this.panel2.TabIndex = 1;
            // 
            // Mix
            // 
            this.Mix.FlatAppearance.BorderSize = 0;
            this.Mix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mix.Image = ((System.Drawing.Image)(resources.GetObject("Mix.Image")));
            this.Mix.Location = new System.Drawing.Point(671, 11);
            this.Mix.Name = "Mix";
            this.Mix.Size = new System.Drawing.Size(24, 23);
            this.Mix.TabIndex = 5;
            this.Mix.UseVisualStyleBackColor = true;
            this.Mix.Click += new System.EventHandler(this.Mix_Click);
            // 
            // Max
            // 
            this.Max.FlatAppearance.BorderSize = 0;
            this.Max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Max.Image = ((System.Drawing.Image)(resources.GetObject("Max.Image")));
            this.Max.Location = new System.Drawing.Point(701, 11);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(24, 23);
            this.Max.TabIndex = 4;
            this.Max.UseVisualStyleBackColor = true;
            this.Max.Click += new System.EventHandler(this.Max_Click);
            // 
            // Close
            // 
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.Location = new System.Drawing.Point(731, 11);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(24, 23);
            this.Close.TabIndex = 3;
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Profile
            // 
            this.Profile.FlatAppearance.BorderSize = 0;
            this.Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Profile.Image = ((System.Drawing.Image)(resources.GetObject("Profile.Image")));
            this.Profile.Location = new System.Drawing.Point(641, 11);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(24, 23);
            this.Profile.TabIndex = 2;
            this.Profile.UseVisualStyleBackColor = true;
            this.Profile.MouseEnter += new System.EventHandler(this.Profile_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(110, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "中国人民解放军军人体能考核系统";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 82);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // New
            // 
            this.New.FlatAppearance.BorderSize = 0;
            this.New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.New.Image = ((System.Drawing.Image)(resources.GetObject("New.Image")));
            this.New.Location = new System.Drawing.Point(12, 116);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(36, 37);
            this.New.TabIndex = 3;
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            this.New.MouseEnter += new System.EventHandler(this.button5_MouseEnter);
            // 
            // Fresh
            // 
            this.Fresh.FlatAppearance.BorderSize = 0;
            this.Fresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fresh.Image = ((System.Drawing.Image)(resources.GetObject("Fresh.Image")));
            this.Fresh.Location = new System.Drawing.Point(225, 116);
            this.Fresh.Name = "Fresh";
            this.Fresh.Size = new System.Drawing.Size(36, 37);
            this.Fresh.TabIndex = 4;
            this.Fresh.UseVisualStyleBackColor = true;
            this.Fresh.MouseEnter += new System.EventHandler(this.Fresh_MouseEnter);
            // 
            // Print
            // 
            this.Print.FlatAppearance.BorderSize = 0;
            this.Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Print.Image = ((System.Drawing.Image)(resources.GetObject("Print.Image")));
            this.Print.Location = new System.Drawing.Point(183, 116);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(36, 37);
            this.Print.TabIndex = 5;
            this.Print.UseVisualStyleBackColor = true;
            this.Print.MouseEnter += new System.EventHandler(this.Print_MouseEnter);
            // 
            // Export
            // 
            this.Export.FlatAppearance.BorderSize = 0;
            this.Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Export.Image = ((System.Drawing.Image)(resources.GetObject("Export.Image")));
            this.Export.Location = new System.Drawing.Point(141, 116);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(36, 37);
            this.Export.TabIndex = 6;
            this.Export.UseVisualStyleBackColor = true;
            this.Export.MouseEnter += new System.EventHandler(this.Export_MouseEnter);
            // 
            // Edit
            // 
            this.Edit.FlatAppearance.BorderSize = 0;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Location = new System.Drawing.Point(99, 116);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(36, 37);
            this.Edit.TabIndex = 7;
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.MouseEnter += new System.EventHandler(this.Edit_MouseEnter);
            // 
            // Delete
            // 
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Location = new System.Drawing.Point(57, 116);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(36, 37);
            this.Delete.TabIndex = 8;
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.MouseEnter += new System.EventHandler(this.Delete_MouseEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "___________________________________";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(451, 116);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 30);
            this.textBox1.TabIndex = 10;
            // 
            // Search
            // 
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Image = ((System.Drawing.Image)(resources.GetObject("Search.Image")));
            this.Search.Location = new System.Drawing.Point(673, 116);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(36, 37);
            this.Search.TabIndex = 11;
            this.Search.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cOMPANYIDDataGridViewTextBoxColumn,
            this.cOMPANYNAMEDataGridViewTextBoxColumn,
            this.tESTIDDataGridViewTextBoxColumn,
            this.cOMLEVELIDDataGridViewTextBoxColumn,
            this.cOMLEVELNAMEDataGridViewTextBoxColumn,
            this.qTYTOTALDataGridViewTextBoxColumn,
            this.qTYJOINDataGridViewTextBoxColumn,
            this.qTYRATEDataGridViewTextBoxColumn,
            this.tESTPASSDataGridViewTextBoxColumn,
            this.tESTFAILDataGridViewTextBoxColumn,
            this.tESTRATEDataGridViewTextBoxColumn,
            this.sCOREDataGridViewTextBoxColumn,
            this.bASEPASSDataGridViewTextBoxColumn,
            this.bASEFAILDataGridViewTextBoxColumn,
            this.bASERATEDataGridViewTextBoxColumn,
            this.mAJORPASSDataGridViewTextBoxColumn,
            this.mAJORFAILDataGridViewTextBoxColumn,
            this.mAJORRATEDataGridViewTextBoxColumn,
            this.pARENTIDDataGridViewTextBoxColumn,
            this.aTENDDataGridViewCheckBoxColumn,
            this.kMLEVELDataGridViewTextBoxColumn,
            this.cLASSIFYIDDataGridViewTextBoxColumn,
            this.rEMARKDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tCOMPANYBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(769, 388);
            this.dataGridView1.TabIndex = 12;
            // 
            // cOMPANYIDDataGridViewTextBoxColumn
            // 
            this.cOMPANYIDDataGridViewTextBoxColumn.DataPropertyName = "COMPANY_ID";
            this.cOMPANYIDDataGridViewTextBoxColumn.HeaderText = "编号";
            this.cOMPANYIDDataGridViewTextBoxColumn.Name = "cOMPANYIDDataGridViewTextBoxColumn";
            this.cOMPANYIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // cOMPANYNAMEDataGridViewTextBoxColumn
            // 
            this.cOMPANYNAMEDataGridViewTextBoxColumn.DataPropertyName = "COMPANY_NAME";
            this.cOMPANYNAMEDataGridViewTextBoxColumn.HeaderText = "名称";
            this.cOMPANYNAMEDataGridViewTextBoxColumn.Name = "cOMPANYNAMEDataGridViewTextBoxColumn";
            this.cOMPANYNAMEDataGridViewTextBoxColumn.Width = 80;
            // 
            // tESTIDDataGridViewTextBoxColumn
            // 
            this.tESTIDDataGridViewTextBoxColumn.DataPropertyName = "TEST_ID";
            this.tESTIDDataGridViewTextBoxColumn.HeaderText = "考核项目编号";
            this.tESTIDDataGridViewTextBoxColumn.Name = "tESTIDDataGridViewTextBoxColumn";
            this.tESTIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // cOMLEVELIDDataGridViewTextBoxColumn
            // 
            this.cOMLEVELIDDataGridViewTextBoxColumn.DataPropertyName = "COMLEVEL_ID";
            this.cOMLEVELIDDataGridViewTextBoxColumn.HeaderText = "单位级别编号";
            this.cOMLEVELIDDataGridViewTextBoxColumn.Name = "cOMLEVELIDDataGridViewTextBoxColumn";
            this.cOMLEVELIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // cOMLEVELNAMEDataGridViewTextBoxColumn
            // 
            this.cOMLEVELNAMEDataGridViewTextBoxColumn.DataPropertyName = "COMLEVEL_NAME";
            this.cOMLEVELNAMEDataGridViewTextBoxColumn.HeaderText = "单位级别";
            this.cOMLEVELNAMEDataGridViewTextBoxColumn.Name = "cOMLEVELNAMEDataGridViewTextBoxColumn";
            this.cOMLEVELNAMEDataGridViewTextBoxColumn.Width = 50;
            // 
            // qTYTOTALDataGridViewTextBoxColumn
            // 
            this.qTYTOTALDataGridViewTextBoxColumn.DataPropertyName = "QTY_TOTAL";
            this.qTYTOTALDataGridViewTextBoxColumn.HeaderText = "实力数";
            this.qTYTOTALDataGridViewTextBoxColumn.Name = "qTYTOTALDataGridViewTextBoxColumn";
            this.qTYTOTALDataGridViewTextBoxColumn.Width = 40;
            // 
            // qTYJOINDataGridViewTextBoxColumn
            // 
            this.qTYJOINDataGridViewTextBoxColumn.DataPropertyName = "QTY_JOIN";
            this.qTYJOINDataGridViewTextBoxColumn.HeaderText = "参考人数";
            this.qTYJOINDataGridViewTextBoxColumn.Name = "qTYJOINDataGridViewTextBoxColumn";
            this.qTYJOINDataGridViewTextBoxColumn.Width = 40;
            // 
            // qTYRATEDataGridViewTextBoxColumn
            // 
            this.qTYRATEDataGridViewTextBoxColumn.DataPropertyName = "QTY_RATE";
            this.qTYRATEDataGridViewTextBoxColumn.HeaderText = "参考率";
            this.qTYRATEDataGridViewTextBoxColumn.Name = "qTYRATEDataGridViewTextBoxColumn";
            this.qTYRATEDataGridViewTextBoxColumn.Width = 60;
            // 
            // tESTPASSDataGridViewTextBoxColumn
            // 
            this.tESTPASSDataGridViewTextBoxColumn.DataPropertyName = "TEST_PASS";
            this.tESTPASSDataGridViewTextBoxColumn.HeaderText = "合格人数";
            this.tESTPASSDataGridViewTextBoxColumn.Name = "tESTPASSDataGridViewTextBoxColumn";
            this.tESTPASSDataGridViewTextBoxColumn.Width = 40;
            // 
            // tESTFAILDataGridViewTextBoxColumn
            // 
            this.tESTFAILDataGridViewTextBoxColumn.DataPropertyName = "TEST_FAIL";
            this.tESTFAILDataGridViewTextBoxColumn.HeaderText = "不合格人数";
            this.tESTFAILDataGridViewTextBoxColumn.Name = "tESTFAILDataGridViewTextBoxColumn";
            this.tESTFAILDataGridViewTextBoxColumn.Width = 40;
            // 
            // tESTRATEDataGridViewTextBoxColumn
            // 
            this.tESTRATEDataGridViewTextBoxColumn.DataPropertyName = "TEST_RATE";
            this.tESTRATEDataGridViewTextBoxColumn.HeaderText = "合格率";
            this.tESTRATEDataGridViewTextBoxColumn.Name = "tESTRATEDataGridViewTextBoxColumn";
            this.tESTRATEDataGridViewTextBoxColumn.Width = 50;
            // 
            // sCOREDataGridViewTextBoxColumn
            // 
            this.sCOREDataGridViewTextBoxColumn.DataPropertyName = "SCORE";
            this.sCOREDataGridViewTextBoxColumn.HeaderText = "单位成绩";
            this.sCOREDataGridViewTextBoxColumn.Name = "sCOREDataGridViewTextBoxColumn";
            this.sCOREDataGridViewTextBoxColumn.Width = 50;
            // 
            // bASEPASSDataGridViewTextBoxColumn
            // 
            this.bASEPASSDataGridViewTextBoxColumn.DataPropertyName = "BASE_PASS";
            this.bASEPASSDataGridViewTextBoxColumn.HeaderText = "基础合格人数";
            this.bASEPASSDataGridViewTextBoxColumn.Name = "bASEPASSDataGridViewTextBoxColumn";
            this.bASEPASSDataGridViewTextBoxColumn.Width = 40;
            // 
            // bASEFAILDataGridViewTextBoxColumn
            // 
            this.bASEFAILDataGridViewTextBoxColumn.DataPropertyName = "BASE_FAIL";
            this.bASEFAILDataGridViewTextBoxColumn.HeaderText = "基础不合格人数";
            this.bASEFAILDataGridViewTextBoxColumn.Name = "bASEFAILDataGridViewTextBoxColumn";
            this.bASEFAILDataGridViewTextBoxColumn.Width = 40;
            // 
            // bASERATEDataGridViewTextBoxColumn
            // 
            this.bASERATEDataGridViewTextBoxColumn.DataPropertyName = "BASE_RATE";
            this.bASERATEDataGridViewTextBoxColumn.HeaderText = "基础合格率";
            this.bASERATEDataGridViewTextBoxColumn.Name = "bASERATEDataGridViewTextBoxColumn";
            this.bASERATEDataGridViewTextBoxColumn.Width = 40;
            // 
            // mAJORPASSDataGridViewTextBoxColumn
            // 
            this.mAJORPASSDataGridViewTextBoxColumn.DataPropertyName = "MAJOR_PASS";
            this.mAJORPASSDataGridViewTextBoxColumn.HeaderText = "专业合格人数";
            this.mAJORPASSDataGridViewTextBoxColumn.Name = "mAJORPASSDataGridViewTextBoxColumn";
            this.mAJORPASSDataGridViewTextBoxColumn.Width = 40;
            // 
            // mAJORFAILDataGridViewTextBoxColumn
            // 
            this.mAJORFAILDataGridViewTextBoxColumn.DataPropertyName = "MAJOR_FAIL";
            this.mAJORFAILDataGridViewTextBoxColumn.HeaderText = "专业不合格人数";
            this.mAJORFAILDataGridViewTextBoxColumn.Name = "mAJORFAILDataGridViewTextBoxColumn";
            this.mAJORFAILDataGridViewTextBoxColumn.Width = 40;
            // 
            // mAJORRATEDataGridViewTextBoxColumn
            // 
            this.mAJORRATEDataGridViewTextBoxColumn.DataPropertyName = "MAJOR_RATE";
            this.mAJORRATEDataGridViewTextBoxColumn.HeaderText = "专业合格率";
            this.mAJORRATEDataGridViewTextBoxColumn.Name = "mAJORRATEDataGridViewTextBoxColumn";
            this.mAJORRATEDataGridViewTextBoxColumn.Width = 40;
            // 
            // pARENTIDDataGridViewTextBoxColumn
            // 
            this.pARENTIDDataGridViewTextBoxColumn.DataPropertyName = "PARENTID";
            this.pARENTIDDataGridViewTextBoxColumn.HeaderText = "父级编号";
            this.pARENTIDDataGridViewTextBoxColumn.Name = "pARENTIDDataGridViewTextBoxColumn";
            this.pARENTIDDataGridViewTextBoxColumn.Width = 40;
            // 
            // aTENDDataGridViewCheckBoxColumn
            // 
            this.aTENDDataGridViewCheckBoxColumn.DataPropertyName = "ATEND";
            this.aTENDDataGridViewCheckBoxColumn.HeaderText = "是否末级";
            this.aTENDDataGridViewCheckBoxColumn.Name = "aTENDDataGridViewCheckBoxColumn";
            this.aTENDDataGridViewCheckBoxColumn.Width = 40;
            // 
            // kMLEVELDataGridViewTextBoxColumn
            // 
            this.kMLEVELDataGridViewTextBoxColumn.DataPropertyName = "KM_LEVEL";
            this.kMLEVELDataGridViewTextBoxColumn.HeaderText = "所在科目级数";
            this.kMLEVELDataGridViewTextBoxColumn.Name = "kMLEVELDataGridViewTextBoxColumn";
            this.kMLEVELDataGridViewTextBoxColumn.Width = 40;
            // 
            // cLASSIFYIDDataGridViewTextBoxColumn
            // 
            this.cLASSIFYIDDataGridViewTextBoxColumn.DataPropertyName = "CLASSIFY_ID";
            this.cLASSIFYIDDataGridViewTextBoxColumn.HeaderText = "CLASSIFY_ID";
            this.cLASSIFYIDDataGridViewTextBoxColumn.Name = "cLASSIFYIDDataGridViewTextBoxColumn";
            this.cLASSIFYIDDataGridViewTextBoxColumn.Width = 40;
            // 
            // rEMARKDataGridViewTextBoxColumn
            // 
            this.rEMARKDataGridViewTextBoxColumn.DataPropertyName = "REMARK";
            this.rEMARKDataGridViewTextBoxColumn.HeaderText = "备注";
            this.rEMARKDataGridViewTextBoxColumn.Name = "rEMARKDataGridViewTextBoxColumn";
            this.rEMARKDataGridViewTextBoxColumn.Width = 80;
            // 
            // tCOMPANYBindingSource
            // 
            this.tCOMPANYBindingSource.DataMember = "T_COMPANY";
            this.tCOMPANYBindingSource.DataSource = this.mTPDataSet;
            // 
            // mTPDataSet
            // 
            this.mTPDataSet.DataSetName = "MTPDataSet";
            this.mTPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // arreaBindingSource
            // 
            this.arreaBindingSource.DataMember = "Arrea";
            this.arreaBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // arreaTableAdapter
            // 
            this.arreaTableAdapter.ClearBeforeFill = true;
            // 
            // t_COMPANYTableAdapter
            // 
            this.t_COMPANYTableAdapter.ClearBeforeFill = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(768, 560);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.Fresh);
            this.Controls.Add(this.New);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCOMPANYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arreaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Mix;
        private System.Windows.Forms.Button Max;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Profile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Fresh;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource arreaBindingSource;
        private DatabaseDataSetTableAdapters.ArreaTableAdapter arreaTableAdapter;
        private MTPDataSet mTPDataSet;
        private System.Windows.Forms.BindingSource tCOMPANYBindingSource;
        private MTPDataSetTableAdapters.T_COMPANYTableAdapter t_COMPANYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPANYIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPANYNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tESTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMLEVELIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMLEVELNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTYTOTALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTYJOINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTYRATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tESTPASSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tESTFAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tESTRATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCOREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bASEPASSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bASEFAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bASERATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAJORPASSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAJORFAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAJORRATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pARENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aTENDDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kMLEVELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLASSIFYIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEMARKDataGridViewTextBoxColumn;
    }
}