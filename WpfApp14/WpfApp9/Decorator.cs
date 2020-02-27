using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp9
{
    /// <summary>
    /// Декоратор (Decorator) представляет структурный шаблон проектирования, который позволяет динамически подключать
    /// к объекту дополнительную функциональность.Для определения нового функционала в классах нередко
    /// используется наследование.Декораторы же предоставляет наследованию более гибкую альтернативу,
    /// поскольку позволяют динамически в процессе выполнения определять новые возможности у объектов.
    /// </summary>
    class Decorator
    {
    }

    abstract class Pizza
    {
        public Pizza(string n)
        {
            this.Name = n;
        }
        public string Name { get; protected set; }
        public abstract int GetCost();
    }

    class ItalianPizza : Pizza
    {
        public ItalianPizza() :base("Italian pizza")
        {

        }

        public override int GetCost()
        {
            return 10;
        }
    }

    class BulgerianPizza : Pizza
    {
        public BulgerianPizza(): base("Bulgerian pizza")
        {

        }

        public override int GetCost()
        {
            return 8;
        }
    }

    abstract class PizzaDecorator : Pizza
    {
        protected Pizza Pizza;
        public PizzaDecorator(string n, Pizza pizza) : base(n)
        {
            this.Pizza = pizza;
        }
    }

    class PizzaWithTomato : PizzaDecorator
    {
        public PizzaWithTomato(Pizza pizza):base(pizza.Name+" with tomatoes", pizza)
        {

        }

        public override int GetCost()
        {
            return Pizza.GetCost() + 3;
        }
    }

    class PizzaWithCheese : PizzaDecorator
    {
        public PizzaWithCheese(Pizza pizza):base(pizza.Name+" with cheese", pizza)
        {

        }

        public override int GetCost()
        {
            return Pizza.GetCost() + 1;
        }
    }
}
