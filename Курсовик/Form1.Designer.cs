namespace Курсовик
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
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbDirection = new System.Windows.Forms.TrackBar();
            this.lblDirection = new System.Windows.Forms.Label();
            this.tdSpreading = new System.Windows.Forms.TrackBar();
            this.lblSpreading = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCounter = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdSpreading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(441, 15);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(335, 465);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseDown);
            this.picDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer_Tick1);
            // 
            // tbDirection
            // 
            this.tbDirection.Location = new System.Drawing.Point(12, 252);
            this.tbDirection.Maximum = 359;
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(194, 45);
            this.tbDirection.TabIndex = 1;
            this.tbDirection.Scroll += new System.EventHandler(this.tbDirection_Scroll);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(202, 252);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(17, 13);
            this.lblDirection.TabIndex = 2;
            this.lblDirection.Text = "0°";
            // 
            // tdSpreading
            // 
            this.tdSpreading.Location = new System.Drawing.Point(12, 313);
            this.tdSpreading.Maximum = 359;
            this.tdSpreading.Name = "tdSpreading";
            this.tdSpreading.Size = new System.Drawing.Size(194, 45);
            this.tdSpreading.TabIndex = 3;
            this.tdSpreading.Scroll += new System.EventHandler(this.tdSpreading_Scroll);
            // 
            // lblSpreading
            // 
            this.lblSpreading.AutoSize = true;
            this.lblSpreading.Location = new System.Drawing.Point(202, 313);
            this.lblSpreading.Name = "lblSpreading";
            this.lblSpreading.Size = new System.Drawing.Size(17, 13);
            this.lblSpreading.TabIndex = 4;
            this.lblSpreading.Text = "0°";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(50, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Направление:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(69, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Разброс:";
            // 
            // tbCounter
            // 
            this.tbCounter.Location = new System.Drawing.Point(12, 192);
            this.tbCounter.Maximum = 100;
            this.tbCounter.Minimum = 50;
            this.tbCounter.Name = "tbCounter";
            this.tbCounter.Size = new System.Drawing.Size(194, 45);
            this.tbCounter.TabIndex = 7;
            this.tbCounter.Value = 50;
            this.tbCounter.Scroll += new System.EventHandler(this.tbCounter_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(54, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Радиус точек:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 78);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(194, 45);
            this.trackBar1.TabIndex = 12;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(33, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Сила гравитации:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(21, 106);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(185, 25);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Нулевая гравитация";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(203)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(788, 492);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCounter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSpreading);
            this.Controls.Add(this.picDisplay);
            this.Controls.Add(this.tdSpreading);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.tbDirection);
            this.Name = "Form1";
            this.Text = "Поймай все точки!";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdSpreading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tbDirection;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.TrackBar tdSpreading;
        private System.Windows.Forms.Label lblSpreading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbCounter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

