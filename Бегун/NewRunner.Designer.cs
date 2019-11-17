namespace Подготовка_к_WSR_3.Бегун
{
    partial class NewRunner
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lbl_Timer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_done = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_conpassword = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cmb_gender = new System.Windows.Forms.ComboBox();
            this.pic_img = new System.Windows.Forms.PictureBox();
            this.lbl_name_img = new System.Windows.Forms.Label();
            this.btn_browse = new System.Windows.Forms.Button();
            this.dtp_DateOf_Birth = new System.Windows.Forms.DateTimePicker();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cmb_Country = new System.Windows.Forms.ComboBox();
            this.dbMaraphoneDataSet = new Подготовка_к_WSR_3.dbMaraphoneDataSet();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.countryTableAdapter = new Подготовка_к_WSR_3.dbMaraphoneDataSetTableAdapters.CountryTableAdapter();
            this.lbl_error = new System.Windows.Forms.Label();
            this.runnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.runnerTableAdapter = new Подготовка_к_WSR_3.dbMaraphoneDataSetTableAdapters.RunnerTableAdapter();
            this.tableAdapterManager = new Подготовка_к_WSR_3.dbMaraphoneDataSetTableAdapters.TableAdapterManager();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roleTableAdapter = new Подготовка_к_WSR_3.dbMaraphoneDataSetTableAdapters.RoleTableAdapter();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new Подготовка_к_WSR_3.dbMaraphoneDataSetTableAdapters.UserTableAdapter();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMaraphoneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.topPanel.Controls.Add(this.btn_minimize);
            this.topPanel.Controls.Add(this.btn_close);
            this.topPanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(740, 25);
            this.topPanel.TabIndex = 3;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lbl_Timer
            // 
            this.lbl_Timer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_Timer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Timer.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Timer.Location = new System.Drawing.Point(0, 565);
            this.lbl_Timer.Name = "lbl_Timer";
            this.lbl_Timer.Size = new System.Drawing.Size(740, 41);
            this.lbl_Timer.TabIndex = 5;
            this.lbl_Timer.Text = "lbl_Timer";
            this.lbl_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.ForeColor = System.Drawing.Color.White;
            this.btn_minimize.Image = global::Подготовка_к_WSR_3.Properties.Resources.icons8_m5acos_minimize_16;
            this.btn_minimize.Location = new System.Drawing.Point(690, 0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(25, 25);
            this.btn_minimize.TabIndex = 1;
            this.btn_minimize.UseVisualStyleBackColor = false;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Image = global::Подготовка_к_WSR_3.Properties.Resources.icons8_shutdown_16;
            this.btn_close.Location = new System.Drawing.Point(715, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(25, 25);
            this.btn_close.TabIndex = 0;
            this.btn_close.UseVisualStyleBackColor = false;
            // 
            // btn_Back
            // 
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.ForeColor = System.Drawing.Color.White;
            this.btn_Back.Image = global::Подготовка_к_WSR_3.Properties.Resources.icons8_arrow_pointing_left_32;
            this.btn_Back.Location = new System.Drawing.Point(4, 31);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(53, 39);
            this.btn_Back.TabIndex = 6;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_done
            // 
            this.btn_done.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_done.FlatAppearance.BorderSize = 0;
            this.btn_done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_done.ForeColor = System.Drawing.Color.White;
            this.btn_done.Location = new System.Drawing.Point(28, 398);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(131, 37);
            this.btn_done.TabIndex = 11;
            this.btn_done.Text = "Готово";
            this.btn_done.UseVisualStyleBackColor = false;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(28, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 5);
            this.panel1.TabIndex = 10;
            // 
            // txt_surname
            // 
            this.txt_surname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_surname.Location = new System.Drawing.Point(28, 279);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(290, 20);
            this.txt_surname.TabIndex = 9;
            this.txt_surname.Enter += new System.EventHandler(this.txt_surname_Enter);
            this.txt_surname.Leave += new System.EventHandler(this.txt_surname_Leave);
            // 
            // txt_email
            // 
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Location = new System.Drawing.Point(28, 76);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(290, 20);
            this.txt_email.TabIndex = 9;
            this.txt_email.Enter += new System.EventHandler(this.txt_email_Enter);
            this.txt_email.Leave += new System.EventHandler(this.txt_email_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Location = new System.Drawing.Point(28, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 5);
            this.panel2.TabIndex = 10;
            // 
            // txt_password
            // 
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Location = new System.Drawing.Point(28, 134);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(290, 20);
            this.txt_password.TabIndex = 9;
            this.txt_password.Enter += new System.EventHandler(this.txt_password_Enter);
            this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Location = new System.Drawing.Point(28, 155);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 5);
            this.panel3.TabIndex = 10;
            // 
            // txt_conpassword
            // 
            this.txt_conpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_conpassword.Location = new System.Drawing.Point(28, 182);
            this.txt_conpassword.Name = "txt_conpassword";
            this.txt_conpassword.Size = new System.Drawing.Size(290, 20);
            this.txt_conpassword.TabIndex = 9;
            this.txt_conpassword.Enter += new System.EventHandler(this.txt_conpassword_Enter);
            this.txt_conpassword.Leave += new System.EventHandler(this.txt_conpassword_Leave);
            // 
            // txt_name
            // 
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name.Location = new System.Drawing.Point(28, 228);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(290, 20);
            this.txt_name.TabIndex = 9;
            this.txt_name.Enter += new System.EventHandler(this.txt_name_Enter);
            this.txt_name.Leave += new System.EventHandler(this.txt_name_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Location = new System.Drawing.Point(28, 203);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(290, 5);
            this.panel4.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.Location = new System.Drawing.Point(28, 249);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(290, 5);
            this.panel5.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel6.Location = new System.Drawing.Point(28, 360);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(290, 5);
            this.panel6.TabIndex = 10;
            // 
            // cmb_gender
            // 
            this.cmb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_gender.FormattingEnabled = true;
            this.cmb_gender.Items.AddRange(new object[] {
            "Выберите пол",
            "Мужской",
            "Женский",
            "Нариман"});
            this.cmb_gender.Location = new System.Drawing.Point(28, 330);
            this.cmb_gender.Name = "cmb_gender";
            this.cmb_gender.Size = new System.Drawing.Size(290, 29);
            this.cmb_gender.TabIndex = 12;
            // 
            // pic_img
            // 
            this.pic_img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_img.Location = new System.Drawing.Point(431, 91);
            this.pic_img.Name = "pic_img";
            this.pic_img.Size = new System.Drawing.Size(262, 136);
            this.pic_img.TabIndex = 13;
            this.pic_img.TabStop = false;
            // 
            // lbl_name_img
            // 
            this.lbl_name_img.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_name_img.Location = new System.Drawing.Point(431, 44);
            this.lbl_name_img.Name = "lbl_name_img";
            this.lbl_name_img.Size = new System.Drawing.Size(262, 44);
            this.lbl_name_img.TabIndex = 14;
            // 
            // btn_browse
            // 
            this.btn_browse.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_browse.FlatAppearance.BorderSize = 0;
            this.btn_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_browse.ForeColor = System.Drawing.Color.White;
            this.btn_browse.Location = new System.Drawing.Point(494, 233);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(131, 37);
            this.btn_browse.TabIndex = 11;
            this.btn_browse.Text = "Обзор";
            this.btn_browse.UseVisualStyleBackColor = false;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // dtp_DateOf_Birth
            // 
            this.dtp_DateOf_Birth.Location = new System.Drawing.Point(431, 288);
            this.dtp_DateOf_Birth.Name = "dtp_DateOf_Birth";
            this.dtp_DateOf_Birth.Size = new System.Drawing.Size(262, 27);
            this.dtp_DateOf_Birth.TabIndex = 15;
            this.dtp_DateOf_Birth.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel7.Location = new System.Drawing.Point(431, 373);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(262, 5);
            this.panel7.TabIndex = 10;
            // 
            // cmb_Country
            // 
            this.cmb_Country.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.countryBindingSource1, "CountryName", true));
            this.cmb_Country.DataSource = this.countryBindingSource1;
            this.cmb_Country.DisplayMember = "CountryName";
            this.cmb_Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Country.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Country.FormattingEnabled = true;
            this.cmb_Country.Location = new System.Drawing.Point(431, 343);
            this.cmb_Country.Name = "cmb_Country";
            this.cmb_Country.Size = new System.Drawing.Size(262, 29);
            this.cmb_Country.TabIndex = 12;
            this.cmb_Country.ValueMember = "CountryName";
            // 
            // dbMaraphoneDataSet
            // 
            this.dbMaraphoneDataSet.DataSetName = "dbMaraphoneDataSet";
            this.dbMaraphoneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.dbMaraphoneDataSet;
            // 
            // countryBindingSource1
            // 
            this.countryBindingSource1.DataMember = "Country";
            this.countryBindingSource1.DataSource = this.dbMaraphoneDataSet;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(24, 105);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 17);
            this.lbl_error.TabIndex = 16;
            // 
            // runnerBindingSource
            // 
            this.runnerBindingSource.DataMember = "Runner";
            this.runnerBindingSource.DataSource = this.dbMaraphoneDataSet;
            // 
            // runnerTableAdapter
            // 
            this.runnerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CharityTableAdapter = null;
            this.tableAdapterManager.CountryTableAdapter = this.countryTableAdapter;
            this.tableAdapterManager.EventTableAdapter = null;
            this.tableAdapterManager.EventTypeTableAdapter = null;
            this.tableAdapterManager.GenderTableAdapter = null;
            this.tableAdapterManager.MarathonTableAdapter = null;
            this.tableAdapterManager.RaceKitOptionTableAdapter = null;
            this.tableAdapterManager.RegistrationEventTableAdapter = null;
            this.tableAdapterManager.RegistrationStatusTableAdapter = null;
            this.tableAdapterManager.RegistrationTableAdapter = null;
            this.tableAdapterManager.RoleTableAdapter = this.roleTableAdapter;
            this.tableAdapterManager.RunnerTableAdapter = this.runnerTableAdapter;
            this.tableAdapterManager.SponsorshipTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Подготовка_к_WSR_3.dbMaraphoneDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = this.userTableAdapter;
            this.tableAdapterManager.VolunteerTableAdapter = null;
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataMember = "Role";
            this.roleBindingSource.DataSource = this.dbMaraphoneDataSet;
            // 
            // roleTableAdapter
            // 
            this.roleTableAdapter.ClearBeforeFill = true;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.dbMaraphoneDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // NewRunner
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(740, 606);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.dtp_DateOf_Birth);
            this.Controls.Add(this.lbl_name_img);
            this.Controls.Add(this.pic_img);
            this.Controls.Add(this.cmb_Country);
            this.Controls.Add(this.cmb_gender);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_conpassword);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lbl_Timer);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewRunner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Runner2";
            this.Load += new System.EventHandler(this.NewRunner_Load);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMaraphoneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_minimize;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lbl_Timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_conpassword;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.PictureBox pic_img;
        private System.Windows.Forms.ComboBox cmb_gender;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_name_img;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.DateTimePicker dtp_DateOf_Birth;
        private System.Windows.Forms.ComboBox cmb_Country;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private dbMaraphoneDataSet dbMaraphoneDataSet;
        private System.Windows.Forms.BindingSource countryBindingSource1;
        private dbMaraphoneDataSetTableAdapters.CountryTableAdapter countryTableAdapter;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.BindingSource runnerBindingSource;
        private dbMaraphoneDataSetTableAdapters.RunnerTableAdapter runnerTableAdapter;
        private dbMaraphoneDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private dbMaraphoneDataSetTableAdapters.RoleTableAdapter roleTableAdapter;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private dbMaraphoneDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.BindingSource userBindingSource;
    }
}