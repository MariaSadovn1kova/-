using System;
using System.Drawing;

namespace Курсовик
{
   public abstract class IImpactPoint
   {
        public float X; // ну точка же, вот и две координаты
        public float Y;
        public int count = 0; //Количество частиц в точке

        // абстрактный метод с помощью которого будем изменять состояние частиц
        // например притягивать
        public abstract void ImpactParticle(Particle particle);

        // базовый класс для отрисовки точечки
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
    public class GravityPoint : IImpactPoint
    {
        public int Power = 50; // сила притяжения

        // а сюда по сути скопировали с минимальными правками то что было в UpdateState
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            float r = (float)Math.Sqrt(gX * gX + gY * gY);
            if (r + particle.Radius < Power/2)
            {
                particle.Life = 0;
                count++;
            }
        }
        public override void Render(Graphics g)
        {
            SolidBrush myBrush = new SolidBrush(ColorTranslator.FromHtml("#FDBCB4"));
            SolidBrush myBrush1 = new SolidBrush(ColorTranslator.FromHtml("#FFA089"));
            SolidBrush myBrush2 = new SolidBrush(ColorTranslator.FromHtml("#EA7E5D"));
            SolidBrush myBrush3 = new SolidBrush(ColorTranslator.FromHtml("#FF6E4A"));
            SolidBrush myBrush4 = new SolidBrush(ColorTranslator.FromHtml("#FD7C6E"));
            SolidBrush myBrush5 = new SolidBrush(ColorTranslator.FromHtml("#FD5E53"));
            SolidBrush myBrush6 = new SolidBrush(ColorTranslator.FromHtml("#FF5349"));
            SolidBrush myBrush7 = new SolidBrush(ColorTranslator.FromHtml("#CC6666"));
            SolidBrush myBrush8 = new SolidBrush(ColorTranslator.FromHtml("#CD4A4A"));
            SolidBrush myBrush9 = new SolidBrush(ColorTranslator.FromHtml("#BC5D58"));

           if (count <= 100)
            {

                g.FillEllipse(
                       myBrush,
                       X - Power / 2,
                       Y - Power / 2,
                       Power,
                       Power
                    );
            }
          
            if ((count <= 200)&&(count > 100))
            {
                g.FillEllipse(
                       myBrush1,
                       X - Power / 2,
                       Y - Power / 2,
                       Power,
                       Power
                    );
            }
            if ((count <= 300) && (count > 200))
            {
                g.FillEllipse(
                       myBrush2,
                       X - Power / 2,
                       Y - Power / 2,
                       Power,
                       Power
                    );
            }
            if ((count <= 400) && (count > 300))
            {
                g.FillEllipse(
                       myBrush3,
                       X - Power / 2,
                       Y - Power / 2,
                       Power,
                       Power
                    );
            }
            if ((count <= 500) && (count > 400))
            {
                g.FillEllipse(
                       myBrush4,
                       X - Power / 2,
                       Y - Power / 2,
                       Power,
                       Power
                    );
            }
            if ((count <= 600) && (count > 500))
            {
                g.FillEllipse(
                       myBrush5,
                       X - Power / 2,
                       Y - Power / 2,
                       Power,
                       Power
                    );
            }
            if ((count <= 700) && (count > 600))
            {
                g.FillEllipse(
                       myBrush6,
                       X - Power / 2,
                       Y - Power / 2,
                       Power,
                       Power
                    );
            }
            if ((count <= 800) && (count > 700))
            {
                g.FillEllipse(
                       myBrush7,
                       X - Power / 2,
                       Y - Power / 2,
                       Power,
                       Power
                    );
            }
            if ((count <= 900) && (count > 800))
            {
                g.FillEllipse(
                       myBrush8,
                       X - Power / 2,
                       Y - Power / 2,
                       Power,
                       Power
                    );
            }
            if (count > 900)
            {
                g.FillEllipse(
                       myBrush9,
                       X - Power / 2,
                       Y - Power / 2,
                       Power,
                       Power
                    );
            }
                g.DrawString(
               Convert.ToString(count), // надпись, можно перенос строки вставлять (если вы Катя, то может не работать и надо использовать \r\n)
               new Font("Verdana", 10), // шрифт и его размер
               new SolidBrush(Color.White), // цвет шрифта
               X - 13, // расположение в пространстве
               Y - 10
           );
            
        }



    }
}
