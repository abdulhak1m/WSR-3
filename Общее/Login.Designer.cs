namespace Подготовка_к_WSR_3.Общее
{
    partial class Login
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
            this.txt_Login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_login = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
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
            this.topPanel.Size = new System.Drawing.Size(467, 25);
            this.topPanel.TabIndex = 2;
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
            this.lbl_Timer.Location = new System.Drawing.Point(0, 338);
            this.lbl_Timer.Name = "lbl_Timer";
            this.lbl_Timer.Size = new System.Drawing.Size(467, 41);
            this.lbl_Timer.TabIndex = 4;
            this.lbl_Timer.Text = "lbl_Timer";
            this.lbl_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_Login
            // 
            this.txt_Login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Login.Location = new System.Drawing.Point(88, 147);
            this.txt_Login.Name = "txt_Login";
            this.txt_Login.Size = new System.Drawing.Size(290, 20);
            this.txt_Login.TabIndex = 5;
            this.txt_Login.Enter += new System.EventHandler(this.txt_Login_Enter);
            this.txt_Login.Leave += new System.EventHandler(this.txt_Login_Leave);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(0, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 57);
            this.label1.TabIndex = 6;
            this.label1.Text = "MaraphoneSkills 2019";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(88, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 5);
            this.panel1.TabIndex = 7;
            // 
            // txt_password
            // 
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Location = new System.Drawing.Point(88, 205);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(290, 20);
            this.txt_password.TabIndex = 5;
            this.txt_password.Enter += new System.EventHandler(this.txt_password_Enter);
            this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Location = new System.Drawing.Point(88, 226);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 5);
            this.panel2.TabIndex = 7;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(247, 251);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(131, 37);
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "Войти";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // show
            // 
            this.show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show.FlatAppearance.BorderSize = 0;
            this.show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show.ForeColor = System.Drawing.Color.White;
            this.show.Image = global::Подготовка_к_WSR_3.Properties.Resources.icons8_visible_filled_16;
            this.show.Location = new System.Drawing.Point(384, 200);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(25, 25);
            this.show.TabIndex = 8;
            this.show.UseVisualStyleBackColor = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Image = global::Подготовка_к_WSR_3.Properties.Resources.icons8_arrow_pointing_left_32;
            this.btn_Cancel.Location = new System.Drawing.Point(88, 251);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(131, 37);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Image = global::Подготовка_к_WSR_3.Properties.Resources.icons8_shutdown_16;
            this.btn_close.Location = new System.Drawing.Point(442, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(25, 25);
            this.btn_close.TabIndex = 0;
            this.btn_close.UseVisualStyleBackColor = false;
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
            this.btn_minimize.Location = new System.Drawing.Point(417, 0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(25, 25);
            this.btn_minimize.TabIndex = 2;
            this.btn_minimize.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(467, 379);
            this.Controls.Add(this.show);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_Login);
            this.Controls.Add(this.lbl_Timer);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btn_close;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lbl_Timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button btn_minimize;
    }
}