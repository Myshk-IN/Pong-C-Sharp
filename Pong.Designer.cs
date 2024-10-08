namespace PingPong
{
    partial class Pong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picLeftStick = new System.Windows.Forms.PictureBox();
            this.picRightStick = new System.Windows.Forms.PictureBox();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.picHiddenDown = new System.Windows.Forms.PictureBox();
            this.picHiddenUp = new System.Windows.Forms.PictureBox();
            this.picLeft = new System.Windows.Forms.PictureBox();
            this.picRight = new System.Windows.Forms.PictureBox();
            this.lblScoreRight = new System.Windows.Forms.Label();
            this.lblScoreLeft = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftStick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightStick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHiddenDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHiddenUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRight)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picLeftStick
            // 
            this.picLeftStick.BackColor = System.Drawing.Color.AliceBlue;
            this.picLeftStick.Location = new System.Drawing.Point(12, 139);
            this.picLeftStick.Name = "picLeftStick";
            this.picLeftStick.Size = new System.Drawing.Size(10, 120);
            this.picLeftStick.TabIndex = 0;
            this.picLeftStick.TabStop = false;
            // 
            // picRightStick
            // 
            this.picRightStick.BackColor = System.Drawing.Color.AliceBlue;
            this.picRightStick.Location = new System.Drawing.Point(698, 139);
            this.picRightStick.Name = "picRightStick";
            this.picRightStick.Size = new System.Drawing.Size(10, 120);
            this.picRightStick.TabIndex = 1;
            this.picRightStick.TabStop = false;
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.SystemColors.Control;
            this.picBall.Location = new System.Drawing.Point(335, 218);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(19, 17);
            this.picBall.TabIndex = 2;
            this.picBall.TabStop = false;
            // 
            // picHiddenDown
            // 
            this.picHiddenDown.Location = new System.Drawing.Point(-1, 447);
            this.picHiddenDown.Name = "picHiddenDown";
            this.picHiddenDown.Size = new System.Drawing.Size(722, 10);
            this.picHiddenDown.TabIndex = 3;
            this.picHiddenDown.TabStop = false;
            // 
            // picHiddenUp
            // 
            this.picHiddenUp.Location = new System.Drawing.Point(-1, -7);
            this.picHiddenUp.Name = "picHiddenUp";
            this.picHiddenUp.Size = new System.Drawing.Size(722, 10);
            this.picHiddenUp.TabIndex = 4;
            this.picHiddenUp.TabStop = false;
            // 
            // picLeft
            // 
            this.picLeft.Location = new System.Drawing.Point(-1, -7);
            this.picLeft.Name = "picLeft";
            this.picLeft.Size = new System.Drawing.Size(10, 464);
            this.picLeft.TabIndex = 5;
            this.picLeft.TabStop = false;
            // 
            // picRight
            // 
            this.picRight.Location = new System.Drawing.Point(711, -7);
            this.picRight.Name = "picRight";
            this.picRight.Size = new System.Drawing.Size(10, 464);
            this.picRight.TabIndex = 6;
            this.picRight.TabStop = false;
            // 
            // lblScoreRight
            // 
            this.lblScoreRight.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreRight.ForeColor = System.Drawing.SystemColors.Control;
            this.lblScoreRight.Location = new System.Drawing.Point(206, 31);
            this.lblScoreRight.Name = "lblScoreRight";
            this.lblScoreRight.Size = new System.Drawing.Size(68, 91);
            this.lblScoreRight.TabIndex = 7;
            this.lblScoreRight.Text = "0";
            // 
            // lblScoreLeft
            // 
            this.lblScoreLeft.Font = new System.Drawing.Font("Agency FB", 48F);
            this.lblScoreLeft.ForeColor = System.Drawing.SystemColors.Control;
            this.lblScoreLeft.Location = new System.Drawing.Point(435, 31);
            this.lblScoreLeft.Name = "lblScoreLeft";
            this.lblScoreLeft.Size = new System.Drawing.Size(68, 91);
            this.lblScoreLeft.TabIndex = 8;
            this.lblScoreLeft.Text = "0";
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(720, 454);
            this.Controls.Add(this.lblScoreLeft);
            this.Controls.Add(this.lblScoreRight);
            this.Controls.Add(this.picRight);
            this.Controls.Add(this.picLeft);
            this.Controls.Add(this.picHiddenUp);
            this.Controls.Add(this.picHiddenDown);
            this.Controls.Add(this.picBall);
            this.Controls.Add(this.picRightStick);
            this.Controls.Add(this.picLeftStick);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Pong";
            this.Text = "Pong";
            this.Load += new System.EventHandler(this.Pong_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyDown_1);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pong_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.picLeftStick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightStick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHiddenDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHiddenUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picLeftStick;
        private System.Windows.Forms.PictureBox picRightStick;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.PictureBox picHiddenDown;
        private System.Windows.Forms.PictureBox picHiddenUp;
        private System.Windows.Forms.PictureBox picLeft;
        private System.Windows.Forms.PictureBox picRight;
        private System.Windows.Forms.Label lblScoreRight;
        private System.Windows.Forms.Label lblScoreLeft;
    }
}