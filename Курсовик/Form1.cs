using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace Курсовик
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter;
        bool Launch = true;
        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
            radioButton2.Checked = true;
        }
        private void timer_Tick1(object sender, EventArgs e)
        {
            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);
                emitter.Render(g);
            }
            picDisplay.Invalidate();
            foreach (var p in emitter.particles)
            {
                if (p.X > picDisplay.Width || p.Y > picDisplay.Height || p.X < 0 || p.Y < 0)
                {
                    p.Life = 0;
                }
            }
            if (Launch == true)
            {
                emitter.UpdateState();
            }
            else
            {

            }

        }

        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            emitter.MousePositionX = e.X;
            emitter.MousePositionY = e.Y;
        }

        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = tbDirection.Value; 
            lblDirection.Text = $"{tbDirection.Value}°"; 
        }

        private void tdSpreading_Scroll(object sender, EventArgs e)
        {
            emitter.Spreading = tdSpreading.Value;
            lblSpreading.Text = $"{tdSpreading.Value}°"; 
        }

        private void tbCounter_Scroll(object sender, EventArgs e)
        {
            foreach (var p in emitter.impactPoints)
            {
                if (p is CountPoint)  
                {
                    (p as CountPoint).Power = tbCounter.Value;
                    label6.Text = $"{tbCounter.Value}";
                }
            }
        }

        private void picDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                emitter.impactPoints.Add(new CountPoint
                {
                    X = emitter.MousePositionX,
                    Y = emitter.MousePositionY,
                    Power = tbCounter.Value,
                });
                emitter.UpdateStateForPoints();
            }
            if (e.Button == MouseButtons.Right)
            {
                foreach (var point in emitter.impactPoints)
                {
                    if (point is CountPoint)
                    {
                        var a = point as CountPoint;
                        var x = a.X - e.X;
                        var y = a.Y - e.Y;
                        double r = Math.Sqrt(x * x + y * y);
                        if (r <= a.Power / 2)
                        {
                            emitter.impactPoints.Remove(point as CountPoint);
                            break;
                        }
                    }
                }
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
                label5.Text = $"{trackBar1.Value}";
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

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            emitter.SpeedMax = trackBar2.Value;
            label8.Text = $"{trackBar2.Value}";
        }

        private void trackBar4_Scroll_1(object sender, EventArgs e)
        {
            emitter.RadiusMax = trackBar4.Value;
            label11.Text = $"{trackBar4.Value}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Launch = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Launch = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                this.emitter = new Emitter
                {
                    Direction = 180,
                    Spreading = tdSpreading.Value,
                    GravitationY = trackBar1.Value,
                    SpeedMin = 10,
                    SpeedMax = trackBar2.Value,
                    ParticlesPerTick = trackBar5.Value,
                    RadiusMax = trackBar4.Value,
                    ColorFrom = Color.Blue,
                    ColorTo = Color.FromArgb(0, Color.Green),
                    X = picDisplay.Width - 30,
                    Y = 30,
                };
                emitters.Add(this.emitter);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            this.emitter = new Emitter
            {
                Direction = 0,
                Spreading = tdSpreading.Value,
                GravitationY = trackBar1.Value,
                SpeedMin = 10,
                SpeedMax = trackBar2.Value,
                ParticlesPerTick = trackBar5.Value,
                RadiusMax = trackBar4.Value,
                ColorFrom = Color.Yellow,
                ColorTo = Color.FromArgb(0, Color.Red),
                X = picDisplay.Width / 2,
                Y = 30,
            };
            emitters.Add(this.emitter);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            this.emitter = new Emitter
            {
                Direction = 0,
                Spreading = tdSpreading.Value,
                GravitationY = trackBar1.Value,
                SpeedMin = 10,
                SpeedMax = trackBar2.Value,
                ParticlesPerTick = trackBar5.Value,
                RadiusMax = trackBar4.Value,
                ColorFrom = Color.Violet,
                ColorTo = Color.FromArgb(0, Color.Pink),
                X = 30,
                Y = 30,
            };
            emitters.Add(this.emitter);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                emitter.impactPoints.Add(new AntiGravityPoint
                {
                    X = picDisplay.Width / 2,
                    Y = picDisplay.Height / 2
                });
            }
            else
            {
                emitter.impactPoints = emitter.impactPoints
                .Where(x => !(x is AntiGravityPoint))
                .ToList();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            emitter.UpdateState();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                emitter.impactPoints.Add(new GravityPoint
                {
                    X = picDisplay.Width / 2 + 100,
                    Y = picDisplay.Height / 2,
                });
                emitter.impactPoints.Add(new GravityPoint
                {
                    X = picDisplay.Width / 2 - 100,
                    Y = picDisplay.Height / 2,
                });
            }
            else
            {
                emitter.impactPoints = emitter.impactPoints
                .Where(x => !(x is GravityPoint))
                .ToList();
            }
        }
        private void trackBar5_Scroll_1(object sender, EventArgs e)
        {
            emitter.ParticlesPerTick = trackBar5.Value;
            label13.Text = $"{trackBar5.Value}";
        }
    }
}
