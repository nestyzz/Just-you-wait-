
using System;
using System.Windows.Forms;

namespace Just_you_wait
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.egg = new System.Windows.Forms.PictureBox();
            this.wolfRight = new System.Windows.Forms.PictureBox();
            this.counter = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.upperLeftStick = new System.Windows.Forms.PictureBox();
            this.lowerLeftStick = new System.Windows.Forms.PictureBox();
            this.rightUpperStick = new System.Windows.Forms.PictureBox();
            this.rightLowerStick = new System.Windows.Forms.PictureBox();
            this.wolfLeft = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.egg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wolfRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperLeftStick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerLeftStick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightUpperStick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightLowerStick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wolfLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // egg
            // 
            this.egg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.egg.BackColor = System.Drawing.Color.Transparent;
            this.egg.Image = ((System.Drawing.Image)(resources.GetObject("egg.Image")));
            this.egg.InitialImage = null;
            this.egg.Location = new System.Drawing.Point(-95, -103);
            this.egg.Name = "egg";
            this.egg.Size = new System.Drawing.Size(12, 12);
            this.egg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.egg.TabIndex = 0;
            this.egg.TabStop = false;
            // 
            // wolfRight
            // 
            this.wolfRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wolfRight.BackColor = System.Drawing.Color.Transparent;
            this.wolfRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.wolfRight.Image = ((System.Drawing.Image)(resources.GetObject("wolfRight.Image")));
            this.wolfRight.InitialImage = null;
            this.wolfRight.Location = new System.Drawing.Point(284, 102);
            this.wolfRight.Name = "wolfRight";
            this.wolfRight.Size = new System.Drawing.Size(143, 134);
            this.wolfRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wolfRight.TabIndex = 1;
            this.wolfRight.TabStop = false;
            // 
            // counter
            // 
            this.counter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.counter.AutoSize = true;
            this.counter.BackColor = System.Drawing.Color.Transparent;
            this.counter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.counter.ForeColor = System.Drawing.Color.DarkRed;
            this.counter.Location = new System.Drawing.Point(278, 18);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(29, 31);
            this.counter.TabIndex = 2;
            this.counter.Text = "0";
            this.counter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.EggMoving);
            // 
            // upperLeftStick
            // 
            this.upperLeftStick.BackColor = System.Drawing.Color.Transparent;
            this.upperLeftStick.Image = ((System.Drawing.Image)(resources.GetObject("upperLeftStick.Image")));
            this.upperLeftStick.Location = new System.Drawing.Point(89, 75);
            this.upperLeftStick.Name = "upperLeftStick";
            this.upperLeftStick.Size = new System.Drawing.Size(37, 24);
            this.upperLeftStick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.upperLeftStick.TabIndex = 7;
            this.upperLeftStick.TabStop = false;
            // 
            // lowerLeftStick
            // 
            this.lowerLeftStick.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lowerLeftStick.BackColor = System.Drawing.Color.Transparent;
            this.lowerLeftStick.Image = ((System.Drawing.Image)(resources.GetObject("lowerLeftStick.Image")));
            this.lowerLeftStick.Location = new System.Drawing.Point(89, 144);
            this.lowerLeftStick.Name = "lowerLeftStick";
            this.lowerLeftStick.Size = new System.Drawing.Size(37, 24);
            this.lowerLeftStick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lowerLeftStick.TabIndex = 8;
            this.lowerLeftStick.TabStop = false;
            // 
            // rightUpperStick
            // 
            this.rightUpperStick.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rightUpperStick.BackColor = System.Drawing.Color.Transparent;
            this.rightUpperStick.Image = ((System.Drawing.Image)(resources.GetObject("rightUpperStick.Image")));
            this.rightUpperStick.Location = new System.Drawing.Point(468, 74);
            this.rightUpperStick.Name = "rightUpperStick";
            this.rightUpperStick.Size = new System.Drawing.Size(37, 24);
            this.rightUpperStick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightUpperStick.TabIndex = 10;
            this.rightUpperStick.TabStop = false;
            // 
            // rightLowerStick
            // 
            this.rightLowerStick.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rightLowerStick.BackColor = System.Drawing.Color.Transparent;
            this.rightLowerStick.Image = ((System.Drawing.Image)(resources.GetObject("rightLowerStick.Image")));
            this.rightLowerStick.Location = new System.Drawing.Point(468, 144);
            this.rightLowerStick.Name = "rightLowerStick";
            this.rightLowerStick.Size = new System.Drawing.Size(37, 24);
            this.rightLowerStick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightLowerStick.TabIndex = 11;
            this.rightLowerStick.TabStop = false;
            // 
            // wolfLeft
            // 
            this.wolfLeft.BackColor = System.Drawing.Color.Transparent;
            this.wolfLeft.Image = ((System.Drawing.Image)(resources.GetObject("wolfLeft.Image")));
            this.wolfLeft.InitialImage = null;
            this.wolfLeft.Location = new System.Drawing.Point(150, 102);
            this.wolfLeft.Name = "wolfLeft";
            this.wolfLeft.Size = new System.Drawing.Size(143, 134);
            this.wolfLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wolfLeft.TabIndex = 12;
            this.wolfLeft.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(595, 285);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.egg);
            this.Controls.Add(this.wolfLeft);
            this.Controls.Add(this.wolfRight);
            this.Controls.Add(this.rightUpperStick);
            this.Controls.Add(this.rightLowerStick);
            this.Controls.Add(this.upperLeftStick);
            this.Controls.Add(this.lowerLeftStick);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.wolfMoving);
            ((System.ComponentModel.ISupportInitialize)(this.egg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wolfRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperLeftStick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerLeftStick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightUpperStick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightLowerStick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wolfLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox egg;
        private System.Windows.Forms.PictureBox wolfRight;
        private System.Windows.Forms.Label counter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox upperLeftStick;
        private System.Windows.Forms.PictureBox lowerLeftStick;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox rightUpperStick;
        private System.Windows.Forms.PictureBox rightLowerStick;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private PictureBox wolfLeft;
    }
}

