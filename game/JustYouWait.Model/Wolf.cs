using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustYouWait.Model
{
    public class Wolf
    {
        public int x;
        public int y;
        public int topLeftRightYPos;
        public int leftTopDownXPos;
        public int downLeftRightPos;
        public int rightTopDownPos;

        public Wolf(int x, int y)
        {
            this.x = x;
            this.y = y;
            topLeftRightYPos = 20;
            leftTopDownXPos = 80;
            downLeftRightPos = 70;
            rightTopDownPos = 229;
        }
    }
}
