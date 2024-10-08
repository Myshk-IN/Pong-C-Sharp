using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Pong : Form
    {
    
        
        bool isTouchedDown;
        bool isTouchedUp;
        bool isStartedL;
        bool isStartedR;
        
        bool rstickTouchUp;
        bool rstickTouchDown;
        bool lstickTouchUp;
        bool lstickTouchDown;

        bool right;
        bool left;

        int speedY1 = 6;
        int speedY2 = 6;
        int speedX1 = 6;
        int speedX2 = 6;
        
        int num;

        int lScore = 0;
        int rScore = 0;
        
        public Pong()
        {
            InitializeComponent();
            timer1.Enabled = true;
            lblScoreRight.SendToBack();
            lblScoreLeft.SendToBack();
           
        }
     

        private void timer1_Tick(object sender, EventArgs e)
        {
            BallMove();
        }

        private void BallMove()
        {
            if (!isStartedR && !isStartedL && !isTouchedDown && !isTouchedUp) // before the ball touched anything
                picBall.Left += speedX1;
     
             if(isStartedL) // if touched the left stick
            {
               
                picBall.Left+= speedX1;
                switch (num)
                {
                    case 0:
                    picBall.Top -= speedY1;
                        break;
                    case 1:
                    picBall.Top += speedY1;
                        break;
                }
            }
             else if(isStartedR)  // if touched the right stick
            {
                picBall.Left += speedX1;
                switch (num)
                {
                    case 0:
                        picBall.Top -= speedY1;
                        break;
                    case 1:
                        picBall.Top += speedY1;
                        break;
                }
            }
             if(isTouchedDown) // if the lower boundery is touched
             {
                picBall.Top -= speedY2;
                if(left)
                    picBall.Left += speedX2;
                if(right)
                    picBall.Left -= speedX2;
            }
             else if(isTouchedUp)// if the upper boundery is touched
            {
                picBall.Top += speedY2;
                if (left)
                    picBall.Left += speedX2;
                if (right)
                    picBall.Left -= speedX2;
            }

            
            if (picBall.Bounds.IntersectsWith(picRightStick.Bounds)) //ball intersection with the right stick
            {
                num = new Random().Next(0,3);
                isStartedR = true;
                isTouchedUp = false;
                isTouchedDown = false;
                right = true;
                left = false;
                speedX1 *= -1;
                

            }
            else if (picBall.Bounds.IntersectsWith(picLeftStick.Bounds)) //ball intersection with the left stick
            {
                num = new Random().Next(0, 3);
                isStartedL = true;
                isTouchedUp = false;
                isTouchedDown = false;
                left = true;
                right = false;
                speedX1 *= -1;
            }

            else if(picBall.Bounds.IntersectsWith(picHiddenDown.Bounds)) //ball intersection with the lower boundary
            {
                isTouchedDown = true;
                isTouchedUp = false;
                isStartedL = false;
                isStartedR = false;
            }
            else if(picBall.Bounds.IntersectsWith(picHiddenUp.Bounds)) //ball intersection with the upper boundary
            {
                isTouchedUp = true;
                isTouchedDown = false;
                isStartedL = false;         
                isStartedR = false;         
            }

            if (picBall.Bounds.IntersectsWith(picLeft.Bounds)) // ball intersection with the left boundary
            {
                picBall.Location = new Point(335, 218);
                isTouchedDown = false;
                isTouchedUp=false;
                isStartedL=false;
                isStartedR=false;
                rScore++;
                lblScoreLeft.Text = rScore.ToString();
            }
            else if(picBall.Bounds.IntersectsWith(picRight.Bounds))// ball intersection with the right boundary
            {
                picBall.Location = new Point(335, 218);
                isTouchedDown = false;
                isTouchedUp = false;
                isStartedL = false;
                isStartedR = false;
                lScore++;
                lblScoreRight.Text = lScore.ToString();
              
            }

            if (lScore == 6)
            {
                timer1.Enabled = false;
                var result = MessageBox.Show("Left Player Won. Do You Want To Start Again?","Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    this.Close();
                else
                    Application.Exit();
            }
            else if(rScore==6)
            {
                timer1.Enabled = false;
                var result = MessageBox.Show("Right Player Won. Do You Want To Start Again?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    this.Close();
                else
                    Application.Exit();

            }

        }

        private void Pong_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (picRightStick.Bounds.IntersectsWith(picHiddenDown.Bounds))
                rstickTouchDown = true;
            else
                rstickTouchDown = false;

            if (picRightStick.Bounds.IntersectsWith(picHiddenUp.Bounds))
                rstickTouchUp = true;
            else
                rstickTouchUp = false;

            if (picLeftStick.Bounds.IntersectsWith(picHiddenDown.Bounds))
                lstickTouchDown = true;
            else
                lstickTouchDown = false;

            if (picLeftStick.Bounds.IntersectsWith(picHiddenUp.Bounds))
                lstickTouchUp = true;
            else
                lstickTouchUp = false;

            switch (e.KeyCode)  //sticks moving 
            {
                case Keys.W:
                    if (!lstickTouchUp)
                        picLeftStick.Top -= 14;
                    break;
                case Keys.S:
                    if (!lstickTouchDown)
                        picLeftStick.Top += 14;
                    break;
                case Keys.Up:
                    if (!rstickTouchUp)
                        picRightStick.Top -= 14;
                    break;
                case Keys.Down:
                    if (!rstickTouchDown)
                        picRightStick.Top += 14;
                    break;
            }
        }

        private void Pong_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        private void Pong_Load(object sender, EventArgs e)
        {
        }
        private void Pong_KeyDown(object sender, KeyEventArgs e)
        {
        }

       
    }
}
