using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Подготовка_к_WSR_3.Общее
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            // обращаемся к методу передвижения формы
            FormMovement();
            // метод приватного ввода пароля
            PrivateEnterPassword();
            // закрыть форму с помощью Лямдо выражений
            btn_close.Click += (s, e) => { Close(); };
            // скрыть окно
            btn_minimize.Click += (s, e) => { this.WindowState = FormWindowState.Minimized; };
            // подсказки пользователю
            #region textBox
            // подсказки пользователя
            txt_Login.Text = "Введите email";
            txt_Login.ForeColor = Color.CornflowerBlue;

            txt_password.Text = "Введите пароль";
            txt_password.UseSystemPasswordChar = false;
            txt_password.ForeColor = Color.CornflowerBlue;
            #endregion
        }
        // конфиденциальный ввод пароля
        private void PrivateEnterPassword()
        {
            txt_password.TextChanged += (s, e) => { txt_password.UseSystemPasswordChar = true; };
            show.MouseDown += (s, e) => { txt_password.UseSystemPasswordChar = false; };
            show.MouseUp += (s, e) =>
            {
                if (txt_password.Text == "Введите пароль")
                    txt_password.UseSystemPasswordChar = false;
                else
                    txt_password.UseSystemPasswordChar = true; 
            };
        }
        // метод передвиженя формы
        private void FormMovement()
        {
            int move = 0, x = 0, y = 0;
            topPanel.MouseDown += (s, e) => { move = 1; x = e.X; y = e.Y; };
            topPanel.MouseMove += (s, e) => { if (move == 1) SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y); };
            topPanel.MouseUp += (s, e) => { move = 0; };
        }
        // устанавливаем таймер до старта Марафона
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime maraphoneSkills = new DateTime(2019, 12, 12, 8, 0, 0);
            TimeSpan totalTime = maraphoneSkills - DateTime.Now;
            lbl_Timer.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта Марафона!";
        }
        
        private void Login_Load(object sender, EventArgs e)
        {
            // запускаем таймер
            timer1.Start();
        }
        // переход на стартовую форму
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите покинуть окно авторизации?", 
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ActiveForm.Hide();
                Start start = new Start();
                start.ShowDialog();
                Close();
            }
        }

        // подсказки пользователя
        #region TextUser
        private void txt_Login_Enter(object sender, EventArgs e)
        {
            if(txt_Login.Text == "Введите email")
            {
                txt_Login.Text = "";
                txt_Login.ForeColor = Color.Black;
            }
        }

        private void txt_Login_Leave(object sender, EventArgs e)
        {
            if(txt_Login.Text == "")
            {
                txt_Login.Text = "Введите email";
                txt_Login.ForeColor = Color.CornflowerBlue;
            }
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text == "Введите пароль")
            {
                txt_password.Text = "";
                txt_password.UseSystemPasswordChar = false;
                txt_password.ForeColor = Color.Black;
            }

        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if(txt_password.Text == "")
            {
                txt_password.Text = "Введите пароль";
                txt_password.UseSystemPasswordChar = false;
                txt_password.ForeColor = Color.CornflowerBlue;
            }
        }
        #endregion

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
                btn_login.PerformClick();
            if (e.KeyValue == (char)Keys.Escape)
                btn_Cancel.PerformClick();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
