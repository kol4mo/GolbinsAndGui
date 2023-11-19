using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolbinsAndGui.model
{
    internal class Dialouge
    {
        public static int dialougePosition = 0;
        public static bool choice;
        public static int adventurer1(Controller controller)
        {
            if (dialougePosition >= 0 && dialougePosition < 3)
            {
                switch (dialougePosition)
                {
                    case 0:
                        controller.changeOtherName("Freddy");
                        controller.changeOtherText("Hello Abby");
                        controller.changePlayerChoices("Ahh", "lol");
                        break;
                    case 1:
                        if (choice)
                        {
                            controller.changeOtherText("harhar");
                        } else
                        {
                            controller.changeOtherText("Bite o' 83");
                        }
                        controller.changePlayerChoices("leave", "leave");
                        break;
                    case 2:
                        return 1;
                }
                dialougePosition++;
            }
            return 0;
        }
    }
}
