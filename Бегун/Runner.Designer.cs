namespace Подготовка_к_WSR_3.Бегун
{
    partial class Runner
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
            this.lbl_Timer = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_NewRunner = new System.Windows.Forms.Button();
            this.bti_Runner = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.topPanel.Controls.Add(this.btn_close);
            this.topPanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(408, 25);
            this.topPanel.TabIndex = 2;
            // 
            // lbl_Timer
            // 
            this.lbl_Timer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_Timer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Timer.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Timer.Location = new System.Drawing.Point(0, 299);
            this.lbl_Timer.Name = "lbl_Timer";
            this.lbl_Timer.Size = new System.Drawing.Size(408, 41);
            this.lbl_Timer.TabIndex = 3;
            this.lbl_Timer.Text = "lbl_Timer";
            this.lbl_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_NewRunner
            // 
            this.btn_NewRunner.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_NewRunner.FlatAppearance.BorderSize = 0;
            this.btn_NewRunner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NewRunner.ForeColor = System.Drawing.Color.White;
            this.btn_NewRunner.Location = new System.Drawing.Point(62, 177);
            this.btn_NewRunner.Name = "btn_NewRunner";
            this.btn_NewRunner.Size = new System.Drawing.Size(285, 71);
            this.btn_NewRunner.TabIndex = 4;
            this.btn_NewRunner.Text = "Я новый участник";
            this.btn_NewRunner.UseVisualStyleBackColor = false;
            this.btn_NewRunner.Click += new System.EventHandler(this.btn_NewRunner_Click);
            // 
            // bti_Runner
            // 
            this.bti_Runner.BackColor = System.Drawing.Color.RoyalBlue;
            this.bti_Runner.FlatAppearance.BorderSize = 0;
            this.bti_Runner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bti_Runner.ForeColor = System.Drawing.Color.White;
            this.bti_Runner.Location = new System.Drawing.Point(62, 91);
            this.bti_Runner.Name = "bti_Runner";
            this.bti_Runner.Size = new System.Drawing.Size(285, 71);
            this.bti_Runner.TabIndex = 5;
            this.bti_Runner.Text = "Я раннее участвовал";
            this.bti_Runner.UseVisualStyleBackColor = false;
            this.bti_Runner.Click += new System.EventHandler(this.bti_Runner_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.ForeColor = System.Drawing.Color.White;
            this.btn_Back.Image = global::Подготовка_к_WSR_3.Properties.Resources.icons8_arrow_pointing_left_32;
            this.btn_Back.Location = new System.Drawing.Point(3, 31);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(79, 39);
            this.btn_Back.TabIndex = 5;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
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
            this.btn_close.Location = new System.Drawing.Point(383, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(25, 25);
            this.btn_close.TabIndex = 0;
            this.btn_close.UseVisualStyleBackColor = false;
            // 
            // Runner
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(408, 340);
            this.Controls.Add(this.btn_NewRunner);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.bti_Runner);
            this.Controls.Add(this.lbl_Timer);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Runner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Runner";
            this.Load += new System.EventHandler(this.Runner_Load);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_Timer;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_NewRunner;
        private System.Windows.Forms.Button bti_Runner;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btn_Back;
    }
}