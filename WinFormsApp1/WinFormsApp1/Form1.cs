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

            // ������������� ��������� ��� TextBox
            textBox1.Text = "������� ���-���";
            textBox1.ForeColor = SystemColors.GrayText;


        }

        //����� �� textBox
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // ����� � ������� BackSpace
            {
                e.Handled = true;
            }
        }

        //���������� �����
        private void AddDigitToTextBox(int digit)
        {
            textBox1.Text += digit.ToString();
        }

        private void n_1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "������� ���-���")
            {
                textBox1.Clear();
                textBox1.ForeColor = SystemColors.WindowText;
                AddDigitToTextBox(1);
            }
            else
            {
                // �������� �� ������������ ����� �����
                if (textBox1.Text.Length < 5)
                {
                    AddDigitToTextBox(1);
                }
                else
                {
                    // ��������� ����� �����, ������ �������� ��������� �� ������ ��� ��������� ������ ��������
                    MessageBox.Show("�� �������� ������ �����.");
                }
            }
        }


        private void n_2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "������� ���-���")
            {
                textBox1.Clear();
                textBox1.ForeColor = SystemColors.WindowText;
                AddDigitToTextBox(2);
            }
            else
            {
                // �������� �� ������������ ����� �����
                if (textBox1.Text.Length < 5)
                {
                    AddDigitToTextBox(2);
                }
                else
                {
                    // ��������� ����� �����, ������ �������� ��������� �� ������ ��� ��������� ������ ��������
                    MessageBox.Show("�� �������� ������ �����.");
                }
            }

        }

        private void n_3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "������� ���-���")
            {
                textBox1.Clear();
                textBox1.ForeColor = SystemColors.WindowText;
                AddDigitToTextBox(3);
            }
            else
            {
                // �������� �� ������������ ����� �����
                if (textBox1.Text.Length < 5)
                {
                    AddDigitToTextBox(3);
                }
                else
                {
                    // ��������� ����� �����, ������ �������� ��������� �� ������ ��� ��������� ������ ��������
                    MessageBox.Show("�� �������� ������ �����.");
                }
            }
        }

        private void n_4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "������� ���-���")
            {
                textBox1.Clear();
                textBox1.ForeColor = SystemColors.WindowText;
                AddDigitToTextBox(4);
            }
            else
            {
                // �������� �� ������������ ����� �����
                if (textBox1.Text.Length < 5)
                {
                    AddDigitToTextBox(4);
                }
                else
                {
                    // ��������� ����� �����, ������ �������� ��������� �� ������ ��� ��������� ������ ��������
                    MessageBox.Show("�� �������� ������ �����.");
                };
            }
        }

        private void n_5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "������� ���-���")
            {
                textBox1.Clear();
                textBox1.ForeColor = SystemColors.WindowText;
                AddDigitToTextBox(5);
            }
            else
            {
                // �������� �� ������������ ����� �����
                if (textBox1.Text.Length < 5)
                {
                    AddDigitToTextBox(5);
                }
                else
                {
                    // ��������� ����� �����, ������ �������� ��������� �� ������ ��� ��������� ������ ��������
                    MessageBox.Show("�� �������� ������ �����.");
                }
            }
        }

        private void n_6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "������� ���-���")
            {
                textBox1.Clear();
                textBox1.ForeColor = SystemColors.WindowText;
                AddDigitToTextBox(6);
            }
            else
            {
                // �������� �� ������������ ����� �����
                if (textBox1.Text.Length < 5)
                {
                    AddDigitToTextBox(6);
                }
                else
                {
                    // ��������� ����� �����, ������ �������� ��������� �� ������ ��� ��������� ������ ��������
                    MessageBox.Show("�� �������� ������ �����.");
                }
            }
        }

        private void n_7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "������� ���-���")
            {
                textBox1.Clear();
                textBox1.ForeColor = SystemColors.WindowText;
                AddDigitToTextBox(7);
            }
            else
            {
                // �������� �� ������������ ����� �����
                if (textBox1.Text.Length < 5)
                {
                    AddDigitToTextBox(7);
                }
                else
                {
                    // ��������� ����� �����, ������ �������� ��������� �� ������ ��� ��������� ������ ��������
                    MessageBox.Show("�� �������� ������ �����.");
                }
            }
        }

        private void n_8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "������� ���-���")
            {
                textBox1.Clear();
                textBox1.ForeColor = SystemColors.WindowText;
                AddDigitToTextBox(8);
            }
            else
            {
                // �������� �� ������������ ����� �����
                if (textBox1.Text.Length < 5)
                {
                    AddDigitToTextBox(8);
                }
                else
                {
                    // ��������� ����� �����, ������ �������� ��������� �� ������ ��� ��������� ������ ��������
                    MessageBox.Show("�� �������� ������ �����.");
                }
            }
        }

        private void n_9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "������� ���-���")
            {
                textBox1.Clear();
                textBox1.ForeColor = SystemColors.WindowText;
                AddDigitToTextBox(9);
            }
            else
            {
                // �������� �� ������������ ����� �����
                if (textBox1.Text.Length < 5)
                {
                    AddDigitToTextBox(9);
                }
                else
                {
                    // ��������� ����� �����, ������ �������� ��������� �� ������ ��� ��������� ������ ��������
                    MessageBox.Show("�� �������� ������ �����.");
                }
            }
        }

        private void n_0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "������� ���-���")
            {
                textBox1.Clear();
                textBox1.ForeColor = SystemColors.WindowText;
                AddDigitToTextBox(0);
            }
            else
            {
                // �������� �� ������������ ����� �����
                if (textBox1.Text.Length < 5)
                {
                    AddDigitToTextBox(0);
                }
                else
                {
                    // ��������� ����� �����, ������ �������� ��������� �� ������ ��� ��������� ������ ��������
                    MessageBox.Show("�� �������� ������ �����.");
                }
            }
        }

        private void bEnter_Click(object sender, EventArgs e)
        {
            String code = textBox1.Text;

            DB dB = new DB();

            // �������� ������� ��� ���������� SQL ������
            MySqlCommand command = new MySqlCommand("SELECT cod FROM `codes` WHERE cod = @cd OR control = @cl;", dB.getConnection());
            // ���������� ���������� � �������
            command.Parameters.Add("@cd", MySqlDbType.VarChar).Value = code;
            command.Parameters.Add("@cl", MySqlDbType.VarChar).Value = code;

            try
            {
                // �������� ����������� � ���� ������
                dB.openConnection();

                // ���������� ������� �������
                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    // �������� ������ ������ �������
                    MessageBox.Show("������ ������������!");
                    //textBox1.Clear();
                }
                else
                {
                    // ��� �����, ��������������� ������ �������
                    MessageBox.Show("���-��� ��� �������� ������� ��������! ���������� ��� ���!");

                }
            }
            catch (Exception ex)
            {
                // ��������� ����������, ���� ��������� ������
                MessageBox.Show("������ ���������� ������: " + ex.Message);
            }
            finally
            {
                // ����� ������� ���������� � ����� ������ ����� �������������
                dB.closeConnection();
            }

            textBox1.Clear();
            // ������������� ��������� ��� TextBox
            textBox1.Text = "������� ���-���";
            textBox1.ForeColor = SystemColors.GrayText;

        }

        private void ohrana_Click(object sender, EventArgs e)
        {
            // ������� � ���������� ����� ����� � ��������
            var ohranaForm = new Form2();
            ohranaForm.ShowDialog();
            Close();
        }

        private void codDostup_Click(object sender, EventArgs e)
        {
            // ������� ��������� �����
            var codDostupForm = new Form3();
            // �������� ������� �����
            this.Hide();
            // ���������� �����
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
                // ������������� ��������� ��� TextBox
                textBox1.Text = "������� ���-���";
                textBox1.ForeColor = SystemColors.GrayText;
            }
        }

        private void codControl_Click(object sender, EventArgs e)
        {
            // ������� ��������� �����
            var codControlForm = new Form4();
            // �������� ������� �����
            this.Hide();
            // ���������� �����
            codControlForm.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // ������������ ����� �� ������� ����
                Application.Exit(); // ��������� ���������� ����� ����������
            }
        }
    }
}
