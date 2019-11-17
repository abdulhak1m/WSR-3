using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Подготовка_к_WSR_3.Бегун;
using Подготовка_к_WSR_3.Общее;

namespace Подготовка_к_WSR_3
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            FormMovement();
            btn_close.Click += (s, e) => { Close(); };
            // скрыть окно
            btn_minimize.Click += (s, e) => { this.WindowState = FormWindowState.Minimized; };
        }
        // передвижение формы
        private void FormMovement()
        {
            int move = 0, x = 0, y = 0;
            topPanel.MouseDown += (s, e) => { move = 1; x = e.X; y = e.Y; };
            topPanel.MouseMove += (s, e) => { if (move == 1) SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y); };
            topPanel.MouseUp += (s, e) => { move = 0; };
        }
        // переход в окно выбора типа Бегуна
        private void btn_IWantRunner_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Runner runner = new Runner();
            runner.ShowDialog();
            Close();
        }
        // устанавливаем таймер
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime maraphoneSkills = new DateTime(2019, 12, 12, 8, 0, 0);
            TimeSpan totalTime = maraphoneSkills - DateTime.Now;
            lbl_Timer.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта Марафона!";
        }
        // запускаем таймер
        private void Start_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        // переход в окно Авторизации
        private void btn_login_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Login login = new Login();
            login.ShowDialog();
            Close();
        }
    }
}
