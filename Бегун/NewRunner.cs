using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Подготовка_к_WSR_3.Бегун
{
    public partial class NewRunner : Form
    {
        public NewRunner()
        {
            InitializeComponent();
            // закрыть программу
            btn_close.Click += (s, e) => { Close(); };
            // скрыть окно
            btn_minimize.Click += (s, e) => { this.WindowState = FormWindowState.Minimized; };
            // метод передвижения формы
            FormMovement();
            #region textBox
            // подсказки пользователя
            txt_email.Text = "Введите email";
            txt_email.ForeColor = Color.CornflowerBlue;

            txt_password.Text = "Введите пароль";
            txt_password.UseSystemPasswordChar = false;
            txt_password.ForeColor = Color.CornflowerBlue;


            txt_conpassword.Text = "Подтвредите пароль";
            txt_conpassword.UseSystemPasswordChar = false;
            txt_conpassword.ForeColor = Color.CornflowerBlue;

            txt_name.Text = "Введите имя";
            txt_name.ForeColor = Color.CornflowerBlue;


            txt_surname.Text = "Введите фамилию";
            txt_surname.ForeColor = Color.CornflowerBlue;

            cmb_gender.SelectedIndex = 0;
            //cmb_Country.SelectedIndex = 0;

            #endregion

        }
        // метод передвиженя формы
        private void FormMovement()
        {
            int move = 0, x = 0, y = 0;
            topPanel.MouseDown += (s, e) => { move = 1; x = e.X; y = e.Y; };
            topPanel.MouseMove += (s, e) => { if (move == 1) SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y); };
            topPanel.MouseUp += (s, e) => { move = 0; };
        }
        // устанавливаем таймер
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime maraphoneSkills = new DateTime(2019, 12, 12, 8, 0, 0);
            TimeSpan totalTime = maraphoneSkills - DateTime.Now;
            lbl_Timer.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта Марафона!";
        }
        private bool Check()
        {
            if (txt_password.Text == "Введите пароль" || txt_password.Text == "" &&
                txt_conpassword.Text == "Подтвредите пароль" || txt_conpassword.Text == "Подтвредите пароль")
            {
                if (txt_conpassword.Text != txt_password.Text)
                {
                    lbl_error.Text = "Внимание, пароли не совпадают!";
                    return false;
                }
                else
                {
                    lbl_error.Text = "";
                    return true;
                }
            }
            else
                return false;
        }
        //
        byte[] ConvertToBinaryImg(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        private void NewRunner_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbMaraphoneDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.dbMaraphoneDataSet.User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbMaraphoneDataSet.Role". При необходимости она может быть перемещена или удалена.
            this.roleTableAdapter.Fill(this.dbMaraphoneDataSet.Role);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbMaraphoneDataSet.Runner". При необходимости она может быть перемещена или удалена.
            this.runnerTableAdapter.Fill(this.dbMaraphoneDataSet.Runner);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbMaraphoneDataSet.Country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter.Fill(this.dbMaraphoneDataSet.Country);
            timer1.Start();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Start start = new Start();
            start.ShowDialog();
            Close();
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            if (!Check())
                return;
            try
            {
                for(int i = 0; i < this.dbMaraphoneDataSet.User.Count; i++)
                {
                    if(txt_email.Text == this.dbMaraphoneDataSet.User[i].Email)
                    {
                        MessageBox.Show("Извините, но такой пользователь уже существует!", "Пользователь существует!", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                bool isdigit = false;
                bool spec = false;
                bool lowchar = false;

                for(int i = 0; i < txt_password.TextLength; i++)
                {
                    if (char.IsDigit(txt_password.Text[i]))
                    {
                        isdigit = true;
                        break;
                    }
                }
                for(int i = 0; i < txt_password.TextLength; i++)
                {
                    if (char.IsLower(txt_password.Text[i]))
                    {
                        lowchar = true;
                        break;
                    }
                }
                for(int i = 0; i < txt_password.TextLength; i++)
                {
                    if(txt_password.Text[i] == '$'
                        || txt_password.Text[i] == '%' || txt_password.Text[i] == '^'
                        || txt_password.Text[i] == '@' || txt_password.Text[i] == '#' 
                        || txt_password.Text[i] == '!')
                    {
                        spec = true;
                        break;
                    }
                }
                DateTime date = Convert.ToDateTime(dtp_DateOf_Birth.Value);
                if (DateTime.Now.Year - date.Year < 10)
                {
                    MessageBox.Show("Возраст бегуна, на момент регистрации не должен быть меньше 10-ти лет!", "Уведомление системы!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(txt_password.TextLength < 6 || !spec || !isdigit || !lowchar)
                {
                    MessageBox.Show("Неккоректный формат пароля! Пароль не должен быть меньше 6-ти символов, из которых " +
                        "должна быть как минимум одна буква нижнего регистра, одна цифра и одна из слудеющих символов:" +
                        "$,%,^,@,#,!", "Неккоректный формат пароля!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!img)
                    {
                        if (MessageBox.Show("Вы хотите загрузить фото профиля?", "Фото", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            return;
                        }
                        else
                        {
                            this.userTableAdapter.Insert(txt_email.Text, this.txt_password.Text, txt_surname.Text, 'R');
                            Image img = Image.FromFile(filename);
                            this.runnerTableAdapter.Insert(cmb_gender.Text, Convert.ToDateTime(this.dtp_DateOf_Birth.Value), Convert.ToString(this.cmb_Country.SelectedValue), this.txt_email.Text, null);
                            MessageBox.Show("Успешно!");
                        }
                    }
                    else
                    {
                        this.userTableAdapter.Insert(txt_email.Text, this.txt_password.Text, txt_surname.Text, 'R');
                        Image img = Image.FromFile(filename); 
                        this.runnerTableAdapter.Insert(cmb_gender.Text, Convert.ToDateTime(this.dtp_DateOf_Birth.Value), Convert.ToString(this.cmb_Country.SelectedValue), this.txt_email.Text, null);
                        MessageBox.Show("Успешно!");
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #region TextBox
        private void txt_email_Enter(object sender, EventArgs e)
        {
            if (txt_email.Text == "Введите email")
            {
                txt_email.Text = "";
                txt_email.ForeColor = Color.Black;
            }
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            if (txt_email.Text == "")
            {
                txt_email.Text = "Введите email";
                txt_email.ForeColor = Color.CornflowerBlue;
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
            if (txt_password.Text == "")
            {
                txt_password.Text = "Введите пароль";
                txt_password.UseSystemPasswordChar = false;
                txt_password.ForeColor = Color.CornflowerBlue;
            }
        }

        private void txt_conpassword_Enter(object sender, EventArgs e)
        {
            if (txt_conpassword.Text == "Подтвредите пароль")
            {
                txt_conpassword.Text = "";
                txt_conpassword.UseSystemPasswordChar = false;
                txt_conpassword.ForeColor = Color.Black;
            }
        }

        private void txt_conpassword_Leave(object sender, EventArgs e)
        {
            if (txt_conpassword.Text == "")
            {
                txt_conpassword.Text = "Подтвредите пароль";
                txt_conpassword.UseSystemPasswordChar = false;
                txt_conpassword.ForeColor = Color.CornflowerBlue;
            }
        }

        private void txt_name_Enter(object sender, EventArgs e)
        {
            if (txt_name.Text == "Введите имя")
            {
                txt_name.Text = "";
                txt_name.ForeColor = Color.Black;
            }
        }

        private void txt_name_Leave(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                txt_name.Text = "Введите имя";
                txt_name.ForeColor = Color.CornflowerBlue;
            }
        }

        private void txt_surname_Enter(object sender, EventArgs e)
        {
            if (txt_surname.Text == "Введите фамилию")
            {
                txt_surname.Text = "";
                txt_surname.ForeColor = Color.Black;
            }
        }

        private void txt_surname_Leave(object sender, EventArgs e)
        {
            if (txt_surname.Text == "")
            {
                txt_surname.Text = "Введите фамилию";
                txt_surname.ForeColor = Color.CornflowerBlue;
            }
        }
        #endregion
        string filename;
        bool img;
        private void btn_browse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog file = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if(file.ShowDialog() == DialogResult.OK)
                {
                    filename = file.FileName;
                    pic_img.Image = Image.FromFile(filename);
                    img = true;
                }
            }
        }
    }
}
