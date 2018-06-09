namespace MTPsys.View
{
    partial class OpenEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenEdit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sex = new System.Windows.Forms.ComboBox();
            this.age = new System.Windows.Forms.TextBox();
            this.weight = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sg = new System.Windows.Forms.TextBox();
            this.dg = new System.Windows.Forms.TextBox();
            this.yt = new System.Windows.Forms.TextBox();
            this.sq = new System.Windows.Forms.TextBox();
            this.s = new System.Windows.Forms.TextBox();
            this.y = new System.Windows.Forms.TextBox();
            this.f = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tTESTITEMSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mTP1DataSet11 = new MTPsys.MTP1DataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.t_TEST_ITEMSTableAdapter1 = new MTPsys.MTP1DataSet1TableAdapters.T_TEST_ITEMSTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tTESTITEMSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTP1DataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 53);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑 Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(312, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "人员基本信息";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sex);
            this.groupBox1.Controls.Add(this.age);
            this.groupBox1.Controls.Add(this.weight);
            this.groupBox1.Controls.Add(this.height);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(-1, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 134);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "人员基本信息";
            // 
            // sex
            // 
            this.sex.FormattingEnabled = true;
            this.sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.sex.Location = new System.Drawing.Point(625, 32);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(100, 20);
            this.sex.TabIndex = 15;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(83, 66);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(100, 21);
            this.age.TabIndex = 13;
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(625, 66);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(100, 21);
            this.weight.TabIndex = 12;
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(341, 64);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(100, 21);
            this.height.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(565, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "体重：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(290, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "身高：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(40, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "年龄：";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(341, 29);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(100, 21);
            this.Name.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(565, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "性别：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(290, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "姓名：";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(83, 28);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 21);
            this.ID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(40, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "编号：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sg);
            this.groupBox2.Controls.Add(this.dg);
            this.groupBox2.Controls.Add(this.yt);
            this.groupBox2.Controls.Add(this.sq);
            this.groupBox2.Controls.Add(this.s);
            this.groupBox2.Controls.Add(this.y);
            this.groupBox2.Controls.Add(this.f);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(4, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(749, 215);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "项目基本成绩";
            // 
            // sg
            // 
            this.sg.Location = new System.Drawing.Point(545, 115);
            this.sg.Name = "sg";
            this.sg.Size = new System.Drawing.Size(162, 21);
            this.sg.TabIndex = 15;
            // 
            // dg
            // 
            this.dg.Location = new System.Drawing.Point(545, 79);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(162, 21);
            this.dg.TabIndex = 14;
            // 
            // yt
            // 
            this.yt.Location = new System.Drawing.Point(545, 47);
            this.yt.Name = "yt";
            this.yt.Size = new System.Drawing.Size(162, 21);
            this.yt.TabIndex = 13;
            // 
            // sq
            // 
            this.sq.Location = new System.Drawing.Point(153, 144);
            this.sq.Name = "sq";
            this.sq.Size = new System.Drawing.Size(162, 21);
            this.sq.TabIndex = 12;
            // 
            // s
            // 
            this.s.Location = new System.Drawing.Point(153, 115);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(162, 21);
            this.s.TabIndex = 11;
            // 
            // y
            // 
            this.y.Location = new System.Drawing.Point(153, 83);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(162, 21);
            this.y.TabIndex = 10;
            // 
            // f
            // 
            this.f.Location = new System.Drawing.Point(153, 48);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(162, 21);
            this.f.TabIndex = 9;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(417, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 12);
            this.label18.TabIndex = 8;
            this.label18.Text = "项目";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Wheat;
            this.label17.Font = new System.Drawing.Font("汉仪南宫体简", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(403, 80);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(145, 20);
            this.label17.TabIndex = 7;
            this.label17.Text = "单杠屈臂悬垂:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Wheat;
            this.label16.Font = new System.Drawing.Font("汉仪南宫体简", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(403, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 20);
            this.label16.TabIndex = 6;
            this.label16.Text = "引体向上:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Wheat;
            this.label15.Font = new System.Drawing.Font("汉仪南宫体简", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(403, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 20);
            this.label15.TabIndex = 5;
            this.label15.Text = "双杠臂屈伸:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Wheat;
            this.label14.Font = new System.Drawing.Font("汉仪南宫体简", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(54, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 20);
            this.label14.TabIndex = 4;
            this.label14.Text = "3000米:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Wheat;
            this.label13.Font = new System.Drawing.Font("汉仪南宫体简", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(54, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "往返跑:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Wheat;
            this.label12.Font = new System.Drawing.Font("汉仪南宫体简", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(54, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "仰卧起坐:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Wheat;
            this.label11.Font = new System.Drawing.Font("汉仪南宫体简", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(54, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "俯卧撑：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(76, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "项目";
            // 
            // tTESTITEMSBindingSource1
            // 
            this.tTESTITEMSBindingSource1.DataMember = "T_TEST_ITEMS";
            this.tTESTITEMSBindingSource1.DataSource = this.mTP1DataSet11;
            // 
            // mTP1DataSet11
            // 
            this.mTP1DataSet11.DataSetName = "MTP1DataSet1";
            this.mTP1DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(665, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_TEST_ITEMSTableAdapter1
            // 
            this.t_TEST_ITEMSTableAdapter1.ClearBeforeFill = true;
            // 
            // OpenEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 456);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
           
            this.Text = "OpenEdit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tTESTITEMSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTP1DataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
     
        private System.Windows.Forms.DataGridViewTextBoxColumn sUBJECTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rESULTSDataGridViewTextBoxColumn;
        private MTP1DataSet1 mTP1DataSet1;
        private MTP1DataSet1TableAdapters.T_TEST_ITEMSTableAdapter t_TEST_ITEMSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lISTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUBJECTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMSDataGridViewTextBoxColumn;
        private MTP1DataSet1 mTP1DataSet11;
        private MTP1DataSet1TableAdapters.T_TEST_ITEMSTableAdapter t_TEST_ITEMSTableAdapter1;
        private System.Windows.Forms.ComboBox sex;
        private System.Windows.Forms.BindingSource tTESTITEMSBindingSource1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox sg;
        private System.Windows.Forms.TextBox dg;
        private System.Windows.Forms.TextBox yt;
        private System.Windows.Forms.TextBox sq;
        private System.Windows.Forms.TextBox s;
        private System.Windows.Forms.TextBox y;
        private System.Windows.Forms.TextBox f;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
    }
}