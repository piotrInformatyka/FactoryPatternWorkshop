using System;
using System.Collections.Generic;
using System.Text;

namespace workshop
{
    class AbstractFactory2
    {
        public interface Button { }
        public class WinButton : Button { }
        public class WpfButton : Button { }

        public interface Checkbox { }
        public class WinCheckBox : Checkbox { }
        public class WpfCheckbox : Checkbox { }


        public interface IComponentFactory
        {
            Button CreateButton();
            Checkbox CreateCheckbox();
        }



        public class WinComponentFactory : IComponentFactory
        {
            public Button CreateButton()
            {
                return new WinButton();
            }

            public Checkbox CreateCheckbox()
            {
                return new WinCheckBox();
            }
        }

        public class WpfComponentFactory : IComponentFactory
        {
            public Button CreateButton()
            {
                return new WpfButton();
            }

            public Checkbox CreateCheckbox()
            {
                return new WpfCheckbox();
            }
        }
    }
}
