using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            // Устанавливаем подсказку для TextBox
            textBox1.Text = "Введите пин-код";
            textBox1.ForeColor = SystemColors.GrayText;


        }

        //Фокус на textBox
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        //Добавление цифры
        private void AddDigitToTextBox(int digit)
        {
            textBox1.Text += digit.ToString();
        }

        private void n_1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите пин-код")
            {
                textBox1.Clear();
                textBox1.ForeColor = SystemColors.WindowText;
                AddDigitToTextBox(1);
            }
            else
            {
                // Проверка на максимальную длину ввода
                if (textBox1.Text.Length < 5)
                {
                    AddDigitToTextBox(1);
                }
                else
                {
                    // Достигнут лимит ввода, можете добавить сообщение об ошибке или выполнить другие действия
                    MessageBox.Show("Вы достигли лимита ввода.");
                }
            }
        }


        private void n_2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите пин-код")
            {
                textBox1.Clear();
                textBox1.ForeColor = SystemColors.WindowText;
                AddDigitToTextBox(2);
            }
            else
            {
                // Проверка на максимальную длину ввода
                if (textBox1.Text.Length < 5)
                {
                    AddDigitToTextBox(2);
                }
                else
                {
                    // Достигнут лимит ввода, можете добавить сообщение об ошибке или выполнить другие действия
                    MessageBox.Show("Вы достигли лимита ввода.");
                }
            }

        }

        private void n_3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите пин-код")
            {
                textBox1.Clear();
                textBox1.ForeColor = SystemColors.WindowText;
                AddDigitToTextBox(3);
            }
            else
            {
                // Проверка на максимальную длину ввода
                if (textBox1.Text.Length < 5)
                {
                    AddDigitToTextBox(3);
                }
                else
                {
                    // Достигнут лимит ввода, можете добавить сообщение об ошибке или выполнить другие действия
                    MessageBox.Show("Вы достигли лимита ввода.");
                }
            }
        }

        private void n_4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите пин-код")
            {
                textBox1.Clear();
                textBox1.ForeColor = SystemColors.WindowText;
                AddDigitToTextBox(4);
            }
            else
            {
                // Проверка на максимальную длину ввода
                if (textBox1.Text.Length < 5)
                {
                    AddDigitToTextBox(4);
                }
                else
                {
                    // Достигнут лимит ввода, можете добавить сообщение об ошибке или выполнить другие действия
                    MessageBox.Show("Вы достигли лимита ввода.");
                };
            }
        }

        private void n_5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите пин-код")
            {
                textBox1.Clear();
                textBox1.ForeColor = SystemColors.WindowText;
                AddDigitToTextBox(5);
            }
            else
            {
                // Проверка на максимальную длину ввода
                if (textBox1.Text.Length < 5)
                {
                    AddDigitToTextBox(5);
                }
                else
                {
                    // Достигнут лимит ввода, можете добавить сообщение об ошибке или выполнить другие действия
                    MessageBox.Show("Вы достигли лимита ввода.");
                }
            }
        }

        private void n_6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите пин-код")
            {
                textBox1.Clear();
                textBox1.ForeColor = SystemColors.WindowText;
                AddDigitToTextBox(6);
            }
            else
            {
                // Проверка на максимальную длину ввода
                if (textBox1.Text.Length < 5)
                {
                    AddDigitToTextBox(6);
                }
                else
                {
                    // Достигнут лимит ввода, можете добавить сообщение об ошибке или выполнить другие действия
                    MessageBox.Show("Вы достигли лимита ввода.");
                }
            }
        }

        private void n_7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите пин-код")
            {
                textBox1.Clear();
                textBox1.ForeColor = SystemColors.WindowText;
                AddDigitToTextBox(7);
            }
            else
            {
                // Проверка на максимальную длину ввода
                if (textBox1.Text.Length < 5)
                {
                    AddDigitToTextBox(7);
                }
                else
                {
                    // Достигнут лимит ввода, можете добавить сообщение об ошибке или выполнить другие действия
                    MessageBox.Show("Вы достигли лимита ввода.");
                }
            }
        }

        private void n_8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите пин-код")
            {
                textBox1.Clear();
                textBox1.ForeColor = SystemColors.WindowText;
                AddDigitToTextBox(8);
            }
            else
            {
                // Проверка на максимальную длину ввода
                if (textBox1.Text.Length < 5)
                {
                    AddDigitToTextBox(8);
                }
                else
                {
                    // Достигнут лимит ввода, можете добавить сообщение об ошибке или выполнить другие действия
                    MessageBox.Show("Вы достигли лимита ввода.");
                }
            }
        }

        private void n_9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите пин-код")
            {
                textBox1.Clear();
                textBox1.ForeColor = SystemColors.WindowText;
                AddDigitToTextBox(9);
            }
            else
            {
                // Проверка на максимальную длину ввода
                if (textBox1.Text.Length < 5)
                {
                    AddDigitToTextBox(9);
                }
                else
                {
                    // Достигнут лимит ввода, можете добавить сообщение об ошибке или выполнить другие действия
                    MessageBox.Show("Вы достигли лимита ввода.");
                }
            }
        }

        private void n_0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите пин-код")
            {
                textBox1.Clear();
                textBox1.ForeColor = SystemColors.WindowText;
                AddDigitToTextBox(0);
            }
            else
            {
                // Проверка на максимальную длину ввода
                if (textBox1.Text.Length < 5)
                {
                    AddDigitToTextBox(0);
                }
                else
                {
                    // Достигнут лимит ввода, можете добавить сообщение об ошибке или выполнить другие действия
                    MessageBox.Show("Вы достигли лимита ввода.");
                }
            }
        }

        private void bEnter_Click(object sender, EventArgs e)
        {
            String code = textBox1.Text;

            DB dB = new DB();

            // Создание объекта для выполнения SQL команд
            MySqlCommand command = new MySqlCommand("SELECT cod FROM `codes` WHERE cod = @cd OR control = @cl;", dB.getConnection());
            // Добавление параметров к команде
            command.Parameters.Add("@cd", MySqlDbType.VarChar).Value = code;
            command.Parameters.Add("@cl", MySqlDbType.VarChar).Value = code;

            try
            {
                // Открытие подключения к базе данных
                dB.openConnection();

                // Выполнение команды выборки
                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    // Проверка данных прошло успешно
                    MessageBox.Show("Доступ предоставлен!");
                    //textBox1.Clear();
                }
                else
                {
                    // Нет строк, соответствующих вашему запросу
                    MessageBox.Show("Пин-код или контроль доступа неверный! Попробуйте ещё раз!");

                }
            }
            catch (Exception ex)
            {
                // Обработка исключений, если произошла ошибка
                MessageBox.Show("Ошибка обновления данных: " + ex.Message);
            }
            finally
            {
                // Важно закрыть соединение с базой данных после использования
                dB.closeConnection();
            }

            textBox1.Clear();
            // Устанавливаем подсказку для TextBox
            textBox1.Text = "Введите пин-код";
            textBox1.ForeColor = SystemColors.GrayText;

        }

        private void ohrana_Click(object sender, EventArgs e)
        {
            // Создаем и отображаем новую форму с вопросом
            var ohranaForm = new Form2();
            ohranaForm.ShowDialog();
            Close();
        }

        private void codDostup_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр формы
            var codDostupForm = new Form3();
            // Скрываем главную форму
            this.Hide();
            // Показываем форму
            codDostupForm.ShowDialog();

        }

        private void b_del_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            if (textBox1.Text.Length == 0)
            {
                // Устанавливаем подсказку для TextBox
                textBox1.Text = "Введите пин-код";
                textBox1.ForeColor = SystemColors.GrayText;
            }
        }

        private void codControl_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр формы
            var codControlForm = new Form4();
            // Скрываем главную форму
            this.Hide();
            // Показываем форму
            codControlForm.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Пользователь нажал на крестик окна
                Application.Exit(); // Завершаем выполнение всего приложения
            }
        }
    }
}
