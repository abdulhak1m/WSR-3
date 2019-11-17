namespace Подготовка_к_WSR_3
{
    partial class Start
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_IWantRunner = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.topPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_Timer = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_IWantRunner
            // 
            this.btn_IWantRunner.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_IWantRunner.FlatAppearance.BorderSize = 0;
            this.btn_IWantRunner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IWantRunner.ForeColor = System.Drawing.Color.White;
            this.btn_IWantRunner.Location = new System.Drawing.Point(88, 67);
            this.btn_IWantRunner.Name = "btn_IWantRunner";
            this.btn_IWantRunner.Size = new System.Drawing.Size(285, 71);
            this.btn_IWantRunner.TabIndex = 0;
            this.btn_IWantRunner.Text = "Я хочу стать Бегуном";
            this.btn_IWantRunner.UseVisualStyleBackColor = false;
            this.btn_IWantRunner.Click += new System.EventHandler(this.btn_IWantRunner_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
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
            this.topPanel.Size = new System.Drawing.Size(461, 25);
            this.topPanel.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(88, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(285, 71);
            this.button3.TabIndex = 0;
            this.button3.Text = "Я хочу стать спонсором";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(88, 242);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(285, 71);
            this.button4.TabIndex = 0;
            this.button4.Text = "Я хочу узнать больше";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_Timer
            // 
            this.lbl_Timer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_Timer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Timer.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Timer.Location = new System.Drawing.Point(0, 368);
            this.lbl_Timer.Name = "lbl_Timer";
            this.lbl_Timer.Size = new System.Drawing.Size(461, 41);
            this.lbl_Timer.TabIndex = 4;
            this.lbl_Timer.Text = "lbl_Timer";
            this.lbl_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn_close.Location = new System.Drawing.Point(436, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(25, 25);
            this.btn_close.TabIndex = 0;
            this.btn_close.UseVisualStyleBackColor = false;
            // 
            // btn_login
            // 
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Image = global::Подготовка_к_WSR_3.Properties.Resources.icons8_enter_2_32;
            this.btn_login.Location = new System.Drawing.Point(276, 319);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(97, 41);
            this.btn_login.TabIndex = 0;
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
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
            this.btn_minimize.Location = new System.Drawing.Point(411, 0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(25, 25);
            this.btn_minimize.TabIndex = 2;
            this.btn_minimize.UseVisualStyleBackColor = false;
            // 
            // Start
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(461, 409);
            this.Controls.Add(this.lbl_Timer);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_IWantRunner);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Start_Load);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_IWantRunner;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_Timer;
        private System.Windows.Forms.Button btn_minimize;
    }
}

