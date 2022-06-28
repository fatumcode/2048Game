using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048WinFormsApp
{
    public partial class WelcomeForm : Form
    {

        public static string userName = "Безымянный";
        public static  int sizeMap;

        public WelcomeForm()
        {
            InitializeComponent();
            enterNameTextBox.KeyDown += EnterNameTextBox_KeyDown;
        }

        private void EnterNameTextBox_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                startButton_Click(sender, e);
            }
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            string nameUser = enterNameTextBox.Text;
            if (nameUser == "")
            {
                MessageBox.Show("Вы не ввели имя!", "Ошибка!", MessageBoxButtons.OK);
                return;
            }
            else if (sizeMap == 0)
            {
                MessageBox.Show("Вы не выбрали размер поля игры", "Ошибка!", MessageBoxButtons.OK);
                return;
            }
            else
            {
                userName = nameUser;
                this.Close();

            }
        }

        private void button4x4_Click(object sender, EventArgs e)
        {
            sizeMap = 4;
        }

        private void button5x5_Click(object sender, EventArgs e)
        {
            sizeMap = 5;
        }

        private void button6x6_Click(object sender, EventArgs e)
        {
            sizeMap = 6;
        }

        private void button7x7_Click(object sender, EventArgs e)
        {
            sizeMap = 7;
        }

        private void button8x8_Click(object sender, EventArgs e)
        {
            sizeMap = 8;
        }

        private void button9x9_Click(object sender, EventArgs e)
        {
            sizeMap = 9;
        }
    }
}
