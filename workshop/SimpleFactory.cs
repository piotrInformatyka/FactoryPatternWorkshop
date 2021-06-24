using System;
using System.Collections.Generic;
using System.Text;

namespace workshop
{
    public interface IAreaCalculator { }
    public enum EGeometries
    {
        Circle,
        Rectangle,
        Slot
    }

    public class CircleAreaCalculator : IAreaCalculator{}
    public class RectangleAreaCalculator : IAreaCalculator {}
    public class SlotAreaCalculator : IAreaCalculator {}

    public static class SimpleFactory
    {
        public static IAreaCalculator CreateCalculator(EGeometries calculatorType)
        {
            switch (calculatorType)
            {
                case EGeometries.Circle:
                    return new CircleAreaCalculator();
                case EGeometries.Rectangle:
                    return new RectangleAreaCalculator();
                case EGeometries.Slot:
                    return new SlotAreaCalculator();
                default:
                    throw new Exception("Wrong type passed");
            }
        }
    }
}
