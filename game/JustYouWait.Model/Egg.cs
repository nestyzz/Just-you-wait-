namespace JustYouWait.Model
{
    public class Egg
    {
        public double x;
        public double y;
        public int ySpeed;
        public int xLeftSpeed;
        public int xRightSpeed;
        public int leftTopDownXPos;
        public int leftTopYPos;
        public int leftDownYPos;
        public int rightTopDownXPos;
        public int rightTopYPos;
        public int rightDownYPos;
        public int leftBorder;
        public int rightBorder;
        public int yBorder;
        public Egg(double x, double y)
        {
            this.x = x;
            this.y = y;
            leftTopDownXPos = 89;
            leftTopYPos = 55;
            leftDownYPos = 144;
            rightTopDownXPos= 457;
            rightTopYPos = 15;
            rightDownYPos = 70;
            xLeftSpeed = 9;
            xRightSpeed = -9;
            ySpeed = 4;
            leftBorder = 110;
            rightBorder = 310;
            yBorder = 400;
        }
    }
}