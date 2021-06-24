using System;
using System.Collections.Generic;
using System.Text;

namespace workshop.FactoryMethod
{
    public interface IAreaCalculator { }
    public class CircleAreaCalculator : IAreaCalculator { }
    public class RectangleAreaCalculator : IAreaCalculator { }
    public class SlotAreaCalculator : IAreaCalculator { }




    public abstract class AreaUpdater
    {
        public abstract IAreaCalculator CreateAreaCalculator();

        public void UpdateSomeValues()
        {
            var calculator = CreateAreaCalculator();
            //some operations
        }
    }




    public class CircleCalculatorFactory : AreaUpdater
{
        public override IAreaCalculator CreateAreaCalculator()
        {
            return new CircleAreaCalculator();
        }
    }
    public class RectangleCalculatorFactory : AreaUpdater
    {
        public override IAreaCalculator CreateAreaCalculator()
        {
            return new RectangleAreaCalculator();
        }
    }
    public class SlotCalculatorFactory : AreaUpdater
    {
        public override IAreaCalculator CreateAreaCalculator()
        {
            return new SlotAreaCalculator();
        }
    }

}
