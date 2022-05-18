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
        private int wolfRightLocation;
        private int wolfLeftLocation; //расположение волка
        private int randomNumber; //хранение рандомного числа
        
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
            randomNumber = rnd.Next(0, 4); // Запускаю генератор

            speedY = 4;

            switch (randomNumber)
            {

                case 0: // влево-вверх

                    egg.Left = 89;

                    egg.Top = 55;

                    speedX = 9;
                    break;

                case 1: // влево-вниз

                    egg.Left = 89;
                    egg.Top = 144;

                    speedX = 9;
                    break;

                case 2: // вправо-вверх

                    egg.Left = 457;
                    egg.Top = 15;

                    speedX = -9;
                    break;

                case 3: //вправо-вниз

                    egg.Left = 457;
                    egg.Top = 70;

                    speedX = -9;
                    break;
            }
        }

        void AddingCounter()
        {
            int count = Convert.ToInt32(counter.Text) + 1; // прибавила счётчик

            counter.Text = Convert.ToString(count);

            Init();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {

        }

        private void EggMoving(object sender, EventArgs e)
        {
            // Перемещение ядра

            egg.Left += speedX;

            egg.Top += speedY;

            // Если ядро на центральной полосе, то оно должно падать вниз

            if (egg.Left > 160 &egg.Left < 280)
            {

                if (randomNumber == (wolfRightLocation - 1) || randomNumber==(wolfLeftLocation-1))
                {
                    AddingCounter(); // проверка нахождения волка , ядра
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

            if (egg.Top > 400)
            {

                if (Convert.ToInt32(counter.Text) > 0) // работа со счётчиком

                    counter.Text = Convert.ToString(Convert.ToInt32(counter.Text) - 1);

                Init();
            }
        }

        private void wolfMoving(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

                case Keys.A:  // влево--вверх

                    wolfLeft.Top = 20; wolfLeft.Left = 80;

                    wolfLeftLocation = 1; break;

                case Keys.Z:  // влево-вниз

                    wolfLeft.Top = 70; wolfLeft.Left = 80;

                    wolfLeftLocation = 2; break;

                case Keys.M:   // вправо-вниз

                    wolfRight.Top = 70; wolfRight.Left = 229;

                    wolfRightLocation = 4; break;

                case Keys.K:   //вправо-вверх

                    wolfRight.Top = 20; wolfRight.Left = 229;

                    wolfRightLocation = 3; break;
            }
        }
    }
}