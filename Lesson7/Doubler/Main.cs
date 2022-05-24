/*
 * Архангельская Полина
 * 
 * 1.
а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.
Игрок должен получить это число за минимальное количество ходов.
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

namespace Doubler
{
    public partial class Main : Form
    {
        private Random random = new Random();
        private int computerNumber;
        private int userNumber;
        private int CommandCount = 0;               //переменная для количества введенных команд

        public Main()
        {
            MessageBox.Show("Добро пожаловать в игру! Для начала игры нажмите ОК", "Удвоитель",
                  MessageBoxButtons.OK);
           
                InitializeComponent();

                UpdateGameState(userNumber, random.Next(20));
            this.computerNumber = computerNumber;
            MessageBox.Show("Получите число: " + computerNumber);



        }

        private void UpdateGameState(int userNumber)
        {
            labelUserNubmer.Text = $"Текущее число: {userNumber}";
            label1.Text = $"Количество введенных команд: {CommandCount}";
            CommandCount++;
        }

        private void UpdateGameState(int userNumber, int computerNumber)
        {
            
            UpdateGameState(userNumber);
            this.computerNumber = computerNumber;
            labelComputerNumber.Text = $"Получите число: {computerNumber}";
           
        }



        private void buttonReset_Click(object sender, EventArgs e)
        {
            CommandCount = 0;
            userNumber = 0;
            UpdateGameState(userNumber, random.Next(20));
           
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            userNumber = userNumber * 2;
            //UpdateGameState(userNumber);

            UpdateGameState(userNumber *= 2);
            CheckWin();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            //userNumber = userNumber + 1;
            //UpdateGameState(userNumber);
            UpdateGameState(++userNumber);
            CheckWin();
        }

        private void CheckWin()
        {
            if (userNumber == computerNumber)
            {
                MessageBox.Show("Вы успешно завершили игру!", "Удвоитель",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBox.Show("Желаете сыграть еще раз?", "Удвоитель", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    userNumber = 0;
                    CommandCount = 0;
                    UpdateGameState(userNumber, random.Next(20));
                }
                else
                {
                    Close();
                }
            }
        }

    }
}
