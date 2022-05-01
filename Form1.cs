using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JustYouWait.Model;

namespace Just_you_wait
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();
        private int speedX;
        private int speedY;
        private int miKey; //расположение волка
        private int rand; //хранение рандомного числа

        public Form1()
        {
            InitializeComponent();
            Init();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void Init()
        {
            rand = rnd.Next(0, 4); // Запускаю генератор

            speedY = 4;

            switch (rand)
            {

                case 0: // влево-вверх

                    pictureBox1.Left = 89; 

                    pictureBox1.Top = 55;

                    speedX = 9;
                    break;

                case 1: // влево-вниз

                    pictureBox1.Left = 89;
                    pictureBox1.Top = 144;

                    speedX = 9;
                    break;

                case 2: // вправо-вверх

                    pictureBox1.Left = 457;
                    pictureBox1.Top = 15;

                    speedX = -9;
                    break;

                case 3: //вправо-вниз

                    pictureBox1.Left = 457;
                    pictureBox1.Top = 70;

                    speedX = -9;
                    break;
            }
        }

        void miCatch()
        {
            int sum = Convert.ToInt32(label1.Text) + 1; // прибавила счётчик

            label1.Text = Convert.ToString(sum);

            Init();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Перемещение ядра

            pictureBox1.Left = pictureBox1.Left + speedX;

            pictureBox1.Top = pictureBox1.Top + speedY;

            // Если ядро на центральной полосе, то оно должно падать вниз

            if (pictureBox1.Left > 152 && pictureBox1.Left < 300)
            {

                if (rand == (miKey - 1))
                {
                    miCatch(); // проверка нахождения волка и ядра
                } 
                else
                {
                    if (speedX > 0)
                    {
                        speedX = 2;
                    }

                    else
                    {
                        speedX = -2;
                    }

                    speedY = 8;
                }
            }

            // Если упало ядро

            if (pictureBox1.Top > 400)
            {

                if (Convert.ToInt32(label1.Text) > 0) // работа со счётчиком

                    label1.Text = Convert.ToString(Convert.ToInt32(label1.Text) - 1);

                Init();
            }
        }

        private void Form1KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

                case Keys.A:  // влево-вверх

                    pictureBox2.Top = 5; pictureBox2.Left = 45;

                    miKey = 1; break;

                case Keys.Z:  // влево-вниз

                    pictureBox2.Top = 50; pictureBox2.Left = 45;

                    miKey = 2; break;

                case Keys.M:   // вправо-вниз

                    pictureBox2.Top = 50; pictureBox2.Left = 229;

                    miKey = 4; break;

                case Keys.K:   //вправо-вверх

                    pictureBox2.Top = 5; pictureBox2.Left = 229;

                    miKey = 3; break;
            }
        }
    }
}
