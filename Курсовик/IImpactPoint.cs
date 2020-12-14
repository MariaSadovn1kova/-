using System;
using System.Drawing;

namespace Курсовик
{
   public abstract class IImpactPoint
   {
        public float X; // ну точка же, вот и две координаты
        public float Y;
        public int count = 0; //Количество частиц в точке
        public int countMin = 0;
        public int countMax = 0;
        public int Power = 50;

        public abstract void ImpactParticle(Particle particle);

        public virtual void Render(Graphics g)
        {
            g.FillEllipse(
                    new SolidBrush(Color.Red),
                    X - 5,
                    Y - 5,
                    10,
                    10
                );
        }
    }
    public class CountPoint : IImpactPoint
    {
        public int Power = 50; 
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            float r = (float)Math.Sqrt(gX * gX + gY * gY);
            if (r + particle.Radius < Power/2)
            {
                particle.Life = 1;
                count++;
                if (count == 1000)
                {
                    count = 0;
                }
            }
            if ((r + particle.Radius < Power / 2) && (particle.Radius < 7))
            {
                countMin++;
            }
            if ((r + particle.Radius < Power / 2) && (particle.Radius > 7))
            {
                countMax++;
            }
        }

        public override void Render(Graphics g)
        {
            int k = 100;
            if (k < 254)
            {
                k++;
            }
            SolidBrush myBrush = new SolidBrush(Color.FromArgb(k, Color.Red));
            g.FillEllipse(
            myBrush,
            X - Power / 2,
            Y - Power / 2,
            Power,
            Power
            );
            g.DrawString(
            Convert.ToString(count),
            new Font("Verdana", 10),
            new SolidBrush(Color.White),
            X - 13,
            Y - 10
            );
            g.DrawString(
            Convert.ToString("Количество\nбольших\nчастиц: " + countMax),
            new Font("Verdana", 10),
            new SolidBrush(Color.White),
            X - -25,
            Y - -20
            );
            g.DrawString(
            Convert.ToString("Количество\nмаленьких\nчастиц: " + countMin),
            new Font("Verdana", 10),
            new SolidBrush(Color.White),
            X - -25,
            Y - 30
            );

        }
      


    }
    public class AntiGravityPoint : IImpactPoint
    {
        public int Power = 100; // сила отторжения

        // а сюда по сути скопировали с минимальными правками то что было в UpdateState
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            float r2 = (float)Math.Max(100, gX * gX + gY * gY);

            particle.SpeedX -= gX * Power / r2; // тут минусики вместо плюсов
            particle.SpeedY -= gY * Power / r2; // и тут

        }
    }
    public class GravityPoint : IImpactPoint
    {
        public int Power = 100; // сила отторжения

        // а сюда по сути скопировали с минимальными правками то что было в UpdateState
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            float r2 = (float)Math.Max(100, gX * gX + gY * gY);

            particle.SpeedX += gX * Power / r2; // тут минусики вместо плюсов
            particle.SpeedY += gY * Power / r2; // и тут

        }
    }
}
