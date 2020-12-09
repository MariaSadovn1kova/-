using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Курсовик
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter; // добавим поле для эмиттера

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);


            this.emitter = new Emitter // создаю эмиттер и привязываю его к полю emitter
            {
                Direction = 0,
                Spreading = 10,
                SpeedMin = 10,
                SpeedMax = 10,
                ColorFrom = Color.Yellow,
                ColorTo = Color.FromArgb(0, Color.Red),
                ParticlesPerTick = 10,
                X = picDisplay.Width / 2,
                Y = 30,
            };
            emitters.Add(this.emitter); // все равно добавляю в список emitters, чтобы он рендерился и обновлялся
        }
        private void timer_Tick1(object sender, EventArgs e)
        {
            emitter.UpdateState(); // тут теперь обновляем эмиттер

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);
                emitter.Render(g); // а тут теперь рендерим через эмиттер
            }

            picDisplay.Invalidate();

        }

        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            // а тут в эмиттер передаем положение мыфки
            emitter.MousePositionX = e.X;
            emitter.MousePositionY = e.Y;
        }

        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = tbDirection.Value; // направлению эмиттера присваиваем значение ползунка 
            lblDirection.Text = $"{tbDirection.Value}°"; // добавил вывод значения
        }

        private void tdSpreading_Scroll(object sender, EventArgs e)
        {
            emitter.Spreading = tdSpreading.Value;
            lblSpreading.Text = $"{tdSpreading.Value}°"; // добавил вывод значения
        }

        private void tbCounter_Scroll(object sender, EventArgs e)
        {
            foreach (var p in emitter.impactPoints)
            {
                if (p is GravityPoint) // так как impactPoints не обязательно содержит поле Power, надо проверить на тип 
                {
                    // если гравитон то меняем силу
                    (p as GravityPoint).Power = tbCounter.Value;
                }
            }
        }

        private void picDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                emitter.impactPoints.Add(new GravityPoint
                {
                    X = emitter.MousePositionX,
                    Y = emitter.MousePositionY,
                });
            }
            if (e.Button == MouseButtons.Right)
            {
                
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                emitter.GravitationY = 0;
            }
            else
            {
                emitter.GravitationY = trackBar1.Value;
                lblSpreading.Text = $"{tdSpreading.Value}°";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                emitter.GravitationY = 0;
            }
            else
            {
                emitter.GravitationY = 1;
            }
        }
    }
}
