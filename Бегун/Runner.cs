using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Подготовка_к_WSR_3.Общее;

namespace Подготовка_к_WSR_3.Бегун
{
    public partial class Runner : Form
    {
        public Runner()
        {
            InitializeComponent();
            // метод передвижения формы
            FormMovement();
            // закрыть форму
            btn_close.Click += (s, e) => { Close(); };
        }
        // передвижене формы
        private void FormMovement()
        {
            int move = 0, x = 0, y = 0;
            topPanel.MouseDown += (s, e) => { move = 1; x = e.X; y = e.Y; };
            topPanel.MouseMove += (s, e) => { if (move == 1) SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y); };
            topPanel.MouseUp += (s, e) => { move = 0; };
        }
        // установим таймер
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime maraphoneSkills = new DateTime(2019, 12, 12, 8, 0, 0);
            TimeSpan totalTime = maraphoneSkills - DateTime.Now;
            lbl_Timer.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта Марафона!"; 
        }
        // запускаем таймер
        private void Runner_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        // форма авторизцыии
        private void bti_Runner_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Login login = new Login();
            login.ShowDialog();
            Close();
        }
        // регистрация Бегуна
        private void btn_NewRunner_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            NewRunner runner = new NewRunner();
            runner.ShowDialog();
            Close();
        }
        // назад, на главное окно
        private void btn_Back_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Start start = new Start();
            start.ShowDialog();
            Close();
        }
    }
}
