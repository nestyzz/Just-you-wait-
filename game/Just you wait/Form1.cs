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
        Wolf leftWolf;
        Wolf rightWolf;
        Egg eg;

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
            leftWolf = new Wolf(150, 102);
            rightWolf = new Wolf(284, 102);
            eg = new Egg(-100, -100);

            randomNumber = rnd.Next(0, 4); // Запускаю генератор
            speedY = eg.ySpeed;

            switch (randomNumber)
            {

                case 0: // влево-вверх

                    egg.Left = eg.leftTopDownXPos;

                    egg.Top = eg.leftTopYPos;

                    speedX = eg.xLeftSpeed;
                    break;

                case 1: // влево-вниз

                    egg.Left = eg.leftTopDownXPos;
                    egg.Top = eg.leftDownYPos;

                    speedX = eg.xLeftSpeed;
                    break;

                case 2: // вправо-вверх

                    egg.Left = eg.rightTopDownXPos;
                    egg.Top = eg.rightTopYPos;

                    speedX = eg.xRightSpeed;
                    break;

                case 3: //вправо-вниз

                    egg.Left = eg.rightTopDownXPos;
                    egg.Top = eg.rightDownYPos;

                    speedX = eg.xRightSpeed;
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

            if (egg.Left > eg.leftBorder & egg.Left < eg.rightBorder)
            {

                if (randomNumber == (wolfRightLocation - 1) || randomNumber==(wolfLeftLocation-1))
                {
                    AddingCounter(); // проверка нахождения волка , ядра
                }
                else
                {
                    if (speedX > 0)
                    {
                        speedX = eg.ySpeed-2;
                    }

                    else
                    {
                        speedX = eg.ySpeed - 6;
                    }

                    speedY = eg.ySpeed*2;
                }
            }

            // Если упало ядро

            if (egg.Top > eg.yBorder)
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

                    wolfLeft.Top = leftWolf.topLeftRightYPos; wolfLeft.Left = leftWolf.leftTopDownXPos;
                    wolfLeftLocation = 1; break;

                case Keys.Z:  // влево-вниз

                    wolfLeft.Top = leftWolf.downLeftRightPos; wolfLeft.Left = leftWolf.leftTopDownXPos;
                    wolfLeftLocation = 2; break;

                case Keys.M:   // вправо-вниз

                    wolfRight.Top = rightWolf.downLeftRightPos; wolfRight.Left = rightWolf.rightTopDownPos;
                    wolfRightLocation = 4; break;

                case Keys.K:   //вправо-вверх

                    wolfRight.Top = rightWolf.topLeftRightYPos; wolfRight.Left = rightWolf.rightTopDownPos;
                    wolfRightLocation = 3; break;
            }
        }
    }
}