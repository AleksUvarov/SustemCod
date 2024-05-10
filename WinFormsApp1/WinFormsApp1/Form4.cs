using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            // Устанавливаем подсказку для TextBox
            textBox1.Text = "Введите старый код контроля";
            textBox1.ForeColor = SystemColors.GrayText;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Focus();
            // Скрытие кнопки при загрузке формы
            codControl.Visible = false;
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
            if ((textBox1.Text == "Введите старый код контроля") || (textBox1.Text == "Введите новый код контроля"))
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
            if ((textBox1.Text == "Введите старый код контроля") || (textBox1.Text == "Введите новый код контроля"))
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
            if ((textBox1.Text == "Введите старый код контроля") || (textBox1.Text == "Введите новый код контроля"))
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
            if ((textBox1.Text == "Введите старый код контроля") || (textBox1.Text == "Введите новый код контроля"))
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
            if ((textBox1.Text == "Введите старый код контроля") || (textBox1.Text == "Введите новый код контроля"))
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
            if ((textBox1.Text == "Введите старый код контроля") || (textBox1.Text == "Введите новый код контроля"))
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
            if ((textBox1.Text == "Введите старый код контроля") || (textBox1.Text == "Введите новый код контроля"))
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
            if ((textBox1.Text == "Введите старый код контроля") || (textBox1.Text == "Введите новый код контроля"))
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
            if ((textBox1.Text == "Введите старый код контроля") || (textBox1.Text == "Введите новый код контроля"))
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
            if ((textBox1.Text == "Введите старый код контроля") || (textBox1.Text == "Введите новый код контроля"))
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

            // DataTable - послужил для преобразования данных из БД в таблицу что можно разобрать на языке C#
            DataTable table = new DataTable();

            // MySqlDataAdapter - служит для перевода из SQL данных в данные обычные (массивы, объекты...)
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            // MySqlCommand - позволяет записать SQL команду, что будет выполнена в базе данных
            MySqlCommand command = new MySqlCommand("SELECT cod FROM `codes` WHERE control = @cl;", dB.getConnection());
            command.Parameters.Add("@cl", MySqlDbType.VarChar).Value = code;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Код доступа верный!");
                // Устанавливаем подсказку для TextBox
                textBox1.Text = "Введите новый код контроля";
                textBox1.ForeColor = SystemColors.GrayText;
                // Отображение кнопки
                codControl.Visible = true;
            }
            else
            {
                MessageBox.Show("Код доступа неверный! Попробуйте ещё раз!");
                // Устанавливаем подсказку для TextBox
                textBox1.Text = "Введите старый код контроля";
                textBox1.ForeColor = SystemColors.GrayText;
            }

            
        }

        private void codControl_Click(object sender, EventArgs e)
        {
            String code = textBox1.Text;
            DB dB = new DB();

            // Создание объекта для выполнения SQL команд
            MySqlCommand command = new MySqlCommand("UPDATE codes SET control = @cl WHERE id = 1;", dB.getConnection());
            // Добавление параметров к команде
            command.Parameters.Add("@cl", MySqlDbType.VarChar).Value = code;

            try
            {
                // Открытие подключения к базе данных
                dB.openConnection();

                // Выполнение команды обновления и получение числа затронутых строк
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    // Обновление данных прошло успешно
                    MessageBox.Show("Данные успешно обновлены.");
                    // Показываем главную форму
                    Form1 mainForm = new Form1();
                    mainForm.Show();
                    // Показываем форму 4
                    Close();
                }
                else
                {
                    // Нет строк, соответствующих вашему запросу
                    MessageBox.Show("Нет данных для обновления.");
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
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
          
        }
    }
}
