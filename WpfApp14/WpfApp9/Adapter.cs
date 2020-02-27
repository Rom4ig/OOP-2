using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp9
{
    /// <summary>
    /// Паттерн Адаптер (Adapter) предназначен для преобразования интерфейса одного класса в интерфейс другого.
    /// Благодаря реализации данного паттерна мы можем использовать вместе классы с несовместимыми интерфейсами.
    /// </summary>
    class Adapter
    {

    }

    interface ITransoprt
    {
        void Drive();
    }

    class Auto : ITransoprt
    {
        public void Drive()
        {
            MessageBox.Show("Car drive on road");
        }
    }

    class Driver
    {
        public void Travel(ITransoprt transoprt)
        {
            transoprt.Drive();
        }
    }

    interface IAnimal
    {
        void Move();
    }

    class Horse : IAnimal
    {
        public void Move()
        {
            MessageBox.Show("Horse go on field");
        }
    }

    class HorseToTransoprtAdapter: ITransoprt
    {
        Horse horse;
        public HorseToTransoprtAdapter(Horse s)
        {
            horse = s;
        }

        public void Drive()
        {
            horse.Move();
        }
    }


}
