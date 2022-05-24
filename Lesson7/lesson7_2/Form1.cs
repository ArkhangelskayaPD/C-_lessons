/*
 * Архангельская Полина
 * 
 * 2. Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток. Компьютер говорит, больше или меньше загаданное число введенного.
a) Для ввода данных от человека используется элемент TextBox;
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson7_2
{
    public partial class Form1 : Form
    {
        private int computerNumber = 0;
        private int userNumber;
        private string str;
        public Form1()
        {
            MessageBox.Show("Добро пожаловать в игру! Для начала игры нажмите ОК", "Угадай число",
                 MessageBoxButtons.OK);

            InitializeComponent();

  

            Random random = new Random();

            computerNumber = random.Next(1, 100);

         


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            str = this.textBox1.Text;
            userNumber = int.Parse(str);
            //   label1.Text = $"Пользователь ввел число: {userNumber}";

        }
   

        private void button1_Click(object sender, EventArgs e)
        {
            if (userNumber > computerNumber)
            {
                MessageBox.Show("Ваше число больше загаданного", "Угадай число",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (userNumber < computerNumber)
            {
                MessageBox.Show("Ваше число меньше загаданного", "Угадай число",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (userNumber == computerNumber)
            {
                MessageBox.Show("Вы успешно завершили игру!", "Угадай число",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();

            }
        }
    }


    }
    
