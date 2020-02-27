using System.Windows;

namespace WpfApp8
{
    ///Паттерн "Абстрактная фабрика" (Abstract Factory) предоставляет
    ///интерфейс для создания семейств взаимосвязанных объектов с
    ///определенными интерфейсами без указания конкретных типов данных объектов.
    internal abstract class Weapon
    {
        public abstract void Hit();
    }

    // абстрактный класс движение
    abstract class Movement
    {
        public abstract void Move();
    }

    // класс арбалет
    class Arbalet : Weapon
    {
        public override void Hit()
        {
            MessageBox.Show("Стреляем из арбалета");
        }
    }

    // класс меч
    class Sword : Weapon
    {
        public override void Hit()
        {
            MessageBox.Show("Бьем мечом");
        }
    }
    // движение полета
    class FlyMovement : Movement
    {
        public override void Move()
        {
            MessageBox.Show("Летим");
        }
    }

    // движение - бег
    class RunMovement : Movement
    {
        public override void Move()
        {
            MessageBox.Show("Бежим");
        }
    }
    // класс абстрактной фабрики
    abstract class HeroFactory
    {
        public abstract Movement CreateMovement();
        public abstract Weapon CreateWeapon();
    }

    // Фабрика создания летящего героя с арбалетом
    class ElfFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new FlyMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Arbalet();
        }
    }

    // Фабрика создания бегущего героя с мечом
    class VoinFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new RunMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Sword();
        }
    }

    // клиент - сам супергерой
    class Hero
    {
        private Weapon weapon;
        private Movement movement;
        public Hero(HeroFactory factory)
        {
            weapon = factory.CreateWeapon();
            movement = factory.CreateMovement();
        }
        public void Run()
        {
            movement.Move();
        }
        public void Hit()
        {
            weapon.Hit();
        }
    }

}
