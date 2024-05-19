using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetaZadaca
{
    public class Decorater
    {
        public interface Coffee
        {
            double GetCost();
            string GetDescription();
        }
        public class Espresso : Coffee
        {
            public double GetCost()
            {
                return 1.99;
            }

            public string GetDescription()
            {
                return "Espresso";
            }
        }

        public abstract class CoffeeDecorator : Coffee
        {
            protected Coffee coffee;

            public CoffeeDecorator(Coffee coffee)
            {
                this.coffee = coffee;
            }

            public abstract double GetCost();
            public abstract string GetDescription();
        }

        public class Milk : CoffeeDecorator
        {
            public Milk(Coffee coffee) : base(coffee) { }

            public override double GetCost()
            {
                return coffee.GetCost() + 0.5;
            }

            public override string GetDescription()
            {
                return coffee.GetDescription() + ", Milk";
            }
        }

        public class Sugar : CoffeeDecorator
        {
            public Sugar(Coffee coffee) : base(coffee) { }

            public override double GetCost()
            {
                return coffee.GetCost() + 0.2;
            }

            public override string GetDescription()
            {
                return coffee.GetDescription() + ", Sugar";
            }
        }


    }
}
