using System.Windows;

namespace WpfApp8
{
    /// <summary>
    /// Паттерн Прототип (Prototype) 
    /// позволяет создавать объекты на основе уже ранее
    /// созданных объектов-прототипов. То есть по сути данный
    /// паттерн предлагает технику клонирования объектов.
    /// </summary>
    interface IFigure
    {
        IFigure Clone();
        void GetInfo();
    }

    class Rectangle : IFigure
    {
        int width;
        int height;
        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }

        public IFigure Clone()
        {
            //return new Rectangle(this.width, this.height);
            return this.MemberwiseClone() as IFigure;
        }
        public void GetInfo()
        {
            MessageBox.Show($"Прямоугольник длиной {height} и шириной {width}");
        }
    }

    class Circle : IFigure
    {
        int radius;
        public Circle(int r)
        {
            radius = r;
        }

        public IFigure Clone()
        {
            return this.MemberwiseClone() as IFigure;
            //return new Circle(this.radius);
        }
        public void GetInfo()
        {
            MessageBox.Show($"Круг радиусом {radius}");
        }
    }
}
