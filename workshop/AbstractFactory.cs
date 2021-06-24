using System;
using System.Collections.Generic;
using System.Text;

namespace workshop
{
    class AbstractFactory
    {
        public interface ICircle { }
        public class FullCircle : ICircle { }
        public class SegmentCircle : ICircle { }

        public interface ISlot{}
        public class FullSlot : ISlot { }
        public class SegmentSlot : ISlot { }
        

        public interface IShapeFactory
        {
            ICircle CreateCircleShape();
            ISlot CreateSlotShape();
        }



        public class FullShapeFactory : IShapeFactory
        {
            public ICircle CreateCircleShape()
            {
                return new FullCircle();
            }

            public ISlot CreateSlotShape()
            {
                return new FullSlot();
            }
        }   

        public class SegmentShapeFactory : IShapeFactory
        {
            public ICircle CreateCircleShape()
            {
                return new SegmentCircle();
            }

            public ISlot CreateSlotShape()
            {
                return new SegmentSlot();
            }
        }

    }
}
