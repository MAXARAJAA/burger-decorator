using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burger_decorator
{
    
        abstract class Burger
    {
            public Burger(string n)
            {
                this.Name = n;
            }
            public string Name { get; protected set; }
            public abstract string GetCost();
        }

        class ItalianBurger : Burger
    {
            public ItalianBurger() : base("Итальянский бургер")
            { }
            public override string GetCost()
            {
                return "10";
            }
        }
        class BulgerianBurger : Burger
    {
            public BulgerianBurger()
                : base("Болгарсккий бургер")
            { }
            public override string GetCost()
            {
                return "8";
            }
        }

        abstract class BurgerDecorator : Burger
    {
            protected Burger burger;
            public BurgerDecorator(string n, Burger burger) : base(n)
            {
                this.burger = burger;
            }
        }

        class TomatoBurger : BurgerDecorator
    {
            public TomatoBurger(Burger p)
                : base(p.Name + ", с томатами", p)
            { }

            public override string GetCost()
            {
                return burger.GetCost() + "3";
            }
        }

        class CheeseBurger : BurgerDecorator
    {
            public CheeseBurger(Burger p)
                : base(p.Name + ", с сыром", p)
            { }

            public override string GetCost()
            {
                return burger.GetCost() + "5";
            }
        }
    
}
